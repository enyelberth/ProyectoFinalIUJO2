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
        public List<DVD> DVDsRegistrados = new List<DVD>();


        int n = 0;

        public void agregar(DVD dvd)
        {

            DVDsRegistrados.Add(dvd);


        }

        //esta funcion escribe un objeto en la base de datos
        public void escribirenbase(DVD dvd)
        {

            XmlDocument DVDdatos = new XmlDocument();

            DVDdatos.Load("Datos.xml");

            XmlNode peliculas = DVDdatos.SelectSingleNode("/registros/DVDs/Peliculas");

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

            attribute = DVDdatos.CreateAttribute("diaingreso");
            attribute.Value = Convert.ToString(dvd.dia_ingreso);
            pelicula.Attributes.Append(attribute);

            attribute = DVDdatos.CreateAttribute("Mesingreso");
            attribute.Value = Convert.ToString(dvd.mes_ingreso);
            pelicula.Attributes.Append(attribute);

            attribute = DVDdatos.CreateAttribute("Aingreso");
            attribute.Value = Convert.ToString(dvd.año_emision);
            pelicula.Attributes.Append(attribute);

            attribute = DVDdatos.CreateAttribute("Prestamo");
            string presta = (dvd.prestamo == true) ? "y" : "n";
            attribute.Value = presta;
            pelicula.Attributes.Append(attribute);

            attribute = DVDdatos.CreateAttribute("Descripcion");
            attribute.Value = dvd.descripcion;
            pelicula.Attributes.Append(attribute);

            peliculas.AppendChild(pelicula);

            n = n + 1;

            agregar(dvd);

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
                string diaingreso = pelicula.Attributes["diaingreso"].Value;
                string Mesingreso = pelicula.Attributes["Mesingreso"].Value;
                string Añoingreso = pelicula.Attributes["Aingreso"].Value;
                bool prestamo = (pelicula.Attributes["Prestamo"].Value == "y") ? true : false;
                string descripcion = pelicula.Attributes["Descripcion"].Value;

                DVD index = new DVD(nombre, codigo, Tipo, cantidad, añoemision, Añoingreso, Mesingreso, diaingreso, prestamo, descripcion);
                DVDsRegistrados.Add(index);


            }




        }
    }
}
