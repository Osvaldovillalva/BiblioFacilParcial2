﻿namespace Vista
{
    partial class FormLibros
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
            buttonSalir = new Button();
            panel1 = new Panel();
            buttonLimpiar = new Button();
            textBoxCantidad = new TextBox();
            label3 = new Label();
            textBoxAutor = new TextBox();
            label2 = new Label();
            textBoxTitulo = new TextBox();
            label1 = new Label();
            buttonAgregar = new Button();
            buttonModificar = new Button();
            buttonBorrar = new Button();
            dgvLibros = new DataGridView();
            textBoxBuscar = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // buttonSalir
            // 
            buttonSalir.Dock = DockStyle.Bottom;
            buttonSalir.Location = new Point(0, 392);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(238, 47);
            buttonSalir.TabIndex = 0;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(buttonLimpiar);
            panel1.Controls.Add(textBoxCantidad);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxAutor);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxTitulo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonAgregar);
            panel1.Controls.Add(buttonModificar);
            panel1.Controls.Add(buttonBorrar);
            panel1.Controls.Add(buttonSalir);
            panel1.Location = new Point(4, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 441);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(36, 154);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(166, 46);
            buttonLimpiar.TabIndex = 9;
            buttonLimpiar.Text = "Limpiar Todo";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.BorderStyle = BorderStyle.FixedSingle;
            textBoxCantidad.Location = new Point(11, 125);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(216, 23);
            textBoxCantidad.TabIndex = 8;
            textBoxCantidad.TextChanged += textBoxCantidad_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(11, 107);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 7;
            label3.Text = "Cantidad";
            // 
            // textBoxAutor
            // 
            textBoxAutor.BorderStyle = BorderStyle.FixedSingle;
            textBoxAutor.Location = new Point(11, 71);
            textBoxAutor.Name = "textBoxAutor";
            textBoxAutor.Size = new Size(216, 23);
            textBoxAutor.TabIndex = 6;
            textBoxAutor.TextChanged += textBoxAutor_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 53);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 5;
            label2.Text = "Apellido del Autor";
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.BorderStyle = BorderStyle.FixedSingle;
            textBoxTitulo.Location = new Point(11, 27);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(216, 23);
            textBoxTitulo.TabIndex = 4;
            textBoxTitulo.TextChanged += textBoxTitulo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 3;
            label1.Text = "Titulo";
            // 
            // buttonAgregar
            // 
            buttonAgregar.Dock = DockStyle.Bottom;
            buttonAgregar.Location = new Point(0, 206);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(238, 69);
            buttonAgregar.TabIndex = 2;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Dock = DockStyle.Bottom;
            buttonModificar.Location = new Point(0, 275);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(238, 60);
            buttonModificar.TabIndex = 1;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonBorrar
            // 
            buttonBorrar.Dock = DockStyle.Bottom;
            buttonBorrar.Location = new Point(0, 335);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(238, 57);
            buttonBorrar.TabIndex = 0;
            buttonBorrar.Text = "Borrar";
            buttonBorrar.UseVisualStyleBackColor = true;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // dgvLibros
            // 
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.AllowUserToDeleteRows = false;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(249, 101);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.ReadOnly = true;
            dgvLibros.RowTemplate.Height = 25;
            dgvLibros.Size = new Size(669, 387);
            dgvLibros.TabIndex = 2;
            dgvLibros.CellContentClick += dgvLibros_CellContentClick;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.BorderStyle = BorderStyle.FixedSingle;
            textBoxBuscar.Location = new Point(303, 57);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(615, 23);
            textBoxBuscar.TabIndex = 3;
            textBoxBuscar.TextChanged += textBoxBuscar_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.ForeColor = Color.White;
            label4.Location = new Point(255, 65);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 4;
            label4.Text = "Buscar";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumVioletRed;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(930, 50);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // FormLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(930, 500);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(textBoxBuscar);
            Controls.Add(dgvLibros);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLibros";
            Text = "FormLibros";
            Load += FormLibros_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSalir;
        private Panel panel1;
        private DataGridView dgvLibros;
        private Button buttonBorrar;
        private Label label3;
        private TextBox textBoxAutor;
        private Label label2;
        private TextBox textBoxTitulo;
        private Label label1;
        private Button buttonAgregar;
        private Button buttonModificar;
        private TextBox textBoxCantidad;
        private TextBox textBoxBuscar;
        private Label label4;
        private Button buttonLimpiar;
        private Panel panel2;
    }
}