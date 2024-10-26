namespace Sistema_POS.Views
{
    partial class Proveedores
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
            panel2 = new Panel();
            label6 = new Label();
            inpCorreo = new TextBox();
            label5 = new Label();
            inpDireccion = new TextBox();
            label4 = new Label();
            inpTelefono = new TextBox();
            btnGuardar = new Button();
            label3 = new Label();
            inpEmpresa = new TextBox();
            Label2 = new Label();
            inpNombre = new TextBox();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            btnEliminar = new Button();
            btnEditar = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(197, 45);
            label1.TabIndex = 0;
            label1.Text = "Proveedores";
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(inpCorreo);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(inpDireccion);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(inpTelefono);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(inpEmpresa);
            panel2.Controls.Add(Label2);
            panel2.Controls.Add(inpNombre);
            panel2.Location = new Point(592, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 476);
            panel2.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 275);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 10;
            label6.Text = "Correo";
            // 
            // inpCorreo
            // 
            inpCorreo.Location = new Point(3, 296);
            inpCorreo.Name = "inpCorreo";
            inpCorreo.Size = new Size(289, 23);
            inpCorreo.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 211);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 8;
            label5.Text = "Dirección";
            // 
            // inpDireccion
            // 
            inpDireccion.Location = new Point(3, 232);
            inpDireccion.Name = "inpDireccion";
            inpDireccion.Size = new Size(289, 23);
            inpDireccion.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 145);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 6;
            label4.Text = "Telefono";
            // 
            // inpTelefono
            // 
            inpTelefono.Location = new Point(3, 166);
            inpTelefono.Name = "inpTelefono";
            inpTelefono.Size = new Size(289, 23);
            inpTelefono.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.CornflowerBlue;
            btnGuardar.ForeColor = SystemColors.ButtonFace;
            btnGuardar.Location = new Point(0, 374);
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
            label3.Location = new Point(5, 87);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 3;
            label3.Text = "Empresa";
            // 
            // inpEmpresa
            // 
            inpEmpresa.Location = new Point(3, 108);
            inpEmpresa.Name = "inpEmpresa";
            inpEmpresa.Size = new Size(289, 23);
            inpEmpresa.TabIndex = 2;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(5, 20);
            Label2.Name = "Label2";
            Label2.Size = new Size(51, 15);
            Label2.TabIndex = 1;
            Label2.Text = "Nombre";
            // 
            // inpNombre
            // 
            inpNombre.Location = new Point(3, 41);
            inpNombre.Name = "inpNombre";
            inpNombre.Size = new Size(289, 23);
            inpNombre.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 476);
            panel1.TabIndex = 3;
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
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(809, 97);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Orange;
            btnEditar.ForeColor = SystemColors.ButtonFace;
            btnEditar.Location = new Point(728, 97);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // Proveedores
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
            Name = "Proveedores";
            Text = "Proveedores";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Label label6;
        private TextBox inpCorreo;
        private Label label5;
        private TextBox inpDireccion;
        private Label label4;
        private TextBox inpTelefono;
        private Button btnGuardar;
        private Label label3;
        private TextBox inpEmpresa;
        private Label Label2;
        private TextBox inpNombre;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button btnEliminar;
        private Button btnEditar;
    }
}