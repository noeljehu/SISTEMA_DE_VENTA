using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("CategoriaProducto")]
    public class CategoriaProducto
    {
        [Key]
        public int IdCategoria { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = null!;

        public string? Descripcion { get; set; }

        // Relación con Producto
        public List<Producto> Productos { get; set; } = new List<Producto>();
    }
}
