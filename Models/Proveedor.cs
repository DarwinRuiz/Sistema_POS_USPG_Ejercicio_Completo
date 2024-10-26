
using System.ComponentModel.DataAnnotations.Schema;


namespace Sistema_POS.Models
{
    [Table("Proveedores", Schema = "inv")]
    public class Proveedor
    {
        [Column("Proveedor_id")]
        public int ProveedorId { get; set; }
        public string Nombre { get; set; }
        public string Empresa { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public string Correo { get; set; }

        [Column("Fecha_creacion")]
        public DateTime? FechaCreacion { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
