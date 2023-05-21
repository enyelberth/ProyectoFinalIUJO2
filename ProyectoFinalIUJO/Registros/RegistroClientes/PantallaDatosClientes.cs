
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ProyectoFinalIUJO.Registros.RegistroClientes
{
	
	public partial class PantallaDatosClientes : Form
	{
		public PantallaDatosClientes()
		{
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			
			Coleccion_clientes colecciocliente = new Coleccion_clientes();
						List<Cliente> ListaClientees = new List<Cliente>();
						
						
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PantallaDatosClientesLoad(object sender, EventArgs e)
		{
			
		}
		
		void Base_DCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
	}
}
