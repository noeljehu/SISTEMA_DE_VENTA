using System;
using System.Collections.Generic;
using System.Linq;
using BLL;
using Models;

namespace DAL
{
    public class CategoriaProductoService
    {
        private readonly AppDbContext _context;

        public CategoriaProductoService(AppDbContext context)
        {
            _context = context;
        }

        // 🟢 Crear una Categoría
        public bool AgregarCategoria(string nombre, string descripcion)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre de la categoría es obligatorio.");

            var categoria = new CategoriaProducto
            {
                Nombre = nombre,
                Descripcion = descripcion
            };

            _context.CategoriasProducto.Add(categoria);
            _context.SaveChanges();
            return true;
        }

        // 🔵 Obtener todas las Categorías
        public List<CategoriaProducto> ObtenerCategorias()
        {
            return _context.CategoriasProducto.ToList();
        }

        public CategoriaProducto? BuscarCategoriaPorNombre(string nombre)
        {
            return _context.CategoriasProducto
                           .FirstOrDefault(c => c.Nombre == nombre);
        }


        // 🟡 Actualizar Categoría
        public bool ActualizarCategoria(int idCategoria, string nombre, string descripcion)
        {
            var categoria = _context.CategoriasProducto.Find(idCategoria);
            if (categoria == null)
                throw new Exception("No se encontró la categoría.");

            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre de la categoría es obligatorio.");

            categoria.Nombre = nombre;
            categoria.Descripcion = descripcion;

            _context.SaveChanges();
            return true;
        }

        // ❌ Eliminar Categoría
        public bool EliminarCategoria(int idCategoria)
        {
            var categoria = _context.CategoriasProducto.Find(idCategoria);
            if (categoria == null)
                throw new Exception("No se encontró la categoría.");

            _context.CategoriasProducto.Remove(categoria);
            _context.SaveChanges();
            return true;
        }
    }
}
