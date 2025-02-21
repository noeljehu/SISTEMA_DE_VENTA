using System;
using System.Collections.Generic;
using System.Linq;
using BLL;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL
{
    public class RolService
    {
        private readonly AppDbContext _context;

        public RolService(AppDbContext context)
        {
            _context = context;
        }

        // Obtener todos los roles
        public List<Rol> ObtenerRoles()
        {
            return _context.Roles.ToList();
        }
    }
}
