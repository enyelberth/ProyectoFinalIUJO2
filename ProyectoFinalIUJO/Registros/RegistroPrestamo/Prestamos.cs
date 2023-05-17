using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProyectoFinalIUJO.Registros.RegistroClientes;
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
        private static int contador = 0;
        private int id;
        private DateTime _FechaPrestamo;
        private DateTime _FechaDevolucion;
        private string _NombreCliente;
        private string Producto;
        private int MontoPagar;


        //public Prestamo(DateTime fechaPrestamo, DateTime fechaDevolucion, Cliente cliente, Item item)
        //private string
        public Prestamos(DateTime _FechaPrestamo,DateTime _FechaDevolucion,string _NombreCliente, string Producto)
        {
            this.id = ++contador;
            this._FechaPrestamo = _FechaPrestamo;
            this._FechaDevolucion = _FechaDevolucion;
            this._NombreCliente = _NombreCliente;
            this.Producto = Producto;
            this.MontoPagar = MontoPagar;
        
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
