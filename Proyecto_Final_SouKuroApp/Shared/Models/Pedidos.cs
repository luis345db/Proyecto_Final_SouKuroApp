using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Pedidos
    {
        public int PedidoId { get; set; }

        public int Cantidad { get; set; }

        public DateTime Fecha_Llegada { get; set; } = DateTime.Now;

        [ForeignKey("Pedidos")]
        public ICollection<Pedidos_Detalle> Detalle { get; set; } = new List<Pedidos_Detalle>();
    }
}
