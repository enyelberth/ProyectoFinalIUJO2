﻿using System;
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

            Rectangle rect = this.RectangleToScreen(this.ClientRectangle);
            Cursor.Clip = rect;
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
            if (dvd.producto == "Age of empires")
            {
                buttonDemo.Visible = true;

            }
            if (dvd.producto == "Plantas vs zombies")
            {
                buttonDemo.Visible = true;

            }
            //if (dvd.producto == "Half life")
            //{
            //    buttonDemo.Visible = true;

            //}
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
            datos.modificar(producto);
            this.Close();
        }
		
		void ButtonReproducirClick(object sender, EventArgs e)
		{
            try
            {


                buttonReproducir.Enabled = false;

                leer.Play();
            }
            catch(Exception)
            {
                MessageBox.Show("No se pudo reproducir el arhivo, es posible que haya sido eliminado o actualize la lista de articulos");
            }
		}

        private void detallesproducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cursor.Clip = Rectangle.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            leer.Stop();
            leer.Dispose();
            this.Close();
        }

        private void buttonDemo_Click(object sender, EventArgs e)
        {
            try
            {


                string caminocarpeta = Path.GetFullPath(Assembly.GetEntryAssembly().Location);
                string caminoarchivo;

                if (labelnombre.Text == "Doom")
                {
                    caminoarchivo = "Demos\\doom\\Launch The Ultimate DOOM";
                    Process.Start(caminoarchivo);

                }
                if (labelnombre.Text == "Age of empires")
                {
                    caminoarchivo = "Demos\\age\\empires";
                    Process.Start(caminoarchivo);

                }
                if (labelnombre.Text == "Plantas vs zombies")
                {
                    caminoarchivo = "Demos\\pvz\\Plants";
                    Process.Start(caminoarchivo);

                }
                //if (labelnombre.Text == "Half life")
                //{
                //    caminoarchivo = "Demos\\halflife\\halflife";
                //    Process.Start(caminoarchivo);

                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo correr la prueba, es probable que no exista el archivo o que no se ha actualizado la lista de articulos, detalles: " + ex.Message);
            }
        }
    }
}
