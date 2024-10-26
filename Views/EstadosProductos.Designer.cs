namespace Sistema_POS.Views
{
    partial class EstadosProductos
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnGuardar = new Button();
            label3 = new Label();
            inpDescripcion = new TextBox();
            Label2 = new Label();
            inpNombre = new TextBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(327, 45);
            label1.TabIndex = 0;
            label1.Text = "Estados de Productos";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 476);
            panel1.TabIndex = 1;
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
            // panel2
            // 
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(inpDescripcion);
            panel2.Controls.Add(Label2);
            panel2.Controls.Add(inpNombre);
            panel2.Location = new Point(592, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 476);
            panel2.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.CornflowerBlue;
            btnGuardar.ForeColor = SystemColors.ButtonFace;
            btnGuardar.Location = new Point(0, 160);
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
            label3.Size = new Size(69, 15);
            label3.TabIndex = 3;
            label3.Text = "Descripción";
            // 
            // inpDescripcion
            // 
            inpDescripcion.Location = new Point(3, 108);
            inpDescripcion.Name = "inpDescripcion";
            inpDescripcion.Size = new Size(289, 23);
            inpDescripcion.TabIndex = 2;
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
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(809, 87);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Orange;
            btnEditar.ForeColor = SystemColors.ButtonFace;
            btnEditar.Location = new Point(728, 87);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // EstadosProductos
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
            Name = "EstadosProductos";
            Text = "EstadosProductos";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button btnGuardar;
        private Label label3;
        private TextBox inpDescripcion;
        private Label Label2;
        private TextBox inpNombre;
        private Button btnEliminar;
        private Button btnEditar;
    }
}