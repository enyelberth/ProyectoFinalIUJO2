﻿/*
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
			int cedula;
			cedula = int.Parse(inputCedula.Text);
			bool sexo;
			if(radioButton1.Checked=true)
			{
				sexo= true;
			}else{
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
		
		void InputCedulaValidated(object sender, EventArgs e)
		{
	
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
	}
}
