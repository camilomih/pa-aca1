using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibonacciConMientras
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
            String numeroTXT = txtbNumero.Text;


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
            resultado[0] = 0;
            resultado[1] = 1;
            int n = 2;
            while(n < numero)
            {
                resultado[n] = resultado[n - 1] + resultado[n - 2];
                n += 1;
            }

            MessageBox.Show(string.Join(",", resultado));
        }
    }
}
