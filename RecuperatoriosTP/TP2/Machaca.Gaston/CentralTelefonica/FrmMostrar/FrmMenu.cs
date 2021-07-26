using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelefoniaCelular;

namespace FrmMostrar
{
    public partial class FrmMenu : Form
    {
        public Central central;
        private string ruta = "";

        public FrmMenu()
        {
            InitializeComponent();

            central = new Central("Movistar");
        }
        
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
        }

        private void ReanudarPararImagen_Click(object sender, EventArgs e)
        {
            if(MenuFondo.Enabled == true)
            {
                MenuFondo.Enabled = false;
            }
            else
            {
                MenuFondo.Enabled = true;
            }
        }

        private void agregarLlamadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionLlamada llamada = new SeleccionLlamada();

            llamada.ShowDialog();

            switch(llamada.ConfirmarSeleccion())
            {
                case 0:
                    MessageBox.Show("No se selecciono ninguna opcion");
                    break;
                case 1:
                    FrmLlamador subMenuLocal = new FrmLlamador(central,"Local");
                    subMenuLocal.ShowDialog();
                    central = subMenuLocal.ExponerCentralita;
                    break;
                case 2:
                    FrmLlamador subMenuProvincial = new FrmLlamador(central,"Provincial");
                    subMenuProvincial.ShowDialog();
                    central = subMenuProvincial.ExponerCentralita;
                    break;
            }
        }

        private void Menu_Closing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Seguro que quiere salir de la aplicacion?", "Salir",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)
            {
                e.Cancel = true; //Cancela el cerrado del formulario
            }
        }

        private void facturacionTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!ReferenceEquals(central,null))
            {
                FrmMostrar mostrar = new FrmMostrar(central);

                mostrar.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay datos para mostrar la facturacion.");
            }
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
            axWindowsMediaPlayer1.Visible = true;
        }

        private void BtnRPausar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            axWindowsMediaPlayer1.Visible = false;
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.Visible = false;
            Reproduciendo.Text = "";
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.Visible = true;
        }

        #endregion
    }
}
