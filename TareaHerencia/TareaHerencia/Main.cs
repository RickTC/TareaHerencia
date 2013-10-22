using System;

namespace TareaHerencia
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Alumno alumno = new Alumno( 209514538,"Ricardo","Tapia",3314864958);
		//	Persona persona = new Persona();
			
			alumno.datos();
			alumno.muestra();
		}
	}
}
