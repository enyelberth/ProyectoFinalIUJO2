using ProyectoFinalIUJO.Registros.RegistroClientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace ProyectoFinalIUJO.Registros.RegistroClientes
{
	
	public partial class PantallaDatosClientes : Form
	{
			Coleccion_clientes clientes = new Coleccion_clientes();
		public static List<Cliente> clienteRegistrado = new List<Cliente>();
			
			
		public PantallaDatosClientes()
		{
			
		
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
            cargarDatosRegistro();
//			DataSet midata = new DataSet();
//			midata.ReadXml("Datos.xml");
			//Base_D = new midata.Tables[0];
			
			

			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
       public void clonar()
        {

            //clienteRegistrado.AddRange(.clonar());
            clienteRegistrado.AddRange(clientes.clonar());


        }
	

		
		public void cargarDatosRegistro()
		{
			
			clienteRegistrado.AddRange(clientes.clonar());
			
			foreach (Cliente cliente in clienteRegistrado)
            {
				MessageBox.Show("sadasdasdaas");
				//			int n = 10;

                Base_D.Rows.Add(cliente.Nombre_Cliente, cliente.Apellido_Cliente, cliente.Cedula,cliente.Sexo,cliente.FechaNacimientoCliente,cliente.TelefonoCelular,cliente.TelefonoResidencial,cliente.CorreoElectronico,cliente.Direccion,cliente.FechaRegistroCliente);
             //   Base_D.Rows.Add("easudji");
             //Base_D.Rows[n].Cells[0].Value=cliente.Nombre_Cliente;

            }
			
		
		}
		       private void cargarDatosRegistro(object sender, EventArgs e)
        {
            clonar();
            cargarDatosRegistro();

           // cargardatagrids();
            //labelfechahoy.Text = DateTime.Now.Date.ToString();
        }


		
		void Base_DCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
	}
}
