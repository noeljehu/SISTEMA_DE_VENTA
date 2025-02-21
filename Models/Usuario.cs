using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        public int IdTrabajador { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; } = null!;

        [Required]
        [StringLength(255)]
        public string Contraseña { get; set; } = null!;

        [Required]
        public int IdRol { get; set; }

        public bool Activo { get; set; } = true;

        [ForeignKey("IdTrabajador")]
        public virtual Trabajador Trabajador { get; set; } = null!;

        [ForeignKey("IdRol")]
        public virtual Rol Rol { get; set; } = null!;
    }
}
