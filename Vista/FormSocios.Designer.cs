﻿namespace Vista
{
    partial class FormSocios
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
            buttonAgregar = new Button();
            BtnModificar = new Button();
            buttonBorrar = new Button();
            dgvSocios = new DataGridView();
            textBoxBuscar = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            buttonSalir = new Button();
            buttonLimpiar = new Button();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            textBoxDni = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            SuspendLayout();
            // 
            // buttonAgregar
            // 
            buttonAgregar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAgregar.Location = new Point(213, 56);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(170, 50);
            buttonAgregar.TabIndex = 4;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BtnModificar.Location = new Point(214, 210);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(170, 50);
            BtnModificar.TabIndex = 3;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // buttonBorrar
            // 
            buttonBorrar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBorrar.Location = new Point(214, 121);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(170, 50);
            buttonBorrar.TabIndex = 2;
            buttonBorrar.Text = "Borrar";
            buttonBorrar.UseVisualStyleBackColor = true;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // dgvSocios
            // 
            dgvSocios.AllowUserToAddRows = false;
            dgvSocios.AllowUserToDeleteRows = false;
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Location = new Point(405, 100);
            dgvSocios.Name = "dgvSocios";
            dgvSocios.ReadOnly = true;
            dgvSocios.RowTemplate.Height = 25;
            dgvSocios.Size = new Size(513, 333);
            dgvSocios.TabIndex = 2;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.BorderStyle = BorderStyle.FixedSingle;
            textBoxBuscar.Location = new Point(474, 62);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(444, 23);
            textBoxBuscar.TabIndex = 3;
            textBoxBuscar.TextChanged += textBoxBuscar_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(405, 62);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
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
            // 
            // buttonSalir
            // 
            buttonSalir.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSalir.Location = new Point(12, 438);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(350, 50);
            buttonSalir.TabIndex = 1;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLimpiar.Location = new Point(15, 285);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(170, 50);
            buttonLimpiar.TabIndex = 5;
            buttonLimpiar.Text = "Limpiar Todo";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.BorderStyle = BorderStyle.FixedSingle;
            textBoxNombre.Location = new Point(12, 86);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(195, 23);
            textBoxNombre.TabIndex = 6;
            textBoxNombre.TextChanged += textBoxNombre_TextChanged;
            // 
            // textBoxApellido
            // 
            textBoxApellido.BorderStyle = BorderStyle.FixedSingle;
            textBoxApellido.Location = new Point(15, 158);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(192, 23);
            textBoxApellido.TabIndex = 7;
            textBoxApellido.TextChanged += textBoxApellido_TextChanged;
            // 
            // textBoxDni
            // 
            textBoxDni.BorderStyle = BorderStyle.FixedSingle;
            textBoxDni.Location = new Point(15, 237);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(192, 23);
            textBoxDni.TabIndex = 8;
            textBoxDni.TextChanged += textBoxDni_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 9;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 121);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 10;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(15, 199);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 11;
            label3.Text = "D.N.I";
            // 
            // FormSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(930, 500);
            Controls.Add(textBoxNombre);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBoxApellido);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(textBoxDni);
            Controls.Add(label4);
            Controls.Add(textBoxBuscar);
            Controls.Add(dgvSocios);
            Controls.Add(buttonAgregar);
            Controls.Add(buttonLimpiar);
            Controls.Add(BtnModificar);
            Controls.Add(buttonSalir);
            Controls.Add(buttonBorrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSocios";
            Text = "FormSocios";
            Load += FormSocios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvSocios;
        private Button buttonAgregar;
        private Button BtnModificar;
        private Button buttonBorrar;
        private TextBox textBoxBuscar;
        private Label label4;
        private Panel panel2;
        private Button buttonSalir;
        private Button buttonLimpiar;
        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private TextBox textBoxDni;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}