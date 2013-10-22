using System;

namespace TareaHerencia
{
	public class Persona
	{
		
		public string nombre;
		public string apellido;
		public int id;
		public int telefono;
		
		
		public int ID
		{
			get
			{
				return id;
			}
			set
			{
				id = value;
			}
		}
		
		
		public string Nombre
		{
			get
			{
				return nombre;
			}
			set
			{
				nombre = value;
			}
		}
		
		public string Apellido
		{
			get 
			{
				return apellido;
			}
			set
			{
				apellido = value;
			}
		}
		
		public int Telefono
		{
			get 
			{
				return telefono;
			}
			set
			{
				telefono = value;
			}
		}
		
		public Persona (int pid, string pnombre, string papellido, int ptelefono)
		{
			id= pid;
			nombre= pnombre;
			apellido= papellido;
			telefono= ptelefono;
		}
	}
}

