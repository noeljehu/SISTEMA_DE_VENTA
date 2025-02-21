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
            _context = context;
        }

        // 🟢 Crear Producto
        public bool AgregarProducto(string nombre, string descripcion, decimal precio, int stock)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del producto es obligatorio.");

            if (precio <= 0)
                throw new ArgumentException("El precio debe ser mayor a 0.");

            if (stock < 0)
                throw new ArgumentException("El stock no puede ser negativo.");

            var producto = new Producto
            {
                Nombre = nombre,
                Descripcion = descripcion,
                Precio = precio,
                Stock = stock,
                Estado = true
            };

            _context.Productos.Add(producto);
            _context.SaveChanges();
            return true;
        }

        // 🔵 Obtener todos los Productos
        public List<Producto> ObtenerProductos()
        {
            return _context.Productos
                           .OrderBy(p => p.IdProducto)
                           .ToList();
        }

        // 🔍 Buscar Producto por ID
        public Producto? BuscarProductoPorId(int idProducto)
        {
            return _context.Productos.FirstOrDefault(p => p.IdProducto == idProducto);
        }

        // 🔍 Buscar Producto por Nombre
        public List<Producto> BuscarProductoPorNombre(string nombre)
        {
            return _context.Productos
                           .Where(p => p.Nombre.Contains(nombre))
                           .ToList();
        }

        // 🟡 Actualizar Producto
        public bool ActualizarProducto(int idProducto, string nombre, string descripcion, decimal precio, int stock)
        {
            var producto = _context.Productos.Find(idProducto);
            if (producto == null)
                throw new Exception("No se encontró el producto.");

            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del producto es obligatorio.");

            if (precio <= 0)
                throw new ArgumentException("El precio debe ser mayor a 0.");

            if (stock < 0)
                throw new ArgumentException("El stock no puede ser negativo.");

            producto.Nombre = nombre;
            producto.Descripcion = descripcion;
            producto.Precio = precio;
            producto.Stock = stock;

            _context.SaveChanges();
            return true;
        }

        // 🔴 Deshabilitar Producto (Estado = false)
        public bool DeshabilitarProducto(int idProducto)
        {
            var producto = _context.Productos.Find(idProducto);
            if (producto == null)
                throw new Exception("No se encontró el producto.");

            if (!producto.Estado)
                throw new Exception("El producto ya está deshabilitado.");

            producto.Estado = false;
            _context.SaveChanges();
            return true;
        }

        // 🟢 Habilitar Producto (Estado = true)
        public bool HabilitarProducto(int idProducto)
        {
            var producto = _context.Productos.Find(idProducto);
            if (producto == null)
                throw new Exception("No se encontró el producto.");

            if (producto.Estado)
                throw new Exception("El producto ya está habilitado.");

            producto.Estado = true;
            _context.SaveChanges();
            return true;
        }
        // 🔍 Buscar Productos por Nombre (Ignora mayúsculas y espacios adicionales)
        

    }
}
