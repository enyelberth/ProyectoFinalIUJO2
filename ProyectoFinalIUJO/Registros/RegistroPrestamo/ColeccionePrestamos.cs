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
using ProyectoFinalIUJO.Registros.RegistroClientes;

namespace ProyectoFinalIUJO.Registros.RegistroPrestamo
{
    class ColeccionePrestamos
    {
        public static List<Prestamos> listaprestamos = new List<Prestamos>();


        public void agregar(Prestamos index)
        {

            listaprestamos.Add(index);

        }

        

        public void modificar(Prestamos index)
        {
            foreach (Prestamos prestamo in listaprestamos)
            {
                if (prestamo.Codigoprestamo == index.Codigoprestamo)
                {

                    prestamo.Producto = index.Producto;
                    prestamo.FechaPrestamo1 = index.FechaPrestamo1;
                    prestamo.FechaDevolucion1 = index.FechaDevolucion1;
                    prestamo.Cantidad = index.Cantidad;
                    prestamo.Tipo_DVD = index.Tipo_DVD;
                    prestamo.Cedula_cliente = index.Cedula_cliente;
                    prestamo.Apellido_cliente = index.Apellido_cliente;
                    prestamo.Nombre_cliente = index.Nombre_cliente;
                    prestamo.MontoPagar1 = index.MontoPagar1;   

                }

            }

        }

        public void eliminar(string index)
        {


            for (int i = 0; i < listaprestamos.Count; i++)
            {
                if (listaprestamos[i].Codigoprestamo == index)
                {
                    
                    listaprestamos.RemoveAt(i);

                }
            }

           
        }






        public bool confirmarcodigo(string codigoindex)
        {
            bool confirmacion = true;

            foreach (Prestamos prestamo in listaprestamos)
            {

                if (prestamo.Codigoprestamo == codigoindex)
                {
                    confirmacion = false;

                }

            }


            return confirmacion;
        }

        public List<Prestamos> clonar()
        {

            return listaprestamos;


        }

        //base de datos

        public void escribirenbase()
        {

            XmlDocument RegistroPrestamo = new XmlDocument();

            RegistroPrestamo.Load("Datos.xml");

            XmlNode baseprestamos = RegistroPrestamo.SelectSingleNode("/registros/Prestamos");

            baseprestamos.RemoveAll();



            foreach (Prestamos Prestamoindex in listaprestamos)
            {

                XmlElement prestamo = RegistroPrestamo.CreateElement("Prestamo");

                XmlAttribute attribute = RegistroPrestamo.CreateAttribute("codigo");
                attribute.Value = Prestamoindex.Codigoprestamo;
                prestamo.Attributes.Append(attribute);

                attribute = RegistroPrestamo.CreateAttribute("fechaprestamo");
                attribute.Value = Prestamoindex.FechaPrestamo1.Date.ToString();
                prestamo.Attributes.Append(attribute);

                attribute = RegistroPrestamo.CreateAttribute("fechadevolucion");
                attribute.Value = Prestamoindex.FechaDevolucion1.Date.ToString();
                prestamo.Attributes.Append(attribute);

                attribute = RegistroPrestamo.CreateAttribute("nombre");
                attribute.Value = Prestamoindex.Nombre_cliente;
                prestamo.Attributes.Append(attribute);

                attribute = RegistroPrestamo.CreateAttribute("apellido");
                attribute.Value = Prestamoindex.Apellido_cliente;
                prestamo.Attributes.Append(attribute);

                attribute = RegistroPrestamo.CreateAttribute("cedula");
                attribute.Value = Prestamoindex.Cedula_cliente;
                prestamo.Attributes.Append(attribute);

                attribute = RegistroPrestamo.CreateAttribute("cantidad");
                attribute.Value = Convert.ToString(Prestamoindex.Cantidad);
                prestamo.Attributes.Append(attribute);

                attribute = RegistroPrestamo.CreateAttribute("tipodvd");
                attribute.Value = Prestamoindex.Tipo_DVD;
                prestamo.Attributes.Append(attribute);

                attribute = RegistroPrestamo.CreateAttribute("producto");
                attribute.Value = Prestamoindex.Producto;
                prestamo.Attributes.Append(attribute);


                attribute = RegistroPrestamo.CreateAttribute("monto");
                attribute.Value = Convert.ToString(Prestamoindex.MontoPagar1);
                prestamo.Attributes.Append(attribute);


                baseprestamos.AppendChild(prestamo);


            }

            RegistroPrestamo.Save("Datos.xml");

        }

        public void LeerRegistro()
        {
            string camino = Path.GetFullPath("Datos.xml");
            XmlDocument leer = new XmlDocument();
            leer.Load(camino);

            XmlNode baseprestamos = leer.SelectSingleNode("/registros/Prestamos");

            foreach (XmlNode prestamo in baseprestamos)
            {
                string codigoprestamo = prestamo.Attributes["codigo"].Value;

                DateTime fechaprestamo = DateTime.Parse(prestamo.Attributes["fechaprestamo"].Value);

                DateTime fechadevolucion = DateTime.Parse(prestamo.Attributes["fechadevolucion"].Value);

                string nombre = prestamo.Attributes["nombre"].Value;

                string apellido = prestamo.Attributes["apellido"].Value;

                string cedula = prestamo.Attributes["cedula"].Value;

                int cantidad = Convert.ToInt32(prestamo.Attributes["cantidad"].Value);

                string tipo = prestamo.Attributes["tipodvd"].Value;

                string producto = prestamo.Attributes["producto"].Value;

                decimal monto = Convert.ToDecimal(prestamo.Attributes["monto"].Value);


                Prestamos index = new Prestamos(fechaprestamo, fechadevolucion, nombre, apellido, cedula, producto, tipo, cantidad, monto, codigoprestamo);

                agregar(index);
            }


        }



    }
}
