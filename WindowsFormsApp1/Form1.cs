using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        static int finalLength = 0;
        private void button1_Click(object sender, EventArgs e)
          
        {
            string input = Interaction.InputBox("Ingrese la cantidad de intentos", "devlights", "", -1, -1);
            int entrada = Int32.Parse(input);
            if(entrada < 1 || entrada > 10)
            {
                do
                {
                    input = Interaction.InputBox("Debe ingresar un valor mayor a 1 y menor a 10", "devlights", "", -1, -1);
                    entrada = int.Parse(input); 
                } while (entrada < 1 || entrada > 10);
               // MessageBox.Show("Ingrese un numero mayor a 0 y menor a 10");
            }

                            for (int i = 0; i < entrada; i++)
                            {
                                string strToProcess = Interaction.InputBox("Ingrese la cadena a tratar", "devlights", "", -1, -1);
                                if (strToProcess.Length<1)
                                    {
                                            do
                                            {
                                                strToProcess = Interaction.InputBox("Debe ingresar una cadena con longitud mayor a 1", "devlights", "Default", -1, -1);
                                            } while (strToProcess.Length < 1);

                                    }else 
                                    if (strToProcess.Length > 100000)
                                      {
                                                do
                                                {
                                                    strToProcess = Interaction.InputBox("Debe ingresar una cadena con longitud menor a 100000", "devlights", "Default", -1, -1);
                                                } while (strToProcess.Length > 100000);
                                     }


                    int totalstrLength = strToProcess.Length;
                                finalLength = totalstrLength;
                                char[] masterarraychar = strToProcess.ToCharArray();
                                for (int k = 1; k < totalstrLength; k++)
                                {

                                    if (masterarraychar[0] != masterarraychar[k])
                                        continue;
                                    matchlen(masterarraychar, k);

                                }
                MessageBox.Show("El resultado es: " +finalLength);
            }
                            //Console.ReadKey();
                        }
                        private static void matchlen(char[] masterarraychar, int k)
                        {
                            for (int j = 0; j < masterarraychar.Length - k; j++)
                            {
                                if (masterarraychar[j + k] == masterarraychar[j])
                                {
                                    finalLength++;
                                }
                                else
                                {
                                    break;
                                }
                            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
