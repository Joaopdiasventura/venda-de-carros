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
            if (comboBox1.Text == "PEQUENO : R$ 15000,00")
            {
                Recipe.attributes.Add("CARRO PEQUENO : R$ 15000,00");
                return 15000.00;
            }
            else if (comboBox1.Text == "MÉDIO: R$ 30000,00")
            {
                Recipe.attributes.Add("CARRO MÉDIO : R$ 30000,00");
                return 30000.00;
            }
            else if (comboBox1.Text == "GRANDE: R$ 45000,00")
            {
                Recipe.attributes.Add("CARRO GRANDE : R$ 45000,00");
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
                Recipe.attributes.Add("MOTOR VERSÃO 1.4.2 : R$ 1200,00");
                return 1200.00;
            }
            else if(radioButton3.Checked == true)
            {
                Recipe.attributes.Add("MOTOR VERSÃO 1.5.0 : R$ 1500,00");
                return 1500.00;
            }
            Recipe.attributes.Add("MOTOR VERSÃO 1.0.0 : R$ 00,00");
            return 0.0;
        }
        public double verifiVersion()
        {
            if (radioButton5.Checked == true)
            {
                Recipe.attributes.Add("CARRO 4 PORTAS : R$ 500,00");
                return 500.00;
            }
            else if (radioButton6.Checked == true)
            {
                Recipe.attributes.Add("CARRO COM TETO SOLAR : R$ 950,00");
                return 950.00;
            }
            Recipe.attributes.Add("CARRO 2 PORTAS : R$ 00,00");
            return 0.0;
        }
        public double verifiColor()
        {
            if (radioButton8.Checked == true)
            {
                Recipe.attributes.Add("COR METÁLICA : R$ 200,00");
                return 200.00;
            }
            else if (radioButton7.Checked == true)
            {
                Recipe.attributes.Add("COR PEROLADA : R$ 500,00");
                return 500.00;
            }
            Recipe.attributes.Add("COR SÓLIDA : R$ 00,00");
            return 0.0;
        }
        public double verifiAccessories()
        {
            double total = 0.0;

            if (checkBox1.Checked == true)
            {
                total += 350.0;
                Recipe.attributes.Add("DVD PLAYER : R$ 350,00");
            }
            if (checkBox2.Checked == true)
            {
                total += 1000.0;
                Recipe.attributes.Add("TRIO ELÉTRICO : R$ 1000,00");
            }
            if (checkBox3.Checked == true)
            {
                total += 2000.0;
                Recipe.attributes.Add("DIREÇÃO HIDRÁULICA : R$ 2000,00");
            }
            if (checkBox4.Checked == true)
            {
                total += 500.0;
                Recipe.attributes.Add("AR CONDICIONADO : R$ 500,00");
            }
            if (checkBox5.Checked == true)
            {
                total += 400.0;
                Recipe.attributes.Add("BANCO DE COURO : R$ 400,00");
            }
            if (checkBox6.Checked == true)
            {
                total += 3000.0;
                Recipe.attributes.Add("BLINDAGEM : R$ 3000,00");
            }

            return total;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double size = verifiSize();
            if (size == 0.0)
            {
                MessageBox.Show("SELECIONE UM TAMANHO VÁLIDO", "ERRO AO COMPRAR O CARRO");
                return;
            }

            double total = 0.0;

            total += size;

            total += verifiEngine();

            total += verifiVersion();

            total += verifiColor();

            total += verifiAccessories();

            string value = $"R$ {total}";
            label3.Text = value;

            DETALHES.Items.Clear();

            foreach (string attribute in Recipe.attributes)
            {
                DETALHES.Items.Add(attribute);
                DETALHES.Items.Add("");
            }

            DETALHES.Items.Add($"TOTAL : {total}");
            Recipe.attributes.Clear();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            DETALHES.Items.Clear();
            Recipe.attributes.Clear();
        }
    }
}

class Recipe
{
    static public List<string> attributes = new List<string>();
}