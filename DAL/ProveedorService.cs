using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Models;

namespace DAL
{
    public class ProveedorService
    {
        private readonly AppDbContext _context;

        public ProveedorService(AppDbContext context)
        {
            _context = context;
        }

        // ✅ Agregar un nuevo proveedor
        public void AgregarProveedor(string nombre, string ruc, string direccion, string telefono, string email, string? tipoProveedor, bool estado, string? observaciones, string? web)
        {
            // Verificar si el proveedor ya existe en la base de datos usando el RUC (o nombre)
            if (_context.Proveedor.Any(p => p.Ruc == ruc))
            {
                throw new Exception("El proveedor ya está registrado.");
            }

            // Crear el nuevo proveedor
            var proveedor = new Proveedor
            {
                Nombre = nombre,
                Ruc = ruc,
                Direccion = direccion,
                Telefono = telefono,
                Email = email,
                TipoProveedor = tipoProveedor,
                Estado = estado,  // El estado se recibe como parámetro
                Observaciones = observaciones,
                Web = web,
                FechaRegistro = DateTime.Now  // Fecha de registro por defecto
            };

            // Agregar el proveedor a la base de datos
            _context.Proveedor.Add(proveedor);
            _context.SaveChanges();
        }


        // ✅ Obtener todos los proveedores
        public List<Proveedor> ObtenerProveedores()
        {
            return _context.Proveedor.ToList();  // Usar "Proveedores" en lugar de "Proveedor"
        }

        // ✅ Buscar proveedor por ID
        public Proveedor? BuscarProveedorPorId(int idProveedor)
        {
            return _context.Proveedor.Find(idProveedor);  // Usar "Proveedores" en lugar de "Proveedor"
        }

        // ✅ Actualizar un proveedor
        public void ActualizarProveedor(Proveedor proveedor)
        {
            var proveedorExistente = _context.Proveedor.Find(proveedor.IdProveedor);  // Usar "Proveedores" en lugar de "Proveedor"
            if (proveedorExistente == null)
            {
                throw new Exception("El proveedor no existe.");
            }

            // Actualizar valores
            proveedorExistente.Nombre = proveedor.Nombre;
            proveedorExistente.Direccion = proveedor.Direccion;
            proveedorExistente.Telefono = proveedor.Telefono;
            proveedorExistente.Email = proveedor.Email;
            proveedorExistente.Estado = proveedor.Estado;

            _context.Proveedor.Update(proveedorExistente);  // Usar "Proveedores" en lugar de "Proveedor"
            _context.SaveChanges();
        }

        // ✅ Eliminar un proveedor
        public void EliminarProveedor(int idProveedor)
        {
            var proveedor = _context.Proveedor.Find(idProveedor);  // Usar "Proveedores" en lugar de "Proveedor"
            if (proveedor == null)
            {
                throw new Exception("El proveedor no existe.");
            }

            _context.Proveedor.Remove(proveedor);  // Usar "Proveedores" en lugar de "Proveedor"
            _context.SaveChanges();
        }
    }
}
