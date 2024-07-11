namespace Vista
{
    partial class FormMenu
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
            buttonSocios = new Button();
            buttonLibros = new Button();
            button1 = new Button();
            buttonPrestamos = new Button();
            button2 = new Button();
            buttonCuota = new Button();
            buttonReglas = new Button();
            buttonSalir = new Button();
            panel2 = new Panel();
            buttonCobroCuotas = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSocios
            // 
            buttonSocios.Dock = DockStyle.Top;
            buttonSocios.FlatAppearance.BorderColor = Color.White;
            buttonSocios.FlatAppearance.BorderSize = 2;
            buttonSocios.FlatStyle = FlatStyle.Flat;
            buttonSocios.ForeColor = SystemColors.ButtonFace;
            buttonSocios.Location = new Point(0, 142);
            buttonSocios.Name = "buttonSocios";
            buttonSocios.Size = new Size(203, 71);
            buttonSocios.TabIndex = 1;
            buttonSocios.Text = "Socios";
            buttonSocios.UseVisualStyleBackColor = true;
            buttonSocios.Click += buttonSocios_Click;
            // 
            // buttonLibros
            // 
            buttonLibros.Dock = DockStyle.Top;
            buttonLibros.FlatAppearance.BorderColor = Color.White;
            buttonLibros.FlatAppearance.BorderSize = 2;
            buttonLibros.FlatStyle = FlatStyle.Flat;
            buttonLibros.ForeColor = SystemColors.ButtonFace;
            buttonLibros.Location = new Point(0, 0);
            buttonLibros.Name = "buttonLibros";
            buttonLibros.Size = new Size(203, 71);
            buttonLibros.TabIndex = 0;
            buttonLibros.Text = "Libros";
            buttonLibros.UseVisualStyleBackColor = true;
            buttonLibros.Click += buttonLibros_Click;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(253, 189);
            button1.Name = "button1";
            button1.Size = new Size(197, 69);
            button1.TabIndex = 2;
            button1.Text = "Consulta Prestamos \r\n\r\n Generar Devoluciones";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonPrestamos
            // 
            buttonPrestamos.Dock = DockStyle.Top;
            buttonPrestamos.FlatAppearance.BorderColor = Color.White;
            buttonPrestamos.FlatAppearance.BorderSize = 2;
            buttonPrestamos.FlatStyle = FlatStyle.Flat;
            buttonPrestamos.ForeColor = SystemColors.ButtonFace;
            buttonPrestamos.Location = new Point(0, 71);
            buttonPrestamos.Name = "buttonPrestamos";
            buttonPrestamos.Size = new Size(203, 71);
            buttonPrestamos.TabIndex = 2;
            buttonPrestamos.Text = "Generar Prestamos ";
            buttonPrestamos.UseVisualStyleBackColor = true;
            buttonPrestamos.Click += buttonPrestamos_Click;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(638, 84);
            button2.Name = "button2";
            button2.Size = new Size(194, 71);
            button2.TabIndex = 3;
            button2.Text = "Registros";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonCuota
            // 
            buttonCuota.ForeColor = SystemColors.ButtonFace;
            buttonCuota.Location = new Point(638, 269);
            buttonCuota.Name = "buttonCuota";
            buttonCuota.Size = new Size(197, 69);
            buttonCuota.TabIndex = 2;
            buttonCuota.Text = "Asignar valor Cuota";
            buttonCuota.UseVisualStyleBackColor = true;
            buttonCuota.Click += buttonCuota_Click;
            // 
            // buttonReglas
            // 
            buttonReglas.ForeColor = SystemColors.ButtonFace;
            buttonReglas.Location = new Point(-15, 289);
            buttonReglas.Name = "buttonReglas";
            buttonReglas.Size = new Size(194, 71);
            buttonReglas.TabIndex = 2;
            buttonReglas.Text = "Reglas de la Biblioteca";
            buttonReglas.UseVisualStyleBackColor = true;
            buttonReglas.Click += buttonReglas_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.FlatAppearance.BorderColor = Color.White;
            buttonSalir.FlatAppearance.BorderSize = 2;
            buttonSalir.FlatStyle = FlatStyle.Flat;
            buttonSalir.ForeColor = SystemColors.ButtonFace;
            buttonSalir.Location = new Point(12, 438);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(350, 50);
            buttonSalir.TabIndex = 1;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonReglas);
            panel2.Location = new Point(411, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(194, 391);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // buttonCobroCuotas
            // 
            buttonCobroCuotas.ForeColor = SystemColors.ButtonFace;
            buttonCobroCuotas.Location = new Point(638, 176);
            buttonCobroCuotas.Name = "buttonCobroCuotas";
            buttonCobroCuotas.Size = new Size(194, 71);
            buttonCobroCuotas.TabIndex = 3;
            buttonCobroCuotas.Text = "Cobrar Cuota";
            buttonCobroCuotas.UseVisualStyleBackColor = true;
            buttonCobroCuotas.Click += buttonCobroCuotas_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumVioletRed;
            panel3.Dock = DockStyle.Top;
            panel3.ForeColor = Color.MediumVioletRed;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(930, 50);
            panel3.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSocios);
            panel1.Controls.Add(buttonPrestamos);
            panel1.Controls.Add(buttonLibros);
            panel1.Location = new Point(5, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(203, 376);
            panel1.TabIndex = 0;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(930, 500);
            Controls.Add(button1);
            Controls.Add(buttonCuota);
            Controls.Add(buttonCobroCuotas);
            Controls.Add(button2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(buttonSalir);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            Text = "Menu";
            Load += FormMenu_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button buttonLibros;
        private Button buttonSalir;
        private Button buttonSocios;
        private Button buttonPrestamos;
        private Button buttonReglas;
        private Button button1;
        private Button button2;
        private Button buttonCuota;
        private Panel panel2;
        private Button buttonCobroCuotas;
        private Panel panel3;
        private Panel panel1;
    }
}