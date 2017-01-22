using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio419
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Potencia(double Base, double Intermedio)
        {
            double vIntermedio = Base * Intermedio;
            return vIntermedio;
        }

        double Factorial(double i, double Intermedio)
        {
            Intermedio = Intermedio * i;  
            return Intermedio;
        }

        private void btnIterativa_Click(object sender, EventArgs e)
        {
            double vNumM = double.Parse(txtNumM.Text);
            double vNumN = double.Parse(txtNumN.Text);
            double vPotParcial = 1;
            double vFacParcial = 1;
            double vResultado = 0;
            for (int i = 1; i <= vNumN; i++)
            {
                vPotParcial = Potencia(vNumM, vPotParcial);
                MessageBox.Show("Resultado de " + vNumM + " elevado a " + i + " = " + vPotParcial);
                vFacParcial = Factorial(i, vFacParcial);
                MessageBox.Show("Resultado del factorial de " + i + " = " + vFacParcial);
                vResultado = vResultado + (vPotParcial / vFacParcial);
                MessageBox.Show("Resultado parcial: " + vResultado);
            }
            MessageBox.Show("Resultado FINAL: " + vResultado);
         }

     }
}
