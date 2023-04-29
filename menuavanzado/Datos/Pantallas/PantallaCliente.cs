/*
 * Creado por SharpDevelop.
 * Usuario: enyelberth
 * Fecha: 28/4/2023
 * Hora: 6:32 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace menuavanzado.Datos.Pantallas
{
	/// <summary>
	/// Description of PantallaCliente.
	/// </summary>
	public partial class PantallaCliente : Form
	{
		Colecciones x;
    	
		public PantallaCliente()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			x = new Colecciones();
			
			Btn_Registro.Click += new EventHandler(Btn_RegistroCliente);
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Btn_RegistroCliente(object sender, EventArgs e)
		{
			string nombre = InputNombre.Text;
			string apellido = inputApellido.Text;
			int cedula = Convert.ToInt32(inputCedula.Text);
			bool sexo = true;
			DateTime fechaN = new DateTime(2015, 10,31); 
			int telefonoC = Convert.ToInt32(InputTelefonoCelular.Text);
			int telefonoR = Convert.ToInt32(InputTelefonoResidencial.Text);
			string correo = inputCorreo.Text;
			string direccion = InputDireccion.Text;
			DateTime fechaR = new DateTime(2022, 10,31);
			x.Agregar(nombre,apellido,cedula,sexo,fechaN,telefonoC,telefonoR,correo,direccion,fechaR);
				MessageBox.Show("Funciona el boton");
		}
		
		void InputCorreoTextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
