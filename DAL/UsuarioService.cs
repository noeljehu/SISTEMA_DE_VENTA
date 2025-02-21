using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BLL;
using Models;

namespace DAL
{
    public class UsuarioService
    {
        private readonly AppDbContext _context;

        public UsuarioService(AppDbContext context)
        {
            _context = context;
        }

        // Método para el login con validación de rol y estado
        public Usuario Login(string username, string contrasena)
        {
            var usuario = _context.Usuarios
                .Include(u => u.Rol)
                .Include(u => u.Trabajador)
                .FirstOrDefault(u => u.Username == username);

            if (usuario == null)
            {
                throw new UnauthorizedAccessException("Usuario no encontrado.");
            }


            // Validar si el usuario está activo
            if (!usuario.Activo)
            {
                throw new UnauthorizedAccessException("El usuario está deshabilitado.");
            }

            return usuario;
        }

        // 🔹 Obtener todos los usuarios con detalles completos (Rol, Trabajador y Persona)
        public List<Usuario> ObtenerUsuarios()
        {
            return _context.Usuarios
                .Include(u => u.Rol)
                .Include(u => u.Trabajador)
                    .ThenInclude(t => t.Persona) // Incluye los datos de Persona
                .ToList();
        }

        // 🔹 Buscar usuario por Username con más detalles
        public Usuario? BuscarUsuarioPorUsername(string username)
        {
            return _context.Usuarios
                .Include(u => u.Rol)
                .Include(u => u.Trabajador)
                    .ThenInclude(t => t.Persona) // Incluye los datos de Persona
                .FirstOrDefault(u => u.Username == username);
        }
        public Trabajador BuscarTrabajadorPorDNI(string dni)
{
    return _context.Trabajadores
        .Include(t => t.Persona) // Asegurar que incluimos la información de la persona
        .FirstOrDefault(t => t.Persona.DNI == dni);
}


        public void AgregarUsuario(Usuario usuario)
        {
            // 🔹 Validar que no haya un usuario con el mismo nombre de usuario
            if (_context.Usuarios.Any(u => u.Username == usuario.Username))
                throw new InvalidOperationException("El nombre de usuario ya está en uso.");

            // 🔹 Buscar trabajador por ID
            var trabajador = _context.Trabajadores
                .Include(t => t.Persona)
                .SingleOrDefault(t => t.IdTrabajador == usuario.IdTrabajador);

            if (trabajador == null)
                throw new InvalidOperationException("No se encontró un trabajador con el ID proporcionado.");

            // 🔹 Validar si el trabajador ya tiene un usuario registrado
            if (_context.Usuarios.Any(u => u.IdTrabajador == trabajador.IdTrabajador))
                throw new InvalidOperationException("Este trabajador ya tiene un usuario registrado.");

            // 🔹 Asignar el usuario a la BD
            usuario.Activo = true;
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }


        // 🔹 Actualizar usuario (excepto contraseña)
        public void ActualizarUsuario(Usuario usuario)
        {
            var usuarioExistente = _context.Usuarios.Find(usuario.IdUsuario);
            if (usuarioExistente == null)
                throw new InvalidOperationException("Usuario no encontrado.");

            usuarioExistente.Username = usuario.Username;
            usuarioExistente.IdRol = usuario.IdRol;
            usuarioExistente.Activo = usuario.Activo;

            _context.SaveChanges(); // ✅ Ahora _context no se elimina antes de tiempo
        }




        // 🔹 Cambiar estado de usuario (Habilitar/Deshabilitar)
        public void CambiarEstadoUsuario(int id, bool estado)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario == null)
                throw new InvalidOperationException("Usuario no encontrado.");

            usuario.Activo = estado;
            _context.SaveChanges();
        }

        // 🔹 Eliminación lógica del usuario
        public void EliminarUsuario(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario == null)
                throw new InvalidOperationException("Usuario no encontrado.");

            usuario.Activo = false; // Se desactiva en lugar de eliminar
            _context.SaveChanges();
        }
    }
}