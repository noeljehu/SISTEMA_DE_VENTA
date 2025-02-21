using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Persona")]
    public class Persona
    {
        [Key]
        public int IdPersona { get; set; }

        [Required]
        [StringLength(8)]
        public string DNI { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string Nombres { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string Apellidos { get; set; } = null!;

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [StringLength(20)]
        public string Sexo { get; set; } = null!;

        [StringLength(255)]
        public string? Direccion { get; set; }

        [StringLength(20)]
        public string? Telefono { get; set; }

        [StringLength(100)]
        public string? Email { get; set; }

        public int? IdUbigeo { get; set; }

        [ForeignKey("IdUbigeo")]
        public virtual Ubigeo? Ubigeo { get; set; }

        public virtual Cliente? Cliente { get; set; }
        public virtual Trabajador? Trabajador { get; set; }
    }
}
