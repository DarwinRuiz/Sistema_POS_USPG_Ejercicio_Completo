using Microsoft.EntityFrameworkCore;
using Sistema_POS.Models;

namespace Sistema_POS.Connections
{
    public class SistemaPOSContext: DbContext
    {
        private string _servidor = "localhost";
        private string _puerto = "1403";
        private string _baseDatos = "Sistema_POS";
        private string _user = "sa";
        private string _password = "POS2024#";

        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<EstadoProducto> EstadosProductos { get; set; }
        public DbSet<Producto> Productos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer($"Data Source={_servidor},{_puerto}; Initial Catalog={_baseDatos}; Integrated Security=false;User ID={_user};Password={_password};TrustServerCertificate=true;"));
        }
    }
}
