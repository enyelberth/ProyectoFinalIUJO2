using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using menuavanzado.Datos;
using menuavanzado.Datos.Pantallas;
using menuavanzado.Registros.RegistroDVDs;

namespace menuavanzado
{
    public partial class MenuPrincipal : Form
    {
        
        encriptacion metodoecryp = new encriptacion();
        ColeccionDVD BasededatosDVD = new ColeccionDVD();
        public MenuPrincipal()
        {
            InitializeComponent();
            Btn_Cliente.Click += new EventHandler(Btn_ClienteClick);
            inicio();
        }

        

        private void BTNCerrar_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path.GetFullPath("Datos.xml"))) // nuevo codigo para encriptar lo escrito en la base de datos y borra el archivo remanente
            {
                BasededatosDVD.escribirenbase();
                metodoecryp.encriptar();

                File.Delete(Path.GetFullPath("Datos.xml"));
            }

            Application.Exit();
        }

        private void BTNMaximizarTamaño_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BTNMaximizarTamaño.Visible = false;
            BTNRestaurarTamaño.Visible = true;
        }

        private void BTNRestaurarTamaño_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BTNRestaurarTamaño.Visible = false;
            BTNMaximizarTamaño.Visible = true;
        }

        private void BTNMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        void Btn_ClienteClick(object sender, EventArgs e)
        {

        	
        	AbrirFormDescrip(new PantallaCliente());
        }
        
        void BtnDatosClienteClick(object sender, EventArgs e)
        {
        	AbrirFormDescrip(new PantallaDatosClientes());
        }
        
        
        private Form AbrirDescripcion = null;
        private void AbrirFormDescrip(Form descripcion1)
        {
            if (AbrirDescripcion != null)
                AbrirDescripcion.Close();
            AbrirDescripcion = descripcion1;
            descripcion1.TopLevel = false;
            descripcion1.FormBorderStyle = FormBorderStyle.None;
            descripcion1.Dock = DockStyle.Fill;
            PanelContenidoPrincipal.Controls.Add(descripcion1);
            PanelContenidoPrincipal.Tag = descripcion1;
            descripcion1.BringToFront();
            descripcion1.Show();
        }
        
        
        void PanelContenidoPrincipalPaint(object sender, PaintEventArgs e)
        {
        	
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormDescrip(new Registros.RegistroDVDs.RegistroDVD());




            
        }


        //esto desencripta la base de datos y si no existe la crea
        void inicio()
        {

            if (File.Exists("Datos.xml.enc"))
            {
            }
            else
            {
                XmlDocument DVDdatos = new XmlDocument();
                XmlNode registros = DVDdatos.CreateElement("registros");
                DVDdatos.AppendChild(registros);

                XmlNode DVDs = DVDdatos.CreateElement("DVDs");
                registros.AppendChild(DVDs);

                XmlNode Peliculas = DVDdatos.CreateElement("Peliculas");
                DVDs.AppendChild(Peliculas);

                XmlNode mp3 = DVDdatos.CreateElement("MP3");
                DVDs.AppendChild(mp3);

                XmlNode Juegos = DVDdatos.CreateElement("Juegos");
                DVDs.AppendChild(Juegos);

                XmlNode personas = DVDdatos.CreateElement("Personas");
                registros.AppendChild(personas);

                XmlNode prestamos = DVDdatos.CreateElement("Prestamos");
                registros.AppendChild(prestamos);

                DVDdatos.Save("Datos.xml");

                metodoecryp.encriptar();
            }
            metodoecryp.desencriptar();
            string ruta = Path.GetFullPath("Datos.xml");


            //esta linea oculta la base de datos cuando se desencripta esta oculta para que la podamos ver mientras trabajamos
            //File.SetAttributes(ruta, File.GetAttributes(ruta) | FileAttributes.Hidden);

            BasededatosDVD.leerbase();


        }
    }
}
