//using menuavanzado.Registros.RegistroDVDs.MenudeDatosdeDVD;
using ProyectoFinalIUJO.Registros.RegistroDVD.MenudeDatosdeDVD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace ProyectoFinalIUJO.Registros.RegistroDVD.MenudeDatosdeDVD
{
    internal partial class ElementosProducto : UserControl
    {
        DVD index;

        public ElementosProducto()
        {
            InitializeComponent();
        }

        public void adquiririnformacion(DVD dvd)
        {
            index = dvd;

            Nombreproducto = dvd.producto;

            Codigoproducto = dvd.codigo;

            cantidadproducto = Convert.ToString(dvd.cantidad);
            
            
            string camino = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string caminofinal = Path.Combine(camino, "imagenesdvds\\"+ dvd.ubicacionimagen);
            Bitmap imagen;
            try
            {
                imagen = new Bitmap(caminofinal);
            }
            catch(Exception)
            {
            	string caminonulo = Path.GetFullPath("mostrarnulo.png");
                imagen = new Bitmap(caminonulo);
                
            }
			Imagenproducto = imagen;
        }

        public void reiniciar()
        {


            index = null;


        }

       public string cantidadproducto {get {return labelcantidad.Text;} set {labelcantidad.Text = value;}}
           

        public string Nombreproducto {get {return labelproducto.Text;} set{labelproducto.Text = value;}}
      

        public Image Imagenproducto {get {return pictureBoxproducto.BackgroundImage;} set {pictureBoxproducto.BackgroundImage = value;}}
            

        

        public string Codigoproducto {	get { return labelcodigo.Text; }set { labelcodigo.Text = value; }}

        private void ElementosProducto_Click(object sender, EventArgs e)
        {
            detallesproducto indexobjeto = new detallesproducto();

            if (index != null)
            {
            	Imagenproducto = null;
            	
                indexobjeto.llenardatos(index);

            }
        }


        private void pictureBoxproducto_Click(object sender, EventArgs e)
        {
            detallesproducto indexobjeto = new detallesproducto();

            if (index != null)
            {

                indexobjeto.llenardatos(index);

            }
        }
		
		void PictureBoxproductoMouseMove(object sender, MouseEventArgs e)
		{
			
			Imagenproducto = null;
		}
		
		void LabelproductoClick(object sender, EventArgs e)
		{
			detallesproducto indexobjeto = new detallesproducto();

            if (index != null)
            {
            	Imagenproducto = null;
            	
                indexobjeto.llenardatos(index);

            }
			
		}
		
		void LabelcodigoClick(object sender, EventArgs e)
		{
			detallesproducto indexobjeto = new detallesproducto();

            if (index != null)
            {
            	Imagenproducto = null;
            	
                indexobjeto.llenardatos(index);
            }
		}
		
		void LabelcantidadClick(object sender, EventArgs e)
		{
			detallesproducto indexobjeto = new detallesproducto();

            if (index != null)
            {
            	Imagenproducto = null;
            	
                indexobjeto.llenardatos(index);
            }
		}
		
		void LabelcodigoMouseMove(object sender, MouseEventArgs e)
		{
			Imagenproducto = null;
		}
		
		void LabelcantidadMouseMove(object sender, MouseEventArgs e)
		{
			Imagenproducto = null;
		}
		
		void LabelproductoMouseMove(object sender, MouseEventArgs e)
		{
			Imagenproducto = null;
		}
    }
}
