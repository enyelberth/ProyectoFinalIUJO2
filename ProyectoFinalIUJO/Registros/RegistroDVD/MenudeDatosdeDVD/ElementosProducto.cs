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
    }
}
