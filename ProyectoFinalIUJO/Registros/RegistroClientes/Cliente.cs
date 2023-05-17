using System;

namespace ProyectoFinalIUJO.Registros.RegistroClientes
{
	public class Cliente
	{
				//Datos del clientes
		private string _nombreCliente;
		private string _apellidoCliente;
		private int _cedulaCliente;
		private bool _sexoCliente;
		private DateTime _fechaNacimiento_cliente;
		private int _telefonoCelular;
		private int _telefonoResidencial;
		private string _correoElectronico;
		private string _direccionHabitación;
		private DateTime _fechaRegistro_cliente;
		

		

		
		public string Nombre_Cliente {get {return _nombreCliente;} set {_nombreCliente = value;}}
		public string Apellido_Cliente {get {return _apellidoCliente;} set {_apellidoCliente = value;}}
		public int Cedula{get {return _cedulaCliente;} set {_cedulaCliente = value;}}
		public bool Sexo{get {return _sexoCliente;} set {_sexoCliente = value;}}
		public DateTime FechaNacimientoCliente {get {return _fechaNacimiento_cliente;} set {_fechaNacimiento_cliente= value;}}
		public int TelefonoCelular {get {return _telefonoCelular;} set {_telefonoCelular = value;}}
		public int TelefonoResidencial {get {return _telefonoResidencial;} set {_telefonoResidencial = value;}}
		public string CorreoElectronico {get {return _correoElectronico;} set {_correoElectronico = value;}}
		public string Direccion {get {return _direccionHabitación;} set {_direccionHabitación = value;}}
		public DateTime FechaRegistroCliente {get {return _fechaRegistro_cliente;} set {_fechaRegistro_cliente = value;}}
		
		public Cliente(string nombre,string apellido,int cedula,bool sexo, DateTime fechaN, int telefonoC,int telefonoR,string correo,string direccion,DateTime fechaR)
		{
			this._nombreCliente = nombre;
			this._apellidoCliente = apellido;
			this._cedulaCliente = cedula;
			this._sexoCliente = sexo;
			this._fechaNacimiento_cliente = fechaN;
			this._telefonoCelular = telefonoC;
			this._telefonoResidencial = telefonoR;
			this._correoElectronico = correo;
			this._direccionHabitación = direccion;
			this._fechaRegistro_cliente = fechaR;
		}
       
	}
}
