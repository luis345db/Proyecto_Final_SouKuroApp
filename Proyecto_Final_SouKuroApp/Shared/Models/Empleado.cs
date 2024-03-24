using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models;

public class Empleado
{
    [Key]
    public int EmpleadoId { get; set; }
    [Required]
    public string Nombre { get; set; } = string.Empty;
    [Required]
    public string Apellido { get; set; } = string.Empty;
    [Required]
    public string Cedula { get; set; } = string.Empty;
    [Required]
    public string Telefono { get; set; } = string.Empty;
    [Required]
    public string Direccion { get; set; } = string.Empty;
    public string? Email { get; set; }
    [Required]
    public string Usuario { get; set; } = string.Empty;
    [Required]
    public string Clave { get; set; } = string.Empty;
    [Required]
    public string Rol { get; set; } = string.Empty;
    public DateTime Fecha_Registro { get; set; } = DateTime.Now;
    public bool Activo { get; set; } = true;
    [ForeignKey("EmpleadoId")]
    public ICollection<Compra> Compras { get; set; } = new List<Compra>();


}
