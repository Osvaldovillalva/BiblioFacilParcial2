namespace Vista
{
    partial class FormReglas
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
            label5 = new Label();
            textBoxPorcentajerecargo = new TextBox();
            textBoxDiasvenceCuota = new TextBox();
            label4 = new Label();
            textBoxDiasMulta = new TextBox();
            label3 = new Label();
            buttonModificar = new Button();
            buttonSalir = new Button();
            label2 = new Label();
            textBoxMaximoPrestamo = new TextBox();
            label1 = new Label();
            textBoxDiasPrestamo = new TextBox();
            dgvReglas = new DataGridView();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReglas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBoxPorcentajerecargo);
            panel1.Controls.Add(textBoxDiasvenceCuota);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxDiasMulta);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(buttonModificar);
            panel1.Controls.Add(buttonSalir);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxMaximoPrestamo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxDiasPrestamo);
            panel1.Location = new Point(10, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 442);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(34, 256);
            label5.Name = "label5";
            label5.Size = new Size(183, 15);
            label5.TabIndex = 10;
            label5.Text = "Porcentaje recargo cuota vencida";
            // 
            // textBoxPorcentajerecargo
            // 
            textBoxPorcentajerecargo.BorderStyle = BorderStyle.FixedSingle;
            textBoxPorcentajerecargo.Location = new Point(29, 274);
            textBoxPorcentajerecargo.Name = "textBoxPorcentajerecargo";
            textBoxPorcentajerecargo.Size = new Size(184, 23);
            textBoxPorcentajerecargo.TabIndex = 9;
            textBoxPorcentajerecargo.TextChanged += textBoxPorcentajerecargo_TextChanged;
            // 
            // textBoxDiasvenceCuota
            // 
            textBoxDiasvenceCuota.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiasvenceCuota.Location = new Point(34, 220);
            textBoxDiasvenceCuota.Name = "textBoxDiasvenceCuota";
            textBoxDiasvenceCuota.Size = new Size(184, 23);
            textBoxDiasvenceCuota.TabIndex = 8;
            textBoxDiasvenceCuota.TextChanged += textBoxDiasvenceCuota_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(34, 190);
            label4.Name = "label4";
            label4.Size = new Size(164, 15);
            label4.TabIndex = 7;
            label4.Text = "A cuantos Dias vence la cuota";
            // 
            // textBoxDiasMulta
            // 
            textBoxDiasMulta.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiasMulta.Location = new Point(29, 149);
            textBoxDiasMulta.Name = "textBoxDiasMulta";
            textBoxDiasMulta.Size = new Size(189, 23);
            textBoxDiasMulta.TabIndex = 6;
            textBoxDiasMulta.TextChanged += textBoxDiasMulta_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 116);
            label3.Name = "label3";
            label3.Size = new Size(142, 30);
            label3.TabIndex = 5;
            label3.Text = "Dias de multa \r\nsin poder prestar un  libro";
            label3.Click += label3_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(23, 303);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(194, 60);
            buttonModificar.TabIndex = 4;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.Dock = DockStyle.Bottom;
            buttonSalir.Location = new Point(0, 376);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(238, 66);
            buttonSalir.TabIndex = 3;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 64);
            label2.Name = "label2";
            label2.Size = new Size(197, 15);
            label2.TabIndex = 1;
            label2.Text = "Maxima Cantidad de libros a Prestar";
            // 
            // textBoxMaximoPrestamo
            // 
            textBoxMaximoPrestamo.BorderStyle = BorderStyle.FixedSingle;
            textBoxMaximoPrestamo.Location = new Point(29, 82);
            textBoxMaximoPrestamo.Name = "textBoxMaximoPrestamo";
            textBoxMaximoPrestamo.Size = new Size(191, 23);
            textBoxMaximoPrestamo.TabIndex = 2;
            textBoxMaximoPrestamo.TextChanged += textBoxMaximoPrestamo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 1;
            label1.Text = "Cantidad dias de prestamo";
            // 
            // textBoxDiasPrestamo
            // 
            textBoxDiasPrestamo.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiasPrestamo.Location = new Point(29, 27);
            textBoxDiasPrestamo.Name = "textBoxDiasPrestamo";
            textBoxDiasPrestamo.Size = new Size(191, 23);
            textBoxDiasPrestamo.TabIndex = 0;
            textBoxDiasPrestamo.TextChanged += textBoxDiasPrestamo_TextChanged;
            // 
            // dgvReglas
            // 
            dgvReglas.AllowUserToAddRows = false;
            dgvReglas.AllowUserToDeleteRows = false;
            dgvReglas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReglas.Location = new Point(254, 63);
            dgvReglas.Name = "dgvReglas";
            dgvReglas.ReadOnly = true;
            dgvReglas.RowTemplate.Height = 25;
            dgvReglas.Size = new Size(664, 425);
            dgvReglas.TabIndex = 1;
            dgvReglas.CellContentClick += dgvReglas_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumVioletRed;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(930, 50);
            panel2.TabIndex = 2;
            // 
            // FormReglas
            // 
            BackColor = Color.Black;
            ClientSize = new Size(930, 500);
            Controls.Add(panel2);
            Controls.Add(dgvReglas);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReglas";
            Text = "FormReglas";
            Load += FormReglas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReglas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox textBoxMaximoPrestamo;
        private Label label1;
        private TextBox textBoxDiasPrestamo;
        private Button buttonSalir;
        private DataGridView dgvReglas;
        private Button buttonModificar;
        private TextBox textBoxDiasMulta;
        private Label label3;
        private TextBox textBoxDiasvenceCuota;
        private Label label4;
        private TextBox textBoxPorcentajerecargo;
        private Label label5;
        private Panel panel2;
    }
}