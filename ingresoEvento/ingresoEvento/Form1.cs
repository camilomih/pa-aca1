using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ingresoEvento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Generar variables
            int edad;
            String edadTxt = txtbEdad.Text;

            //Validar si es un numero
            if (edadTxt.Trim() == "")
            {
                MessageBox.Show("Inserte un valor");
                return;
            }
            
            for(int i = 0; i < edadTxt.Length; i++)
            {
                if (!char.IsNumber(edadTxt[i]))
                {
                    MessageBox.Show("El valor solo debe ser numerico");
                    return;
                }
            }

            //Capturar variable
            edad= int.Parse(txtbEdad.Text);

            if(edad < 16)
            {
                MessageBox.Show("No puedes ingresar eres menor de edad");
                return;
            }

            if(edad >= 16 && edad < 21)
            {
                MessageBox.Show("Puedes ingresar gratis, Bienvenido!");
                return;
            }

            if (edad > 21)
            {
                MessageBox.Show("Bienvenido, debes pagar el ingreso.");
                return;
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
