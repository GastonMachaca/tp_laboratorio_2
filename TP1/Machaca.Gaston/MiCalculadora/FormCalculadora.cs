using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {
    
        } 

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (cmbOperador.Text == "")
            {
                cmbOperador.Text = "+";
            }
            lblResultado.Text = Convert.ToString(Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {           
            Limpiar(); 
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            double num = 0;  

            if(lblResultado.Text == "" || lblResultado.Text == "Valor invalido")
            {
                lblResultado.Text = "0";
            }
            else
            {
                num = Convert.ToDouble(lblResultado.Text);
            }

            if(num <= 0)
            {
                lblResultado.Text = "Valor invalido";
            }
            else
            {
                this.lblResultado.Text = new Numero().Decimalbinario(Convert.ToDouble(this.lblResultado.Text));
            }

        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = new Numero().BinaroDecimal(this.lblResultado.Text);
        }

        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            this.cmbOperador.Text = null;
            txtNumero1.Focus();
            lblResultado.Text = "";   
        }
        
        private static double Operar(string numero1,string numero2,string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);          

            return Calculadora.Operar(num1, num2, operador); 
        }
    }
}
