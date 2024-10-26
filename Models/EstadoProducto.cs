
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_POS.Models
{
    [Table("Estados_productos", Schema = "inv")]
    public class EstadoProducto
    {
        [Column("Estado_producto_id")]
        public int EstadoProductoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        [Column("Fecha_creacion")]
        public DateTime? FechaCreacion { get; set; }

        public virtual ICollection<Producto>? Productos { get; set; }
    }
}
