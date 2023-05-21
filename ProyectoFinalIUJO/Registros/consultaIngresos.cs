using ProyectoFinalIUJO.Registros.RegistroPrestamo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinalIUJO.Registros
{
    public partial class consultaIngresos : Form
    {

        ColeccionePrestamos lista = new ColeccionePrestamos();
        static List<Prestamos> prestamos = new List<Prestamos>();
        decimal monto;
      

        public consultaIngresos()
        {
            InitializeComponent();
        }

        public void actualizar()
        {
            monto = 0;
            prestamos.Clear();
            prestamos.AddRange(lista.clonar());
            dataGridViewprestamos.Rows.Clear();

            foreach (Prestamos prestamo in prestamos)
            {
                if (dateTimePicker1.Value == prestamo.FechaDevolucion1)
                {
                    dataGridViewprestamos.Rows.Add(prestamo.Codigoprestamo, prestamo.FechaPrestamo1.ToString("dd/MM/yyyy"), prestamo.FechaDevolucion1.ToString("dd/MM/yyyy"), prestamo.Nombre_cliente, prestamo.Apellido_cliente, prestamo.Cedula_cliente, prestamo.Cantidad, prestamo.Tipo_DVD, prestamo.Producto, prestamo.MontoPagar1);
                    monto = monto + prestamo.MontoPagar1;
                }
            }

            labelmonto.Text = Convert.ToString(monto);

        }

        private void consultaIngresos_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            actualizar();
        }
    }
}
