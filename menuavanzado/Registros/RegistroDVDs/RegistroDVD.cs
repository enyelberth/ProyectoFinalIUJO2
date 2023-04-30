using menuavanzado.Registros.RegistroDVDs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace menuavanzado.Registros.RegistroDVDs
{
    public partial class RegistroDVD : Form
    {
        public RegistroDVD()
        {
            InitializeComponent();
        }

        private void buttonregistro_Click(object sender, EventArgs e)
        {
            ColeccionDVD x = new ColeccionDVD();  
            bool confirmacion = false;

            if (textBoxAñoemision.Text != "") 
            {
                if(textBoxañoingreso.Text != "")
                {
                    if (textBoxCantidad.Text != "")
                    {
                        if(textBoxcodigo.Text != "")
                        {
                            if(textBoxdescripcion.Text != "" )
                            {
                                if(textBoxDiaingreso.Text != "")
                                {
                                    if(textBoxmesingreso.Text != "")
                                    {
                                        if(textBoxprestamo.Text != "")
                                        {
                                            if(textBoxTitulo.Text != "")
                                            {
                                                confirmacion = true;
                                                string Producto = textBoxTitulo.Text;
                                                string Codigo = textBoxcodigo.Text;
                                                string Tipo_DVD = comboBoxtipoDVD.Text;
                                                int Cantidad = Convert.ToInt32(textBoxCantidad.Text);
                                                int Año_emision = Convert.ToInt32(textBoxAñoemision.Text);
                                                string dia_ingreso = textBoxDiaingreso.Text;
                                                string mes_ingreso = textBoxmesingreso.Text;
                                                string año_ingreso = textBoxañoingreso.Text;
                                                bool Prestamo = (radioButtonNO.Checked == true) ? false : true;
                                                string Descripcion = textBoxdescripcion.Text;

                                                DVD index = new DVD(Producto, Codigo, Tipo_DVD, Cantidad, Año_emision, año_ingreso, mes_ingreso, dia_ingreso, Prestamo, Descripcion);

                                                x.agregar(index);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (confirmacion == false)
            {
                MessageBox.Show("Uno o mas de los campos del registro estan vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }


        //validaciones

        private void textBoxAñoemision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void textBoxDiaingreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void textBoxmesingreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void textBoxañoingreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void textBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    }
}
