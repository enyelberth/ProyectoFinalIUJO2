using menuavanzado.Registros.RegistroDVDs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace menuavanzado.Registros.RegistroDVDs
{
    public partial class RegistroDVD : Form
    {
        OpenFileDialog ubicacionimagen;

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
                if (textBoxañoingreso.Text != "")
                {
                    if (textBoxCantidad.Text != "")
                    {
                        if (textBoxcodigo.Text != "")
                        {
                            if (textBoxdescripcion.Text != "")
                            {
                                if (textBoxDiaingreso.Text != "")
                                {
                                    if (textBoxmesingreso.Text != "")
                                    {
                                        if (textBoxprestamo.Text != "")
                                        {
                                            if (textBoxTitulo.Text != "")
                                            {
                                                if (textBoximagen.Text != "")
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
                                                    string imagen = obtenerimagen();

                                                    DVD index = new DVD(Producto, Codigo, Tipo_DVD, Cantidad, Año_emision, año_ingreso, mes_ingreso, dia_ingreso, Prestamo, Descripcion, imagen);
                                                    MessageBox.Show(index.ubicacionimagen); 

                                                    //x.agregar(index);
                                                }

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


        private void buttonarchivo_Click_1(object sender, EventArgs e)
        {
            bool continuar = false;
            OpenFileDialog nuevo = new OpenFileDialog();

            do
            {

                try
                {

                    nuevo.ShowDialog();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Se produjo un error al mostrar el diálogo de selección de archivo: " + ex.Message, "Error");

                }

                try
                {
                    Image comprobar = Image.FromFile(nuevo.FileName);

                    continuar = true;

                    textBoximagen.Text = Path.GetFileName(nuevo.FileName);
                    ubicacionimagen = nuevo;
                }
                catch (IOException ex)
                {


                    MessageBox.Show("Se ha producido un error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (ArgumentException ex)
                {

                    MessageBox.Show("Se ha producido un error al seleccionar la imagen, seleccione una imagen valida porfavor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            } while (continuar != true);

        }


        //metodos

        public string obtenerimagen()
        {
            OpenFileDialog nuevo = ubicacionimagen;
            string caminocarpeta = "";
            string caminofinal = "";


            try
            {

                caminocarpeta = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                caminofinal = Path.Combine(caminocarpeta, "imagenesdvds\\" + Path.GetFileName(nuevo.FileName));

                MessageBox.Show(caminofinal);

                //File.Copy(caminoarchivo, caminofinal);



                return Path.GetFileName(nuevo.FileName); ;
            }

            catch (IOException e)
            {


                MessageBox.Show("Se ha producido un error\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (ArgumentException e)
            {

                MessageBox.Show("Se ha producido un error al seleccionar la imagen, seleccione una imagen valida porfavor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            return Path.GetFileName(nuevo.FileName);

        }
    }
}
