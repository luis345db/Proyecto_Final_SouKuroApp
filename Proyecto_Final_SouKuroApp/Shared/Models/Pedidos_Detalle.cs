﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Pedidos_Detalle
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre_Producto { get; set;}

        [Required]
        public int Cantidad { get; set; }

    }
}
