using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menuavanzado.Registros.RegistroDVDs
{
    public partial class DatosDVDs : Form
    {
        ColeccionDVD coleccionDVD = new ColeccionDVD();
        List<DVD> listaDVDS = new List<DVD>();
        List<DVD> listaarticulos = new List<DVD>();


        int serie = 0;


        public DatosDVDs()
        {
            InitializeComponent();
        }

        private void DatosDVDs_Load(object sender, EventArgs e)
        {


            listaDVDS.AddRange(coleccionDVD.clonar());



            filtrar(4);
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
                elementosProducto3.adquiririnformacion(listaarticulos[serie + 4]);
            }

            if (listaarticulos.Count > serie+5 && listaarticulos[serie+5] != null)
            {
                elementosProducto3.adquiririnformacion(listaarticulos[serie + 5]);
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
                        if (d.prestamo == true)
                        {
                            listaarticulos.Add(d);
                        }

                    }
                break;

                case 2: //solo mp3s

                    foreach (DVD d in listaDVDS)
                    {
                        if((d.prestamo == true) && (d.tipo_DVD == "Mp3"))
                        {

                            listaarticulos.Add(d); ;

                        }


                    }
                break;

                case 3: //solo peliculas

                    foreach (DVD d in listaDVDS)
                    {
                        if ((d.prestamo == true) && (d.tipo_DVD == "Pelicula"))
                        {

                            listaarticulos.Add(d); ;

                        }


                    }
                break;

                case 4: // solo Videojuego

                    foreach (DVD d in listaDVDS)
                    {
                        if ((d.prestamo == true) && (d.tipo_DVD == "Videojuego"))
                        {
                            listaarticulos.Add(d);
                            ;
                        }
                    }
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


        //eventos

        private void buttonatras_Click(object sender, EventArgs e)
        {
            if (serie != 0)
            {

                //serie = serie - 5; 

            }
        }

        private void buttonadelante_Click(object sender, EventArgs e)
        {

            //serie = serie + 5;

        }
    }
}
