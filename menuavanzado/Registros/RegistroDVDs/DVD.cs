using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuavanzado.Registros.RegistroDVDs
{
    internal class DVD
    {
        private string Producto;
        private string Codigo;
        private string Tipo_DVD;
        private int Cantidad;
        private int Año_emision;
        private int Dia_ingreso;
        private int Mes_ingreso;
        private int Año_ingreso;
        private bool Prestamo;
        private string Descripcion;
        private string Ubicacionimagen;
                 
        public string producto { get { return Producto; } set { Producto = value; } }
        public string codigo { get { return Codigo; } set { Codigo = value; } }
        public string tipo_DVD { get {return Tipo_DVD; } set { Tipo_DVD = value; } }
        public int cantidad { get { return Cantidad; } set { Cantidad = value; }}
        public int año_emision { get { return Año_emision; } set { Año_emision = value; }}
        public bool prestamo { get { return Prestamo; } set { Prestamo = value; }}
        public string descripcion { get { return Descripcion; } set { Descripcion = value; }}
        public int dia_ingreso { get { return Dia_ingreso; } set { Dia_ingreso = value; } }
        public int mes_ingreso { get { return Mes_ingreso; } set { Mes_ingreso = value; } }
        public int año_ingreso { get { return Año_ingreso; } set { Año_ingreso = value; } }
        public string ubicacionimagen { get { return Ubicacionimagen; } set { Ubicacionimagen = value; }}

        public DVD(string _producto, string _tipoDVD, int _cantidad, int _añoemision, string _añoingreso, string _mesingreso, string _diaingreso, bool _prestamo, string _descripcion)
        {
            producto = _producto;
            tipo_DVD = _tipoDVD;
            codigo = generarcodigo();
            cantidad = _cantidad;
            año_emision = _añoemision;
            dia_ingreso = Convert.ToInt32(_diaingreso);
            mes_ingreso = Convert.ToInt32(_mesingreso);
            año_ingreso = Convert.ToInt32(_añoingreso);
            prestamo = _prestamo;
            descripcion = _descripcion;


        }

        public DVD(string _producto, string _tipoDVD, string _codigo, int _cantidad, int _añoemision, string _añoingreso, string _mesingreso, string _diaingreso, bool _prestamo, string _descripcion, string _ubicacionimagen)
        {
            producto = _producto;
            tipo_DVD = _tipoDVD;
            codigo = _codigo;
            cantidad = _cantidad;
            año_emision = _añoemision;
            dia_ingreso = Convert.ToInt32(_diaingreso);
            mes_ingreso = Convert.ToInt32(_mesingreso);
            año_ingreso = Convert.ToInt32(_añoingreso);
            prestamo = _prestamo;
            descripcion = _descripcion;
            ubicacionimagen = _ubicacionimagen;
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
