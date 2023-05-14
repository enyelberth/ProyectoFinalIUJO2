using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalIUJO.Registros.RegistroDVD
{
	internal class DVD
    {
        private string Producto;
        private string Codigo;
        private string Tipo_DVD;
        private int Cantidad;
        private int Año_emision;
        private DateTime Fechaingreso;
        private bool Prestamo;
        private string Descripcion;
        private string Ubicacionimagen;
        private string UbicacionArchivo;

        public string producto { get { return Producto; } set { Producto = value; } }
        public string codigo { get { return Codigo; } set { Codigo = value; } }
        public string tipo_DVD { get {return Tipo_DVD; } set { Tipo_DVD = value; } }
        public int cantidad { get { return Cantidad; } set { Cantidad = value; }}
        public int año_emision { get { return Año_emision; } set { Año_emision = value; }}
        public bool prestamo { get { return Prestamo; } set { Prestamo = value; }}
        public string descripcion { get { return Descripcion; } set { Descripcion = value; }}
        public string ubicacionimagen { get { return Ubicacionimagen; } set { Ubicacionimagen = value; }}
        public DateTime fechaingreso { get { return Fechaingreso;} set { Fechaingreso = value; }}
        	public string ubicacionArchivo { get {return UbicacionArchivo;} set { UbicacionArchivo = value; }}

        public DVD(string _producto, string _tipoDVD, string _codigo, int _cantidad, int _añoemision, DateTime _fechaingreso, bool _prestamo, string _descripcion, string _ubicacionimagen)
        {
            producto = _producto;
            tipo_DVD = _tipoDVD;
            codigo = _codigo;
            cantidad = _cantidad;
            año_emision = _añoemision;
            fechaingreso = _fechaingreso;
            prestamo = _prestamo;
            descripcion = _descripcion;
            ubicacionimagen = _ubicacionimagen;
        }

        public DVD(string _producto, string _tipoDVD, string _codigo, int _cantidad, int _añoemision, DateTime _fechaingreso, bool _prestamo, string _descripcion, string _ubicacionimagen, string _ubicacionarchivo)
        {
            producto = _producto;
            tipo_DVD = _tipoDVD;
            codigo = _codigo;
            cantidad = _cantidad;
            año_emision = _añoemision;
            fechaingreso = _fechaingreso;
            prestamo = _prestamo;
            descripcion = _descripcion;
            ubicacionimagen = _ubicacionimagen;
            ubicacionArchivo = _ubicacionarchivo;


        }

        string generarcodigo()
        {
            string resultado;
            bool continuar = false;
            ColeccionDVD revisar = new ColeccionDVD();

            do
            {
                Random codigo = new Random();
                resultado = Convert.ToString(codigo.Next(10000, 99999));
                continuar = revisar.confirmarcodigo(resultado);

            } while (continuar != true);

            return resultado;
        }
    }
}
