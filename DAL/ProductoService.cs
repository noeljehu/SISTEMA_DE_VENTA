using System;
using System.Collections.Generic;
using System.Linq;
using BLL;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL
{
    public class ProductoService
    {
        private readonly AppDbContext _context;

        public ProductoService(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        // 🟢 Crear Producto
        public bool AgregarProducto(string nombre, string descripcion, decimal precio, int stock, int idCategoria)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del producto es obligatorio.");

            if (precio <= 0)
                throw new ArgumentException("El precio debe ser mayor a 0.");

            if (stock < 0)
                throw new ArgumentException("El stock no puede ser negativo.");

            if (!_context.CategoriasProducto.Any(c => c.IdCategoria == idCategoria))
                throw new ArgumentException("La categoría seleccionada no existe.");

            // Generar el código del producto
            int nuevoCodigo = GenerarCodigoProducto();

            var producto = new Producto
            {
                IdProducto = nuevoCodigo, // ✅ Corrección: asignar correctamente el nuevo código
                Nombre = nombre,
                Descripcion = descripcion,
                Precio = precio,
                Stock = stock,
                IdCategoria = idCategoria,
                Estado = true
            };

            _context.Productos.Add(producto);
            _context.SaveChanges();
            return true;
        }

        private int GenerarCodigoProducto()
        {
            // Obtener el último IdProducto registrado
            int ultimoCodigo = _context.Productos
                                       .OrderByDescending(p => p.IdProducto)
                                       .Select(p => p.IdProducto)
                                       .FirstOrDefault();

            // Si no hay productos, iniciamos en 1,000,000
            return (ultimoCodigo >= 1000000) ? ultimoCodigo + 1 : 1000000;
        }

        // 🔵 Obtener todos los Productos Activos
        public List<Producto> ObtenerProductos()
        {
            return _context.Productos
                           .Where(p => p.Estado) // Solo productos activos
                           .OrderBy(p => p.IdProducto)
                           .ToList();
        }

        // 🔍 Buscar Producto por ID (Cambio de `string` a `int`)
        public Producto? BuscarProductoPorId(int idProducto)
        {
            return _context.Productos
                           .FirstOrDefault(p => p.IdProducto == idProducto && p.Estado);
        }

        // 🔍 Buscar Productos por Nombre
        public List<Producto> BuscarProductoPorNombre(string nombre)
        {
            return _context.Productos
                           .Where(p => p.Nombre.Contains(nombre) && p.Estado)
                           .ToList();
        }

        // 🟡 Actualizar Producto (Cambio de `string idProducto` a `int idProducto`)
        public bool ActualizarProducto(int idProducto, string nombre, string descripcion, decimal precio, int stock, int idCategoria)
        {
            var producto = _context.Productos.FirstOrDefault(p => p.IdProducto == idProducto && p.Estado);
            if (producto == null)
                throw new Exception("No se encontró el producto.");

            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del producto es obligatorio.");

            if (precio <= 0)
                throw new ArgumentException("El precio debe ser mayor a 0.");

            if (stock < 0)
                throw new ArgumentException("El stock no puede ser negativo.");

            if (!_context.CategoriasProducto.Any(c => c.IdCategoria == idCategoria))
                throw new ArgumentException("La categoría seleccionada no existe.");

            producto.Nombre = nombre;
            producto.Descripcion = descripcion;
            producto.Precio = precio;
            producto.Stock = stock;
            producto.IdCategoria = idCategoria;

            _context.SaveChanges();
            return true;
        }

        // ❌ Eliminar Producto (Cambio de `string idProducto` a `int idProducto`)
        public bool EliminarProducto(int idProducto)
        {
            var producto = _context.Productos.FirstOrDefault(p => p.IdProducto == idProducto && p.Estado);
            if (producto == null)
                throw new Exception("No se encontró el producto.");

            producto.Estado = false;
            _context.SaveChanges();
            return true;
        }

        // ✅ Habilitar Producto (Cambio de `string idProducto` a `int idProducto`)
        public bool HabilitarProducto(int idProducto)
        {
            var producto = _context.Productos.FirstOrDefault(p => p.IdProducto == idProducto);
            if (producto == null)
                throw new Exception("No se encontró el producto.");

            producto.Estado = true;
            _context.SaveChanges();
            return true;
        }

        // 🚫 Deshabilitar Producto (Cambio de `string idProducto` a `int idProducto`)
        public bool DeshabilitarProducto(int idProducto)
        {
            var producto = _context.Productos.FirstOrDefault(p => p.IdProducto == idProducto);
            if (producto == null)
                throw new Exception("No se encontró el producto.");

            producto.Estado = false;
            _context.SaveChanges();
            return true;
        }
    }
}
