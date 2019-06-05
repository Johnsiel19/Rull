using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ruleta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
       
        
        }



        public int Aleatorio()
        {

            Random aleatorio = new Random();
            int numero;


            numero = aleatorio.Next(1, 37);
            return numero;

        }

      

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
        
            Valorlabel.Text = "0";
            Jugada1numericUpDown.Value = 0;
            Jugada2numericUpDown.Value = 0;
            Jugada3numericUpDown.Value = 0;
            apostearnumericUpDown.Value = 0;
            Jugarbutton.Enabled = true;


        }

        private void Jugarbutton_Click(object sender, EventArgs e)
        {
            int ganancia = 0;
           if (Jugada1numericUpDown.Value >0 && Jugada2numericUpDown.Value ==0 && Jugada3numericUpDown.Value == 0) {
                ganancia = Convert.ToInt32(apostearnumericUpDown.Value) * 32;
            }

            if (Jugada1numericUpDown.Value > 0 && Jugada2numericUpDown.Value > 0 && Jugada3numericUpDown.Value == 0)
            {
                ganancia = Convert.ToInt32(apostearnumericUpDown.Value) * 17;
            }
            if (Jugada1numericUpDown.Value > 0 && Jugada2numericUpDown.Value > 0 && Jugada3numericUpDown.Value > 0)
            {
                ganancia = Convert.ToInt32(apostearnumericUpDown.Value) * 11;
            }



            Valorlabel.Text = Aleatorio().ToString();
            if (Jugada1numericUpDown.Enabled == true)
            {
                if(Convert.ToInt32( Valorlabel.Text) == Jugada1numericUpDown.Value || Convert.ToInt32(Valorlabel.Text) == Jugada2numericUpDown.Value || Convert.ToInt32(Valorlabel.Text) == Jugada3numericUpDown.Value)
                {
                    MessageBox.Show("has ganado $" + ganancia);
                }
                else
                {
                    MessageBox.Show("No has acertado");
           
                }

            }


            Jugarbutton.Enabled = false;


        }
    }
}
