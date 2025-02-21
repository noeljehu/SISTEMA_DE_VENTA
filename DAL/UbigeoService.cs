using System.Collections.Generic;
using System.Linq;
using BLL;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL
{
    public class UbigeoService
    {
        private readonly AppDbContext _context;

        public UbigeoService(AppDbContext context)
        {
            _context = context;
        }

        // Método que devuelve solo los distritos
        public List<Ubigeo> ObtenerDistritos()
        {
            return _context.Ubigeos
                .Select(u => new Ubigeo { IdUbigeo = u.IdUbigeo, Distrito = u.Distrito })
                .ToList();
        }
        public bool ExisteUbigeo(int idUbigeo)
        {
            return _context.Ubigeos.Any(u => u.IdUbigeo == idUbigeo);
        }


    }
}
