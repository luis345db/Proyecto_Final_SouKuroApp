using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models;

    public class Pedidos
    {
        [Key]
        public int PedidoId { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public DateTime Fecha_Llegada { get; set; } = DateTime.Now;

        [ForeignKey("Pedidos")]
        public ICollection<Pedidos_Detalle> Detalle { get; set; } = new List<Pedidos_Detalle>();
    }

