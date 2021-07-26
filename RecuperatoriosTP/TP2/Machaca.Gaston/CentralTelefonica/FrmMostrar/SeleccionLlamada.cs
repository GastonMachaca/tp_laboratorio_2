using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMostrar
{
    public partial class SeleccionLlamada : Form
    {
        private string mensaje;
        public SeleccionLlamada()
        {
            InitializeComponent();
        }

        public int ConfirmarSeleccion()
        {
            int retorno;

            switch (this.mensaje)
            {
                case "Local":
                    retorno = 1;
                    break;
                case "Provincial":
                    retorno = 2;
                    break;
                default:
                    retorno = 0;
                    break;
            }
            return retorno;
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            mensaje = "Local";
            this.Close();
        }

        private void btnProvincial_Click(object sender, EventArgs e)
        {
            mensaje = "Provincial";
            this.Close();
        }
    }
}
