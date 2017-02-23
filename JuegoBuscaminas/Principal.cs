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
    public partial class Principal : Form
        {

        Form1 form1;
        public Principal ()
            {
            InitializeComponent ();
            }
        private int alto;
        private int ancho;


        private void button1_Click (object sender, EventArgs e)
            {
            if (string.IsNullOrEmpty (txtusuario.Text))
                {
                MessageBox.Show ("Ingrese un usuario");
                }
            if (rbfacil.Checked)
                {
                alto = 5;
                ancho = 4;
                llmar ();
                }
            else if (rbmedio.Checked)
                {
                alto = 7;
                ancho = 6;
                llmar ();
                }
            else if (rbdificil.Checked)
                {
                alto = 9;
                ancho = 8;
                llmar ();
                }
            else {
                    MessageBox.Show("Selecciona un NIVEL");
                }

            }

        private void llmar ()
            {

            form1 = new Form1 (txtusuario.Text, alto, ancho);
            form1.Show ();
            this.Hide ();
            }
        }
    }
