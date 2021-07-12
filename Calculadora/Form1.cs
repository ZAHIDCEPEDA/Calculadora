using Calculadora.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        Suma sum = new Suma();
        Resta res = new Resta();
        Multiplicacion mul = new Multiplicacion();
        Division div = new Division();
        string primero=string.Empty;
        string total=string.Empty;
        public Form1()
        {
            InitializeComponent();
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            txtcalculadora.Text = txtcalculadora.Text + "0";
            primero = primero + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtcalculadora.Text = txtcalculadora.Text + "1";
            primero = primero + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtcalculadora.Text = txtcalculadora.Text + "2";
            primero = primero + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtcalculadora.Text = txtcalculadora.Text + "3";
            primero = primero + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtcalculadora.Text = txtcalculadora.Text + "4";
            primero = primero + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtcalculadora.Text = txtcalculadora.Text + "5";
            primero = primero + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtcalculadora.Text = txtcalculadora.Text + "6";
            primero = primero + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtcalculadora.Text = txtcalculadora.Text + "7";
            primero = primero + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtcalculadora.Text = txtcalculadora.Text + "8";
            primero = primero + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtcalculadora.Text = txtcalculadora.Text + "9";
            primero = primero + "9";
        }

        private void btncoma_Click(object sender, EventArgs e)
        {
            txtcalculadora.Text = txtcalculadora.Text + ",";
            primero = primero + ",";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblseguir.Text = "";
        }

        private void btnmas_Click(object sender, EventArgs e)
        {
            Suma sum = new Suma();
            primero = primero + "+";
            string[] numeros = primero.Split('+');
            txtcalculadora.Text = sum.Sumar(numeros).ToString(); 
            total = "+";
            txtcalculadora.Clear();
            lblseguir.Text = primero;
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            
            Resta res = new Resta();
            primero = primero + "-";
            string[] numeros1 = primero.Split('-');
            txtcalculadora.Text = res.Restar(numeros1).ToString();
            total = "-";
            txtcalculadora.Clear();
            lblseguir.Text = primero;
        }

        private void btnpor_Click(object sender, EventArgs e)
        {
            Multiplicacion mul = new Multiplicacion();
            primero = primero + "x";
            string[] numeros2 = primero.Split('x');
            txtcalculadora.Text = mul.Multiplicar(numeros2).ToString();
            total = "x";
            txtcalculadora.Clear();
            lblseguir.Text = primero;
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            Division div = new Division();
            primero = primero + "÷";
            string[] numeros3 = primero.Split('÷');
            txtcalculadora.Text = div.Dividir(numeros3).ToString();
            total = "÷";
            txtcalculadora.Clear();
            lblseguir.Text = primero;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (txtcalculadora.Text.Length > 1)
            {
            txtcalculadora.Text = txtcalculadora.Text.Remove(txtcalculadora.Text.Length - 1);
            }
            else
            {
                txtcalculadora.Text="";
            }   
        }

        private void btnporcentaje_Click(object sender, EventArgs e)
        {
            decimal primero = Convert.ToDecimal(txtcalculadora.Text);
            primero=primero* Convert.ToDecimal(total) / 100;
            txtcalculadora.Text = primero.ToString();
        }

        private void btnreiniciar2_Click(object sender, EventArgs e)
        {
            txtcalculadora.Text = "";
            lblseguir.Text = "";
        }

        private void btnreiniciar_Click(object sender, EventArgs e)
        {
            primero = string.Empty;
            txtcalculadora.Text = "";
        }

        private void btndivisionentre1_Click(object sender, EventArgs e)
        {
            decimal primero = Convert.ToDecimal(txtcalculadora.Text);
            primero = ( 1 / primero);
            txtcalculadora.Text = primero.ToString();
            lblseguir.Text = Convert.ToString(primero);
        }

        private void btncuadrado_Click(object sender, EventArgs e)
        {
            decimal primero = Convert.ToDecimal(txtcalculadora.Text);
            primero = (primero * primero);
            txtcalculadora.Text = primero.ToString();
            lblseguir.Text = Convert.ToString(primero);
        }

        private void btnraiz_Click(object sender, EventArgs e)
        {
            double primero = double.Parse(txtcalculadora.Text);
            primero = Math.Sqrt(primero);
            txtcalculadora.Text = primero.ToString();
            lblseguir.Text = Convert.ToString(primero);
        }

        private void btnsignos_Click(object sender, EventArgs e)
        {
            decimal primero = Convert.ToDecimal(txtcalculadora.Text);
            primero = ((primero) * (-1));
            txtcalculadora.Text = primero.ToString();
            lblseguir.Text = Convert.ToString(primero);
        }
        private void btnigual_Click(object sender, EventArgs e)
        {
            switch (total)
            {
                case "+":
                    Suma sum = new Suma();
                    string[] numeros = primero.Split('+');
                    txtcalculadora.Text = sum.Sumar(numeros).ToString();
                    primero = "";
                break;

                case "-":
                    Resta res = new Resta();
                    string[] numeros1 = primero.Split('-');
                    txtcalculadora.Text = res.Restar(numeros1).ToString();
                    primero = "";
                    break;

                case "x":
                    Multiplicacion  mul = new Multiplicacion();
                    string[] numeros2 = primero.Split('x');
                    txtcalculadora.Text = mul.Multiplicar(numeros2).ToString();
                    primero = "";
                    break;

                case "÷":
                    Division div = new Division();
                    string[] numeros3 = primero.Split('÷');
                    txtcalculadora.Text = div.Dividir(numeros3).ToString();
                    primero = "";
                    break;
            }
        }

       
    }
}
