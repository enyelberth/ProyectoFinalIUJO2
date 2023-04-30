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
        private string Fecha_ingreso;
        private bool Prestamo;
        private string Descripcion;

        public string producto { get => Producto; set => Producto = value; }
        public string codigo { get => Codigo; set => Codigo = value; }
        public string tipo_DVD { get => Tipo_DVD; set => Tipo_DVD = value; }
        public int cantidad { get => Cantidad; set => Cantidad = value; }
        public int año_emision { get => Año_emision; set => Año_emision = value; }
        public bool prestamo { get => Prestamo; set => Prestamo = value; }
        public string descripcion { get => Descripcion; set => Descripcion = value; }
        public string fecha_ingreso { get => Fecha_ingreso; set => Fecha_ingreso = value; }

        public DVD(string _producto, string _codigo, string _tipoDVD, int _cantidad, int _añoemision, string _añoingreso, string _mesingreso, string _diaingreso, bool _prestamo, string _descripcion  ) 
        {
            producto = _producto;
            codigo = _codigo;   
            tipo_DVD = _tipoDVD;
            codigo = _codigo;
            cantidad = _cantidad;
            año_emision = _añoemision;
            fecha_ingreso = ("" +_diaingreso + "/" + _mesingreso + "/" + _añoingreso);
            prestamo = _prestamo;
            descripcion = _descripcion;
        
        }

    }
}
