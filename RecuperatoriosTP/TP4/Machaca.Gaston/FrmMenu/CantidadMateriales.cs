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
    public partial class CantidadMateriales : Form
    {

        private int cantidad;

        public int Cantidad { get => this.cantidad ; }

        public CantidadMateriales(string Tipomotor)
        {
            InitializeComponent();

            this.materialActual.Text = Tipomotor;

            maskedTextBox1.Mask = "###";
        }

        private void CantidadMateriales_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cantidad = Convert.ToInt32(this.maskedTextBox1.Text);
                this.DialogResult = DialogResult.OK;           
            }
            catch (Exception)
            {
                maskedTextBox1.Focus();
                maskedTextBox1.Clear();
                MessageBox.Show("Se ha intentando ingresar un parametro invalido");
            }             
        }
    }
}
