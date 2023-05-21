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
    public partial class Consultadeprestamos : Form
    {
        ColeccionePrestamos prestamos = new ColeccionePrestamos();

        public List<Prestamos> lista = new List<Prestamos>(); 

        public Consultadeprestamos()
        {
            InitializeComponent();
        }

        private void Consultadeprestamos_Load(object sender, EventArgs e)
        {
            actualizardatagrid();
        }

        public void actualizardatagrid()
        {
            lista.Clear();

            lista.AddRange(prestamos.clonar());

            dataGridViewprestamos.Rows.Clear();

            foreach (Prestamos prestamo in lista)
            {
                
                dataGridViewprestamos.Rows.Add(prestamo.Codigoprestamo, prestamo.FechaPrestamo1.ToString("dd/MM/yyyy"), prestamo.FechaDevolucion1.ToString("dd/MM/yyyy"), prestamo.Nombre_cliente, prestamo.Apellido_cliente, prestamo.Cedula_cliente, prestamo.Cantidad, prestamo.Tipo_DVD, prestamo.Producto, prestamo.MontoPagar1);

            }


        }

        private void dataGridViewprestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttoneliminar.Visible = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaseleccionada = dataGridViewprestamos.Rows[e.RowIndex];

                textBoxcodigo.Text = filaseleccionada.Cells[0].Value.ToString(); 
                dateTimePicker1.Value = DateTime.Parse(filaseleccionada.Cells[1].Value.ToString());
                dateTimePicker2.Value = DateTime.Parse(filaseleccionada.Cells[2].Value.ToString());
                textboxnombrecliente.Text = filaseleccionada.Cells[3].Value.ToString();
                textBoxapellidocliente.Text = filaseleccionada.Cells[4].Value.ToString();
                textBoxcedulacliente.Text = filaseleccionada.Cells[5].Value.ToString();
                textBoxcantidad.Text = Convert.ToString(filaseleccionada.Cells[6].Value.ToString());
                textBoxtipoDVD.Text = filaseleccionada.Cells[7].Value.ToString();
                textBoxproducto.Text = filaseleccionada.Cells[8].Value.ToString();

            }
        }

        private void buttonmodificar_Click(object sender, EventArgs e)
        {
            

        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            prestamos.eliminar(textBoxcodigo.Text);

            MessageBox.Show("Prestamo eliminado");

            actualizardatagrid();
        }




        //base de datos
    }
}
