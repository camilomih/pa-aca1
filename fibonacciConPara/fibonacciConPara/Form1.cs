using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibonacciConPara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //Generar variables
            int numero;
            String numeroTXT = txtBNumero.Text;
            

            //Validar si es un numero
            if (numeroTXT.Trim() == "")
            {
                MessageBox.Show("Inserte un valor");
                return;
            }

            for (int i = 0; i < numeroTXT.Length; i++)
            {
                if (!char.IsNumber(numeroTXT[i]))
                {
                    MessageBox.Show("El valor solo debe ser numerico");
                    return;
                }
            }

            //Capturar variable
            numero = int.Parse(numeroTXT);
            int[] resultado = new int[numero];

            for (int i = 0; i < numero; i++)
            {
                if (i > 1) { 
                    resultado[i] = resultado[i - 2] + resultado[i - 1];
                    continue;
                }

                resultado[i] = i;
            }

            MessageBox.Show(string.Join(",", resultado));
           
        }
    }
}
