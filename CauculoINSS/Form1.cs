using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CauculoINSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncaucular_Click(object sender, EventArgs e)
        {
            double salario, salariototal, insscobrado;
            string porcentagem;

            salario = Convert.ToDouble(txtsalario.Text);

            if(salario <= 1556.94){
                salariototal = salario - (salario * 0.08);
                insscobrado = salario * 0.08;
                porcentagem = "8%" ;
                lblfinal.Text = salariototal.ToString();
                lblINSScobrado.Text = insscobrado.ToString();
                lblporcentagem.Text = porcentagem.ToString();
            }

            else if(salario >= 1556.95 && salario <= 2594.92)
            {
                salariototal = salario - (salario * 0.09) ;
                insscobrado = salario * 0.09;
                porcentagem = "9%";
                lblfinal.Text = salariototal.ToString();
                lblINSScobrado.Text = insscobrado.ToString();
                lblporcentagem.Text = porcentagem.ToString();
            }

            else if(salario >= 2594.93 && salario <= 5189.82)
            {
                salariototal = salario - (salario * 0.11);
                insscobrado = salario * 0.11;
                porcentagem = "11%";
                lblfinal.Text = salariototal.ToString();
                lblINSScobrado.Text = insscobrado.ToString();
                lblporcentagem.Text = porcentagem.ToString();
            }

            else
            {
                salariototal = salario - 570.88;
                insscobrado = 570.88;
                porcentagem = "Valor Fixo";
                lblfinal.Text = salariototal.ToString();
                lblINSScobrado.Text = insscobrado.ToString();
                lblporcentagem.Text = porcentagem.ToString();
            }
        }
    }
}
