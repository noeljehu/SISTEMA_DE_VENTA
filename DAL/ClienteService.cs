using System;
using System.Collections.Generic;
using System.Linq;
using BLL;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL
{
    internal class ClienteService
    {
        private readonly AppDbContext _context;

        public ClienteService(AppDbContext context)
        {
            _context = context;
        }

        

      

        // Método para obtener todos los clientes con sus datos de persona
        public List<Cliente> ObtenerClientes()
        {
            return _context.Clientes.Include(c => c.Persona).ToList();
        }

        // Método para agregar un nuevo cliente
        public void AgregarCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        // Método para actualizar un cliente
        public void ActualizarCliente(Cliente cliente)
        {
            var clienteExistente = _context.Clientes
                .FirstOrDefault(c => c.IdCliente == cliente.IdCliente);

            if (clienteExistente != null)
            {
                _context.Entry(clienteExistente).State = EntityState.Detached;
            }

            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }

        // Método para eliminar un cliente
        public void EliminarCliente(int id)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.IdCliente == id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }
        }

        // Método para buscar un cliente por DNI
        public Cliente? BuscarClientePorDni(string dni)
        {
            return _context.Clientes
                .Include(c => c.Persona) // CORREGIDO: antes era "IdPersonaNavigation"
                .FirstOrDefault(c => c.Persona.DNI == dni);
        }
    }
}
