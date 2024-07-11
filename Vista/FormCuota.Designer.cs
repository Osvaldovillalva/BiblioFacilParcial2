namespace Vista
{
    partial class FormCuota
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
            label3 = new Label();
            comboBoxMes = new ComboBox();
            label1 = new Label();
            textBoxAño = new TextBox();
            buttonAgregar = new Button();
            buttonEliminar = new Button();
            buttonModificar = new Button();
            textBoxValorCuota = new TextBox();
            label2 = new Label();
            dgvValorCuota = new DataGridView();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvValorCuota).BeginInit();
            SuspendLayout();
            // 
            // buttonSalir
            // 
            buttonSalir.Dock = DockStyle.Bottom;
            buttonSalir.Location = new Point(0, 374);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(187, 61);
            buttonSalir.TabIndex = 0;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBoxMes);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxAño);
            panel1.Controls.Add(buttonAgregar);
            panel1.Controls.Add(buttonEliminar);
            panel1.Controls.Add(buttonModificar);
            panel1.Controls.Add(textBoxValorCuota);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonSalir);
            panel1.Location = new Point(12, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(187, 435);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(12, 53);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 11;
            label3.Text = "Mes";
            // 
            // comboBoxMes
            // 
            comboBoxMes.FormattingEnabled = true;
            comboBoxMes.Items.AddRange(new object[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });
            comboBoxMes.Location = new Point(12, 71);
            comboBoxMes.Name = "comboBoxMes";
            comboBoxMes.Size = new Size(165, 23);
            comboBoxMes.TabIndex = 10;
            comboBoxMes.SelectedIndexChanged += comboBoxMes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 9;
            label1.Text = "Año";
            // 
            // textBoxAño
            // 
            textBoxAño.BorderStyle = BorderStyle.FixedSingle;
            textBoxAño.Location = new Point(12, 27);
            textBoxAño.Name = "textBoxAño";
            textBoxAño.Size = new Size(165, 23);
            textBoxAño.TabIndex = 8;
            textBoxAño.TextChanged += textBoxAño_TextChanged;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Dock = DockStyle.Bottom;
            buttonAgregar.Location = new Point(0, 194);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(187, 61);
            buttonAgregar.TabIndex = 7;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Dock = DockStyle.Bottom;
            buttonEliminar.Location = new Point(0, 255);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(187, 59);
            buttonEliminar.TabIndex = 6;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Dock = DockStyle.Bottom;
            buttonModificar.Location = new Point(0, 314);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(187, 60);
            buttonModificar.TabIndex = 5;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // textBoxValorCuota
            // 
            textBoxValorCuota.BorderStyle = BorderStyle.FixedSingle;
            textBoxValorCuota.Location = new Point(12, 125);
            textBoxValorCuota.Name = "textBoxValorCuota";
            textBoxValorCuota.Size = new Size(165, 23);
            textBoxValorCuota.TabIndex = 4;
            textBoxValorCuota.TextChanged += textBoxValorCuota_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 2;
            label2.Text = "Valor de la Cuota ";
            // 
            // dgvValorCuota
            // 
            dgvValorCuota.AllowUserToAddRows = false;
            dgvValorCuota.AllowUserToDeleteRows = false;
            dgvValorCuota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvValorCuota.Location = new Point(217, 53);
            dgvValorCuota.Name = "dgvValorCuota";
            dgvValorCuota.ReadOnly = true;
            dgvValorCuota.RowTemplate.Height = 25;
            dgvValorCuota.Size = new Size(693, 435);
            dgvValorCuota.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumVioletRed;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(930, 47);
            panel2.TabIndex = 3;
            // 
            // FormCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(930, 500);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(dgvValorCuota);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCuota";
            Text = "FormCuota";
            Load += FormCuota_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvValorCuota).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSalir;
        private Panel panel1;
        private DataGridView dgvValorCuota;
        private Button buttonModificar;
        private TextBox textBoxValorCuota;
        private Label label2;
        private Button buttonEliminar;
        private Label label1;
        private TextBox textBoxAño;
        private Button buttonAgregar;
        private Label label3;
        private ComboBox comboBoxMes;
        private Panel panel2;
    }
}