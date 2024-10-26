
using System.ComponentModel.DataAnnotations.Schema;


namespace Sistema_POS.Models
{
    [Table("Productos", Schema = "inv")]
    public class Producto
    {
        [Column("Producto_id")]
        public int ProductoId { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }

        [Column("Cantidad_stock")]
        public int CantidadStock { get; set; }
        public string? Categoria { get; set; }

        [Column("Proveedor_id")]
        public int? ProveedorId { get; set; }

        [Column("Fecha_vencimiento")]
        public DateTime? FechaVencimiento { get; set; }

        [Column("Ubicacion_almacen")]
        public string? UbicacionAlmacen { get; set; }

        [Column("Estado_producto_id")]
        public int? EstadoProductoId { get; set; }

        [Column("Fecha_creacion")]
        public DateTime? FechaCreacion { get; set; }

        public virtual Proveedor Proveedor { get; set; }
        public virtual EstadoProducto EstadoProducto { get; set; }
    }
}
