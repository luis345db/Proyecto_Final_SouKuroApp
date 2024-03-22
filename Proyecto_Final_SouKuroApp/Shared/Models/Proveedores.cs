using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Proveedores
    {
        [Key]
        public int ProveedorId { get; set; }
        [Required]
        public string Certificacion { get; set; }
        [Required]
        public string RNC { get; set; }
        [Required]
        public int Telefono { get; set; }

        [ForeignKey("Proveedores")]
        public ICollection<Proveedores_Detalle> Detalle { get; set; } = new List<Proveedores_Detalle>();
    }
}
