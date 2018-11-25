using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_2
{
    public partial class Calculadora : Form
    {
        double value = 0;
        string operacao = "";
        bool operacao_pressionada = false;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            //teste Commit
            if ((result.Text == "0") || (operacao_pressionada))
                result.Clear();
            operacao_pressionada = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operacao_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operacao = b.Text;
            value = double.Parse (result.Text);
            operacao_pressionada = true;
            equacao.Text = value + " " + operacao;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            equacao.Text = "";
            switch (operacao)
            {
                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    break;

                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;

                case "*":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break;

                case "/":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;

                default:
                    break;
            }// Fim do switch   
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }
    }
}
