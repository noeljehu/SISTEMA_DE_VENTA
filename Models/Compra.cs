using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Compra
    {
        [Key]
        public int IdCompra { get; set; }
        public int IdProveedor { get; set; }
        public DateTime FechaCompra { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }

        public Proveedor Proveedor { get; set; } // Relación con Proveedor
        public ICollection<DetalleCompra> Detalles { get; set; } = new List<DetalleCompra>(); // Agregado
    }


}
