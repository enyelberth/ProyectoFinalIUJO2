using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ProyectoFinalIUJO.Registros.RegistroDVD;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;

namespace ProyectoFinalIUJO.Registros.RegistroDVD
{

    internal class ColeccionDVD
    {
        public static List<DVD> DVDsRegistrados = new List<DVD>();

        public void agregar(DVD dvd)
        {

            DVDsRegistrados.Add(dvd);


        }

        //esta funcion escribe un objeto en la base de datos


        public void escribirenbase()
        {

            XmlDocument DVDdatos = new XmlDocument();

            DVDdatos.Load("Datos.xml");

            XmlNode peliculas = DVDdatos.SelectSingleNode("/registros/DVDs/Peliculas");
            XmlNode MP3s = DVDdatos.SelectSingleNode("/registros/DVDs/MP3");
            XmlNode Juegos = DVDdatos.SelectSingleNode("/registros/DVDs/Juegos");

            peliculas.RemoveAll();
            MP3s.RemoveAll();
            Juegos.RemoveAll();


            foreach (DVD dvd in DVDsRegistrados)
            {

                XmlElement producto = DVDdatos.CreateElement("producto");

                XmlAttribute attribute = DVDdatos.CreateAttribute("nombre");
                attribute.Value = dvd.producto;
                producto.Attributes.Append(attribute);

                attribute = DVDdatos.CreateAttribute("codigo");
                attribute.Value = dvd.codigo;
                producto.Attributes.Append(attribute);

                attribute = DVDdatos.CreateAttribute("Tipo");
                attribute.Value = dvd.tipo_DVD;
                producto.Attributes.Append(attribute);

                attribute = DVDdatos.CreateAttribute("cantidad");
                attribute.Value = Convert.ToString(dvd.cantidad);
                producto.Attributes.Append(attribute);

                attribute = DVDdatos.CreateAttribute("AEmision");
                attribute.Value = Convert.ToString(dvd.año_emision);
                producto.Attributes.Append(attribute);

                attribute = DVDdatos.CreateAttribute("Fechaingreso");
                DateTime fecha = dvd.fechaingreso.Date;
                string stringfecha = fecha.ToString();
                attribute.Value = stringfecha;
                producto.Attributes.Append(attribute);

                attribute = DVDdatos.CreateAttribute("Prestamo");
                string presta = (dvd.prestamo == true) ? "y" : "n";
                attribute.Value = presta;
                producto.Attributes.Append(attribute);

                attribute = DVDdatos.CreateAttribute("Descripcion");
                attribute.Value = dvd.descripcion;
                producto.Attributes.Append(attribute);

                attribute = DVDdatos.CreateAttribute("Imagen");
                attribute.Value = dvd.ubicacionimagen;
                producto.Attributes.Append(attribute);
                
                if(dvd.tipo_DVD == "Mp3")
                {
                    attribute = DVDdatos.CreateAttribute("Archivo");
                    attribute.Value = dvd.ubicacionArchivo;
                    producto.Attributes.Append(attribute);

                    MP3s.AppendChild(producto);

                }
                else if (dvd.tipo_DVD == "Videojuego")
                {

                    Juegos.AppendChild(producto);

                }
                else if (dvd.tipo_DVD == "Pelicula")
                {

                    peliculas.AppendChild(producto);

                }


            }

            DVDdatos.Save("Datos.xml");
        }


        //esta funcion lee lo escrito en la base de datos y lo transforma en objetos de una lista
        public void leerbase()
        {
            string camino = Path.GetFullPath("Datos.xml");
            XmlDocument leer = new XmlDocument();

            leer.Load(camino);

            XmlNode peliculas = leer.SelectSingleNode("/registros/DVDs/Peliculas");
            XmlNode MP3s = leer.SelectSingleNode("/registros/DVDs/MP3");
            XmlNode Juegos = leer.SelectSingleNode("/registros/DVDs/Juegos");


            foreach (XmlNode pelicula in peliculas.ChildNodes)
            {
                string nombre = pelicula.Attributes["nombre"].Value;
                string codigo = pelicula.Attributes["codigo"].Value;
                string Tipo = pelicula.Attributes["Tipo"].Value;
                int cantidad = Convert.ToInt32(pelicula.Attributes["cantidad"].Value);
                int añoemision = Convert.ToInt32(pelicula.Attributes["AEmision"].Value);
                string convertirfecha = pelicula.Attributes["Fechaingreso"].Value;
                DateTime fechaingreso = DateTime.Parse(convertirfecha);
                
                bool prestamo = (pelicula.Attributes["Prestamo"].Value == "y") ? true : false;
                string descripcion = pelicula.Attributes["Descripcion"].Value;
                string imagen = pelicula.Attributes["Imagen"].Value;

                
                DVD index1 = new DVD(nombre, Tipo, codigo, cantidad, añoemision, fechaingreso, prestamo, descripcion, imagen);
                
                DVDsRegistrados.Add(index1);

            }

            foreach (XmlNode MP3 in MP3s.ChildNodes)
            {
                string nombre = MP3.Attributes["nombre"].Value;
                string codigo = MP3.Attributes["codigo"].Value;
                string Tipo = MP3.Attributes["Tipo"].Value;
                int cantidad = Convert.ToInt32(MP3.Attributes["cantidad"].Value);
                int añoemision = Convert.ToInt32(MP3.Attributes["AEmision"].Value);
                string convertirfecha = MP3.Attributes["Fechaingreso"].Value;
                DateTime fechaingreso = DateTime.Parse(convertirfecha);
                bool prestamo = (MP3.Attributes["Prestamo"].Value == "y") ? true : false;
                string descripcion = MP3.Attributes["Descripcion"].Value;
                string imagen = MP3.Attributes["Imagen"].Value;
                string archivo = MP3.Attributes["Archivo"].Value;



                DVD index2 = new DVD(nombre, Tipo, codigo, cantidad, añoemision, fechaingreso, prestamo, descripcion, imagen, archivo);
                DVDsRegistrados.Add(index2);

            }

            foreach (XmlNode juego in Juegos.ChildNodes)
            {
                string nombre = juego.Attributes["nombre"].Value;
                string codigo = juego.Attributes["codigo"].Value;
                string Tipo = juego.Attributes["Tipo"].Value;
                int cantidad = Convert.ToInt32(juego.Attributes["cantidad"].Value);
                int añoemision = Convert.ToInt32(juego.Attributes["AEmision"].Value);
                string convertirfecha = juego.Attributes["Fechaingreso"].Value;
                DateTime fechaingreso = DateTime.Parse(convertirfecha);
                bool prestamo = (juego.Attributes["Prestamo"].Value == "y") ? true : false;
                string descripcion = juego.Attributes["Descripcion"].Value;
                string imagen = juego.Attributes["Imagen"].Value;


                DVD index3 = new DVD(nombre, Tipo, codigo, cantidad, añoemision, fechaingreso, prestamo, descripcion, imagen);
                DVDsRegistrados.Add(index3);

            }







        }

        //revisarrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr

        public void modificar(DVD index)
        {
        	MenudeDatosdeDVD.DatosDVDs datos = new MenudeDatosdeDVD.DatosDVDs();
            foreach (DVD dvd in DVDsRegistrados)
            {
                if (dvd.codigo == index.codigo)
                {
                    dvd.producto = index.producto;
                    dvd.tipo_DVD = index.tipo_DVD;
                    dvd.codigo = index.codigo;
                    dvd.cantidad = index.cantidad;
                    dvd.descripcion = index.descripcion;
                    dvd.año_emision = index.año_emision;
                    dvd.fechaingreso = index.fechaingreso;
                    dvd.prestamo = index.prestamo;
                    dvd.ubicacionimagen = index.ubicacionimagen;

                    if (dvd.tipo_DVD == "Mp3")
                    {
                    dvd.ubicacionArchivo = index.ubicacionArchivo;
                    }

                }

            }
            
            datos.actualizar();

        }

        public void eliminar(DVD index)
        {
            

            for (int i = 0; i < DVDsRegistrados.Count; i++)
            {
                if (DVDsRegistrados[i] == index)
                {
                	string caminocarpeta = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                	string caminofinal = Path.Combine(caminocarpeta, "imagenesdvds\\" + DVDsRegistrados[i].ubicacionimagen);
                    File.Delete(caminofinal);
                	if (DVDsRegistrados[i].tipo_DVD == "Mp3") 
                	{
                		string caminofinalarchivo = Path.Combine(caminocarpeta, "archivosmp3\\" + DVDsRegistrados[i].ubicacionArchivo);
                		File.Delete(caminofinalarchivo);
                		
                	}
                   
                    DVDsRegistrados.RemoveAt(i);
                   
                }
            }
        }



        public bool confirmarcodigo(string codigoindex)
        {
            bool confirmacion = true;

            foreach (DVD dvd in DVDsRegistrados)
            {

                if (dvd.codigo == codigoindex)
                {
                    confirmacion = false;

                }

            }


            return confirmacion;
        }
        
        public bool confirmardisponible(string producto, string tipo, int cantidad)
        {
        	foreach(DVD dvd in DVDsRegistrados)
        	{
        		
        			if (producto == dvd.producto && tipo == dvd.tipo_DVD) 
        			{
							
							dvd.cantidad = dvd.cantidad + cantidad;
							MessageBox.Show("Unidad/es añadida a " + dvd.producto);
						
        				return false;
        			}
        		
        	}
        		
        	
        	return true;
        	
        }

        public List<DVD> clonar()
        {
            List<DVD> lista = new List<DVD>();

            lista.AddRange(DVDsRegistrados);

            return lista;
        }


       
        public void AbrirFormDescrip(Form descripcion1)
        {
            descripcion1.TopLevel = false;
            descripcion1.FormBorderStyle = FormBorderStyle.None;
            descripcion1.Dock = DockStyle.Fill;
            descripcion1.BringToFront();
            descripcion1.Show();
        }

    }
}
