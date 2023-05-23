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
        Coleccion_clientes coleccion = new Coleccion_clientes();

        public PantallaCliente()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
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
					Int64 cedula;
					cedula = Convert.ToInt64(inputCedula.Text);
					bool sexo;
				if(radioButton1.Checked==true)
				{
					sexo= true;
				}
				else
				{
					sexo=false;
				}
                //int.Parse(InputTelefonoCelular.Text);
                
					DateTime fechaN = new DateTime();
                    fechaN = DateTime.Parse(InputFechaNacimiento.Value.ToString());
                    Int64 telefonoC = Convert.ToInt64(InputTelefonoCelular.Text);
                    Int64 telefonoR = Convert.ToInt64(InputTelefonoResidencial.Text); ;
					string correo = inputCorreo.Text;
					string direccion = InputDireccion.Text;
                    string Sexo;
                    Sexo = (sexo == true ? "Masculino" : "Femenino");
                
                // string sexooo = "Masculino";
                    DateTime fechaR = new DateTime();
                    fechaR = DateTime.Today;


                    Cliente index1 = new Cliente(nombre, apellido, cedula, Sexo, fechaN, telefonoC, telefonoR, correo, direccion, fechaR);

					coleccion.agregar(index1);

					limpiartextboxes();
					
				}
		}

        public void limpiartextboxes()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }

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
		if(inputCedula.Text.Length >= 8)
			{
				e.Handled = true;

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
			if(InputTelefonoCelular.Text.Length >= 11)
			{
				e.Handled = true;	

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
			if (InputTelefonoResidencial.Text.Length >= 11)
			{


				e.Handled = true;
			}
		}

        private void PantallaCliente_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Registro_Click(object sender, EventArgs e)
        {

        }
		
		void InputNombreTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void InputApellidoTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void InputCedulaTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}

        private void InputDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void InputTelefonoCelular_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
