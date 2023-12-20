﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcualdora
{
    public partial class Operação : Form
    {
        decimal ValorDigitado1 = 0; decimal ValorDigitado2 = 0;
        string operacao = "";
        public object txtResultado { get; private set; }

        public Operação()
        {
            InitializeComponent();
        }

        private void Operação_Load(object sender, EventArgs e)
        {

        }

        private void Botão0_Click(object sender, EventArgs e)
        {
            VisorDaCalculadora.Text = VisorDaCalculadora.Text + "0";
        }

        private void VisorDaCalculadora_TextChanged(object sender, EventArgs e)
        {

        }

        private void Botão1_Click(object sender, EventArgs e)
        {
          
                VisorDaCalculadora.Text = VisorDaCalculadora.Text + "1";
            

        }

        private void Botão2_Click(object sender, EventArgs e)
        {
            VisorDaCalculadora.Text = VisorDaCalculadora.Text + "2";
        }

        private void Botão3_Click(object sender, EventArgs e)
        {
            VisorDaCalculadora.Text = VisorDaCalculadora.Text + "3";
        }

        private void Botão4_Click(object sender, EventArgs e)
        {
            VisorDaCalculadora.Text = VisorDaCalculadora.Text + "4";
        }

        private void Botão5_Click(object sender, EventArgs e)
        {
            VisorDaCalculadora.Text = VisorDaCalculadora.Text + "5";
        }

        private void Botão6_Click(object sender, EventArgs e)
        {
            VisorDaCalculadora.Text +=  "6";
        }

        private void Botão7_Click(object sender, EventArgs e)
        {
            VisorDaCalculadora.Text += "7";
        }

        private void Botão8_Click(object sender, EventArgs e)
        {
            VisorDaCalculadora.Text +=  "8";
        }

        private void Botão99_Click(object sender, EventArgs e)
        {
            VisorDaCalculadora.Text +=  "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            VisorDaCalculadora.Text += ".";
        }

        private void BotãoMais_Click(object sender, EventArgs e)
        {
            if (VisorDaCalculadora.Text != "")
            {
                ValorDigitado1 = decimal.Parse(VisorDaCalculadora.Text, CultureInfo.InvariantCulture);
                VisorDaCalculadora.Text = "";
                operacao = "Soma";
                Operaçãoas.Text = "+";

            }
            
        }

        private void BotãoIgual_Click(object sender, EventArgs e)
        {
            
            if (VisorDaCalculadora.Text != "")
            {
                ValorDigitado2 = decimal.Parse(VisorDaCalculadora.Text, CultureInfo.InvariantCulture);
                switch (operacao)
                {
                    case "Soma":
                        VisorDaCalculadora.Text = Convert.ToString(ValorDigitado1 + ValorDigitado2);
                        break;
                    case "Subtração":
                        VisorDaCalculadora.Text = Convert.ToString(ValorDigitado1 - ValorDigitado2);
                        break;
                    case "Multi":
                        VisorDaCalculadora.Text = Convert.ToString(ValorDigitado1 * ValorDigitado2);
                        break;
                    case "Divisão":
                        VisorDaCalculadora.Text = Convert.ToString(ValorDigitado1 / ValorDigitado2);
                        break;

                }
            }
            

            
        }

        private void BotãoMenos_Click(object sender, EventArgs e)
        {
            if (VisorDaCalculadora.Text != "")

            {
                ValorDigitado1 = decimal.Parse(VisorDaCalculadora.Text, CultureInfo.InvariantCulture);
                VisorDaCalculadora.Text = "";
                operacao = "Subtração";
                Operaçãoas.Text = "-";

            }
        }

        private void BotãoMultiplicação_Click(object sender, EventArgs e)
        {
            if (VisorDaCalculadora.Text != "")
            {
                ValorDigitado1 = decimal.Parse(VisorDaCalculadora.Text, CultureInfo.InvariantCulture);
                VisorDaCalculadora.Text = "";
                operacao = "Multi";
                Operaçãoas.Text = "X";
            }
            
        }

        private void BotãoDivisão_Click(object sender, EventArgs e)
        {
            if (VisorDaCalculadora.Text != "")
            {
                ValorDigitado1 = decimal.Parse(VisorDaCalculadora.Text, CultureInfo.InvariantCulture);
                VisorDaCalculadora.Text = "";
                operacao = "Divisão";
                Operaçãoas.Text = "/";
            }
            
        }

        private void BotãoCE_Click(object sender, EventArgs e)
        {
            VisorDaCalculadora.Text = "";
        }

        private void BotãoC_Click(object sender, EventArgs e)
        {
            VisorDaCalculadora.Text = "";
            ValorDigitado1 = 0;
            ValorDigitado2 = 0;
            Operaçãoas.Text ="";
        }
    }
}
