
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalIUJO.Registros.RegistroDVD.MenudeDatosdeDVD;

namespace ProyectoFinalIUJO.Registros.RegistroDVD.MenudeDatosdeDVD
{
    public partial class DatosDVDs : Form
    {
        ColeccionDVD coleccionDVD = new ColeccionDVD();
        List<DVD> listaDVDS = new List<DVD>();
        List<DVD> listaarticulos = new List<DVD>();

        int filtraropcion;
        int ordenaropcion;


        int serie = 0;


        public DatosDVDs()
        {
            InitializeComponent();
        }

        private void DatosDVDs_Load(object sender, EventArgs e)
        {


            listaDVDS.AddRange(coleccionDVD.clonar());


            labelposicion1.Text = (serie < 1) ? "1" : Convert.ToString(serie / 5 + 1);
            filtrar(1);

            ordenar(3);
            actualizar();

        }

        public void actualizar()
        {


            if (listaarticulos.Count > serie && listaarticulos[serie] != null)
            {
                elementosProducto1.adquiririnformacion(listaarticulos[serie]);
            }

            if (listaarticulos.Count > serie+1 && listaarticulos[serie+1] != null)
            {
                elementosProducto2.adquiririnformacion(listaarticulos[serie + 1]);
            }

            if (listaarticulos.Count > serie+2 && listaarticulos[serie+2] != null)
            {
                elementosProducto3.adquiririnformacion(listaarticulos[serie+2]);
            }

            if (listaarticulos.Count > serie+3 && listaarticulos[serie+3] != null)
            {
                elementosProducto4.adquiririnformacion(listaarticulos[serie + 3]);
            }

            if (listaarticulos.Count > serie+4 && listaarticulos[serie+4] != null)
            {
                elementosProducto5.adquiririnformacion(listaarticulos[serie + 4]);
            }

            if (listaarticulos.Count > serie+5 && listaarticulos[serie+5] != null)
            {
                elementosProducto6.adquiririnformacion(listaarticulos[serie + 5]);
            }

        }

        public void filtrar(int opcion)
        {
            listaarticulos.Clear();  

            switch(opcion)
            {
                case 1: //toda la lista

                    foreach (DVD d in listaDVDS)
                    {
                        //if (d.prestamo == true)
                        //{
                            listaarticulos.Add(d);
                        //}

                    }
                    int posicionfinal = listaarticulos.Count / 5;
                    if (posicionfinal < 1)
                    {

                        posicionfinal = 1;

                    }
                    labelposicion2.Text = Convert.ToString(posicionfinal);

                    filtraropcion = 1; 
                    break;


                case 2: //solo mp3s

                    foreach (DVD d in listaDVDS)
                    {
                        if((d.prestamo == true) && (d.tipo_DVD == "Mp3"))
                        {

                            listaarticulos.Add(d); ;

                        }


                    }
                    posicionfinal = listaarticulos.Count / 5;
                    if (posicionfinal < 1)
                    {

                        posicionfinal = 1;

                    }
                    labelposicion2.Text = Convert.ToString(posicionfinal);

                    filtraropcion = 2;
                    break;


                case 3: //solo peliculas

                    foreach (DVD d in listaDVDS)
                    {
                        if ((d.prestamo == true) && (d.tipo_DVD == "Pelicula"))
                        {

                            listaarticulos.Add(d); ;

                        }


                    }
                    posicionfinal = listaarticulos.Count / 5;
                    if (posicionfinal < 1)
                    {

                        posicionfinal = 1;

                    }
                    labelposicion2.Text = Convert.ToString(posicionfinal);

                    filtraropcion = 3;
                    break;


                case 4: // solo Videojuego

                    foreach (DVD d in listaDVDS)
                    {
                        if ((d.prestamo == true) && (d.tipo_DVD == "Videojuego"))
                        {
                            listaarticulos.Add(d);
                            
                        }
                    }

                    posicionfinal = listaarticulos.Count / 5;
                    if(posicionfinal < 1)
                    {

                        posicionfinal = 1;

                    }
                    labelposicion2.Text = Convert.ToString(posicionfinal);

                    filtraropcion = 4;
                    break;

            }
        }

        public void ordenar(int opcion)
        {

            switch(opcion)
            {
                case 1:

                    listaarticulos.OrderBy(index => index.fechaingreso).ToList(); //por fecha de ingreso mas nuevo a mas viejo
                break;

                case 2:

                    listaarticulos.OrderBy(index => index.fechaingreso).ToList(); //por fecha de ingreso mas viejo al mas nuevo
                    listaarticulos.Reverse();

                break;

                case 3:

                    listaarticulos = listaarticulos.OrderBy(dvd => dvd.producto).ToList();   // a-z

                    break;

                case 4:

                    listaarticulos = listaarticulos.OrderBy(dvd => dvd.producto).ToList();  
                    listaarticulos.Reverse(); //z-a

                break;

                case 5:

                    listaarticulos = listaarticulos.OrderBy(dvd => dvd.año_emision).ToList(); //por fecha de emision

                break;







            }




        }


        public void limpiar()
        {
            //foreach(Control control in this.Controls)
            foreach(ElementosProducto elemento in this.Controls.OfType<ElementosProducto>())
            {
                //if (control is ElementosProducto elemento)
                //{


                    elemento.reiniciar();
                    elemento.cantidadproducto = "0";
                    elemento.Nombreproducto = "";
                    elemento.Codigoproducto = "000000";
                    string rutaarchivo = Path.GetFullPath("mostrarnulo.png");
                    Bitmap imagen = new Bitmap(rutaarchivo);
                    elemento.Imagenproducto = imagen;



                //}

               



            }



        }


        //eventos

        private void buttonatras_Click(object sender, EventArgs e)
        {
            if (serie != 0)
            {

                serie = serie - 5; 
                labelposicion1.Text = Convert.ToString(serie / 5 + 1);

            if(serie == 0)
            {
                labelposicion1.Text = "1";

            }

            }
            limpiar();
            filtrar(filtraropcion);
            ordenar(ordenaropcion);
            actualizar();
        }

        private void buttonadelante_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(labelposicion1.Text) == Convert.ToInt32(labelposicion2.Text) )
            {

            }
            else if(Convert.ToInt32(labelposicion1.Text) < Convert.ToInt32(labelposicion2.Text))
            {
                serie = serie + 5;
                labelposicion1.Text = Convert.ToString(serie / 5 + 1);
                if (serie == 0)
                {

                    labelposicion1.Text = "1";

                }
               
            }
            limpiar();
            filtrar(filtraropcion);
            ordenar(ordenaropcion);
            actualizar();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiar();

            if(comboBox1.Text == "Sin filtro")
            {
                filtrar(1);
                actualizar();
            }
            if (comboBox1.Text == "Peliculas")
            {
                filtrar(3);
                actualizar();
            }
            if (comboBox1.Text == "Mp3s")
            {
                filtrar(2);
                actualizar();   
            }
            if (comboBox1.Text == "Videojuegos")
            {
                filtrar(4);
                actualizar();
            }
            
        
    
	}
    }
}
