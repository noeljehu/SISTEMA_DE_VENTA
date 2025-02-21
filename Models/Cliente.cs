using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        [Required]
        public int IdPersona { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        public bool Estado { get; set; } = true;

        [ForeignKey("IdPersona")]
        public virtual Persona Persona { get; set; } = null!;
    }
}
