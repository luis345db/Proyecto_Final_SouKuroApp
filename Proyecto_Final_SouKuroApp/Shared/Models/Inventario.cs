using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Inventario
    {
        [Key]
        public int InventarioId { get; set; }

        [ForeignKey("Producto")]
        public int ProductoId { get; set; }

        [Required] 
        public int Cantidad_Productos { get; set; }


    }
}
