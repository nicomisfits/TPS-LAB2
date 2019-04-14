using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculadora cal = new Calculadora();

        private static string numeroTxt1;
        private static string numeroTxt2;        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.lblResultado.Text = "";
        }        

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            numeroTxt1 = txtNumero1.Text;
        }       

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {
            numeroTxt2 = txtNumero2.Text;
        }        

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Numero numero1 = new Numero(numeroTxt1);
            Numero numero2 = new Numero(numeroTxt2);
            string operador = cal.ValidarOperador(this.cmbOperacion.SelectedItem.ToString());            
            double resultado = cal.Operar(numero1, numero2, operador);
            this.lblResultado.Text = resultado.ToString();            
        }

        private void btnToDec_Click(object sender, EventArgs e)
        {
            Numero numero = new Numero(this.lblResultado.Text);
            this.lblResultado.Text = numero.BinarioADecimal(this.lblResultado.Text);
        }

        private void btnToBin_Click(object sender, EventArgs e)
        {
            Numero numero = new Numero(this.lblResultado.Text);
            this.lblResultado.Text = numero.DecimalBinario(this.lblResultado.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
