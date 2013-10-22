using System;

namespace TareaHerencia
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Alumno alumno = new Alumno( 209,"Ricardo","Tapia",33148);
			//Persona persona = new Persona(236,"Porfirio","Cervantes",32569);
			
			
			
			Console.WriteLine("CLASS ALUMNO");
			Console.WriteLine("ID: "+ alumno.id);
			Console.WriteLine("Nombre: "+ alumno.nombre);
			Console.WriteLine("Apellido: "+alumno.apellido);
			Console.WriteLine("Telefono: "+alumno.telefono);
			/*Console.WriteLine("CLASS PERSONA");
			Console.WriteLine("ID: "+ persona.id);
			Console.WriteLine("Nombre: "+ persona.nombre);
			Console.WriteLine("Apellido: "+ persona.apellido);
			Console.WriteLine("Telefono: "+persona.telefono);*/
			
			
		}
	}
}
