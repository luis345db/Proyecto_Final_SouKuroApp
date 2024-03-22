﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Pedidos_Detalle
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("PedidoId")]

        [Required]
        public string Nombre_Producto { get; set;}

        [Required]
        public int Cantidad { get; set; }

    }
}
