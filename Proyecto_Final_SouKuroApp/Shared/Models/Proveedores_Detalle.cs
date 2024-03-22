using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Proveedores_Detalle
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ProveedorId")]
        [Required]
        public string TipoProducto { get; set; } = string.Empty;

        [Required]
        public string NombreProveedor { get; set; } = string.Empty;
    }
}
