using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        bool textoCalculo = true;
        String realizar;
        double primerValor;
        double segundoValor;
        double porcentaje;
        double numeroCien;
        double total;


        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            txtCalculos.Text = "0";
        }
        public void numeroUno()
        {
            if (textoCalculo == true)
            {
                txtCalculos.Text = "";
                txtCalculos.Text = "1";
                textoCalculo = false;
            }
            else
            {
                txtCalculos.Text = txtCalculos.Text + "1";
            }
        }
        public void numeroDos()
        {
            if (textoCalculo == true)
            {
                txtCalculos.Text = "";
                txtCalculos.Text = "2";
                textoCalculo = false;
            }
            else
            {
                txtCalculos.Text = txtCalculos.Text + "2";
            }
        }
        public void numeroTres()
        {
            if (textoCalculo == true)
            {
                txtCalculos.Text = "";
                txtCalculos.Text = "3";
                textoCalculo = false;
            }
            else
            {
                txtCalculos.Text = txtCalculos.Text + "3";
            }
        }
        public void numeroCuatro()
        {
            if (textoCalculo == true)
            {
                txtCalculos.Text = "";
                txtCalculos.Text = "4";
                textoCalculo = false;
            }
            else
            {
                txtCalculos.Text = txtCalculos.Text + "4";
            }
        }
        public void numeroCinco()
        {
            if (textoCalculo == true)
            {
                txtCalculos.Text = "";
                txtCalculos.Text = "5";
                textoCalculo = false;
            }
            else
            {
                txtCalculos.Text = txtCalculos.Text + "5";
            }
        }
        public void numeroSeis()
        {
            if (textoCalculo == true)
            {
                txtCalculos.Text = "";
                txtCalculos.Text = "6";
                textoCalculo = false;
            }
            else
            {
                txtCalculos.Text = txtCalculos.Text + "6";
            }
        }
        public void numeroSiete()
        {
            if (textoCalculo == true)
            {
                txtCalculos.Text = "";
                txtCalculos.Text = "7";
                textoCalculo = false;
            }
            else
            {
                txtCalculos.Text = txtCalculos.Text + "7";
            }
        }
        public void numeroOcho()
        {
            if (textoCalculo == true)
            {
                txtCalculos.Text = "";
                txtCalculos.Text = "8";
                textoCalculo = false;
            }
            else
            {
                txtCalculos.Text = txtCalculos.Text + "8";
            }
        }
        public void numeroNueve()
        {
            if (textoCalculo == true)
            {
                txtCalculos.Text = "";
                txtCalculos.Text = "9";
                textoCalculo = false;
            }
            else
            {
                txtCalculos.Text = txtCalculos.Text + "9";
            }
        }
        public void numeroCero()
        {
            if (txtCalculos.Text == "0")
            {
                return;
            }
            else
            {
                txtCalculos.Text = txtCalculos.Text + "0";
            }
        }
        public void botonSuma()
        {
            realizar = "+";
            textoCalculo = true;
            primerValor = double.Parse(txtCalculos.Text);
        }
        public void botonResta()
        {
            realizar = "-";
            textoCalculo = true;
            primerValor = double.Parse(txtCalculos.Text);
        }
        public void botonMultiplicar()
        {
            realizar = "*";
            textoCalculo = true;
            primerValor = double.Parse(txtCalculos.Text);
        }
        public void botonDividir()
        {
            realizar = "/";
            textoCalculo = true;
            primerValor = double.Parse(txtCalculos.Text);
        }
        public void botonRaizCuadrada()
        {
            realizar = "√ ";
            textoCalculo = true;
            primerValor = double.Parse(txtCalculos.Text);
        }
        public void botonPorcentaje()
        {
            realizar = "% ";
            textoCalculo = true;
            primerValor = double.Parse(txtCalculos.Text);
            numeroCien = 100;
        }

        private void btnUno_Click(object sender, EventArgs e)
        {

            numeroUno();

        }
        private void btnDos_Click(object sender, EventArgs e)
        {

            numeroDos();
        }
        private void btnTres_Click(object sender, EventArgs e)
        {
            numeroTres();
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            numeroCuatro();
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            numeroCinco();
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            numeroSeis();
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            numeroSiete();
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            numeroOcho();
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            numeroNueve();
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            numeroCero();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            botonSuma();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            botonResta();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            botonMultiplicar();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            botonDividir();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            botonRaizCuadrada();
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            botonPorcentaje();
        }

        public void botonIgualdad()
        {
            segundoValor = double.Parse(txtCalculos.Text);
            numeroCien = double.Parse(txtCalculos.Text);
            textoCalculo = true;
        }



        public void Suma()
        {
           
            switch (realizar)
            {
                case "+":
                    total = primerValor + segundoValor;
                    txtCalculos.Text = total.ToString();
                    break;
            }
        }
        public void Resta()
        {
            
            switch (realizar)
            {
                case "-":
                    total = primerValor - segundoValor;
                    txtCalculos.Text = total.ToString();
                    break;
            }
        }
        public void Multplicar()
        {
           
            switch (realizar)
            {
                case "*":
                    total = primerValor * segundoValor;
                    txtCalculos.Text = total.ToString();
                    break;

            }
        }
        public void Division()
        {
            
            switch (realizar)
            {
                case "/":
                    total = primerValor / segundoValor;
                    txtCalculos.Text = total.ToString();
                    break;
            }
        }
        public void RaizCuadrada()
        {
         
            switch (realizar)
            {
                case "√ ":
                    total = Math.Sqrt(primerValor);
                    txtCalculos.Text = total.ToString();
                    break;
            }

        }
        public void Porcentaje()
        {
           
            switch (realizar)
            {
                case "%":
                    total = primerValor * segundoValor;
                    porcentaje = this.total / numeroCien;
                    txtCalculos.Text = porcentaje.ToString();
                    break;
            }
        }
       

        private void btnIgualdad_Click(object sender, EventArgs e)
        {
            botonIgualdad();
            Suma();
            Resta();
            Multplicar();
            Division();
            RaizCuadrada();
            Porcentaje();
            

        }

        public void btnBorrarTodo_Click(object sender, EventArgs e)
            {
               txtCalculos.Clear();
        }
    }
}

