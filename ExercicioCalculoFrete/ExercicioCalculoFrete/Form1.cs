using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioCalculoFrete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void CalcularFrete()
        {
            string nome = txtNome.Text;
            decimal valor = decimal.Parse(txtValor.Text);
            string estado = cbxUF.SelectedItem.ToString();
            decimal frete = 0;

            if (valor>1000)
            {
                valor += 0;
            }
            if (valor <= 1000)
            {
                if (estado=="SP")
                {
                    frete = 5;
                }
                if (estado == "RJ")
                {
                    frete = 10;
                }
                if (estado == "AM")
                {
                    frete = 20;

                }
                if (estado!="SP" && estado!="RJ" && estado!="AM")
                {
                    frete = 15;
                }
            }

            var valorTotal = valor + frete;
            lblValorCompra.Text = valor.ToString("C");
            lblFrete.Text = frete.ToString("C");
            lblTotal.Text = valorTotal.ToString("C");
            

        }
        void LimparFrete()
        {
            txtNome.Text = string.Empty;
            txtValor.Text = "";
            cbxUF.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularFrete();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFrete();
        }
    }
}
