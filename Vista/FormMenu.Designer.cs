﻿namespace Vista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            buttonSocios = new Button();
            buttonLibros = new Button();
            button1 = new Button();
            buttonPrestamos = new Button();
            button2 = new Button();
            buttonCuota = new Button();
            buttonSalir = new Button();
            buttonCobroCuotas = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonSocios
            // 
            buttonSocios.FlatAppearance.BorderColor = Color.White;
            buttonSocios.FlatAppearance.BorderSize = 0;
            buttonSocios.FlatStyle = FlatStyle.Flat;
            buttonSocios.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSocios.ForeColor = SystemColors.ButtonFace;
            buttonSocios.Location = new Point(12, 67);
            buttonSocios.Name = "buttonSocios";
            buttonSocios.Size = new Size(170, 50);
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
            buttonLibros.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLibros.ForeColor = SystemColors.ButtonFace;
            buttonLibros.Location = new Point(12, 133);
            buttonLibros.Name = "buttonLibros";
            buttonLibros.Size = new Size(170, 50);
            buttonLibros.TabIndex = 0;
            buttonLibros.Text = "Libros";
            buttonLibros.UseVisualStyleBackColor = true;
            buttonLibros.Click += buttonLibros_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(12, 263);
            button1.Name = "button1";
            button1.Size = new Size(170, 59);
            button1.TabIndex = 2;
            button1.Text = "Generar\r\n Devoluciones";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonPrestamos
            // 
            buttonPrestamos.FlatAppearance.BorderColor = Color.White;
            buttonPrestamos.FlatAppearance.BorderSize = 0;
            buttonPrestamos.FlatStyle = FlatStyle.Flat;
            buttonPrestamos.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPrestamos.ForeColor = SystemColors.ButtonFace;
            buttonPrestamos.Location = new Point(12, 189);
            buttonPrestamos.Name = "buttonPrestamos";
            buttonPrestamos.Size = new Size(170, 50);
            buttonPrestamos.TabIndex = 2;
            buttonPrestamos.Text = "Generar Prestamos ";
            buttonPrestamos.UseVisualStyleBackColor = true;
            buttonPrestamos.Click += buttonPrestamos_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(12, 363);
            button2.Name = "button2";
            button2.Size = new Size(170, 50);
            button2.TabIndex = 3;
            button2.Text = "Registros";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonCuota
            // 
            buttonCuota.FlatStyle = FlatStyle.Popup;
            buttonCuota.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCuota.ForeColor = SystemColors.ButtonFace;
            buttonCuota.Location = new Point(228, 67);
            buttonCuota.Name = "buttonCuota";
            buttonCuota.Size = new Size(170, 60);
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
            buttonSalir.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSalir.ForeColor = SystemColors.ButtonFace;
            buttonSalir.Image = (Image)resources.GetObject("buttonSalir.Image");
            buttonSalir.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalir.Location = new Point(573, 440);
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
            buttonCobroCuotas.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCobroCuotas.ForeColor = SystemColors.ButtonFace;
            buttonCobroCuotas.Location = new Point(228, 133);
            buttonCobroCuotas.Name = "buttonCobroCuotas";
            buttonCobroCuotas.Size = new Size(170, 50);
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
            panel3.Size = new Size(930, 40);
            panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(512, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 346);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(930, 500);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}