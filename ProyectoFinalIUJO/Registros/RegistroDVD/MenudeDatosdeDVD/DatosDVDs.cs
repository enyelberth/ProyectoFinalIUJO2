﻿
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

        static int filtraropcion = 1;
        static int ordenaropcion = 3;


        int serie = 0;


        public DatosDVDs()
        {
            InitializeComponent();
            actualizar();
        }

        private void DatosDVDs_Load(object sender, EventArgs e)
        {
            llenarbase();

            labelposicion1.Text = (serie < 1) ? "1" : Convert.ToString(serie / 5 + 1);

            

            filtrar(1);
            ordenar(3);
            actualizar();

            string posicionfinal = Convert.ToString(listaarticulos.Count / 5 +1);
            if (posicionfinal == "0")
            {
                posicionfinal = "1";
            }
            labelposicion2.Text = posicionfinal;



        }

        public void llenarbase() 
        {
        	listaDVDS.Clear();
            listaDVDS.AddRange(coleccionDVD.clonar());
            listaarticulos.Clear();
            listaarticulos.AddRange(listaDVDS);


            serie = 0;
            labelposicion1.Text = "1";
            labelposicion2.Text = Convert.ToString(listaarticulos.Count / 5 +1);

            actualizar();


        
        
        }


        public void actualizar()
        {
            if (serie == 0)
            {




                if (listaarticulos.Count > serie && listaarticulos[serie] != null)
                {
                    elementosProducto1.adquiririnformacion(listaarticulos[serie]);
                }

                if (listaarticulos.Count > serie + 1 && listaarticulos[serie + 1] != null)
                {
                    elementosProducto2.adquiririnformacion(listaarticulos[serie + 1]);
                }

                if (listaarticulos.Count > serie + 2 && listaarticulos[serie + 2] != null)
                {
                    elementosProducto3.adquiririnformacion(listaarticulos[serie + 2]);
                }

                if (listaarticulos.Count > serie + 3 && listaarticulos[serie + 3] != null)
                {
                    elementosProducto4.adquiririnformacion(listaarticulos[serie + 3]);
                }

                if (listaarticulos.Count > serie + 4 && listaarticulos[serie + 4] != null)
                {
                    elementosProducto5.adquiririnformacion(listaarticulos[serie + 4]);
                }

                if (listaarticulos.Count > serie + 5 && listaarticulos[serie + 5] != null)
                {
                    elementosProducto6.adquiririnformacion(listaarticulos[serie + 5]);
                }

            }
            else
            {
                if (listaarticulos.Count > serie && listaarticulos[serie +1] != null)
                {
                    elementosProducto1.adquiririnformacion(listaarticulos[serie + 1]);
                }

                if (listaarticulos.Count > serie + 2 && listaarticulos[serie + 2] != null)
                {
                    elementosProducto2.adquiririnformacion(listaarticulos[serie + 2]);
                }

                if (listaarticulos.Count > serie + 3 && listaarticulos[serie + 3] != null)
                {
                    elementosProducto3.adquiririnformacion(listaarticulos[serie + 3]);
                }

                if (listaarticulos.Count > serie + 4 && listaarticulos[serie + 4] != null)
                {
                    elementosProducto4.adquiririnformacion(listaarticulos[serie + 4]);
                }

                if (listaarticulos.Count > serie + 5 && listaarticulos[serie + 5] != null)
                {
                    elementosProducto5.adquiririnformacion(listaarticulos[serie + 5]);
                }

                if (listaarticulos.Count > serie + 6 && listaarticulos[serie + 6] != null)
                {
                    elementosProducto6.adquiririnformacion(listaarticulos[serie + 6]);
                }







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

                    listaarticulos = listaarticulos.OrderBy(dvd => dvd.producto).ToList();   //z-a
                    listaarticulos.Reverse();

                break;

                case 5:

                    listaarticulos = listaarticulos.OrderBy(dvd => dvd.año_emision).ToList(); //por fecha de emision

                break;

                case 6:

                    listaarticulos = listaarticulos.OrderBy(dvd => dvd.año_emision).ToList(); //por fecha de emision mas antiguos
                    listaarticulos.Reverse();
                break;







            }
        }

        public void eliminar(DVD dvdeliminar)
        {

            coleccionDVD.eliminar(dvdeliminar);
            llenarbase();

        }
        

        public void modificar(DVD dvdmodificar) 
        {
            RegistroDVD registro = new RegistroDVD();

            
            registro.cargardatos(dvdmodificar);
            
            

        }

            

        


        public void limpiar()
        {
           
            foreach(ElementosProducto elemento in this.Controls.OfType<ElementosProducto>())
            {
                
					elemento.BackColor = Color.White;            	
                    elemento.reiniciar();
                    elemento.cantidadproducto = "0";
                    elemento.Nombreproducto = "";
                    elemento.Codigoproducto = "000000";
                    string rutaarchivo = Path.GetFullPath("mostrarnulo.png");
                    Bitmap imagen = new Bitmap(rutaarchivo);
                    elemento.Imagenproducto = imagen;
            }



        }
        
        public void limpiarimagenes()
        {
        	foreach(ElementosProducto elemento in this.Controls.OfType<ElementosProducto>())
            {
	        	string rutaarchivo = Path.GetFullPath("mostrarnulo.png");
	                    Bitmap imagen = new Bitmap(rutaarchivo);
	                    elemento.Imagenproducto = imagen;
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

        private void DatosDVDs_Activated(object sender, EventArgs e)
        {
            MessageBox.Show("activado");
        }

        private void DatosDVDs_Deactivate(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiar();

            if (comboBox2.Text == "A/Z")
            {
                ordenar(3);
                actualizar();
            }
            if (comboBox2.Text == "Z/A")
            {
                ordenar(2);
                actualizar();
            }
            if (comboBox2.Text == "Fecha de estreno de mayor a menor")
            {
                ordenar(5);
                actualizar();
            }
            if (comboBox2.Text == "Fecha de estreno de menor a mayor")
            {
                ordenar(6);
                actualizar();
            }
            if (comboBox2.Text == "Mas recientes")
            {
                ordenar(1);
                actualizar();
            }
            if (comboBox2.Text == "Mas antiguos")
            {
                ordenar(2);
                actualizar();
            }
        }

        private void buttonatualizar_Click(object sender, EventArgs e)
        {
        	limpiar();
        	llenarbase();
            actualizar();
            labelposicion2.Text = Convert.ToString(serie / 5 + 1);
        }

		
		void ElementosProducto1Load(object sender, EventArgs e)
		{
			MessageBox.Show("limpiado");
			limpiarimagenes();
		}
		
		
		
		void ElementosProducto2MouseMove(object sender, MouseEventArgs e)
		{
			elementosProducto2.Imagenproducto = null;
		}
		
		void ElementosProducto1MouseMove(object sender, MouseEventArgs e)
		{
		   elementosProducto1.Imagenproducto = null;
		}
		
		void ElementosProducto1MouseLeave(object sender, EventArgs e)
		{
			actualizar();
		}
		
		void ElementosProducto2MouseLeave(object sender, EventArgs e)
		{
			actualizar();
		}
		
		void ElementosProducto3MouseLeave(object sender, EventArgs e)
		{
			actualizar();
		}
		
		void ElementosProducto3MouseMove(object sender, MouseEventArgs e)
		{
			elementosProducto3.Imagenproducto = null;
		}
		
		void ElementosProducto4MouseMove(object sender, MouseEventArgs e)
		{
			elementosProducto4.Imagenproducto = null;
			
		}
		
		void ElementosProducto5MouseMove(object sender, MouseEventArgs e)
		{
			elementosProducto5.Imagenproducto = null;
		}
		
		void ElementosProducto6MouseMove(object sender, MouseEventArgs e)
		{
			elementosProducto6.Imagenproducto = null;
		}
		
		void ElementosProducto4MouseLeave(object sender, EventArgs e)
		{
            actualizar();
		}
		
		void ElementosProducto5MouseLeave(object sender, EventArgs e)
		{
            actualizar();
		}
		
		void ElementosProducto6MouseLeave(object sender, EventArgs e)
		{   
            actualizar();
		}
		
		void DatosDVDsMouseMove(object sender, MouseEventArgs e)
		{
			actualizar();
		}
    }
}
