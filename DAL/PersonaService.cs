using System;
using System.Collections.Generic;
using System.Linq;
using BLL;
using Models;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class PersonaService
    {
        private readonly AppDbContext _context;

        public PersonaService(AppDbContext context)
        {
            _context = context;
        }

        // Método para agregar una nueva persona
        public void AgregarPersona(string dni, string nombres, string apellidos, DateTime fechaNacimiento,
                            string sexo, string direccion, string telefono, string email, int idUbigeo)
        {
            var ubigeoEntity = _context.Ubigeos.FirstOrDefault(u => u.IdUbigeo == idUbigeo);
            if (ubigeoEntity == null)
            {
                throw new Exception("El código de Ubigeo ingresado no existe.");
            }

            if (_context.Personas.Any(p => p.DNI == dni))
            {
                throw new Exception("El DNI ya está registrado.");
            }

            var nuevaPersona = new Persona
            {
                DNI = dni,
                Nombres = nombres,
                Apellidos = apellidos,
                FechaNacimiento = fechaNacimiento,
                Sexo = sexo,
                Direccion = direccion,
                Telefono = telefono,
                Email = email,
                IdUbigeo = idUbigeo
            };

            _context.Personas.Add(nuevaPersona);
            _context.SaveChanges();
        }


        // Método para obtener todas las personas
        public List<object> ObtenerPersonasConRoles()
        {
            var personas = from p in _context.Personas
                           join c in _context.Clientes on p.IdPersona equals c.IdPersona into clienteJoin
                           from cliente in clienteJoin.DefaultIfEmpty()
                           join t in _context.Trabajadores on p.IdPersona equals t.IdPersona into trabajadorJoin
                           from trabajador in trabajadorJoin.DefaultIfEmpty()
                           join u in _context.Ubigeos on p.IdUbigeo equals u.IdUbigeo into ubigeoJoin
                           from ubigeo in ubigeoJoin.DefaultIfEmpty() // Se une con Ubigeo
                           select new
                           {
                               p.IdPersona,
                               p.DNI,
                               p.Nombres,
                               p.Apellidos,
                               p.FechaNacimiento,
                               p.Sexo,
                               p.Direccion,
                               p.Telefono,
                               p.Email,
                               Departamento = ubigeo != null ? ubigeo.Departamento : "Desconocido", // ✅ Ahora sí existe
                               Ubigeo = ubigeo != null ? ubigeo.CodigoUbigeo : "Desconocido",
                               EsCliente = cliente != null ? "Sí" : "Si",
                               EsTrabajador = trabajador != null ? "Sí" : "No",
                               Cargo = trabajador != null ? trabajador.Cargo : null
                           };

            return personas.ToList<object>();

        }


        // Método para buscar una persona por DNI
        public Persona BuscarPorDNI(string dni)
        {
            return _context.Personas.Include(p => p.Ubigeo)
                                     .FirstOrDefault(p => p.DNI == dni);
        }

        // Método para actualizar una persona
        public void ActualizarPersona(Persona persona)
        {
            // Buscar persona en la base de datos
            var personaExistente = _context.Personas.FirstOrDefault(p => p.IdPersona == persona.IdPersona);

            if (personaExistente == null)
            {
                throw new Exception("La persona no existe.");
            }

            // Verificar si el DNI ya está registrado en otra persona
            var dniEnUso = _context.Personas.Any(p => p.DNI == persona.DNI && p.IdPersona != persona.IdPersona);
            if (dniEnUso)
            {
                throw new Exception("El DNI ya está registrado por otra persona.");
            }

            // Aplicar cambios
            personaExistente.DNI = persona.DNI;
            personaExistente.Nombres = persona.Nombres;
            personaExistente.Apellidos = persona.Apellidos;
            personaExistente.FechaNacimiento = persona.FechaNacimiento;
            personaExistente.Sexo = persona.Sexo;
            personaExistente.Direccion = persona.Direccion;
            personaExistente.Telefono = persona.Telefono;
            personaExistente.Email = persona.Email;
            personaExistente.IdUbigeo = persona.IdUbigeo;

            _context.SaveChanges();
        }



        // Método para eliminar una persona
        public void EliminarPersona(int idPersona)
        {
            var persona = _context.Personas.Find(idPersona);
            if (persona != null)
            {
                _context.Personas.Remove(persona);
                _context.SaveChanges();
            }
        }
    }
}