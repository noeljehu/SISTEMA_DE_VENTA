using System;
using System.Collections.Generic;
using System.Linq;
using BLL;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL
{
    public class TrabajadorService
    {
        private readonly AppDbContext _context;

        public TrabajadorService(AppDbContext context)
        {
            _context = context;
        }

        public bool AgregarTrabajadorPorDNI(string dni, string cargo, decimal salario, DateTime fechaContratacion)
        {
            Console.WriteLine("Buscando persona con DNI: " + dni);
            var persona = _context.Personas.FirstOrDefault(p => p.DNI == dni);

            if (persona == null)
            {
                Console.WriteLine("Persona no encontrada.");
                throw new Exception("No se encontró una persona con el DNI especificado.");
            }

            Console.WriteLine("Verificando si la persona ya es un trabajador.");
            if (_context.Trabajadores.Any(t => t.IdPersona == persona.IdPersona))
            {
                Console.WriteLine("La persona ya es un trabajador.");
                throw new Exception("Esta persona ya está registrada como trabajador.");
            }

            Console.WriteLine("Creando trabajador...");
            var trabajador = new Trabajador
            {
                IdPersona = persona.IdPersona,
                Cargo = cargo,
                Salario = salario,
                FechaContratacion = fechaContratacion,
                Estado = true
            };

            _context.Trabajadores.Add(trabajador);
            _context.SaveChanges();
            Console.WriteLine("Trabajador agregado con éxito.");
            return true;
        }


        // 🔵 Obtener Lista de Trabajadores
        public List<Trabajador> ObtenerTrabajadores()
        {
            return _context.Trabajadores
                           .Include(t => t.Persona)
                           .OrderBy(t => t.IdTrabajador)
                           .ToList();
        }

        // 🟡 Actualizar Trabajador
        public bool ActualizarTrabajador(int idTrabajador, string cargo, decimal salario, DateTime fechaContratacion)
        {
            var trabajador = _context.Trabajadores.Find(idTrabajador);
            if (trabajador == null)
                throw new Exception("No se encontró el trabajador.");

            trabajador.Cargo = cargo;
            trabajador.Salario = salario;
            trabajador.FechaContratacion = fechaContratacion;

            _context.SaveChanges();
            return true;
        }

        // 🔴 Deshabilitar Trabajador (Estado = false)
        public bool DeshabilitarTrabajador(int idTrabajador)
        {
            var trabajador = _context.Trabajadores.Find(idTrabajador);
            if (trabajador == null)
                throw new Exception("No se encontró el trabajador.");

            if (!trabajador.Estado)
                throw new Exception("El trabajador ya está deshabilitado.");

            trabajador.Estado = false; // Cambiar el estado a false
            _context.SaveChanges();
            return true;
        }
        // 🟢 Habilitar Trabajador (Estado = true)
        public bool HabilitarTrabajador(int idTrabajador)
        {
            var trabajador = _context.Trabajadores.Find(idTrabajador);
            if (trabajador == null)
                throw new Exception("No se encontró el trabajador.");

            if (trabajador.Estado)
                throw new Exception("El trabajador ya está habilitado.");

            trabajador.Estado = true; // Cambiar el estado a true
            _context.SaveChanges();
            return true;
        }




        // 🔍 Buscar Trabajador por DNI
        public Trabajador? BuscarTrabajadorPorDni(string dni)
        {
            return _context.Trabajadores
                           .Include(t => t.Persona)
                           .FirstOrDefault(t => t.Persona.DNI == dni);
        }

        // 🔴 Eliminar Trabajador (en realidad deshabilitar)
        public bool EliminarTrabajador(int idTrabajador)
        {
            return DeshabilitarTrabajador(idTrabajador); // Reutiliza el método de deshabilitar
        }
    }
}