using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Compra
    {
        [Key]
        public int CompraId { get; set; }

        [Required]
        public DateTime Fecha_Compra {  get; set; }= DateTime.Now;

        [Required]
        public string NFC { get; set;} = string.Empty;

        [Required]
        public int No_Factura { get; set; }

        [Required]
        public string Telefono { get; set; } = string.Empty;

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public int SubTotal { get; set; }

        [Required]
        public int ITEBIS { get; set; }

        [Required]
        public int Total { get; set; }
    }
}
