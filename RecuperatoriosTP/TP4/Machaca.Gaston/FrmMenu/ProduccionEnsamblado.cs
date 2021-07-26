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
using MetodosExtension;
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

        Thread hiloMotorTanque;
        Thread hiloCañonTanque;
        Thread hiloArmaTanque;

        Thread hiloMotorAvion;
        Thread hiloCañonAvion;
        Thread hiloArmaAvion;

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

            MostrarFabrica.Visible = false;

            txtCapFabrica.Enabled = true;
            btnSubmitCapacidad.Enabled = true;

            if (hiloMotorTanque != null)
            {
                hiloMotorTanque.Abort();

                if (hiloCañonTanque != null)
                {
                    hiloCañonTanque.Abort();

                    if (hiloArmaTanque != null)
                    {
                        hiloArmaTanque.Abort();
                    }
                }
            }
            else
            {
                if (hiloCañonTanque != null)
                {
                    hiloCañonTanque.Abort();

                    if (hiloArmaTanque != null)
                    {
                        hiloArmaTanque.Abort();
                    }
                }
            }

            if (hiloMotorAvion != null)
            {
                hiloMotorAvion.Abort();

                if (hiloCañonAvion != null)
                {
                    hiloCañonAvion.Abort();

                    if (hiloArmaAvion != null)
                    {
                        hiloArmaAvion.Abort();
                    }
                }
            }
            else
            {
                if (hiloCañonAvion != null)
                {
                    hiloCañonAvion.Abort();

                    if (hiloArmaAvion != null)
                    {
                        hiloArmaAvion.Abort();
                    }
                }
            }
            btnConfirmar.Enabled = true;
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
                MessageBox.Show(ex.CantidadEmpleados(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                try
                {
                    SQL InsertarTanqueSQL = new SQL();
                    InsertarTanqueSQL.InsertarTanque(tanque);
                }
                catch(ExcepcionSqlConexion ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

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
                try
                {
                    SQL InsertarAvionSQL = new SQL();
                    InsertarAvionSQL.InsertarAvion(avion);
                }
                catch(ExcepcionSqlConexion ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

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

                tanque.Evento += ManejadorEvento;
                tanque.PasarInformacion(tanque);

                MostrarProduccionTanques();
                btnConfirmar.Enabled = false;

                if (cantidadMotoresTanques != 0 || cantidadCañonesTanques != 0 || cantidadArmasTanques != 0)
                {
                    SQL InsertarTanqueSQL = new SQL();
                    InsertarTanqueSQL.InsertarTanque(tanque);
                }

                if (cantidadMotoresAviones != 0 || cantidadCañonesAviones != 0 || cantidadArmasAviones != 0)
                {
                    SQL InsertarAvionSQL = new SQL();
                    InsertarAvionSQL.InsertarAvion(avion);
                }

            }
            catch (ExcepcionConfirmar ex)
            {
                MessageBox.Show(ex.ConfirmarEmpleados(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ExcepcionCompatibilidad ex)
            {
                MessageBox.Show(ex.MostrarCompatibilidad(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(ExcepcionSqlConexion ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /// <summary>
        /// Evento que se acciona al confirmar produccion y enlista la produccion de tanques.
        /// </summary>
        /// <param name="produccion"></param>
        protected void ManejadorEvento(string produccion)
        {
            StreamWriter mensaje = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Informe.log", true);

            mensaje.WriteLine("\nDia y hora: " + DateTime.Now + "\n"+ produccion);

            mensaje.Close();
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
        /// Inicia el hilo tanques-motor al cambiar la seleccion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MotorTanques_SelectedIndexChanged(object sender, EventArgs e)
        {
            motorTanqueActual = MotorTanques.Text;

            if (capacidadMax != 0)
            {
                if (this.MotorTanques.SelectedIndex >= 0)
                {


                    if (this.hiloMotorTanque != null)
                    {
                        this.hiloMotorTanque.Abort();
                    }

                    this.hiloMotorTanque = new Thread(AbrirFormMotoresTanques);
                    this.hiloMotorTanque.IsBackground = true;

                    if (hiloMotorTanque.IsAlive == false)
                    {
                        hiloMotorTanque.Start();
                    }
                }
            }
        }
        /// <summary>
        /// Inicia el hilo tanques-cañon al cambiar la seleccion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CañonTanques_SelectedIndexChanged(object sender, EventArgs e)
        {
            cañonTanqueActual = CañonTanques.Text;

            if (capacidadMax != 0)
            {
                if (this.CañonTanques.SelectedIndex >= 0)
                {

                    if (this.hiloCañonTanque != null)
                    {
                        this.hiloCañonTanque.Abort();
                    }

                    this.hiloCañonTanque = new Thread(AbrirFormCañonesTanques);
                    this.hiloCañonTanque.IsBackground = true;

                    if (hiloCañonTanque.IsAlive == false)
                    {
                        hiloCañonTanque.Start();
                    }
                }
            }
        }
        /// <summary>
        /// Inicia el hilo tanques-arma al cambiar la seleccion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArmaTanques_SelectedIndexChanged(object sender, EventArgs e)
        {
            armaTanqueActual = ArmaTanques.Text;

            if (capacidadMax != 0)
            {
                if (this.ArmaTanques.SelectedIndex >= 0)
                {

                    if (this.hiloArmaTanque != null)
                    {
                        this.hiloArmaTanque.Abort();
                    }

                    this.hiloArmaTanque = new Thread(AbrirFormArmasTanques);
                    this.hiloArmaTanque.IsBackground = true;

                    if (hiloArmaTanque.IsAlive == false)
                    {
                        hiloArmaTanque.Start();
                    }
                }
            }
        }



        #region Form Hilos Tanques
        public void AbrirFormMotoresTanques()
        {
            CantidadMateriales cantidad = new CantidadMateriales(motorTanqueActual);

            if (cantidad.ShowDialog() == DialogResult.OK)
            {
                this.hiloMotorTanque = null;

                cantidadMotoresTanques = cantidad.Cantidad;
            }
        }
        public void AbrirFormCañonesTanques()
        {
            CantidadMateriales cantidad = new CantidadMateriales(cañonTanqueActual);

            if (cantidad.ShowDialog() == DialogResult.OK)
            {
                this.hiloCañonTanque = null;

                cantidadCañonesTanques = cantidad.Cantidad;
            }
        }
        public void AbrirFormArmasTanques()
        {
            CantidadMateriales cantidad = new CantidadMateriales(armaTanqueActual);

            if (cantidad.ShowDialog() == DialogResult.OK)
            {
                this.hiloArmaTanque = null;

                cantidadArmasTanques = cantidad.Cantidad;
            }
        }



        #endregion

        #region Form Hilos Aviones

        public void AbrirFormMotoresAviones()
        {
            CantidadMateriales cantidad = new CantidadMateriales(motorAvionActual);

            if (cantidad.ShowDialog() == DialogResult.OK)
            {
                this.hiloMotorAvion = null;

                cantidadMotoresAviones = cantidad.Cantidad;
            }
        }
        public void AbrirFormCañonesAviones()
        {
            CantidadMateriales cantidad = new CantidadMateriales(cañonAvionActual);

            if (cantidad.ShowDialog() == DialogResult.OK)
            {
                this.hiloCañonAvion = null;

                cantidadCañonesAviones = cantidad.Cantidad;
            }
        }
        public void AbrirFormArmasAviones()
        {
            CantidadMateriales cantidad = new CantidadMateriales(armaAvionActual);

            if (cantidad.ShowDialog() == DialogResult.OK)
            {
                this.hiloArmaAvion = null;

                cantidadArmasAviones = cantidad.Cantidad;
            }
        }

        #endregion

        /// <summary>
        /// Inicia el hilo aviones-motor al cambiar la seleccion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MotorAvion_SelectedIndexChanged(object sender, EventArgs e)
        {
            motorAvionActual = MotorAvion.Text;

            if (capacidadMax != 0)
            {
                if (this.MotorAvion.SelectedIndex >= 0)
                {

                    if (this.hiloMotorAvion != null)
                    {
                        this.hiloMotorAvion.Abort();
                    }

                    this.hiloMotorAvion = new Thread(AbrirFormMotoresAviones);
                    this.hiloMotorAvion.IsBackground = true;

                    if (hiloMotorAvion.IsAlive == false)
                    {
                        hiloMotorAvion.Start();
                    }
                }
            }
        }

        /// <summary>
        /// Inicia el hilo aviones-cañon al cambiar la seleccion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CañonAvion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cañonAvionActual = CañonAvion.Text;

            if (capacidadMax != 0)
            {
                if (this.CañonAvion.SelectedIndex >= 0)
                {

                    if (this.hiloCañonAvion != null)
                    {
                        this.hiloCañonAvion.Abort();
                    }

                    this.hiloCañonAvion = new Thread(AbrirFormCañonesAviones);
                    this.hiloCañonAvion.IsBackground = true;

                    if (hiloCañonAvion.IsAlive == false)
                    {
                        hiloCañonAvion.Start();
                    }
                }
            }
        }

        /// <summary>
        /// Inicia el hilo aviones-arma al cambiar la seleccion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArmaAvion_SelectedIndexChanged(object sender, EventArgs e)
        {
            armaAvionActual = ArmaAvion.Text;

            if (capacidadMax != 0)
            {
                if (this.ArmaAvion.SelectedIndex >= 0)
                {

                    if (this.hiloArmaAvion != null)
                    {
                        this.hiloArmaAvion.Abort();
                    }

                    this.hiloArmaAvion = new Thread(AbrirFormArmasAviones);
                    this.hiloArmaAvion.IsBackground = true;

                    if (hiloArmaAvion.IsAlive == false)
                    {
                        hiloArmaAvion.Start();
                    }
                }
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
