using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using menuavanzado.Datos;
using menuavanzado.Datos.Pantallas;

namespace menuavanzado
{
    public partial class Form1 : Form
    {
  
    
        public Form1()
        {
            InitializeComponent();
            Btn_Cliente.Click += new EventHandler(Btn_ClienteClick);
        }

        private void BTNCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTNMaximizarTamaño_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BTNMaximizarTamaño.Visible = false;
            BTNRestaurarTamaño.Visible = true;
        }

        private void BTNRestaurarTamaño_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BTNRestaurarTamaño.Visible = false;
            BTNMaximizarTamaño.Visible = true;
        }

        private void BTNMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        void Btn_ClienteClick(object sender, EventArgs e)
        {

        	
        	AbrirFormDescrip(new PantallaCliente());
        }
        
        void BtnDatosClienteClick(object sender, EventArgs e)
        {
        	AbrirFormDescrip(new PantallaDatosClientes());
        }
        
        
        private Form AbrirDescripcion = null;
        private void AbrirFormDescrip(Form descripcion1)
        {
            if (AbrirDescripcion != null)
                AbrirDescripcion.Close();
            AbrirDescripcion = descripcion1;
            descripcion1.TopLevel = false;
            descripcion1.FormBorderStyle = FormBorderStyle.None;
            descripcion1.Dock = DockStyle.Fill;
            PanelContenidoPrincipal.Controls.Add(descripcion1);
            PanelContenidoPrincipal.Tag = descripcion1;
            descripcion1.BringToFront();
            descripcion1.Show();
        }
        
        
        void PanelContenidoPrincipalPaint(object sender, PaintEventArgs e)
        {
        	
        }
    }
}
