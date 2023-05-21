using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Xml;
using ProyectoFinalIUJO.Registros.RegistroDVD;
using System.Reflection;
using System.Media;
using System.Diagnostics;

namespace ProyectoFinalIUJO.Registros.RegistroDVD.MenudeDatosdeDVD
{
    internal partial class detallesproducto : Form
    {
		
        DVD producto;

        RegistroDVD registro = new RegistroDVD();
        ColeccionDVD DVDs = new ColeccionDVD();
        DatosDVDs datos = new DatosDVDs();
        
        SoundPlayer leer;

        public detallesproducto()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            
        }

        private void detallesproducto_Load(object sender, EventArgs e)
        {
        	if (producto.tipo_DVD == "Mp3") {
        		
        	}
          string caminoarchivo = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
		  string caminofinal = Path.Combine(caminoarchivo, "archivosmp3\\" + producto.ubicacionArchivo);
		  
			leer = new SoundPlayer(caminofinal);
        }

        public void llenardatos(DVD dvd)
        {
            producto = dvd;
            labelnombre.Text = dvd.producto;
            labelcodigo.Text = dvd.codigo;
            labeltipo.Text = dvd.tipo_DVD;
            labelañoemision.Text = Convert.ToString(dvd.año_emision);
            labelcantidad.Text = Convert.ToString(dvd.cantidad);
            labelingreso.Text = dvd.fechaingreso.ToString("dd/MM/yyyy");
            labelprestamo.Text = (dvd.prestamo == true) ? "Si" : "No";
            textBoxdescripcion.Text = dvd.descripcion;
            string camino = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string caminoarchivo = Path.Combine(camino, "imagenesdvds\\" + producto.ubicacionimagen);
            
            Bitmap imagen = new Bitmap(caminoarchivo);
            
            pictureBoxproductodetalles.BackgroundImage = imagen;
            
            

            this.Show();

            if (dvd.producto == "Doom")
            {
                buttonDemo.Visible = true;
            }
            if (dvd.tipo_DVD == "Mp3")
            {
                buttonReproducir.Visible = true;
            }

        }

        private void detallesproducto_Deactivate(object sender, EventArgs e)
        {
        	leer.Stop();
        	leer.Dispose();
            this.Close();
            
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            pictureBoxproductodetalles.BackgroundImage.Dispose();
            pictureBoxproductodetalles.BackgroundImage = null;
            
            this.Close();
            datos.eliminar(producto);
        }

        private void buttonmodificar_Click(object sender, EventArgs e)
        {
        	pictureBoxproductodetalles.BackgroundImage.Dispose();
        	pictureBoxproductodetalles.BackgroundImage = null;
        	this.Close();
            datos.modificar(producto);
        }
		
		void ButtonReproducirClick(object sender, EventArgs e)
		{
			buttonReproducir.Enabled = false;
			
			leer.Play();
		}

    }
}
