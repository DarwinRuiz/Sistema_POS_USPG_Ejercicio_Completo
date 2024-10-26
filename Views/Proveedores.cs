using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client.NativeInterop;
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
    public partial class Proveedores : Form
    {

        private SistemaPOSContext _context;
        private Proveedor _proveedorSeleccionadoEdicion;

        public Proveedores()
        {
            InitializeComponent();

            _context = new SistemaPOSContext();
            _proveedorSeleccionadoEdicion = null;
            cargarDatos();
        }


        private void cargarDatos()
        {

            _proveedorSeleccionadoEdicion = null;

            var proveedores = _context.Proveedores.Select(p => new
            {
                ProveedorId = p.ProveedorId,
                Nombre = p.Nombre,
                Empresa = p.Empresa,
                Telefono = p.Telefono,
                Direccion = p.Direccion,
                Correo = p.Correo,

            }).ToList();

            dataGridView1.DataSource = proveedores;
            dataGridView1.Columns[0].Visible = false;

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_proveedorSeleccionadoEdicion == null)
            {
                Proveedor proveedor = new Proveedor();
                proveedor.Nombre = inpNombre.Text;
                proveedor.Empresa = inpEmpresa.Text;
                proveedor.Telefono = inpTelefono.Text;
                proveedor.Direccion = inpDireccion.Text;
                proveedor.Correo = inpCorreo.Text;

                _context.Proveedores.Add(proveedor);
            }
            else
            {
                Proveedor proveedorActualizar = _context.Proveedores.Find(_proveedorSeleccionadoEdicion.ProveedorId);
                proveedorActualizar.Nombre = inpNombre.Text.Trim();
                proveedorActualizar.Empresa = inpEmpresa.Text.Trim();
                proveedorActualizar.Telefono = inpTelefono.Text.Trim();
                proveedorActualizar.Direccion = inpDireccion.Text.Trim();
                proveedorActualizar.Correo = inpCorreo.Text.Trim();
            }

            _context.SaveChanges();

            inpNombre.Text = "";
            inpEmpresa.Text = "";
            inpTelefono.Text = "";
            inpDireccion.Text = "";
            inpCorreo.Text = "";

            cargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Proveedor proveedorEliminar = _context.Proveedores.Find((int)dataGridView1.CurrentRow.Cells[0].Value);

                _context.Proveedores.Remove(proveedorEliminar);
                _context.SaveChanges();
                cargarDatos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                _proveedorSeleccionadoEdicion = new Proveedor
                {
                    ProveedorId = (int)dataGridView1.CurrentRow.Cells[0].Value,
                    Nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                    Empresa = dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                    Telefono = dataGridView1.CurrentRow.Cells[3].Value.ToString(),
                    Direccion = dataGridView1.CurrentRow.Cells[4].Value.ToString(),
                    Correo = dataGridView1.CurrentRow.Cells[5].Value.ToString(),
                };

                inpNombre.Text = _proveedorSeleccionadoEdicion.Nombre;
                inpEmpresa.Text = _proveedorSeleccionadoEdicion.Empresa;
                inpTelefono.Text = _proveedorSeleccionadoEdicion.Telefono;
                inpDireccion.Text = _proveedorSeleccionadoEdicion.Direccion;
                inpCorreo.Text = _proveedorSeleccionadoEdicion.Correo;
            }
        }
    }
}
