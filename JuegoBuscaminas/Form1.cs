using BuscaminaVentana;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoBuscaminas
    {
    public partial class Form1 : Form
        {



        Tablero tablero ;
        Button[,] botones ;



        public Form1 (string lbl,  int alto, int ancho)
            {

            InitializeComponent ();
            lbluser.Text = lbl;
            lbancho.Text = Convert.ToString (ancho);
            lbalto.Text = Convert.ToString (alto);
            tablero = new Tablero (ancho, alto);
            botones = new Button[ancho, alto];

            }

        private void OnClick (object sender, EventArgs e)
            {
            //MessageBox.Show("fila: "+((MiBoton)sender).f);
            tablero.levantar (((MiBoton)sender).f, ((MiBoton)sender).c);
            actualizaTablero ();
            }

        public void actualizaTablero ()
            {



            for (int f = 1; f <= Convert.ToInt32 (lbancho.Text); f++)
                {
                for (int c = 1; c <= Convert.ToInt32 (lbalto.Text); c++)
                    {
                    //Texto en el boton
                    botones[f - 1, c - 1].Text = tablero.queHayEn (f, c);

                    if (tablero.queHayEn (f, c).Equals ("0"))
                        {
                        botones[f - 1, c - 1].Enabled = false;
                        botones[f - 1, c - 1].Text = "";
                        botones[f - 1, c - 1].BackColor = System.Drawing.Color.Brown;
                        }
                    else if (tablero.queHayEn (f, c).Equals ("B"))
                        {
                        botones[f - 1, c - 1].Image = global::JuegoBuscaminas.Properties.Resources.bomba;
                        botones[f - 1, c - 1].BackColor = System.Drawing.Color.Red;
                        MessageBox.Show( lbluser.Text + " has perdido la perdido !!");
                        Principal principal = new Principal();
                        principal.Show();
                        this.Hide();
                        }
                    else if (tablero.queHayEn (f, c) != null)
                           {
                              botones[f - 1, c - 1].BackColor = System.Drawing.Color.Yellow;
                            }
                    }
                }
            }

        private void formarTablero () {

        this.tableUI.ColumnCount = Convert.ToInt32 (lbalto.Text);
        this.tableUI.RowCount = Convert.ToInt32 (lbancho.Text);
                for (int i = 0; i < Convert.ToInt32 (lbancho.Text); i++)
                    {
                    for (int j = 0; j < Convert.ToInt32 (lbalto.Text); j++)
                        {
                        botones[i, j] = new MiBoton (i + 1, j + 1);

                        botones[i, j].AutoSize = true;
                        botones[i, j].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        botones[i, j].Size = new System.Drawing.Size (38, 32);
                        botones[i, j].BackColor = System.Drawing.Color.White;
                        botones[i, j].FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb (((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                        //botones[i, j].Text = "f: " + (i + 1);
                        this.tableUI.Controls.Add (botones[i, j]);

                        //asociamos un controlador de eventos para todos los botones
                        botones[i, j].Click += new EventHandler (this.OnClick);
                        }
                    }
                 actualizaTablero ();
            }
   
        private void Form1_Load (object sender, EventArgs e)
            {

            formarTablero();
            }

        private void button1_Click (object sender, EventArgs e)
            {
             this.Close();
            }

        private void button2_Click (object sender, EventArgs e)
            {
           // formarTablero ();
            }
        }
    }
