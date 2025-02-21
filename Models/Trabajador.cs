using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Trabajador")]
    public class Trabajador
    {
        [Key]
        public int IdTrabajador { get; set; }

        [Required]
        public int IdPersona { get; set; }

        [Required]
        [StringLength(100)]
        public string Cargo { get; set; } = null!;

        public decimal? Salario { get; set; }

        [Required]
        public DateTime FechaContratacion { get; set; }

        public bool Estado { get; set; } = true;

        [ForeignKey("IdPersona")]
        public virtual Persona Persona { get; set; } = null!;

        public virtual Usuario? Usuario { get; set; }
    }
}
