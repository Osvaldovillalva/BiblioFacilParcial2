using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    partial class FormLogin : Form
    {
        private Label label1;
        private Label label2;
        private TextBox textBoxUsuario;
        private TextBox textBoxContraseña;
        private Button buttonIngresar;
        private Button buttonCancelar;

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
            label1 = new Label();
            label2 = new Label();
            textBoxUsuario = new TextBox();
            textBoxContraseña = new TextBox();
            buttonIngresar = new Button();
            buttonCancelar = new Button();
            buttonSalir = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 126);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsuario.Location = new Point(138, 78);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(261, 23);
            textBoxUsuario.TabIndex = 2;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.BorderStyle = BorderStyle.FixedSingle;
            textBoxContraseña.Location = new Point(139, 135);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.PasswordChar = '*';
            textBoxContraseña.Size = new Size(260, 23);
            textBoxContraseña.TabIndex = 3;
            // 
            // buttonIngresar
            // 
            buttonIngresar.BackColor = Color.Black;
            buttonIngresar.FlatAppearance.BorderColor = Color.Red;
            buttonIngresar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonIngresar.ForeColor = Color.White;
            buttonIngresar.Location = new Point(222, 223);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(177, 55);
            buttonIngresar.TabIndex = 4;
            buttonIngresar.Text = "Ingresar";
            buttonIngresar.UseVisualStyleBackColor = false;
            buttonIngresar.Click += buttonIngresar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.Black;
            buttonCancelar.FlatAppearance.BorderColor = Color.MediumVioletRed;
            buttonCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.ForeColor = SystemColors.ButtonFace;
            buttonCancelar.Location = new Point(12, 223);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(172, 55);
            buttonCancelar.TabIndex = 5;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.Black;
            buttonSalir.FlatAppearance.BorderColor = Color.White;
            buttonSalir.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSalir.ForeColor = SystemColors.ButtonFace;
            buttonSalir.Location = new Point(12, 329);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(387, 55);
            buttonSalir.TabIndex = 6;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumVioletRed;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 46);
            panel1.TabIndex = 7;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(792, 433);
            Controls.Add(panel1);
            Controls.Add(buttonSalir);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonIngresar);
            Controls.Add(textBoxContraseña);
            Controls.Add(textBoxUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            Text = "Login";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSalir;
        private Panel panel1;
    }
}
