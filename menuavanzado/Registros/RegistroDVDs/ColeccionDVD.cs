using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace menuavanzado.Registros.RegistroDVDs
{

    internal class ColeccionDVD
    {
        public static List<DVD> DVDsRegistrados = new List<DVD>();


        int n = 0;

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

            peliculas.RemoveAll();


            foreach (DVD dvd in DVDsRegistrados)
            {

                XmlElement pelicula = DVDdatos.CreateElement("pelicula");

                XmlAttribute attribute = DVDdatos.CreateAttribute("nombre");
                attribute.Value = dvd.producto;
                pelicula.Attributes.Append(attribute);

                attribute = DVDdatos.CreateAttribute("codigo");
                attribute.Value = dvd.codigo;
                pelicula.Attributes.Append(attribute);

                attribute = DVDdatos.CreateAttribute("Tipo");
                attribute.Value = dvd.tipo_DVD;
                pelicula.Attributes.Append(attribute);

                attribute = DVDdatos.CreateAttribute("cantidad");
                attribute.Value = Convert.ToString(dvd.cantidad);
                pelicula.Attributes.Append(attribute);

                attribute = DVDdatos.CreateAttribute("AEmision");
                attribute.Value = Convert.ToString(dvd.año_emision);
                pelicula.Attributes.Append(attribute);

                attribute = DVDdatos.CreateAttribute("Fechaingreso");
                DateTime fecha = dvd.fechaingreso.Date;
                string stringfecha = fecha.ToString();
                attribute.Value = stringfecha;
                pelicula.Attributes.Append(attribute);

                attribute = DVDdatos.CreateAttribute("Prestamo");
                string presta = (dvd.prestamo == true) ? "y" : "n";
                attribute.Value = presta;
                pelicula.Attributes.Append(attribute);

                attribute = DVDdatos.CreateAttribute("Descripcion");
                attribute.Value = dvd.descripcion;
                pelicula.Attributes.Append(attribute);

                attribute = DVDdatos.CreateAttribute("Imagen");
                attribute.Value = dvd.ubicacionimagen;
                pelicula.Attributes.Append(attribute);

                if(dvd.tipo_DVD == "Mp3")
                {
                    attribute = DVDdatos.CreateAttribute("Archivo");
                    attribute.Value = dvd.ubicacionArchivo;
                    pelicula.Attributes.Append(attribute);

                }

                peliculas.AppendChild(pelicula);


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
                if (Tipo == "Mp3")
                {
                    string archivo = pelicula.Attributes["Archivo"].Value;
                    DVD index1 = new DVD(nombre, codigo, Tipo, cantidad, añoemision, fechaingreso, prestamo, descripcion, imagen, archivo);
                    DVDsRegistrados.Add(index1);
                }
                else
                {
                    DVD index2 = new DVD(nombre, codigo, Tipo, cantidad, añoemision, fechaingreso, prestamo, descripcion, imagen);
                    DVDsRegistrados.Add(index2);
                }

            }




        }

        

        public void modificar(DVD index)
        {

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
                    dvd.ubicacionArchivo = index.ubicacionArchivo;


                }



            }

        }

        public void eliminar(DVD index)
        {
            foreach (DVD dvd in DVDsRegistrados)
            {

                if (dvd == index)
                    DVDsRegistrados.Remove(dvd);

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

    }
}
