using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phineas_y_Ferb
{
    public partial class Form1 : Form
    {
        int cantA = 0;
        int cantP = 0;
        int cantF = 0;
        bool ultP = false;
      
        int invP = 0;
        int invF = 0;
        //Declaro las variables que voy a usar en el código

        public Form1()
        {
            InitializeComponent();

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnIngresarIdea_Click(object sender, EventArgs e)
        {
            string autor = txtAutor.Text;
            int cant = Convert.ToInt32(txtCant.Text);
            //Se ingresa el autor de la idea y la cantidad de ideas. 
            //Se pasa la inicial del autor a string y la cantidad de ideas a int 
            

            if (autor == "A" || autor == "a")
            {
                 cantA = cantA + cant;
                //Si el autor es un amigo, se le suma la cantidad de ideas ingresadas a la variable que cuenta ideas de amigos, cuando se apriete el btnIngresarIdea.
            }
            if (autor == "P" || autor == "p")
            {
                cantP = cantP + cant;
                //Si el autor es Phineas, se le suma la cantidad de ideas ingresadas a la variable que cuenta ideas de Phineas, cuando se apriete el btnIngresarIdea..
            }
            if (autor == "F" || autor == "f")
            {
                cantF = cantF + cant;
                //Si el autor es Phineas, se le suma la cantidad de ideas ingresadas a la variable que cuenta ideas de Phineas, cuando se apriete el btnIngresarIdea..
            }

            txtAutor.Text = "";
            txtCant.Text = "";
            // Se vacían las textboxs cuando se apriete el btnIngresarIdea.
        }

        private void BtnDarIdea_Click(object sender, EventArgs e)
        {
            if (cantA > 0)
            {
                MessageBox.Show("Idea de amigo");
                cantA--;
                //Si hay ideas de amigos, cuando se aprete el btnDarIdea, aparece un MessageBox diciendo "Idea de amigo" y se le resta 1 al contador de ideas de amigos
            }
            else if (ultP == false && cantP > 0)
            {
                MessageBox.Show("Idea de Phineas");
                ultP = true;
                cantP--;
                invP++;
                //La variable ultP dice si la ultima idea dada fue de Phineas o de Ferb cuando no hay ideas de amigos. Si la última fue de Ferb, o es la primera, se muestra un MessageBox que dice "Idea de Phineas"
            }
            else if (ultP == true && cantF > 0)
            {
                MessageBox.Show("Idea de Ferb");
                ultP = false;
                cantF--;
                invF++;
                //Si no hay ideas de amigos, pero si hay de Ferb y el ultimo invento fue de Phineas, se muestra un MessageBox que dice "Idea de Ferb", se le resta 1 al contador de ideas de Ferb y se le suma 1 a la cantidad de sus inventos.
            }
        
            else if (ultP == true && cantP > 0 && cantF == 0)
            {
                MessageBox.Show("Idea de Phineas");
                cantP--;
                invP++;
                // Si no hay ideas de Ferb, pero si de Phineas, aunque la anterior haya sido de Phineas, se muestra un MessageBox que dice "Idea de Phineas", se le resta 1 al contador de ideas de Phineas y se le suma 1 a la cantidad de sus invetos.
            }
            else if (ultP == false && cantP == 0 && cantF > 0)
            {
                MessageBox.Show("Idea de Ferb");
                cantF--;
                invF++;
                // Si no hay ideas de Phineas pero si de Ferb, aunque la anterior haya sido de Ferb, se muestra un MessageBox que dice "Idea de Ferb", se le resta 1 al contador de ideas de Ferb y se le suma 1 a la cantidad de sus invetos.
            }
            else if (cantA == 0 && cantP == 0 && cantF == 0)
            {
                MessageBox.Show("No quedan ideas");
                //Si no hay ideas de nadie se muestra un MessageBox que dice "No quedan ideas"
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnIdeasFaltantes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Faltan construir " + cantA + " ideas de amigos, " + cantP + " de Phineas y " + cantF + " de Ferb");
            //
        }

        private void BtnMasInventos_Click(object sender, EventArgs e)
        {
            if (invP > invF)
            {
                MessageBox.Show("Phineas hizo más inventos");
            }
            else if (invP < invF)
            {
                MessageBox.Show("Ferb hizo más inventos");
            }
            else
            {
                MessageBox.Show("Hicieron la misma cantidad de inventos");
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
