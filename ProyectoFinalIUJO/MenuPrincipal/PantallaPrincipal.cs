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
        
        encriptacion metodoecryp = new encriptacion();
        ColeccionDVD BasededatosDVD = new ColeccionDVD();
        public MainForm()
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
           AbrirFormDescrip(new Registros.RegistroDVD.MenudeDatosdeDVD.DatosDVDs());




            
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

            // Crear 30 objetos de la clase DVD
            DVD dvd1 = new DVD("Titanic", "Pelicula", "00001", 1, 1997, new DateTime(2022, 5, 13), false, "Romance/Drama", "ruta/a/titanic.jpg");
            DVD dvd2 = new DVD("El Señor de los Anillos: El Retorno del Rey", "Pelicula", "00002", 1, 2003, new DateTime(2022, 5, 13), false, "Fantasía/Aventura", "ruta/a/senordelosanillos.jpg");
            DVD dvd3 = new DVD("The Dark Knight", "Pelicula", "00003", 1, 2008, new DateTime(2022, 5, 13), false, "Acción/Crimen", "ruta/a/thedarkknight.jpg");
            //DVD dvd4 = new DVD("Inception", "Pelicula", "00004", 1, 2010, new DateTime(2022, 5, 13), false, "Acción/Ciencia Ficción", "ruta/a/inception.jpg");
            //DVD dvd5 = new DVD("Bohemian Rhapsody", "Mp3", "00005", 1, 2018, new DateTime(2022, 5, 13), false, "Rock/Biografía", "ruta/a/bohemianrhapsody.jpg");
            //DVD dvd6 = new DVD("The Beatles - 1", "Mp3", "00006", 1, 2000, new DateTime(2022, 5, 13), false, "Rock", "ruta/a/thebeatles1.jpg");
            //DVD dvd7 = new DVD("Michael Jackson - Thriller", "Mp3", "00007", 1, 1982, new DateTime(2022, 5, 13), false, "Pop", "ruta/a/michaeljacksonthriller.jpg");
            //DVD dvd8 = new DVD("Queen - Greatest Hits", "Mp3", "00008", 1, 1981, new DateTime(2022, 5, 13), false, "Rock", "ruta/a/queengreatesthits.jpg");
            //DVD dvd9 = new DVD("Resident Evil 4", "Videojuego", "00009", 1, 2005, new DateTime(2022, 5, 13), false, "Acción/Aventura", "ruta/a/residentevil4.jpg");
            //DVD dvd10 = new DVD("The Legend of Zelda: Ocarina of Time", "Videojuego", "00010", 1, 1998, new DateTime(2022, 5, 13), false, "Aventura/Acción", "ruta/a/zeldaocarinaoftime.jpg");
            //DVD dvd11 = new DVD("Super Mario Bros.", "Videojuego", "00011", 1, 1985, new DateTime(2022, 5, 13), false, "Plataformas", "ruta/a/supermariobros.jpg");
            //DVD dvd12 = new DVD("Grand Theft Auto V", "Videojuego", "00012", 1, 2013, new DateTime(2022, 5, 13), false, "Acción/Aventura", "ruta/a/gtav.jpg");
            //DVD dvd13 = new DVD("La La Land", "Pelicula", "00013", 1, 2016, new DateTime(2022, 5, 13), false, "Comedia/Drama", "ruta/a/lalaland.jpg");
            //DVD dvd14 = new DVD("Queen - Live at Wembley '86", "Mp3", "00014", 1, 1992, new DateTime(2022, 5, 13), false, "Rock", "ruta/a/queenwembley.jpg");
            //DVD dvd15 = new DVD("Super Smash Bros. Ultimate", "Videojuego", "00015", 1, 2018, new DateTime(2022, 5, 13), false, "Lucha/Aventura", "ruta/a/supersmashbrosultimate.jpg");
            //DVD dvd16 = new DVD("The Lion King", "Pelicula", "00016", 1, 1994, new DateTime(2022, 5, 13), false, "Animación/Fantasía", "ruta/a/thelionking.jpg");
            //DVD dvd17 = new DVD("The Beatles - Abbey Road", "Mp3", "00017", 1, 1969, new DateTime(2022, 5, 13), false, "Rock", "ruta/a/thebeatlesabbeyroad.jpg");
            //DVD dvd18 = new DVD("The Witcher 3: Wild Hunt", "Videojuego", "00018", 1, 2015, new DateTime(2022, 5, 13), false, "Acción/RPG", "ruta/a/witcher3.jpg");
            //DVD dvd19 = new DVD("The Godfather", "Pelicula", "00019", 1, 1972, new DateTime(2022, 5, 13), false, "Drama/Crimen", "ruta/a/thegodfather.jpg");
            //DVD dvd20 = new DVD("Michael Jackson - Bad", "Mp3", "00020", 1, 1987, new DateTime(2022, 5, 13), false, "Pop", "ruta/a/michaeljacksonbad.jpg");
            //DVD dvd21 = new DVD("Queen - Live at the Odeon", "Mp3", "00021", 1, 2015, new DateTime(2022, 5, 13), false, "Rock", "ruta/a/queenodeon.jpg");
            //DVD dvd22 = new DVD("Assassin's Creed Odyssey", "Videojuego", "00022", 1, 2018, new DateTime(2022, 5, 13), false, "Acción/Aventura", "ruta/a/assassinscreedodyssey.jpg");
            //DVD dvd23 = new DVD("The Shawshank Redemption", "Pelicula", "00023", 1, 1994, new DateTime(2022, 5, 13), false, "Drama/Crimen", "ruta/a/shawshankredemption.jpg");
            //DVD dvd24 = new DVD("The Beatles - Sgt. Pepper's Lonely Hearts Club Band", "Mp3", "00024", 1, 1967, new DateTime(2022, 5, 13), false, "Rock", "ruta/a/thebeatlessgtpepper.jpg");
            //DVD dvd25 = new DVD("The Legend of Zelda: Breath of the Wild", "Videojuego", "00025", 1, 2017, new DateTime(2022, 5, 13), false, "Aventura", "ruta/a/zeldabreathofthewild.jpg");
            //DVD dvd26 = new DVD("The Godfather: Part II", "Pelicula", "00026", 1, 1974, new DateTime(2022, 5, 13), false, "Drama/Crimen", "ruta/a/thegodfatherpart2.jpg");
            //DVD dvd27 = new DVD("Queen - A Night at the Opera", "Mp3", "00027", 1, 1975, new DateTime(2022, 5, 13), false, "Rock", "ruta/a/queenanightattheopera.jpg");
            //DVD dvd28 = new DVD("Red Dead Redemption 2", "Videojuego", "00028", 1, 2018, new DateTime(2022, 5, 13), false, "Acción/Aventura", "ruta/a/reddeadredemption2.jpg");
            //DVD dvd29 = new DVD("The Beatles - Help!", "Mp3", "00029", 1, 1965, new DateTime(2022, 5, 13), false, "Rock", "ruta/a/thebeatleshelp.jpg");
            //DVD dvd30 = new DVD("The Last of Us Part II", "Videojuego", "00030", 1, 2020, new DateTime(2022, 5, 13), false, "Acción/Aventura", "ruta/a/thelastofuspart2.jpg");

            //// Agregar los objetos a la base de datos de DVD utilizando el método agregar()
            BasededatosDVD.agregar(dvd1);
            BasededatosDVD.agregar(dvd2);
            BasededatosDVD.agregar(dvd3);
            //BasededatosDVD.agregar(dvd4);
            //BasededatosDVD.agregar(dvd5);
            //BasededatosDVD.agregar(dvd6);
            //BasededatosDVD.agregar(dvd7);
            //BasededatosDVD.agregar(dvd8);
            //BasededatosDVD.agregar(dvd9);
            //BasededatosDVD.agregar(dvd10);
            //BasededatosDVD.agregar(dvd11);
            //BasededatosDVD.agregar(dvd12);
            //BasededatosDVD.agregar(dvd13);
            //BasededatosDVD.agregar(dvd14);
            //BasededatosDVD.agregar(dvd15);
            //BasededatosDVD.agregar(dvd16);
            //BasededatosDVD.agregar(dvd17);
            //BasededatosDVD.agregar(dvd18);
            //BasededatosDVD.agregar(dvd19);
            //BasededatosDVD.agregar(dvd20);
            //BasededatosDVD.agregar(dvd21);
            //BasededatosDVD.agregar(dvd22);
            //BasededatosDVD.agregar(dvd23);
            //BasededatosDVD.agregar(dvd24);
            //BasededatosDVD.agregar(dvd25);
            //BasededatosDVD.agregar(dvd26);
            //BasededatosDVD.agregar(dvd27);
            //BasededatosDVD.agregar(dvd28);
            //BasededatosDVD.agregar(dvd29);
            //BasededatosDVD.agregar(dvd30);


            //esta linea oculta la base de datos cuando se desencripta esta oculta para que la podamos ver mientras trabajamos
            File.SetAttributes(ruta, File.GetAttributes(ruta) | FileAttributes.Hidden);

            BasededatosDVD.leerbase();


        }
		
		void BTNCerrarClick(object sender, EventArgs e)
		{
			Close();
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
		}
    }

}
 