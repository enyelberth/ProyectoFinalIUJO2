using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProyectoFinalIUJO.Registros.RegistroClientes;
using ProyectoFinalIUJO.Registros.RegistroDVD;

namespace ProyectoFinalIUJO.Registros.RegistroPrestamo
{
    public class Prestamos
    {
        /*
         registro de Préstamos, en el que se lleva los datos concernientes
         * al préstamo del DVD que va a llevar el cliente en un momento dado, 
         * y en el que se registra por cada película en DVD un monto de 2 $ por 3 días
         * , cada juego en cónsola 2 $ por 4 días y 2 $ por cada DVD de pistas de audio po
         * r una semana. dando un monto total que deberá pagar el cliente al momento del registro.
         */
        private int cantidad;
        private string producto;
        private string tipo_DVD;
        private DateTime FechaPrestamo;
        private DateTime FechaDevolucion;
        private string nombre_cliente;
        private string apellido_cliente;
        private string cedula_cliente;
        private decimal MontoPagar;
        private string codigoprestamo;

        public int Cantidad { get {return cantidad;} set {cantidad = value; }}
        public string Producto { get {return producto;} set { producto = value; }}
        public string Tipo_DVD { get {return tipo_DVD;} set { tipo_DVD = value; }}
        public DateTime FechaPrestamo1 { get {return FechaPrestamo;} set { FechaPrestamo = value; }}
        public DateTime FechaDevolucion1 { get {return FechaDevolucion;} set { FechaDevolucion = value; }}
        public string Nombre_cliente { get {return nombre_cliente;} set { nombre_cliente = value; }}
        public string Apellido_cliente { get {return apellido_cliente;} set { apellido_cliente = value; }}
        public string Cedula_cliente { get {return cedula_cliente;} set { cedula_cliente = value; }}
        public decimal MontoPagar1 { get {return MontoPagar;} set { MontoPagar = value; }}
        public string Codigoprestamo { get {return codigoprestamo;} set { codigoprestamo = value; }}

        public Prestamos(DateTime _FechaPrestamo, DateTime _FechaDevolucion, string _NombreCliente, string apellidocliente, string cedula, string producto, string tipoDVD, int _cantidad)
        {
            Cantidad = _cantidad;

            Producto = producto;

            Tipo_DVD = tipoDVD;

            FechaPrestamo1 = _FechaPrestamo;

            FechaDevolucion = _FechaDevolucion;

            Nombre_cliente = _NombreCliente;

            Apellido_cliente = apellidocliente;

            Cedula_cliente = cedula;

            MontoPagar1 = calcularmonto(_FechaPrestamo, _FechaDevolucion, _cantidad, tipo_DVD);

            Codigoprestamo = generarcodigo();

        }

        public Prestamos(DateTime _FechaPrestamo, DateTime _FechaDevolucion, string _NombreCliente, string apellidocliente, string cedula, string producto, string tipoDVD, int _cantidad, decimal monto, string codigo)
        {
            Cantidad = _cantidad;

            Producto = producto;

            Tipo_DVD = tipoDVD;

            FechaPrestamo1 = _FechaPrestamo;

            FechaDevolucion = _FechaDevolucion;

            Nombre_cliente = _NombreCliente;

            Apellido_cliente = apellidocliente;

            Cedula_cliente = cedula;

            MontoPagar1 = monto;

            Codigoprestamo = codigo;

        }

        public string generarcodigo()
        {
            string resultado;
            bool continuar = false;
            ColeccionePrestamos prestamos = new ColeccionePrestamos();
            do
            {
                Random codigo = new Random();
                resultado = Convert.ToString(codigo.Next(10000, 99999));
                continuar = prestamos.confirmarcodigo(resultado);

            } while (continuar != true);

            return resultado;
        }

        // acomodar el decimal que sale de aqui ojo

        public decimal calcularmonto(DateTime fecha_prestamo, DateTime fecha_devolucion, int cantidad, string tipo_dvd)
        {
            decimal monto = 0.00M;
            int diferencia = 0;
            decimal dias;

            diferencia = (int)(fecha_devolucion - fecha_prestamo).TotalDays;
            if(diferencia == 0) diferencia = 1;

            if (tipo_dvd == "Mp3")
            {
                dias = diferencia / 7;


                if (dias == 0) dias = 1;

                monto = (dias * 2) * cantidad;

                MessageBox.Show(Convert.ToString(monto));

            }
            else if (tipo_dvd == "Pelicula")
            {
                dias = diferencia / 3;

                if (dias == 0) dias = 1;

                monto = (dias * 2) * cantidad;

            }
            else if (tipo_dvd == "Videojuego")
            {
                dias = diferencia / 4;

                if (dias == 0) dias = 1;

                monto = (dias * 2) * cantidad;

            }

            return monto;
        }

        

        /*
private decimal CalcularMontoAPagar()
{
decimal montoAPagar = 0;

//if (Producto is DVD)
if (Producto)
{
int duracion = (_FechaDevolucion - _FechaPrestamo).Days;
MontoPagar = 2 * (duracion / 3);

if (duracion % 3 != 0)
{
MontoPagar += 2;
}
}
else if (Producto is JuegoConsola)
{
int duracion = (_FechaDevolucion - _FechaPrestamo).Days;
MontoPagar = 2 * (duracion / 4);

if (duracion % 4 != 0)
{
MontoPagar += 2;
}
}
else if (Producto is DVDpistasAudio)
{
int duracion = (_FechaDevolucion - _FechaPrestamo).Days;
MontoPagar = 2 * (duracion / 7);

if (duracion % 7 != 0)
{
MontoPagar += 2;
}
}

return MontoPagar;
}
* */


    }
}
