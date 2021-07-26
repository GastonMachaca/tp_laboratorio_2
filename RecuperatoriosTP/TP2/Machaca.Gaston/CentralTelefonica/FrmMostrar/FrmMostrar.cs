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
    public partial class FrmMostrar : Form
    {

        public Central centralTelefonica;

        public FrmMostrar(Central central)
        {
            InitializeComponent();
            centralTelefonica = central;
            richTextBox1.ReadOnly = true;
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            if (centralTelefonica.Llamadas.Count == 0)
            {
                richTextBox1.Text = "No hay datos para mostrar...";
            }
            else
            {
                richTextBox1.Text = centralTelefonica.ToString();
            }

            richTextBox1.SelectAll();

            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

            richTextBox1.DeselectAll();
        }    
    }
}
