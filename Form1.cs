using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace venda_de_carros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double verifiSize()
        {
            Console.WriteLine(comboBox1.Text);
            if (comboBox1.Text == "PEQUENO : R$ 15000,00")
            {
                return 15000.00;
            }
            else if (comboBox1.Text == "MÉDIO: R$ 30000,00")
            {
                return 30000.00;
            }
            else if (comboBox1.Text == "GRANDE: R$ 45000,00")
            {
                return 45000.00;
            }
            else
            {
                return 0.0;
            }
        }

        public double verifiEngine()
        {
            if (radioButton2.Checked == true)
            {
                return 1200.00;
            }
            else if(radioButton3.Checked == true)
            {
                return 1500.00;
            }
            return 0.0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (verifiSize() == 0.0)
            {
                MessageBox.Show("SELECIONE UM TAMANHO VÁLIDO", "ERRO AO COMPRAR O CARRO");
                return;
            }

            double total = 0.0;

            total += verifiSize();

            total += verifiEngine();

            Console.WriteLine(total);
        }
    }
}
