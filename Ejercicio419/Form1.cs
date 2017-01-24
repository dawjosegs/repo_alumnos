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
        // ***************************************************************
        // ******* MODO ITERATIVO ****************************************
        // ***************************************************************
        double IPotencia(double Base, double Intermedio)  // Calculo de la Potencia
        {
            double vIntermedio = Base * Intermedio;
            return vIntermedio;
        }

        double IFactorial(double i, double Intermedio)  // Calculo del Factorial
        {
            Intermedio = Intermedio * i;  
            return Intermedio;
        }

        // ***************************************************************
        // ******* MODO RECURSIVO ****************************************
        // ***************************************************************
        double RCalculo(double Base, double Expo)  // Bucle para obtener el Cálculo
        {
            double vIntermedio = 0;
            if (Expo == 0)
            {
                vIntermedio = 1;
            } else
            {
                vIntermedio = (RPotencia(Base, Expo) / RFactorial(Expo)) + RCalculo(Base, Expo - 1);
            }
            return vIntermedio;
        }

        double RPotencia(double Base, double Expo)  // Bucle para obtener la Potencia
        {
            double vIntermedio = 1;
            if (Expo == 0)
            {
                vIntermedio = 1;
            } else
            {
                vIntermedio = Base * RPotencia(Base, Expo - 1);
            }
            return vIntermedio;
        }

        double RFactorial(double Expo)  // Bucle para obtener el Factorial
        {
            double vIntermedio = 1;
            if (Expo == 0)
            {
                vIntermedio = 1;
            } else
            {
                vIntermedio = Expo * RFactorial(Expo - 1);
            }
            return vIntermedio;
        }
        // ***************************************************************
        // ******* ACCIONES DE BOTÓN *************************************
        // ***************************************************************
        private void btnIterativa_Click(object sender, EventArgs e)
        {
            double vNumM = double.Parse(txtNumM.Text);
            double vNumN = double.Parse(txtNumN.Text);
            double vPotParcial = 1;
            double vFacParcial = 1;
            double vResultado = 1;
            for (int i = 1; i <= vNumN; i++)
            {
                vPotParcial = IPotencia(vNumM, vPotParcial);
                vFacParcial = IFactorial(i, vFacParcial);
                vResultado = vResultado + (vPotParcial / vFacParcial);
            }
            MessageBox.Show("Resultado en Modo Iterativo: " + vResultado);
         }

        private void btnRecursiva_Click(object sender, EventArgs e)
        {
            double vNumM = double.Parse(txtNumM.Text);
            double vNumN = double.Parse(txtNumN.Text);
            double vResultado = RCalculo(vNumM, vNumN);
            MessageBox.Show("Resultado en Modo Recursivo: " + vResultado);
        }
    }
    }
