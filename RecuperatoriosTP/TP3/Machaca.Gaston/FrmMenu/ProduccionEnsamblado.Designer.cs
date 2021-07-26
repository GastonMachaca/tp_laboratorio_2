
namespace FrmMenu
{
    partial class ProduccionEnsamblado
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
            this.PanelCapacidad = new System.Windows.Forms.GroupBox();
            this.btnSubmitCapacidad = new System.Windows.Forms.Button();
            this.lblCapFabrica = new System.Windows.Forms.Label();
            this.txtCapFabrica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelAviones = new System.Windows.Forms.GroupBox();
            this.ArmaAvion = new System.Windows.Forms.ComboBox();
            this.CañonAvion = new System.Windows.Forms.ComboBox();
            this.MotorAvion = new System.Windows.Forms.ComboBox();
            this.PanelTanques = new System.Windows.Forms.GroupBox();
            this.ArmaTanques = new System.Windows.Forms.ComboBox();
            this.CañonTanques = new System.Windows.Forms.ComboBox();
            this.MotorTanques = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.MostrarFabrica = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cantidadTanquesMotores = new System.Windows.Forms.MaskedTextBox();
            this.cantidadTanquesCañones = new System.Windows.Forms.MaskedTextBox();
            this.cantidadTanquesArmas = new System.Windows.Forms.MaskedTextBox();
            this.cantidadAvionesMotores = new System.Windows.Forms.MaskedTextBox();
            this.cantidadAvionesCañones = new System.Windows.Forms.MaskedTextBox();
            this.cantidadAvionesArmas = new System.Windows.Forms.MaskedTextBox();
            this.PanelCapacidad.SuspendLayout();
            this.PanelAviones.SuspendLayout();
            this.PanelTanques.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelCapacidad
            // 
            this.PanelCapacidad.BackColor = System.Drawing.Color.Transparent;
            this.PanelCapacidad.Controls.Add(this.btnSubmitCapacidad);
            this.PanelCapacidad.Controls.Add(this.lblCapFabrica);
            this.PanelCapacidad.Controls.Add(this.txtCapFabrica);
            this.PanelCapacidad.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelCapacidad.ForeColor = System.Drawing.Color.White;
            this.PanelCapacidad.Location = new System.Drawing.Point(0, -1);
            this.PanelCapacidad.Name = "PanelCapacidad";
            this.PanelCapacidad.Size = new System.Drawing.Size(165, 130);
            this.PanelCapacidad.TabIndex = 13;
            this.PanelCapacidad.TabStop = false;
            this.PanelCapacidad.Text = "Capac. Fabrica";
            // 
            // btnSubmitCapacidad
            // 
            this.btnSubmitCapacidad.ForeColor = System.Drawing.Color.Black;
            this.btnSubmitCapacidad.Location = new System.Drawing.Point(36, 88);
            this.btnSubmitCapacidad.Name = "btnSubmitCapacidad";
            this.btnSubmitCapacidad.Size = new System.Drawing.Size(90, 32);
            this.btnSubmitCapacidad.TabIndex = 2;
            this.btnSubmitCapacidad.TabStop = false;
            this.btnSubmitCapacidad.Text = "ACEPTAR";
            this.btnSubmitCapacidad.UseVisualStyleBackColor = true;
            this.btnSubmitCapacidad.Click += new System.EventHandler(this.btnSubmitCapacidad_Click);
            // 
            // lblCapFabrica
            // 
            this.lblCapFabrica.AutoSize = true;
            this.lblCapFabrica.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapFabrica.Location = new System.Drawing.Point(22, 26);
            this.lblCapFabrica.Name = "lblCapFabrica";
            this.lblCapFabrica.Size = new System.Drawing.Size(114, 15);
            this.lblCapFabrica.TabIndex = 3;
            this.lblCapFabrica.Text = "Num. de empleados";
            // 
            // txtCapFabrica
            // 
            this.txtCapFabrica.Location = new System.Drawing.Point(31, 50);
            this.txtCapFabrica.Name = "txtCapFabrica";
            this.txtCapFabrica.Size = new System.Drawing.Size(100, 27);
            this.txtCapFabrica.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Motor Radial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cañon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ametralladora:";
            // 
            // PanelAviones
            // 
            this.PanelAviones.BackColor = System.Drawing.Color.Transparent;
            this.PanelAviones.Controls.Add(this.ArmaAvion);
            this.PanelAviones.Controls.Add(this.CañonAvion);
            this.PanelAviones.Controls.Add(this.MotorAvion);
            this.PanelAviones.Controls.Add(this.label3);
            this.PanelAviones.Controls.Add(this.label2);
            this.PanelAviones.Controls.Add(this.label1);
            this.PanelAviones.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelAviones.ForeColor = System.Drawing.Color.White;
            this.PanelAviones.Location = new System.Drawing.Point(0, 323);
            this.PanelAviones.Name = "PanelAviones";
            this.PanelAviones.Size = new System.Drawing.Size(165, 193);
            this.PanelAviones.TabIndex = 14;
            this.PanelAviones.TabStop = false;
            this.PanelAviones.Text = "Datos Aviones:";
            // 
            // ArmaAvion
            // 
            this.ArmaAvion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ArmaAvion.FormattingEnabled = true;
            this.ArmaAvion.Location = new System.Drawing.Point(10, 148);
            this.ArmaAvion.Name = "ArmaAvion";
            this.ArmaAvion.Size = new System.Drawing.Size(141, 28);
            this.ArmaAvion.TabIndex = 9;
            this.ArmaAvion.TabStop = false;
            // 
            // CañonAvion
            // 
            this.CañonAvion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CañonAvion.FormattingEnabled = true;
            this.CañonAvion.Location = new System.Drawing.Point(9, 93);
            this.CañonAvion.Name = "CañonAvion";
            this.CañonAvion.Size = new System.Drawing.Size(141, 28);
            this.CañonAvion.TabIndex = 8;
            this.CañonAvion.TabStop = false;
            // 
            // MotorAvion
            // 
            this.MotorAvion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MotorAvion.FormattingEnabled = true;
            this.MotorAvion.Location = new System.Drawing.Point(9, 42);
            this.MotorAvion.Name = "MotorAvion";
            this.MotorAvion.Size = new System.Drawing.Size(141, 28);
            this.MotorAvion.TabIndex = 7;
            this.MotorAvion.TabStop = false;
            // 
            // PanelTanques
            // 
            this.PanelTanques.BackColor = System.Drawing.Color.Transparent;
            this.PanelTanques.Controls.Add(this.ArmaTanques);
            this.PanelTanques.Controls.Add(this.CañonTanques);
            this.PanelTanques.Controls.Add(this.MotorTanques);
            this.PanelTanques.Controls.Add(this.label4);
            this.PanelTanques.Controls.Add(this.label9);
            this.PanelTanques.Controls.Add(this.label10);
            this.PanelTanques.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelTanques.ForeColor = System.Drawing.Color.White;
            this.PanelTanques.Location = new System.Drawing.Point(1, 128);
            this.PanelTanques.Name = "PanelTanques";
            this.PanelTanques.Size = new System.Drawing.Size(164, 195);
            this.PanelTanques.TabIndex = 15;
            this.PanelTanques.TabStop = false;
            this.PanelTanques.Text = "Datos Tanques:";
            // 
            // ArmaTanques
            // 
            this.ArmaTanques.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ArmaTanques.FormattingEnabled = true;
            this.ArmaTanques.Location = new System.Drawing.Point(9, 156);
            this.ArmaTanques.Name = "ArmaTanques";
            this.ArmaTanques.Size = new System.Drawing.Size(141, 28);
            this.ArmaTanques.TabIndex = 9;
            this.ArmaTanques.TabStop = false;
            // 
            // CañonTanques
            // 
            this.CañonTanques.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CañonTanques.FormattingEnabled = true;
            this.CañonTanques.Location = new System.Drawing.Point(9, 106);
            this.CañonTanques.Name = "CañonTanques";
            this.CañonTanques.Size = new System.Drawing.Size(141, 28);
            this.CañonTanques.TabIndex = 8;
            this.CañonTanques.TabStop = false;
            // 
            // MotorTanques
            // 
            this.MotorTanques.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MotorTanques.FormattingEnabled = true;
            this.MotorTanques.Location = new System.Drawing.Point(9, 55);
            this.MotorTanques.Name = "MotorTanques";
            this.MotorTanques.Size = new System.Drawing.Size(141, 28);
            this.MotorTanques.TabIndex = 7;
            this.MotorTanques.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ametralladora:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Cañon:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Motor:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Black;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(561, 471);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(85, 30);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.Black;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.Location = new System.Drawing.Point(652, 471);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(85, 30);
            this.btnReiniciar.TabIndex = 4;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(743, 471);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 30);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MostrarFabrica
            // 
            this.MostrarFabrica.BackColor = System.Drawing.Color.Black;
            this.MostrarFabrica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MostrarFabrica.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarFabrica.ForeColor = System.Drawing.Color.White;
            this.MostrarFabrica.Location = new System.Drawing.Point(561, 128);
            this.MostrarFabrica.Name = "MostrarFabrica";
            this.MostrarFabrica.ReadOnly = true;
            this.MostrarFabrica.Size = new System.Drawing.Size(267, 316);
            this.MostrarFabrica.TabIndex = 17;
            this.MostrarFabrica.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrmMenu.Properties.Resources.ezgif_com_gif_maker__6_;
            this.pictureBox1.Location = new System.Drawing.Point(181, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(656, 492);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(181, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad de Materiales";
            // 
            // cantidadTanquesMotores
            // 
            this.cantidadTanquesMotores.Location = new System.Drawing.Point(184, 188);
            this.cantidadTanquesMotores.Name = "cantidadTanquesMotores";
            this.cantidadTanquesMotores.Size = new System.Drawing.Size(118, 20);
            this.cantidadTanquesMotores.TabIndex = 18;
            // 
            // cantidadTanquesCañones
            // 
            this.cantidadTanquesCañones.Location = new System.Drawing.Point(184, 239);
            this.cantidadTanquesCañones.Name = "cantidadTanquesCañones";
            this.cantidadTanquesCañones.Size = new System.Drawing.Size(118, 20);
            this.cantidadTanquesCañones.TabIndex = 19;
            // 
            // cantidadTanquesArmas
            // 
            this.cantidadTanquesArmas.Location = new System.Drawing.Point(184, 289);
            this.cantidadTanquesArmas.Name = "cantidadTanquesArmas";
            this.cantidadTanquesArmas.Size = new System.Drawing.Size(118, 20);
            this.cantidadTanquesArmas.TabIndex = 20;
            // 
            // cantidadAvionesMotores
            // 
            this.cantidadAvionesMotores.Location = new System.Drawing.Point(184, 370);
            this.cantidadAvionesMotores.Name = "cantidadAvionesMotores";
            this.cantidadAvionesMotores.Size = new System.Drawing.Size(118, 20);
            this.cantidadAvionesMotores.TabIndex = 21;
            // 
            // cantidadAvionesCañones
            // 
            this.cantidadAvionesCañones.Location = new System.Drawing.Point(184, 421);
            this.cantidadAvionesCañones.Name = "cantidadAvionesCañones";
            this.cantidadAvionesCañones.Size = new System.Drawing.Size(118, 20);
            this.cantidadAvionesCañones.TabIndex = 22;
            // 
            // cantidadAvionesArmas
            // 
            this.cantidadAvionesArmas.Location = new System.Drawing.Point(184, 476);
            this.cantidadAvionesArmas.Name = "cantidadAvionesArmas";
            this.cantidadAvionesArmas.Size = new System.Drawing.Size(118, 20);
            this.cantidadAvionesArmas.TabIndex = 23;
            // 
            // ProduccionEnsamblado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(849, 516);
            this.Controls.Add(this.cantidadAvionesArmas);
            this.Controls.Add(this.cantidadAvionesCañones);
            this.Controls.Add(this.cantidadAvionesMotores);
            this.Controls.Add(this.cantidadTanquesArmas);
            this.Controls.Add(this.cantidadTanquesCañones);
            this.Controls.Add(this.cantidadTanquesMotores);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MostrarFabrica);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.PanelTanques);
            this.Controls.Add(this.PanelAviones);
            this.Controls.Add(this.PanelCapacidad);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProduccionEnsamblado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProduccionEnsamblado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProduccionEnsamblado_FormClosing);
            this.PanelCapacidad.ResumeLayout(false);
            this.PanelCapacidad.PerformLayout();
            this.PanelAviones.ResumeLayout(false);
            this.PanelAviones.PerformLayout();
            this.PanelTanques.ResumeLayout(false);
            this.PanelTanques.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox PanelCapacidad;
        private System.Windows.Forms.Button btnSubmitCapacidad;
        private System.Windows.Forms.Label lblCapFabrica;
        private System.Windows.Forms.TextBox txtCapFabrica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox PanelAviones;
        private System.Windows.Forms.ComboBox CañonAvion;
        private System.Windows.Forms.ComboBox MotorAvion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ArmaAvion;
        private System.Windows.Forms.GroupBox PanelTanques;
        private System.Windows.Forms.ComboBox ArmaTanques;
        private System.Windows.Forms.ComboBox CañonTanques;
        private System.Windows.Forms.ComboBox MotorTanques;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RichTextBox MostrarFabrica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox cantidadTanquesMotores;
        private System.Windows.Forms.MaskedTextBox cantidadTanquesCañones;
        private System.Windows.Forms.MaskedTextBox cantidadTanquesArmas;
        private System.Windows.Forms.MaskedTextBox cantidadAvionesMotores;
        private System.Windows.Forms.MaskedTextBox cantidadAvionesCañones;
        private System.Windows.Forms.MaskedTextBox cantidadAvionesArmas;
    }
}