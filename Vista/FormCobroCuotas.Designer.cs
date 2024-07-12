namespace Vista
{
    partial class FormCobroCuotas
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
            label1 = new Label();
            textBoxDatosSocio = new TextBox();
            dgvSocios = new DataGridView();
            dgvCuotasMensuales = new DataGridView();
            listBoxCarritoCuotas = new ListBox();
            buttonGenerarPago = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuotasMensuales).BeginInit();
            SuspendLayout();
            // 
            // buttonSalir
            // 
            buttonSalir.FlatStyle = FlatStyle.Popup;
            buttonSalir.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSalir.ForeColor = SystemColors.ButtonFace;
            buttonSalir.Location = new Point(577, 448);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(350, 50);
            buttonSalir.TabIndex = 0;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 1;
            label1.Text = "Datos del Socio";
            // 
            // textBoxDatosSocio
            // 
            textBoxDatosSocio.BorderStyle = BorderStyle.FixedSingle;
            textBoxDatosSocio.Location = new Point(12, 71);
            textBoxDatosSocio.Name = "textBoxDatosSocio";
            textBoxDatosSocio.Size = new Size(527, 23);
            textBoxDatosSocio.TabIndex = 2;
            textBoxDatosSocio.TextChanged += textBoxDatosSocio_TextChanged;
            // 
            // dgvSocios
            // 
            dgvSocios.AllowUserToAddRows = false;
            dgvSocios.AllowUserToDeleteRows = false;
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Location = new Point(12, 100);
            dgvSocios.Name = "dgvSocios";
            dgvSocios.ReadOnly = true;
            dgvSocios.RowTemplate.Height = 25;
            dgvSocios.Size = new Size(906, 110);
            dgvSocios.TabIndex = 3;
            // 
            // dgvCuotasMensuales
            // 
            dgvCuotasMensuales.AllowUserToAddRows = false;
            dgvCuotasMensuales.AllowUserToDeleteRows = false;
            dgvCuotasMensuales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuotasMensuales.Location = new Point(12, 228);
            dgvCuotasMensuales.Name = "dgvCuotasMensuales";
            dgvCuotasMensuales.ReadOnly = true;
            dgvCuotasMensuales.RowTemplate.Height = 25;
            dgvCuotasMensuales.Size = new Size(906, 127);
            dgvCuotasMensuales.TabIndex = 4;
            // 
            // listBoxCarritoCuotas
            // 
            listBoxCarritoCuotas.FormattingEnabled = true;
            listBoxCarritoCuotas.ItemHeight = 15;
            listBoxCarritoCuotas.Location = new Point(12, 379);
            listBoxCarritoCuotas.Name = "listBoxCarritoCuotas";
            listBoxCarritoCuotas.Size = new Size(547, 109);
            listBoxCarritoCuotas.TabIndex = 5;
            // 
            // buttonGenerarPago
            // 
            buttonGenerarPago.FlatAppearance.BorderSize = 0;
            buttonGenerarPago.FlatStyle = FlatStyle.Popup;
            buttonGenerarPago.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGenerarPago.ForeColor = SystemColors.ButtonFace;
            buttonGenerarPago.Location = new Point(577, 379);
            buttonGenerarPago.Name = "buttonGenerarPago";
            buttonGenerarPago.Size = new Size(170, 50);
            buttonGenerarPago.TabIndex = 6;
            buttonGenerarPago.Text = "Generar Pago";
            buttonGenerarPago.UseVisualStyleBackColor = true;
            buttonGenerarPago.Click += buttonGenerarPago_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumVioletRed;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 40);
            panel1.TabIndex = 7;
            // 
            // FormCobroCuotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(930, 500);
            Controls.Add(panel1);
            Controls.Add(buttonGenerarPago);
            Controls.Add(listBoxCarritoCuotas);
            Controls.Add(dgvCuotasMensuales);
            Controls.Add(dgvSocios);
            Controls.Add(textBoxDatosSocio);
            Controls.Add(label1);
            Controls.Add(buttonSalir);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCobroCuotas";
            Text = "FormCobroCuotas";
            Load += FormCobroCuotas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuotasMensuales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSalir;
        private Label label1;
        private TextBox textBoxDatosSocio;
        private DataGridView dgvSocios;
        private DataGridView dgvCuotasMensuales;
        private ListBox listBoxCarritoCuotas;
        private Button buttonGenerarPago;
        private Panel panel1;
    }
}