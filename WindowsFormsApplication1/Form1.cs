using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
          //  Random rnd2 = new Random();
            
            int PontosJogador1 = 0;
            int PontosJogador2 = 0;
            int valor1 = 0;
            int valor2 = 0;
            int i = 0;

            for (i=0; i<3; i++)
            {
                if (i == 0)
                {
                    valor1 = rnd1.Next(1, 7);
                    Jogada1.Text = " " + valor1;

                    valor2 = rnd1.Next(1, 7);
                    Jogada11.Text = " " + valor2;

                    if (valor1 != valor2)
                    {
                        if (valor1 > valor2)
                        {
                            PontosJogador1 = PontosJogador1 + 1;
                        }
                        else
                        {
                            PontosJogador2 = PontosJogador2 + 1;
                        }
                    }
                }
                else if (i == 1)
                {
                    valor1 = rnd1.Next(1, 7);
                    Jogada2.Text = " " + valor1;

                    valor2 = rnd1.Next(1, 7);
                    Jogada22.Text = " " + valor2;

                    if (valor1 != valor2)
                    {
                        if (valor1 > valor2)
                        {
                            PontosJogador1 = PontosJogador1 + 1;
                        }
                        else
                        {
                            PontosJogador2 = PontosJogador2 + 1;
                        }
                    }

                } else if (i == 2)
                {
                    valor1 = rnd1.Next(1, 7);
                    Jogada3.Text = " " + valor1;

                    valor2 = rnd1.Next(1, 7);
                    Jogada33.Text = " " + valor2;

                    if (valor1 != valor2)
                    {
                        if (valor1 > valor2)
                        {
                            PontosJogador1 = PontosJogador1 + 1;
                        }
                        else
                        {
                            PontosJogador2 = PontosJogador2 + 1;
                        }
                    }
                }
                
                
             }

               
             if (PontosJogador1 != PontosJogador2)
             {
                if (PontosJogador1 > PontosJogador2)
                {
                    label6.Text = "Jogador 1 Venceu  ";
                }
                else
                {
                    label6.Text = "Jogador 2 Venceu  ";
                }
             }
             else
             {
                label6.Text = "Deu empate";
             }
                
        }


        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
