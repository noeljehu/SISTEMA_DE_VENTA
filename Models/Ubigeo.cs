using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    [Table("Ubigeo")]
    public class Ubigeo
    {
        [Key]
        public int IdUbigeo { get; set; }

        [Required]
        [StringLength(6)]
        public string CodigoUbigeo { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string Distrito { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string Provincia { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string Departamento { get; set; } = null!;

        public int Poblacion { get; set; }

        public decimal Superficie { get; set; }

        public decimal Y { get; set; } // Latitud

        public decimal X { get; set; } // Longitud

        public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
    }

}