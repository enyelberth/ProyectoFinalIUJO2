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
using ProyectoFinalIUJO.Registros;
using ProyectoFinalIUJO.Registros.RegistroDVD;
using ProyectoFinalIUJO;
using ProyectoFinalIUJO.Registros.RegistroClientes;
using ProyectoFinalIUJO.Registros.RegistroDVD.MenudeDatosdeDVD;
//using ProyectoFinalIUJO.Datos.Pantallas;
//using ProyectoFinalIUJO.Registros.RegistroDVDs;

namespace ProyectoFinalIUJO
{
    
    
	public partial class MainForm : Form
    {
        public Panel panelcontenido = new Panel();
        encriptacion metodoecryp = new encriptacion();


        ColeccionDVD BasededatosDVD = new ColeccionDVD();
        Coleccion_clientes Basededatoscliente = new Coleccion_clientes();
        public MainForm()
        {
            InitializeComponent();
           // Btn_Cliente.Click += new EventHandler(Btn_ClienteClick);
            inicio();
        }

        

        private void BTNCerrar_Click_1(object sender, EventArgs e)
        {
            if (File.Exists(Path.GetFullPath("Datos.xml"))) // nuevo codigo para encriptar lo escrito en la base de datos y borra el archivo remanente
            {
                BasededatosDVD.escribirenbase();
                Basededatoscliente.escribirenbase();
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
        public void AbrirFormDescrip(Form descripcion1)
        {
            if (AbrirDescripcion != null)
                AbrirDescripcion.Close();
            AbrirDescripcion = descripcion1;
            descripcion1.TopLevel = false;
            descripcion1.FormBorderStyle = FormBorderStyle.None;
            descripcion1.Dock = DockStyle.Fill;
            panelcontenido.Controls.Add(descripcion1);
            panelcontenido.Tag = descripcion1;
            descripcion1.BringToFront();
            descripcion1.Show();
        }
        
        
        void PanelContenidoPrincipalPaint(object sender, PaintEventArgs e)
        {
        	
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

            //esta linea oculta la base de datos cuando se desencripta, esta oculta para que la podamos ver mientras trabajamos
            //File.SetAttributes(ruta, File.GetAttributes(ruta) | FileAttributes.Hidden);

            BasededatosDVD.leerbase();
            Basededatoscliente.LeerRegistro();


        }

        // Botones de los modulos
    

        private void Btn_Registro_DVD_Click(object sender, EventArgs e)
        {
            AbrirFormDescrip(new Registros.RegistroDVD.RegistroDVD());
        }

        private void Btn_Gestion_DVD_Click(object sender, EventArgs e)
        {
            AbrirFormDescrip(new Registros.RegistroDVD.MenudeDatosdeDVD.DatosDVDs());
        }

        private void Btn_Registro_Cliente_Click(object sender, EventArgs e)
        {
            AbrirFormDescrip(new Registros.RegistroClientes.PantallaCliente());
        }

        private void Btn_Datos_Cliente_Click(object sender, EventArgs e)
        {
            AbrirFormDescrip(new Registros.RegistroClientes.PantallaDatosClientes());
        }

        private void Btn_Registro_Prestamo_Click(object sender, EventArgs e)
        {
            AbrirFormDescrip(new Registros.RegistroPrestamo.PantallaPrestamo());
        }

        private void Btn_Consulta_Prestamos_Click(object sender, EventArgs e)
        {
            AbrirFormDescrip(new Registros.RegistroPrestamo.Consultadeprestamos());
        }

        private void Btn_Consulta_Ingresos_Click(object sender, EventArgs e)
        {
            AbrirFormDescrip(new Registros.consultaIngresos());
        }


        
    }

}
 