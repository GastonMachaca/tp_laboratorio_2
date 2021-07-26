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
    public partial class FrmLlamador : Form
    {

        public Central centralTelefonica;
        public float numeroRandom;
        public float numeroRandomCosto;
        public string tipoDeLlamada;
        public Central ExponerCentralita 
        { 
            get => centralTelefonica; 
        }

        public FrmLlamador(Central central, string llamada)
        {
            InitializeComponent();

            // Carga

            tipoDeLlamada = llamada;

            switch (llamada)
            {
                case "Local":
                    cmbFranja.Enabled = false;
                    cmbFranja.Visible = false;
                    txtOrigen.Text = "011";
                    lblProvincia.Visible = false;
                    break;
                case "Provincial":
                    cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
                    break;
            }

            centralTelefonica = central;
        }

        private void Llamada_Closing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Seguro que quiere salir de la aplicacion?", "Salir",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)
            {
                e.Cancel = true; //Cancela el cerrado del formulario
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDestino.Clear();
            cmbFranja.SelectedIndex = -1;
        }

        private void txtDestino_MouseMove(object sender, MouseEventArgs e)
        {
            txtDestino.ReadOnly = true;
        }

        #region Eventos Botones-Panel
        private void PanelBtn1(object sender, EventArgs e)
        {
            IngresoTexto("1");
        }
        private void PanelBtn2(object sender, EventArgs e)
        {
            IngresoTexto("2");
        }
        private void PanelBtn3(object sender, EventArgs e)
        {
            IngresoTexto("3");
        }
        private void PanelBtn4(object sender, EventArgs e)
        {
            IngresoTexto("4");
        }

        private void PanelBtn5(object sender, EventArgs e)
        {
            IngresoTexto("5");
        }

        private void PanelBtn6(object sender, EventArgs e)
        {
            IngresoTexto("6");
        }

        private void PanelBtn7(object sender, EventArgs e)
        {
            IngresoTexto("7");
        }

        private void PanelBtn8(object sender, EventArgs e)
        {
            IngresoTexto("8");
        }

        private void PanelBtn9(object sender, EventArgs e)
        {
            IngresoTexto("9");
        }

        private void PanelBtn0(object sender, EventArgs e)
        {
            IngresoTexto("0");
        }

        #endregion

        private void IngresoTexto(string a)
        {
            if(txtDestino.Text.Length < 8)
            {
                txtDestino.Text += a;
            }
        }
        private void btnLlamar_Click(object sender, EventArgs e)
        {
            string costo;
            Provincial.Franja franjas;
            Random random = new Random();

            numeroRandom = random.Next(1, 50);
            numeroRandomCosto = (float)(0.5 + random.NextDouble() * (5.6 - 0.5));
          
            switch (tipoDeLlamada)
            {
                case "Local":                  
                    costo = numeroRandomCosto.ToString("#.##");

                    if(txtDestino.Text.Length == 8)
                    {
                        Local nuevaLlamadaLocal = new Local(txtOrigen.Text, numeroRandom, txtDestino.Text, float.Parse(costo));
                        centralTelefonica += nuevaLlamadaLocal;
                        MessageBox.Show("Se realizo una llamada local\n" + nuevaLlamadaLocal.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Se debe de ingresar un numero de 8 digitos.");
                    }
                    break;
                case "Provincial":

                    if(cmbFranja.SelectedValue == null)
                    {
                        MessageBox.Show("No se han completado los parametros requeridos.");
                    }
                    else
                    {
                        Enum.TryParse(cmbFranja.SelectedValue.ToString(), out franjas);

                        if (txtDestino.Text.Length == 8)
                        {
                            Provincial nuevaLlamadaProvincial = new Provincial(txtOrigen.Text, franjas, numeroRandom, txtDestino.Text);
                            centralTelefonica += nuevaLlamadaProvincial;
                            MessageBox.Show("Se realizo una llamada provincial\n" + nuevaLlamadaProvincial.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Se debe de ingresar un numero de 8 digitos.");
                        }
                    }
                    break;
            }         
        }

        private void cmbFranja_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (cmbFranja.SelectedIndex)
            {
                case -1:
                    txtOrigen.Text = "";
                    break;
                case 0:
                    txtOrigen.Text = "351";
                    break;
                case 1:
                    txtOrigen.Text = "261";
                    break;
                case 2:
                    txtOrigen.Text = "388";
                    break;
            }
        }

        private void txtOrigen_MouseMove(object sender, MouseEventArgs e)
        {
            txtOrigen.ReadOnly = true;
        }
    }
}