using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Proveedor
    {
        [Key]
        public int IdProveedor { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(20)]
        public string Ruc { get; set; }  // El RUC es obligatorio y tiene una longitud máxima de 20

        public string? Direccion { get; set; }

        public string? Telefono { get; set; }

        public string? Email { get; set; }

        public string? TipoProveedor { get; set; }  // Tipo de proveedor (por ejemplo, 'Mayorista', 'Minorista', etc.)

        public bool Estado { get; set; } = true;

        public DateTime FechaRegistro { get; set; } = DateTime.Now;  // Fecha de registro, por defecto la fecha actual

        public string? Observaciones { get; set; }

        public string? Web { get; set; }


        public ICollection<Compra> Compras { get; set; } = new List<Compra>();
        
    }
}
