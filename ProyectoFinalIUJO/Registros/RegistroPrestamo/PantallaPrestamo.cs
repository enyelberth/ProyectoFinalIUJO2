using ProyectoFinalIUJO.Registros.RegistroClientes;
using ProyectoFinalIUJO.Registros.RegistroDVD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinalIUJO.Registros.RegistroPrestamo
{
    public partial class PantallaPrestamo : Form
    {
        ColeccionDVD Dvds = new ColeccionDVD();
        Coleccion_clientes clientes = new Coleccion_clientes();
        ColeccionePrestamos prestamos = new ColeccionePrestamos();

        List<DVD> DVDsdisponibles = new List<DVD>();
        List<Cliente> clientesdisponibles = new List<Cliente>();

        bool confirmar1 = false;
        bool confirmar2 = false;    

        

        public PantallaPrestamo()
        {
            InitializeComponent();
        }

        //metodos

        public void clonar()
        {

            DVDsdisponibles.AddRange(Dvds.clonar());
            clientesdisponibles.AddRange(clientes.clonar());


        }

        public void cargardatagrids()
        {
            foreach(DVD dvd in DVDsdisponibles)
            {

                dataGridViewproductos.Rows.Add(dvd.tipo_DVD,dvd.producto, dvd.cantidad);

            }

            foreach (Cliente cliente in clientesdisponibles)
            {

                dataGridViewclientes.Rows.Add(cliente.Nombre_Cliente, cliente.Apellido_Cliente, cliente.Cedula);
                

            }



        }

        public void limpiartxtboxes()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";

                }


            }

            confirmar1 = false;
            confirmar2 = false; 

        }



        // eventos

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PantallaPrestamo_Load(object sender, EventArgs e)
        {
            clonar();
            cargardatagrids();
            labelfechahoy.Text = DateTime.Now.Date.ToString();
        }


        private void buttonmenos_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxcantidad.Text) == 1)
            {
            }
            else
            {
                textBoxcantidad.Text = Convert.ToString(Convert.ToInt32(textBoxcantidad.Text) - 1);

            }
            
        }

        private void buttonmas_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxcantidad.Text) == Convert.ToInt32(textBoxcantidadtotal.Text))
            {
            }
            else
            {
                textBoxcantidad.Text = Convert.ToString(Convert.ToInt32(textBoxcantidad.Text) + 1);

            }
        }

        private void dataGridViewclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            confirmar1 = true; 

            textBoxnombre.Text = "";
            textBoxapellido.Text = "";
            textBoxcodigo.Text = "";

            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaseleccionada = dataGridViewclientes.Rows[e.RowIndex];

                textBoxnombre.Text = filaseleccionada.Cells[0].Value.ToString();
                textBoxapellido.Text = filaseleccionada.Cells[1].Value.ToString();
                textBoxcodigo.Text = filaseleccionada.Cells[2].Value.ToString();

            }
        }

        private void dataGridViewproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            confirmar2 = true;

            textBoxTipodvd.Text = "";
            textBoxnombreDVD.Text = "";
            textBoxcantidad.Text = "1";
            textBoxcantidadtotal.Text = "1";

            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaseleccionada = dataGridViewproductos.Rows[e.RowIndex];

                textBoxTipodvd.Text = filaseleccionada.Cells[0].Value.ToString();
                textBoxnombreDVD.Text = filaseleccionada.Cells[1].Value.ToString();
                textBoxcantidad.Text = filaseleccionada.Cells[2].Value.ToString();
                textBoxcantidadtotal.Text = filaseleccionada.Cells[2].Value.ToString();

            }
        }

        private void buttonregistrar_Click(object sender, EventArgs e)
        {
            if (confirmar2 == true && confirmar1 == true) 
            {

                string nombrecliente = textBoxnombre.Text;
                string apellidocliente = textBoxapellido.Text;
                string cedulacliente = textBoxcodigo.Text;
                string producto = textBoxnombreDVD.Text;
                string tipodvd = textBoxTipodvd.Text;
                int cantidad = Convert.ToInt32(textBoxcantidad.Text);
                DateTime fechaprestamo = DateTime.Now.Date;
                DateTime fechadevolucion = dateTimePicker1.Value.Date;

                int diferencia = (int)(fechadevolucion - fechaprestamo).TotalDays;

                if (fechaprestamo == fechadevolucion || diferencia < 4)
                {
                    MessageBox.Show("Error la fecha de devolucion debe ser por lo menos mayor a 4 dias", "Error");
                    return;

                }
                


                Prestamos index = new Prestamos(fechaprestamo, fechadevolucion, nombrecliente, apellidocliente, cedulacliente, producto, tipodvd, cantidad);
            
                prestamos.agregar(index);

                Dvds.eliminar(index.Producto, index.Tipo_DVD, index.Cantidad);

                limpiartxtboxes();
            
            }
        }

        
    }
}
