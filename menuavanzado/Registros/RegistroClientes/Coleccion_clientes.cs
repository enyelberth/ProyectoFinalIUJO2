using System;
using System.Collections.Generic;
using menuavanzado.Datos;
namespace menuavanzado.Datos
{

	public class Coleccion_clientes
	{
		public List<Cliente> ListaClientes;
		public Coleccion_clientes()
		{
			ListaClientes = new List<Cliente>();
		}
		public void Agregar(string nombre,string apellido,int cedula,bool sexo, DateTime fechaN, int telefonoC,int telefonoR,string correo,string direccion,DateTime fechaR)
		{
			Cliente x = new Cliente(nombre,apellido,cedula,sexo,fechaN,telefonoC,telefonoR,correo,direccion,fechaR);
			ListaClientes.Add(x);
		}
		public void Actualizar(int a, Cliente e)
		{
			foreach(Cliente s in ListaClientes)
			{
				if (s.Cedula == a)
				{
					s.Nombre_Cliente = e.Nombre_Cliente;
					s.Apellido_Cliente = e.Apellido_Cliente;
					s.Cedula = e.Cedula;
					s.Sexo = e.Sexo;
					s.FechaNacimientoCliente = e.FechaNacimientoCliente;
					s.TelefonoCelular = e.TelefonoCelular;
					s.TelefonoResidencial = e.TelefonoResidencial;
					s.CorreoElectronico = e.CorreoElectronico;
					s.Direccion = e.Direccion;
					s.FechaRegistroCliente = e.FechaRegistroCliente;
					break;
				}
			}
		}
	}
}
