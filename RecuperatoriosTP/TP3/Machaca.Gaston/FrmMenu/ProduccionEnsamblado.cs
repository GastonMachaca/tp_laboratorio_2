using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fabrica_Militar;
using Tanques;
using Aviones;
using Excepciones;
using System.Threading;
using System.Reflection;
using System.Text.RegularExpressions;
using System.IO;

namespace FrmMenu
{

    public partial class ProduccionEnsamblado : Form
    {
        public int capacidadMax = 0;

        public Fabrica<Tanque, Avion> fabrica;
        public Tanque tanque;
        public Avion avion;

        public int cantidadMotoresTanques;
        public int cantidadCañonesTanques;
        public int cantidadArmasTanques;

        public int cantidadMotoresAviones;
        public int cantidadCañonesAviones;
        public int cantidadArmasAviones;

        public string motorTanqueActual;
        public string cañonTanqueActual;
        public string armaTanqueActual;

        public string motorAvionActual;
        public string cañonAvionActual;
        public string armaAvionActual;

        /// <summary>
        /// Constructor del formulario de produccion.
        /// </summary>
        public ProduccionEnsamblado()
        {
            InitializeComponent();

            PanelTanques.Enabled = false;
            PanelAviones.Enabled = false;
            btnReiniciar.Enabled = false;
            btnConfirmar.Enabled = false;
            MostrarFabrica.Visible = false;

            cantidadTanquesMotores.Enabled = false;
            cantidadTanquesCañones.Enabled = false;
            cantidadTanquesArmas.Enabled = false;

            cantidadAvionesMotores.Enabled = false;
            cantidadAvionesCañones.Enabled = false;
            cantidadAvionesArmas.Enabled = false;


            cantidadTanquesMotores.Mask = "###";
            cantidadTanquesCañones.Mask = "###";
            cantidadTanquesArmas.Mask = "###";

            cantidadAvionesMotores.Mask = "###";
            cantidadAvionesCañones.Mask = "###";
            cantidadAvionesArmas.Mask = "###";

            string[] motoresT = Enum.GetNames(typeof(TipoMotor));
            string[] cañonesT = Enum.GetNames(typeof(TipoCañon));
            string[] ametralladorasT = Enum.GetNames(typeof(TipoAmetralladoras));

            string[] motoresA = Enum.GetNames(typeof(MotorRadial));
            string[] cañonesA = Enum.GetNames(typeof(Cañones));
            string[] ametralladorasA = Enum.GetNames(typeof(Ametralladoras));


            for (int i=0;i<3;i++)
            {
                MotorTanques.Items.Add(motoresT[i].Replace('_', ' '));
                CañonTanques.Items.Add(cañonesT[i].Replace('_', ' '));
                ArmaTanques.Items.Add(ametralladorasT[i].Replace('_', ' '));

                MotorAvion.Items.Add(motoresA[i].Replace('_', ' '));
                CañonAvion.Items.Add(cañonesA[i].Replace('_', ' '));
                ArmaAvion.Items.Add(ametralladorasA[i].Replace('_', ' '));
            }

           
            MotorTanques.SelectedIndex = -1;
            CañonTanques.SelectedIndex = -1;
            ArmaTanques.SelectedIndex = -1;
            MotorAvion.SelectedIndex = -1;
            CañonAvion.SelectedIndex = -1;
            ArmaAvion.SelectedIndex = -1;
        }

        /// <summary>
        /// Cierra el formulario y habilita el menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Evento al cerrar el formulario de manera forzada o con el boton cerrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProduccionEnsamblado_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Seguro que quiere salir?", "Salir",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)
            {
                e.Cancel = true; //Cancela el cerrado del formulario
            }
            else
            {
                btnReiniciar_Click(sender, e);
            }
        }

        /// <summary>
        /// Reinicia los datos del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtCapFabrica.Clear();
            capacidadMax = 0;
            MotorTanques.SelectedIndex = -1;
            CañonTanques.SelectedIndex = -1;
            ArmaTanques.SelectedIndex = -1;
            MotorAvion.SelectedIndex = -1;
            CañonAvion.SelectedIndex = -1;
            ArmaAvion.SelectedIndex = -1;

            PanelTanques.Enabled = false;
            PanelAviones.Enabled = false;
            btnReiniciar.Enabled = false;
            btnConfirmar.Enabled = false;

            cantidadTanquesMotores.Enabled = false;
            cantidadTanquesCañones.Enabled = false;
            cantidadTanquesArmas.Enabled = false;

            cantidadAvionesMotores.Enabled = false;
            cantidadAvionesCañones.Enabled = false;
            cantidadAvionesArmas.Enabled = false;

            cantidadTanquesMotores.Clear();
            cantidadTanquesCañones.Clear();
            cantidadTanquesArmas.Clear();

            cantidadAvionesMotores.Clear();
            cantidadAvionesCañones.Clear();
            cantidadAvionesArmas.Clear();

            MostrarFabrica.Visible = false;

            txtCapFabrica.Enabled = true;
            btnSubmitCapacidad.Enabled = true;
            btnConfirmar.Enabled = false;
        }

        /// <summary>
        /// Evento a cargo del boton confirmar y validar el ingreso de la capacidad de la fabrica.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmitCapacidad_Click(object sender, EventArgs e)
        {
            try
            {
                ConfirmarIngreso();
            }
            catch (ExcepcionCapacidad ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Metodo a cargo de validar al ingreso de la capacidad de la fabrica.
        /// </summary>
        private void ConfirmarIngreso()
        {
            bool confirma = false;

            confirma = int.TryParse(txtCapFabrica.Text, out capacidadMax);

            if (confirma && capacidadMax >= 100 && capacidadMax <= 200)
            {
                fabrica = new Fabrica<Tanque, Avion>(capacidadMax);

                PanelTanques.Enabled = true;

                PanelAviones.Enabled = true;

                btnReiniciar.Enabled = true;

                btnConfirmar.Enabled = true;

                cantidadTanquesMotores.Enabled = true;
                cantidadTanquesCañones.Enabled = true;
                cantidadTanquesArmas.Enabled = true;

                cantidadAvionesMotores.Enabled = true;
                cantidadAvionesCañones.Enabled = true;
                cantidadAvionesArmas.Enabled = true;

                txtCapFabrica.Enabled = false;

                btnSubmitCapacidad.Enabled = false;
            }
            else
            {
                if (txtCapFabrica.Text is string)
                {
                    txtCapFabrica.Clear();
                }

                throw new ExcepcionCapacidad();
            }

        }

        /// <summary>
        /// Muestra la produccion de tanques y aviones.
        /// </summary>
        private void MostrarProduccionTanques()
        {
            tanque.IdentificarTanque();

            if (cantidadMotoresTanques == 0 || cantidadCañonesTanques == 0 || cantidadArmasTanques == 0)
            {
                fabrica.ValidarIngresoTanques(tanque);

                MessageBox.Show("Se detectaron materiales insuficientes para la produccion de tanques... \n El comandante Davila envia suministros...");
            }
            else
            {
                MessageBox.Show("Materiales recibidos...");
            }

            fabrica.EmsambladoTanques(tanque);

            this.MostrarFabrica.Text = null;

            MostrarFabrica.Text += tanque;

            if (this.avion != null)
            {
                MostrarProduccionAviones();
            }

            MostrarFabrica.Text += fabrica.Mostrar();

            this.MostrarFabrica.SelectAll();

            this.MostrarFabrica.SelectionAlignment = HorizontalAlignment.Center;

            this.MostrarFabrica.DeselectAll();

            MostrarFabrica.Visible = true;
        }

        /// <summary>
        /// Muestra la produccion de aviones y validar materiales para aviones.
        /// </summary>
        private void MostrarProduccionAviones()
        {
            avion.IdentificarAvion();

            if (cantidadMotoresAviones == 0 || cantidadCañonesAviones == 0 || cantidadArmasAviones == 0)
            {
                fabrica.ValidarIngresoAviones(avion);

                MessageBox.Show("Se detectaron materiales insuficientes para la produccion de aviones... \n El comandante Davila envia suministros...");
            }
            else
            {
                MessageBox.Show("Materiales recibidos...");
            }

            fabrica.EmsambladoAviones(avion);

            MostrarFabrica.Text += avion;
        }

        /// <summary>
        /// Evento al presionar el boton confirmar e iniciar el proceso de produccion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            fabrica.AdministrarCapacidad();

            try
            {

                cantidadMotoresTanques = Convert.ToInt32(cantidadTanquesMotores.Text);
                cantidadCañonesTanques = Convert.ToInt32(cantidadTanquesCañones.Text);
                cantidadArmasTanques = Convert.ToInt32(cantidadTanquesArmas.Text);

                cantidadMotoresAviones = Convert.ToInt32(cantidadAvionesMotores.Text);
                cantidadCañonesAviones = Convert.ToInt32(cantidadAvionesCañones.Text);
                cantidadArmasAviones = Convert.ToInt32(cantidadAvionesArmas.Text);


                object cañonesAviones;
                object motoresAviones;
                object armasAviones;

                object cañonesTanques;
                object motoresTanques;
                object armasTanques;

                ConfirmarSeleccion();

                cañonesAviones = AuxiliarParametros(CañonAvion.SelectedItem);
                motoresAviones = AuxiliarParametros(MotorAvion.SelectedItem);
                armasAviones = AuxiliarParametros(ArmaAvion.SelectedItem);

                cañonesTanques = AuxiliarParametros(CañonTanques.SelectedItem);
                motoresTanques = AuxiliarParametros(MotorTanques.SelectedItem);
                armasTanques = AuxiliarParametros(ArmaTanques.SelectedItem);

                Enum.TryParse(cañonesAviones.ToString(), out Cañones cañonA);
                Enum.TryParse(motoresAviones.ToString(), out MotorRadial motorA);
                Enum.TryParse(armasAviones.ToString(), out Ametralladoras armaA);

                Enum.TryParse(cañonesTanques.ToString(), out TipoCañon cañonT);
                Enum.TryParse(motoresTanques.ToString(), out TipoMotor motorT);
                Enum.TryParse(armasTanques.ToString(), out TipoAmetralladoras armaT);

                avion = new Avion(cañonA, cantidadCañonesAviones, motorA, cantidadMotoresAviones, armaA, cantidadArmasAviones);

                tanque = new Tanque(cañonT, cantidadCañonesTanques, motorT, cantidadMotoresTanques, armaT, cantidadArmasTanques);

                tanque.IdentificarTanque();
                avion.IdentificarAvion();

                MostrarProduccionTanques();
                btnConfirmar.Enabled = false;

            }
            catch (ExcepcionConfirmar ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ExcepcionCompatibilidad ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Se ha intentando ingresar un parametro invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Metodo a cargo de identificar si se a ingresado los parametros requeridos.
        /// </summary>
        private void ConfirmarSeleccion()
        {
            if (this.CañonTanques.SelectedItem == null || this.MotorTanques.SelectedItem == null || this.ArmaTanques.SelectedItem == null || this.CañonAvion.SelectedItem == null || this.MotorAvion.SelectedItem == null || this.ArmaAvion.SelectedItem == null)
            {
                throw new ExcepcionConfirmar();
            }
        }

        /// <summary>
        /// Se encarga adaptar las opciones de motores,cañones y ametralladoras para su lectura.
        /// </summary>
        /// <param name="seleccion"></param>
        /// <returns>Cadena de caracteres corregida</returns>
        public object AuxiliarParametros(object seleccion)
        {
            StringBuilder mensaje = new StringBuilder(seleccion.ToString());

            for(int i=0;i< mensaje.Length;i++)
            {
                if(mensaje[i] == ' ')
                {
                    mensaje[i] = '_';
                }
            }

            return mensaje.ToString();
        }
    }
}
