namespace Sistema_POS.Views
{
    partial class Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnEliminar = new Button();
            panel2 = new Panel();
            inpEstado = new ListBox();
            label10 = new Label();
            inpProveedor = new ListBox();
            label9 = new Label();
            label8 = new Label();
            inpUbicacionAlmacen = new TextBox();
            inpPrecio = new NumericUpDown();
            inpCantidadStock = new NumericUpDown();
            label7 = new Label();
            inpNombre = new TextBox();
            label6 = new Label();
            inpCategoria = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btnGuardar = new Button();
            label3 = new Label();
            inpDescripcion = new TextBox();
            Label2 = new Label();
            inpCodigo = new TextBox();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            btnEditar = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inpPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inpCantidadStock).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(164, 45);
            label1.TabIndex = 0;
            label1.Text = "Productos";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(101, 97);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(inpEstado);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(inpProveedor);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(inpUbicacionAlmacen);
            panel2.Controls.Add(inpPrecio);
            panel2.Controls.Add(inpCantidadStock);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(inpNombre);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(inpCategoria);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(inpDescripcion);
            panel2.Controls.Add(Label2);
            panel2.Controls.Add(inpCodigo);
            panel2.Location = new Point(592, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 562);
            panel2.TabIndex = 7;
            // 
            // inpEstado
            // 
            inpEstado.FormattingEnabled = true;
            inpEstado.ItemHeight = 15;
            inpEstado.Location = new Point(5, 482);
            inpEstado.Name = "inpEstado";
            inpEstado.Size = new Size(287, 34);
            inpEstado.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 464);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 19;
            label10.Text = "Estado";
            // 
            // inpProveedor
            // 
            inpProveedor.FormattingEnabled = true;
            inpProveedor.ItemHeight = 15;
            inpProveedor.Location = new Point(5, 420);
            inpProveedor.Name = "inpProveedor";
            inpProveedor.Size = new Size(287, 34);
            inpProveedor.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 402);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 17;
            label9.Text = "Proveedor";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 344);
            label8.Name = "label8";
            label8.Size = new Size(126, 15);
            label8.TabIndex = 16;
            label8.Text = "Ubicación en Almacén";
            // 
            // inpUbicacionAlmacen
            // 
            inpUbicacionAlmacen.Location = new Point(3, 365);
            inpUbicacionAlmacen.Name = "inpUbicacionAlmacen";
            inpUbicacionAlmacen.Size = new Size(289, 23);
            inpUbicacionAlmacen.TabIndex = 15;
            // 
            // inpPrecio
            // 
            inpPrecio.Location = new Point(3, 198);
            inpPrecio.Name = "inpPrecio";
            inpPrecio.Size = new Size(291, 23);
            inpPrecio.TabIndex = 14;
            // 
            // inpCantidadStock
            // 
            inpCantidadStock.Location = new Point(3, 257);
            inpCantidadStock.Name = "inpCantidadStock";
            inpCantidadStock.Size = new Size(289, 23);
            inpCantidadStock.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 72);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 12;
            label7.Text = "Nombre";
            // 
            // inpNombre
            // 
            inpNombre.Location = new Point(3, 91);
            inpNombre.Name = "inpNombre";
            inpNombre.Size = new Size(289, 23);
            inpNombre.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 290);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 10;
            label6.Text = "Categoría";
            // 
            // inpCategoria
            // 
            inpCategoria.Location = new Point(3, 311);
            inpCategoria.Name = "inpCategoria";
            inpCategoria.Size = new Size(289, 23);
            inpCategoria.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 233);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 8;
            label5.Text = "Cantidad en Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 177);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 6;
            label4.Text = "Precio";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.CornflowerBlue;
            btnGuardar.ForeColor = SystemColors.ButtonFace;
            btnGuardar.Location = new Point(0, 523);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(295, 33);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 123);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 3;
            label3.Text = "Descripción";
            // 
            // inpDescripcion
            // 
            inpDescripcion.Location = new Point(3, 144);
            inpDescripcion.Name = "inpDescripcion";
            inpDescripcion.Size = new Size(289, 23);
            inpDescripcion.TabIndex = 2;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(5, 20);
            Label2.Name = "Label2";
            Label2.Size = new Size(46, 15);
            Label2.TabIndex = 1;
            Label2.Text = "Código";
            // 
            // inpCodigo
            // 
            inpCodigo.Location = new Point(3, 41);
            inpCodigo.Name = "inpCodigo";
            inpCodigo.Size = new Size(289, 23);
            inpCodigo.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 476);
            panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(574, 476);
            dataGridView1.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Orange;
            btnEditar.ForeColor = SystemColors.ButtonFace;
            btnEditar.Location = new Point(20, 97);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 614);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Productos";
            Text = "Productos";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inpPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)inpCantidadStock).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEliminar;
        private Panel panel2;
        private Label label6;
        private TextBox inpCategoria;
        private Label label5;
        private Label label4;
        private Button btnGuardar;
        private Label label3;
        private TextBox inpDescripcion;
        private Label Label2;
        private TextBox inpCodigo;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label7;
        private TextBox inpNombre;
        private NumericUpDown inpPrecio;
        private NumericUpDown inpCantidadStock;
        private Label label8;
        private TextBox inpUbicacionAlmacen;
        private ListBox inpEstado;
        private Label label10;
        private ListBox inpProveedor;
        private Label label9;
        private Button btnEditar;
    }
}