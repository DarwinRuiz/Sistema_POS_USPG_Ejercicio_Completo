namespace Sistema_POS
{
    partial class SistemaPOS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            panelInventario = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            buttonInventario = new Button();
            panelLogo = new Panel();
            panelCuerpoApp = new Panel();
            panelMenu.SuspendLayout();
            panelInventario.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Black;
            panelMenu.Controls.Add(panelInventario);
            panelMenu.Controls.Add(buttonInventario);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 614);
            panelMenu.TabIndex = 0;
            // 
            // panelInventario
            // 
            panelInventario.BackColor = Color.DarkGray;
            panelInventario.Controls.Add(button4);
            panelInventario.Controls.Add(button3);
            panelInventario.Controls.Add(button2);
            panelInventario.Dock = DockStyle.Top;
            panelInventario.Location = new Point(0, 145);
            panelInventario.Name = "panelInventario";
            panelInventario.Size = new Size(200, 148);
            panelInventario.TabIndex = 2;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(0, 90);
            button4.Name = "button4";
            button4.Padding = new Padding(35, 0, 0, 0);
            button4.Size = new Size(200, 45);
            button4.TabIndex = 2;
            button4.Text = "Productos";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(0, 45);
            button3.Name = "button3";
            button3.Padding = new Padding(35, 0, 0, 0);
            button3.Size = new Size(200, 45);
            button3.TabIndex = 1;
            button3.Text = "Estados de Productos";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Padding = new Padding(35, 0, 0, 0);
            button2.Size = new Size(200, 45);
            button2.TabIndex = 0;
            button2.Text = "Proveedores";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonInventario
            // 
            buttonInventario.Dock = DockStyle.Top;
            buttonInventario.FlatAppearance.BorderSize = 0;
            buttonInventario.FlatStyle = FlatStyle.Flat;
            buttonInventario.ForeColor = SystemColors.ButtonFace;
            buttonInventario.Location = new Point(0, 100);
            buttonInventario.Name = "buttonInventario";
            buttonInventario.Padding = new Padding(10, 0, 0, 0);
            buttonInventario.Size = new Size(200, 45);
            buttonInventario.TabIndex = 1;
            buttonInventario.Text = "Inventario";
            buttonInventario.TextAlign = ContentAlignment.MiddleLeft;
            buttonInventario.UseVisualStyleBackColor = true;
            buttonInventario.Click += buttonInventario_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 100);
            panelLogo.TabIndex = 0;
            // 
            // panelCuerpoApp
            // 
            panelCuerpoApp.BackColor = SystemColors.ButtonHighlight;
            panelCuerpoApp.Dock = DockStyle.Fill;
            panelCuerpoApp.Location = new Point(200, 0);
            panelCuerpoApp.Name = "panelCuerpoApp";
            panelCuerpoApp.Size = new Size(899, 614);
            panelCuerpoApp.TabIndex = 1;
            // 
            // SistemaPOS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 614);
            Controls.Add(panelCuerpoApp);
            Controls.Add(panelMenu);
            Name = "SistemaPOS";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelInventario.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelInventario;
        private Button button2;
        private Button buttonInventario;
        private Panel panelLogo;
        private Button button4;
        private Button button3;
        private Panel panelCuerpoApp;
    }
}
