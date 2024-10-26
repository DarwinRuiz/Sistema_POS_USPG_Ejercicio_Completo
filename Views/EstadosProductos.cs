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
    public partial class EstadosProductos : Form
    {
        private SistemaPOSContext _context;
        private EstadoProducto _estadoProductoSeleccionadoEdicion;
        public EstadosProductos()
        {
            InitializeComponent();

            _context = new SistemaPOSContext();
            _estadoProductoSeleccionadoEdicion = null;
            cargarDatos();
        }


        private void cargarDatos()
        {

            _estadoProductoSeleccionadoEdicion = null;

            var estadosProductos = _context.EstadosProductos.Select(ep => new
            {
                EstadoProductoId = ep.EstadoProductoId,
                Nombre = ep.Nombre,
                Descripcion = ep.Descripcion
            }).ToList();

            dataGridView1.DataSource = estadosProductos;
            dataGridView1.Columns[0].Visible = false;

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if (_estadoProductoSeleccionadoEdicion == null)
            {
                EstadoProducto estadoProducto = new EstadoProducto();
                estadoProducto.Nombre = inpNombre.Text;
                estadoProducto.Descripcion = inpDescripcion.Text;

                _context.EstadosProductos.Add(estadoProducto);

            }
            else
            {
                EstadoProducto estadoProductoActualizar = _context.EstadosProductos.Find(_estadoProductoSeleccionadoEdicion.EstadoProductoId);
                estadoProductoActualizar.Nombre = inpNombre.Text.Trim();
                estadoProductoActualizar.Descripcion = inpDescripcion.Text.Trim();
            }

            _context.SaveChanges();

            inpNombre.Text = "";
            inpDescripcion.Text = "";

            cargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                _estadoProductoSeleccionadoEdicion = new EstadoProducto
                {
                    EstadoProductoId = (int)dataGridView1.CurrentRow.Cells[0].Value,
                    Nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                    Descripcion = dataGridView1.CurrentRow.Cells[2].Value.ToString()
                };

                inpNombre.Text = _estadoProductoSeleccionadoEdicion.Nombre;
                inpDescripcion.Text = _estadoProductoSeleccionadoEdicion.Descripcion;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                EstadoProducto estadoProductoEliminar = _context.EstadosProductos.Find((int)dataGridView1.CurrentRow.Cells[0].Value);

                _context.EstadosProductos.Remove(estadoProductoEliminar);
                _context.SaveChanges();
                cargarDatos();
            }
        }
    }
}
