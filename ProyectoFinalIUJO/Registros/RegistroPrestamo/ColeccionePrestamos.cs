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

namespace ProyectoFinalIUJO.Registros.RegistroPrestamo
{
    class ColeccionePrestamos
    {
        abstract class Producto
        {
            protected string titulo;

            public string Titulo
            {
                get { return titulo; }
            }
        }

        class DVD : Producto
        {
            public DVD(string titulo)
            {
                this.titulo = titulo;
            }
        }

        class JuegoConsola : Producto
        {
            public JuegoConsola(string titulo)
            {
                this.titulo = titulo;
            }
        }

        class DVDpistasAudio : Producto
        {
            public DVDpistasAudio(string titulo)
            {
                this.titulo = titulo;
            }
        }

        class Cliente
        {
            private string nombre;

            public string Nombre
            {
                get { return nombre; }
            }

            public Cliente(string nombre)
            {
                this.nombre = nombre;
            }

            public override string ToString()
            {
                return nombre;
            }
        }


       


    }
}
