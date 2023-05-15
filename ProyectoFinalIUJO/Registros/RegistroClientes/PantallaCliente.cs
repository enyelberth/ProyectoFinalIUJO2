using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinalIUJO.Registros.RegistroClientes
{
/// <summary>
	/// Description of PantallaCliente.
	/// </summary>
	public partial class PantallaCliente : Form
	{
		Coleccion_clientes x;
    	
		public PantallaCliente()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			x = new Coleccion_clientes();
			
			Btn_Registro.Click += new EventHandler(Btn_RegistroCliente);
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Btn_RegistroCliente(object sender, EventArgs e)
		{
			
			if(string.IsNullOrEmpty(InputNombre.Text)||string.IsNullOrEmpty(inputApellido.Text)||string.IsNullOrEmpty(inputCedula.Text)||string.IsNullOrEmpty(InputTelefonoCelular.Text)||string.IsNullOrEmpty(InputTelefonoResidencial.Text)||string.IsNullOrEmpty(inputCorreo.Text)||string.IsNullOrEmpty(InputDireccion.Text))
			{
				if(string.IsNullOrEmpty(InputNombre.Text))
				{
						MessageBox.Show("El campo Nombre no puede estar vacio");
				}
				if(string.IsNullOrEmpty(inputApellido.Text))
				{
						MessageBox.Show("El campo Apellido no puede estar vacio");
				}
				
				if(string.IsNullOrEmpty(inputCedula.Text))
				{
						MessageBox.Show("El campo de Cedula no puede estar vacio");
				}
				
				if(string.IsNullOrEmpty(InputTelefonoCelular.Text))
				{
						MessageBox.Show("El campo de Telefono Celular no puede estar vacio");
				}
				
				if(string.IsNullOrEmpty(InputTelefonoResidencial.Text))
				{
						MessageBox.Show("El campo de Telefono Residencial no puede estar vacio");
				}
				
				if(string.IsNullOrEmpty(inputCorreo.Text))
				{
						MessageBox.Show("El campo de Correo electronico no puede estar vacio");
				}
				
				if(string.IsNullOrEmpty(InputDireccion.Text))
				{
						MessageBox.Show("El campo de direccion no puede estar vacio");
				}
	
						
				}
				else
				{
					string nombre = InputNombre.Text;
					string apellido = inputApellido.Text;
					int cedula;
					cedula = int.Parse(inputCedula.Text);
					bool sexo;
				if(radioButton1.Checked==true)
				{
					sexo= true;
				}
				else
				{
					sexo=false;
				}
					DateTime fechaN = new DateTime(2015, 10,31); 
					int telefonoC = int.Parse(InputTelefonoCelular.Text);
					int telefonoR = int.Parse(InputTelefonoResidencial.Text);
					string correo = inputCorreo.Text;
					string direccion = InputDireccion.Text;
					DateTime fechaR = new DateTime(2022, 10,31);
	

					x.Agregar(nombre,apellido,cedula,sexo,fechaN,telefonoC,telefonoR,correo,direccion,fechaR);
					MessageBox.Show("Funciona el boton");
					
				}
		}
		
		void InputCorreoTextChanged(object sender, EventArgs e)
		{
			
		}
		private void txtCaracter_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
			{
    	  		MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    	  		e.Handled = true;
    	  		return;
			}
        }
		
		void InputCedulaKeyPress(object sender, KeyPressEventArgs e)
		{
		if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
		{
    	  MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
   		   e.Handled = true;
    	  return;
		}
		
			
		}
		
		void InputNombreKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
				{
      				MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      				e.Handled = true;
      				return;
				}
		}
		
		void InputApellidoKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
				{
      				MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      				e.Handled = true;
      				return;
				}
			
		}
		
		void InputTelefonoCelularKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
			{
    	  		MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
   		  		 e.Handled = true;
    	  		return;
			}
			
		}
		

		
		void InputTelefonoResidencialKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
			{
    	  		MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
   		  		 e.Handled = true;
    	  		return;
			}
		}

        private void PantallaCliente_Load(object sender, EventArgs e)
        {

        }
	}
}
