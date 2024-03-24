using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models;

public class Tipo_Producto
{
    [Key]
    public int Tipo_ProductoId { get; set; }
    [ForeignKey("Producto")]
    public int ProductoId { get; set; }
    [Required]
    public string Tipo { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
}
