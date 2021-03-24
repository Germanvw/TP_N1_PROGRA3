using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private bool VerificarRepetidos(String Nombre)
        {
            foreach(String listanombres in lb_1.Items)
            {
                if(listanombres == Nombre)
                {

                    return false;
                }
            
            }

            return true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_MouseClick(object sender, MouseEventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(tbx_nombre.Text))
            {
                if(VerificarRepetidos(tbx_nombre.Text))
                {
                    lb_1.Items.Add(tbx_nombre.Text);
                }
 
                tbx_nombre.Text = "";
            }
        }

        private void btn_agregar1_Click(object sender, EventArgs e)
        {
            if(lb_1.SelectedIndex != -1)
            {
                lb_2.Items.Add(lb_1.SelectedItem.ToString());
                lb_1.Items.RemoveAt(lb_1.SelectedIndex);
            }    

            else
            {
                MessageBox.Show("No seleccionaste ningun elemento", "Atencion");
            }
        }

        private void btn_agregartodos_Click(object sender, EventArgs e)
        {
            if(lb_1.Items.Count != 0)
            {
                foreach(String listanombres in lb_1.Items)
                {
                    lb_2.Items.Add(listanombres);
                    
                }
                lb_1.Items.Clear();
            }

            else
            {
                MessageBox.Show("No hay nombres en la lista", "Atencion");
            }
        }
    }
}
