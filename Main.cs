using System;

namespace practica3
{
	class MainClass
	{
		public static void Main (string[] args)
		{

	     Desarrollo desarrollo  =  new Desarrollo ();
			desarrollo. capturar ();
			Console . Clear ();
			desarrollo . editar ();
			Console .Clear ();
			desarrollo . eliminar ();
			Console . Clear ();
		    desarrollo . imprimirTodos ();
		}
	}
}
