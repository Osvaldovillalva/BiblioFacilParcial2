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
            buttonSalir = new Button();
            buttonCobroCuotas = new Button();
            panel3 = new Panel();
            SuspendLayout();
            // 
            // buttonSocios
            // 
            buttonSocios.FlatAppearance.BorderColor = Color.White;
            buttonSocios.FlatAppearance.BorderSize = 0;
            buttonSocios.FlatStyle = FlatStyle.Flat;
            buttonSocios.ForeColor = SystemColors.ButtonFace;
            buttonSocios.Location = new Point(0, 56);
            buttonSocios.Name = "buttonSocios";
            buttonSocios.Size = new Size(203, 71);
            buttonSocios.TabIndex = 1;
            buttonSocios.Text = "Socios";
            buttonSocios.UseVisualStyleBackColor = true;
            buttonSocios.Click += buttonSocios_Click;
            // 
            // buttonLibros
            // 
            buttonLibros.FlatAppearance.BorderColor = Color.White;
            buttonLibros.FlatAppearance.BorderSize = 0;
            buttonLibros.FlatStyle = FlatStyle.Flat;
            buttonLibros.ForeColor = SystemColors.ButtonFace;
            buttonLibros.Location = new Point(0, 133);
            buttonLibros.Name = "buttonLibros";
            buttonLibros.Size = new Size(203, 71);
            buttonLibros.TabIndex = 0;
            buttonLibros.Text = "Libros";
            buttonLibros.UseVisualStyleBackColor = true;
            buttonLibros.Click += buttonLibros_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(18, 342);
            button1.Name = "button1";
            button1.Size = new Size(197, 69);
            button1.TabIndex = 2;
            button1.Text = "Consulta Prestamos \r\n\r\n Generar Devoluciones";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonPrestamos
            // 
            buttonPrestamos.FlatAppearance.BorderColor = Color.White;
            buttonPrestamos.FlatAppearance.BorderSize = 0;
            buttonPrestamos.FlatStyle = FlatStyle.Flat;
            buttonPrestamos.ForeColor = SystemColors.ButtonFace;
            buttonPrestamos.Location = new Point(12, 225);
            buttonPrestamos.Name = "buttonPrestamos";
            buttonPrestamos.Size = new Size(203, 71);
            buttonPrestamos.TabIndex = 2;
            buttonPrestamos.Text = "Generar Prestamos ";
            buttonPrestamos.UseVisualStyleBackColor = true;
            buttonPrestamos.Click += buttonPrestamos_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
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
            buttonCuota.FlatStyle = FlatStyle.Popup;
            buttonCuota.ForeColor = SystemColors.ButtonFace;
            buttonCuota.Location = new Point(638, 269);
            buttonCuota.Name = "buttonCuota";
            buttonCuota.Size = new Size(197, 69);
            buttonCuota.TabIndex = 2;
            buttonCuota.Text = "Asignar valor Cuota";
            buttonCuota.UseVisualStyleBackColor = true;
            buttonCuota.Click += buttonCuota_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.FlatAppearance.BorderColor = Color.White;
            buttonSalir.FlatAppearance.BorderSize = 0;
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
            // buttonCobroCuotas
            // 
            buttonCobroCuotas.FlatStyle = FlatStyle.Popup;
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
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(930, 500);
            Controls.Add(buttonLibros);
            Controls.Add(buttonPrestamos);
            Controls.Add(buttonSocios);
            Controls.Add(button1);
            Controls.Add(buttonCuota);
            Controls.Add(buttonCobroCuotas);
            Controls.Add(button2);
            Controls.Add(panel3);
            Controls.Add(buttonSalir);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            Text = "Menu";
            Load += FormMenu_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button buttonLibros;
        private Button buttonSalir;
        private Button buttonSocios;
        private Button buttonPrestamos;
        private Button button1;
        private Button button2;
        private Button buttonCuota;
        private Button buttonCobroCuotas;
        private Panel panel3;
    }
}