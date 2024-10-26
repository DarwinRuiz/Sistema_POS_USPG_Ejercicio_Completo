using Sistema_POS.Views;

namespace Sistema_POS
{
    public partial class SistemaPOS : Form
    {
        public SistemaPOS()
        {
            InitializeComponent();
            ConfigurarMenu();
        }

        public void ConfigurarMenu()
        {
            panelInventario.Visible = false;
        }

        public void OcultarSubmenu()
        {
            if (panelInventario.Visible)
            {
                panelInventario.Visible = false;
            }
        }

        public void MostrarSubmenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                OcultarSubmenu();
                subMenu.Visible = true;
            }
        }

        private void buttonInventario_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelInventario);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirModulo(new Proveedores());
            OcultarSubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirModulo(new EstadosProductos());
            OcultarSubmenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirModulo(new Productos());
            OcultarSubmenu();
        }


        private Form moduloActivo = null;
        private void AbrirModulo(Form modulo)
        {
            if (moduloActivo != null)
            {
                moduloActivo.Close();
            }
            moduloActivo = modulo;
            modulo.TopLevel = false;
            modulo.FormBorderStyle = FormBorderStyle.None;
            modulo.Dock = DockStyle.Fill;
            panelCuerpoApp.Controls.Add(modulo);
            panelCuerpoApp.Tag = modulo;
            modulo.BringToFront();
            modulo.Show();
        }
    }
}
