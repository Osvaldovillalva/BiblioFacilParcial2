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
            panel1 = new Panel();
            button1 = new Button();
            buttonPrestamos = new Button();
            buttonSocios = new Button();
            buttonLibros = new Button();
            button2 = new Button();
            buttonCuota = new Button();
            buttonReglas = new Button();
            buttonSalir = new Button();
            panel2 = new Panel();
            buttonCobroCuotas = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(buttonPrestamos);
            panel1.Controls.Add(buttonSocios);
            panel1.Controls.Add(buttonLibros);
            panel1.Location = new Point(0, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 422);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 231);
            button1.Name = "button1";
            button1.Size = new Size(197, 89);
            button1.TabIndex = 2;
            button1.Text = "Consulta Prestamos \r\n\r\n Generar Devoluciones";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonPrestamos
            // 
            buttonPrestamos.Dock = DockStyle.Top;
            buttonPrestamos.Location = new Point(0, 128);
            buttonPrestamos.Name = "buttonPrestamos";
            buttonPrestamos.Size = new Size(197, 103);
            buttonPrestamos.TabIndex = 2;
            buttonPrestamos.Text = "Generar Prestamos ";
            buttonPrestamos.UseVisualStyleBackColor = true;
            buttonPrestamos.Click += buttonPrestamos_Click;
            // 
            // buttonSocios
            // 
            buttonSocios.Dock = DockStyle.Top;
            buttonSocios.Location = new Point(0, 63);
            buttonSocios.Name = "buttonSocios";
            buttonSocios.Size = new Size(197, 65);
            buttonSocios.TabIndex = 1;
            buttonSocios.Text = "Socios";
            buttonSocios.UseVisualStyleBackColor = true;
            buttonSocios.Click += buttonSocios_Click;
            // 
            // buttonLibros
            // 
            buttonLibros.Dock = DockStyle.Top;
            buttonLibros.Location = new Point(0, 0);
            buttonLibros.Name = "buttonLibros";
            buttonLibros.Size = new Size(197, 63);
            buttonLibros.TabIndex = 0;
            buttonLibros.Text = "Libros";
            buttonLibros.UseVisualStyleBackColor = true;
            buttonLibros.Click += buttonLibros_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Bottom;
            button2.Location = new Point(0, 320);
            button2.Name = "button2";
            button2.Size = new Size(194, 71);
            button2.TabIndex = 3;
            button2.Text = "Registros";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonCuota
            // 
            buttonCuota.Dock = DockStyle.Top;
            buttonCuota.Location = new Point(0, 94);
            buttonCuota.Name = "buttonCuota";
            buttonCuota.Size = new Size(194, 66);
            buttonCuota.TabIndex = 2;
            buttonCuota.Text = "Asignar valor Cuota";
            buttonCuota.UseVisualStyleBackColor = true;
            buttonCuota.Click += buttonCuota_Click;
            // 
            // buttonReglas
            // 
            buttonReglas.Dock = DockStyle.Top;
            buttonReglas.Location = new Point(0, 0);
            buttonReglas.Name = "buttonReglas";
            buttonReglas.Size = new Size(194, 94);
            buttonReglas.TabIndex = 2;
            buttonReglas.Text = "Reglas de la Biblioteca";
            buttonReglas.UseVisualStyleBackColor = true;
            buttonReglas.Click += buttonReglas_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(328, 331);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(156, 74);
            buttonSalir.TabIndex = 1;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonCobroCuotas);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(buttonCuota);
            panel2.Controls.Add(buttonReglas);
            panel2.Location = new Point(606, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(194, 391);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // buttonCobroCuotas
            // 
            buttonCobroCuotas.Dock = DockStyle.Top;
            buttonCobroCuotas.Location = new Point(0, 160);
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
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(buttonSalir);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            Text = "Menu";
            Load += FormMenu_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
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
    }
}