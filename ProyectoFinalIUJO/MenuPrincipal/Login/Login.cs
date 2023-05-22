using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using ProyectoFinalIUJO.Registros;
using ProyectoFinalIUJO.Registros.RegistroDVD;
using ProyectoFinalIUJO;
using ProyectoFinalIUJO.Registros.RegistroClientes;
using ProyectoFinalIUJO.Registros.RegistroDVD.MenudeDatosdeDVD;
using ProyectoFinalIUJO.Registros.RegistroPrestamo;
using ProyectoFinalIUJO.MenuPrincipal;

namespace ProyectoFinalIUJO.MenuPrincipal.Login
{
	/// <summary>
	/// Description of Login.
	/// </summary>
	public partial class Login : Form
	{
		public Login()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			

			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			Close();
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "Nobmaster" && textBox2.Text == "123456") 
			{
    			// Abrir formulario secundario
    			
    			//Application.Run(new);
    			MainForm pantalla = new MainForm();
				pantalla.Show();
				this.Hide();
			}else {
    			// Mostrar mensaje de error
    			MessageBox.Show("El Usuario o la contraseña son incorrectos");
    			textBox2.Text = "";
    			textBox1.Text = "";
				}
//			MainForm pantalla = new MainForm();
//			pantalla.Show();

			
			
		}
		

	}
}
