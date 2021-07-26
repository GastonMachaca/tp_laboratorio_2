
namespace FrmMenu
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnCargar = new System.Windows.Forms.Button();
            this.BtnRPausar = new System.Windows.Forms.Button();
            this.btnReproducir = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.Reproduciendo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fabricaMilitarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.produccionYEmsambladoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicacionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fabricaMilitarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fabricacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pararReanudarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarOcultarVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fabricaMilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.MenuFondo = new System.Windows.Forms.PictureBox();
            this.depositoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pararReanudarImagenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarOcultarVideoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Transparent;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCargar.Location = new System.Drawing.Point(605, 0);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(33, 26);
            this.btnCargar.TabIndex = 13;
            this.btnCargar.TabStop = false;
            this.btnCargar.Text = "⏏️ ";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // BtnRPausar
            // 
            this.BtnRPausar.BackColor = System.Drawing.Color.Transparent;
            this.BtnRPausar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRPausar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRPausar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnRPausar.Location = new System.Drawing.Point(665, 0);
            this.BtnRPausar.Name = "BtnRPausar";
            this.BtnRPausar.Size = new System.Drawing.Size(33, 26);
            this.BtnRPausar.TabIndex = 14;
            this.BtnRPausar.TabStop = false;
            this.BtnRPausar.Text = "⏸";
            this.BtnRPausar.UseVisualStyleBackColor = false;
            this.BtnRPausar.Click += new System.EventHandler(this.BtnRPausar_Click);
            // 
            // btnReproducir
            // 
            this.btnReproducir.BackColor = System.Drawing.Color.Transparent;
            this.btnReproducir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReproducir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReproducir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReproducir.Location = new System.Drawing.Point(697, 0);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(26, 25);
            this.btnReproducir.TabIndex = 17;
            this.btnReproducir.TabStop = false;
            this.btnReproducir.Text = "▶️";
            this.btnReproducir.UseVisualStyleBackColor = false;
            this.btnReproducir.Click += new System.EventHandler(this.btnReproducir_Click);
            // 
            // btnParar
            // 
            this.btnParar.BackColor = System.Drawing.Color.Transparent;
            this.btnParar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnParar.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnParar.Location = new System.Drawing.Point(635, 0);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(33, 26);
            this.btnParar.TabIndex = 18;
            this.btnParar.TabStop = false;
            this.btnParar.Text = "⏹";
            this.btnParar.UseVisualStyleBackColor = false;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // Reproduciendo
            // 
            this.Reproduciendo.BackColor = System.Drawing.Color.LightSlateGray;
            this.Reproduciendo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reproduciendo.ForeColor = System.Drawing.Color.White;
            this.Reproduciendo.Location = new System.Drawing.Point(226, 4);
            this.Reproduciendo.Name = "Reproduciendo";
            this.Reproduciendo.Size = new System.Drawing.Size(361, 19);
            this.Reproduciendo.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSlateGray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplicacionesToolStripMenuItem,
            this.opcionesToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(-1, 30);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(295, 25);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aplicacionesToolStripMenuItem
            // 
            this.aplicacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fabricaMilitarToolStripMenuItem2});
            this.aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            this.aplicacionesToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            // 
            // fabricaMilitarToolStripMenuItem2
            // 
            this.fabricaMilitarToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produccionYEmsambladoToolStripMenuItem});
            this.fabricaMilitarToolStripMenuItem2.Name = "fabricaMilitarToolStripMenuItem2";
            this.fabricaMilitarToolStripMenuItem2.Size = new System.Drawing.Size(159, 22);
            this.fabricaMilitarToolStripMenuItem2.Text = "Fabrica Militar";
            // 
            // produccionYEmsambladoToolStripMenuItem
            // 
            this.produccionYEmsambladoToolStripMenuItem.Name = "produccionYEmsambladoToolStripMenuItem";
            this.produccionYEmsambladoToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.produccionYEmsambladoToolStripMenuItem.Text = "Produccion y Emsamblado";
            this.produccionYEmsambladoToolStripMenuItem.Click += new System.EventHandler(this.produccionYEmsambladoToolStripMenuItem_Click);
            // 
            // aplicacionToolStripMenuItem1
            // 
            this.aplicacionToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.aplicacionToolStripMenuItem1.Name = "aplicacionToolStripMenuItem1";
            this.aplicacionToolStripMenuItem1.Size = new System.Drawing.Size(79, 21);
            this.aplicacionToolStripMenuItem1.Text = "Aplicacion";
            // 
            // fabricaMilitarToolStripMenuItem1
            // 
            this.fabricaMilitarToolStripMenuItem1.Name = "fabricaMilitarToolStripMenuItem1";
            this.fabricaMilitarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.fabricaMilitarToolStripMenuItem1.Text = "Fabrica Militar";
            // 
            // fabricacionToolStripMenuItem
            // 
            this.fabricacionToolStripMenuItem.Name = "fabricacionToolStripMenuItem";
            this.fabricacionToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.fabricacionToolStripMenuItem.Text = "Produccion y Ensamblado";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pararReanudarImagenToolStripMenuItem,
            this.mostrarOcultarVideoToolStripMenuItem});
            this.opcionesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // pararReanudarImagenToolStripMenuItem
            // 
            this.pararReanudarImagenToolStripMenuItem.Name = "pararReanudarImagenToolStripMenuItem";
            this.pararReanudarImagenToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.pararReanudarImagenToolStripMenuItem.Text = "Parar/Reanudar Imagen";
            this.pararReanudarImagenToolStripMenuItem.Click += new System.EventHandler(this.pararReanudarImagenToolStripMenuItem_Click);
            // 
            // mostrarOcultarVideoToolStripMenuItem
            // 
            this.mostrarOcultarVideoToolStripMenuItem.Name = "mostrarOcultarVideoToolStripMenuItem";
            this.mostrarOcultarVideoToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.mostrarOcultarVideoToolStripMenuItem.Text = "Mostrar/Ocultar Video";
            this.mostrarOcultarVideoToolStripMenuItem.Click += new System.EventHandler(this.mostrarOcultarVideoToolStripMenuItem_Click);
            // 
            // aplicacionToolStripMenuItem
            // 
            this.aplicacionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aplicacionToolStripMenuItem.Name = "aplicacionToolStripMenuItem";
            this.aplicacionToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.aplicacionToolStripMenuItem.Text = "Aplicacion";
            // 
            // fabricaMilitarToolStripMenuItem
            // 
            this.fabricaMilitarToolStripMenuItem.Name = "fabricaMilitarToolStripMenuItem";
            this.fabricaMilitarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fabricaMilitarToolStripMenuItem.Text = "Fabrica Militar";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(472, 64);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(432, 210);
            this.axWindowsMediaPlayer1.TabIndex = 21;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.btnReproducir);
            this.panel1.Controls.Add(this.btnParar);
            this.panel1.Controls.Add(this.BtnRPausar);
            this.panel1.Controls.Add(this.Reproduciendo);
            this.panel1.Controls.Add(this.btnCargar);
            this.panel1.Location = new System.Drawing.Point(167, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 26);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::FrmMenu.Properties.Resources.orange_yellow_background_hd_wallpaper_preview;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnclose);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 31);
            this.panel2.TabIndex = 23;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.Image = global::FrmMenu.Properties.Resources.cancel_96245;
            this.btnclose.Location = new System.Drawing.Point(877, 7);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(17, 17);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnclose.TabIndex = 24;
            this.btnclose.TabStop = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // MenuFondo
            // 
            this.MenuFondo.BackColor = System.Drawing.Color.Transparent;
            this.MenuFondo.Image = global::FrmMenu.Properties.Resources.ezgif_com_gif_maker__1_;
            this.MenuFondo.Location = new System.Drawing.Point(-1, 75);
            this.MenuFondo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.MenuFondo.Name = "MenuFondo";
            this.MenuFondo.Size = new System.Drawing.Size(905, 470);
            this.MenuFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuFondo.TabIndex = 2;
            this.MenuFondo.TabStop = false;
            // 
            // depositoToolStripMenuItem
            // 
            this.depositoToolStripMenuItem.Name = "depositoToolStripMenuItem";
            this.depositoToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.depositoToolStripMenuItem.Text = "Deposito";
            // 
            // opcionesToolStripMenuItem1
            // 
            this.opcionesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pararReanudarImagenToolStripMenuItem1,
            this.mostrarOcultarVideoToolStripMenuItem1});
            this.opcionesToolStripMenuItem1.Name = "opcionesToolStripMenuItem1";
            this.opcionesToolStripMenuItem1.Size = new System.Drawing.Size(75, 21);
            this.opcionesToolStripMenuItem1.Text = "Opciones";
            // 
            // pararReanudarImagenToolStripMenuItem1
            // 
            this.pararReanudarImagenToolStripMenuItem1.Name = "pararReanudarImagenToolStripMenuItem1";
            this.pararReanudarImagenToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.pararReanudarImagenToolStripMenuItem1.Text = "Parar/Reanudar Imagen";
            this.pararReanudarImagenToolStripMenuItem1.Click += new System.EventHandler(this.pararReanudarImagenToolStripMenuItem_Click);
            // 
            // mostrarOcultarVideoToolStripMenuItem1
            // 
            this.mostrarOcultarVideoToolStripMenuItem1.Name = "mostrarOcultarVideoToolStripMenuItem1";
            this.mostrarOcultarVideoToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.mostrarOcultarVideoToolStripMenuItem1.Text = "Mostrar/Ocultar Video";
            this.mostrarOcultarVideoToolStripMenuItem1.Click += new System.EventHandler(this.mostrarOcultarVideoToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(903, 569);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.MenuFondo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuCerrar);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MenuFondo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button BtnRPausar;
        private System.Windows.Forms.Button btnReproducir;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Label Reproduciendo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fabricaMilitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicacionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fabricaMilitarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pararReanudarImagenToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ToolStripMenuItem mostrarOcultarVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fabricacionToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnclose;
        private System.Windows.Forms.ToolStripMenuItem depositoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fabricaMilitarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem produccionYEmsambladoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pararReanudarImagenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mostrarOcultarVideoToolStripMenuItem1;
    }
}

