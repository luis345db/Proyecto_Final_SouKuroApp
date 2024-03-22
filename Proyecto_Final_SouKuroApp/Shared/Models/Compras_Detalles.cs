﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Compras_Detalles
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("CompraId")]
        public int ComprasId { get; set; }

        [Required] 
        public string Nombre_Producto { get; set; } = string.Empty;

        [Required]
        public int Unidades {  get; set; }

        [Required]
        public int Precio { get; set; } 
    }
}
