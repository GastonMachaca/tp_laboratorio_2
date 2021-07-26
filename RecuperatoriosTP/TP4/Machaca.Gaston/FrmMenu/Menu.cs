using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMenu
{
    public partial class Menu : Form
    {
        private string ruta = "";

        public Menu()
        {
            InitializeComponent();
        }

        #region Reproductor

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog carga = new OpenFileDialog();

            if (carga.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            ruta = carga.FileName;
            Reproduciendo.Text = ruta;
            axWindowsMediaPlayer1.URL = ruta;
            Reproduciendo.Text = "Reproduciendo: " + axWindowsMediaPlayer1.Ctlcontrols.currentItem.name;
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.Visible = false;
            Reproduciendo.Text = "Esperando archivo...";
        }

        private void BtnRPausar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
        private void btnReproducir_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        #endregion

        #region Opciones Menu
        private void pararReanudarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MenuFondo.Enabled == true)
            {
                MenuFondo.Enabled = false;
            }
            else
            {
                MenuFondo.Enabled = true;
            }
        }

        private void mostrarOcultarVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(axWindowsMediaPlayer1.Visible == false)
            {
                axWindowsMediaPlayer1.Visible = true;
            }
            else
            {
                axWindowsMediaPlayer1.Visible = false;
            }
        }

        #endregion

        #region Eventos Menu

        private void MenuCerrar(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Seguro que quiere salir de la aplicacion?", "Salir",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)
            {
                e.Cancel = true; //Cancela el cerrado del formulario
            }
        }

        #endregion

        /// <summary>
        /// Evento si se acciona el boton cerrar del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Boton del menu para iniciar la produccion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void produccionYEmsambladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            ProduccionEnsamblado ensamblado = new ProduccionEnsamblado();

            ensamblado.ShowDialog();

            if (ensamblado.DialogResult == DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}
