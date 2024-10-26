using Microsoft.EntityFrameworkCore;
using Sistema_POS.Connections;
using Sistema_POS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_POS.Views
{


    public partial class Productos : Form
    {
        private SistemaPOSContext _context;
        private Producto _productoSeleccionadoEdicion;
        public Productos()
        {
            InitializeComponent();

            _context = new SistemaPOSContext();
            _productoSeleccionadoEdicion = null;
            cargarDatos();


            var estadosProductos = _context.EstadosProductos.ToList();
            var proveedores = _context.Proveedores.ToList();
            inpEstado.DisplayMember = "Nombre";
            inpEstado.ValueMember = "EstadoProductoId";
            inpEstado.DataSource = estadosProductos;

            inpProveedor.DisplayMember = "Nombre";
            inpProveedor.ValueMember = "ProveedorId";
            inpProveedor.DataSource = proveedores;
        }

        private void cargarDatos()
        {

            _productoSeleccionadoEdicion = null;

            var productos = _context.Productos.Select(p => new
            {
                ProductoId = p.ProductoId,
                Codigo = p.Codigo,
                Nombre = p.Nombre,
                Descripcion = p.Descripcion,
                Precio = p.Precio,
                CantidadStock = p.CantidadStock,
                Categoria = p.Categoria,
                UbicacionAlmacen = p.UbicacionAlmacen,
                EstadoProductoId = p.EstadoProductoId,
                ProveedorId = p.ProveedorId
            }).ToList();



            dataGridView1.DataSource = productos;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_productoSeleccionadoEdicion == null)
            {
                Proveedor proveedor = _context.Proveedores.Find(inpProveedor.SelectedValue);
                EstadoProducto estadoProducto = _context.EstadosProductos.Find(inpEstado.SelectedValue);

                Producto producto = new Producto();
                producto.Codigo = inpCodigo.Text.Trim();
                producto.Nombre = inpNombre.Text.Trim();
                producto.Descripcion = inpDescripcion.Text.Trim();
                producto.Precio = (decimal)inpPrecio.Value;
                producto.CantidadStock = (int)inpCantidadStock.Value;
                producto.Categoria = inpCategoria.Text.Trim();
                producto.UbicacionAlmacen = inpUbicacionAlmacen.Text.Trim();
                producto.EstadoProducto = estadoProducto;
                producto.Proveedor = proveedor;

                _context.Add(producto);
            }
            else
            {
                Proveedor proveedor = _context.Proveedores.Find(inpProveedor.SelectedValue);
                EstadoProducto estadoProducto = _context.EstadosProductos.Find(inpEstado.SelectedValue);
                Producto productoActualizar = _context.Productos.Find(_productoSeleccionadoEdicion.ProductoId);

                productoActualizar.Codigo = inpCodigo.Text.Trim();
                productoActualizar.Nombre = inpNombre.Text.Trim();
                productoActualizar.Descripcion = inpDescripcion.Text.Trim();
                productoActualizar.Precio = (decimal)inpPrecio.Value;
                productoActualizar.CantidadStock = (int)inpCantidadStock.Value;
                productoActualizar.Categoria = inpCategoria.Text.Trim();
                productoActualizar.UbicacionAlmacen = inpUbicacionAlmacen.Text.Trim();
                productoActualizar.EstadoProducto = estadoProducto;
                productoActualizar.Proveedor = proveedor;
            }

            _context.SaveChanges();

            inpCodigo.Text = "";
            inpNombre.Text = "";
            inpDescripcion.Text = "";
            inpPrecio.Value = 0;
            inpCantidadStock.Value = 0;
            inpCategoria.Text = "";
            inpUbicacionAlmacen.Text = "";
            inpEstado.SelectedValue = 0;
            inpProveedor.SelectedValue = 0;
            cargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                _productoSeleccionadoEdicion = new Producto
                {
                    ProductoId = (int)dataGridView1.CurrentRow.Cells[0].Value,
                    Codigo = dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                    Nombre = dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                    Descripcion = dataGridView1.CurrentRow.Cells[3].Value.ToString(),
                    Precio = (decimal)dataGridView1.CurrentRow.Cells[4].Value,
                    CantidadStock = (int)dataGridView1.CurrentRow.Cells[5].Value,
                    Categoria = dataGridView1.CurrentRow.Cells[6].Value.ToString(),
                    UbicacionAlmacen = dataGridView1.CurrentRow.Cells[7].Value.ToString(),
                    EstadoProductoId = (int)dataGridView1.CurrentRow.Cells[8].Value,
                    ProveedorId = (int)dataGridView1.CurrentRow.Cells[9].Value,
                };

                inpCodigo.Text = _productoSeleccionadoEdicion.Codigo;
                inpNombre.Text = _productoSeleccionadoEdicion.Nombre;
                inpDescripcion.Text = _productoSeleccionadoEdicion.Descripcion;
                inpPrecio.Value = _productoSeleccionadoEdicion.Precio;
                inpCantidadStock.Value = _productoSeleccionadoEdicion.CantidadStock;
                inpCategoria.Text = _productoSeleccionadoEdicion.Categoria;
                inpUbicacionAlmacen.Text = _productoSeleccionadoEdicion.UbicacionAlmacen;
                inpEstado.SelectedValue = _productoSeleccionadoEdicion.EstadoProductoId;
                inpProveedor.SelectedValue = _productoSeleccionadoEdicion.ProveedorId;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Producto productoEliminar = _context.Productos.Find((int)dataGridView1.CurrentRow.Cells[0].Value);

                _context.Productos.Remove(productoEliminar);
                _context.SaveChanges();
                cargarDatos();
            }
        }
    }
}
