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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private bool VerificarRepetidos(String Nombre)
        {
            foreach (String aux in lb_nombres_2.Items)
            {
                if (aux == Nombre)
                {
                    ResetValores();
                    return false;
                }

            }

            return true;
        }


        private void ResetValores(){
            // Reset de valores
            tbx_nombre_2.Text = "";
            tbx_apellido_2.Text = "";
        }
        private void btn_borrar(object sender, EventArgs e)
        {
            if (lb_nombres_2.Items.Count != 0)
            {
                if (lb_nombres_2.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una persona", "Atencion");
                }
                else {
                    lb_nombres_2.Items.RemoveAt(lb_nombres_2.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("No hay ningun elemento en la lista", "Atencion");
                
            }    
        }

        private void btn_agregar(object sender, EventArgs e)
        {
            if (tbx_nombre_2.Text.Trim().Length > 0 && tbx_apellido_2.Text.Length > 0)
            {
                String nombrecompleto = tbx_nombre_2.Text.Substring(0, 1).ToUpper() + tbx_nombre_2.Text.Substring(1).ToLower() + " " + tbx_apellido_2.Text.Substring(0, 1).ToUpper() + tbx_apellido_2.Text.Substring(1).ToLower();


                if (VerificarRepetidos(nombrecompleto))
                {
                lb_nombres_2.Items.Add(nombrecompleto);


                    ResetValores();
                }
                else
                {
                    MessageBox.Show("El Nombre del usuario ya fue ingresado", "Atencion");
                }


            }
            else
            {
                MessageBox.Show("Tanto el Nombre como el Apellido debe estar completo", "Atencion");
            }
        }
    }
}
