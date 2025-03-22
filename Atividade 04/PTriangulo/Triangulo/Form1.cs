using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo
{

    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtA.Text = string.Empty;
            txtB.Text = string.Empty;
            txtC.Text = string.Empty;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(txtA.Text);
            double B = Convert.ToDouble(txtB.Text);
            double C = Convert.ToDouble(txtC.Text);

            if (A + B > C && A + C > B && B + C > A)
            { 
                if (A == B && A == C)
                {
                    MessageBox.Show("Equilátero");
                }
                else if (A == B || B == C)
                {
                    MessageBox.Show("Isóceles");
                }
                else
                {
                    MessageBox.Show("Escaleno");
                }
            }
            else
                MessageBox.Show("Não é triângulo");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtA_Validated(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(txtA.Text);
            if (A == 0 || A < 0)
                MessageBox.Show("Valor inválido");
        }

        private void txtB_Validated(object sender, EventArgs e)
        {
            double B = Convert.ToDouble(txtB.Text);
            if (B == 0 || B < 0)
                MessageBox.Show("Valor inválido");
        }

        private void txtC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtC_Validated(object sender, EventArgs e)
        {
            double C = Convert.ToDouble(txtC.Text);
            if (C == 0 || C < 0)
                MessageBox.Show("Valor inválido");
        }
    }
}
