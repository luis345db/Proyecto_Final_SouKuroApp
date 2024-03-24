using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace Proyecto_Final_SouKuroApp.DAL
{
	public class Contexto : DbContext
	{
		public Contexto(DbContextOptions<Contexto> options) : base(options)
		{
		}
		public DbSet<Compra> Compra { get; set; }
		public DbSet<Empleado> empleados { get; set; }
		public DbSet<Informe> Informe { get; set; }
		public DbSet<Inventario> Inventario { get; set; }
		public DbSet<Pedidos> Pedidos { get; set; }
		public DbSet<Producto> Producto { get; set; }
		public DbSet<Proveedores> Proveedores { get; set; }
		public DbSet<Tipo_Producto> Tipo_Producto { get; set; }
		public DbSet<Compras_Detalles> Compras_Detalles { get; set; }
		public DbSet<Pedidos_Detalle> Pedidos_Detalle { get; set; }


	}
}
