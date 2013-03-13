using System ;
using System.Collections ;
namespace practica3
{
     class Desarrollo
	{		
		private  Hashtable  tabla ;

		public Desarrollo () {
			this.tabla  =  new Hashtable ();
		}

		public void capturar () {
			for ( int i  =  0 ;  i < 4  ; i++)
			     {
				Console.Clear();
				this.capturarDatosPersona ( new Persona ());
			}
		}

		public void  capturarDatosPersona ( Persona  persona ) {
			this. capturarDatos ( persona );
			this. agregarPersona ( persona );


		}

		private void  capturarDatos ( Persona  persona ) {
			Console . WriteLine ( "CAPTURAR LOS DATOS DE LA PERSONA" );
			if ( persona . codigo  ==  "" ) {
				Console. WriteLine ( "Introduzca el Código" );
				persona . codigo  =  Console . ReadLine ();
			}

			Console . WriteLine ( "Introduzca el nombre" );
			persona . Nombre  =  Console. ReadLine ();
			Console . WriteLine ( "Introduzca la dirección" );
			persona . direccion  =  Console. ReadLine ();
			Console . WriteLine ( "Intoduzca el teléfono" );
			persona . telefono  =  Console . ReadLine ();
			Console . WriteLine ( "Introduzca el facebook" );
			persona . facebook  =  Console . ReadLine ();
		}

		private  void agregarPersona ( Persona  persona ) {			
			if( this.tabla.ContainsKey(persona.codigo)) {
				this . tabla.Remove (persona.codigo);
			}

			this . tabla . Add (persona . codigo , persona );
		}

		public void  editar () {
			for( int  i  =  0 ;  i  <  2 ; i++){
				Console .Clear ();
				string  codigo  =  "" ;
				Console. WriteLine ( "Código a Editar" );
				codigo  =  Console. ReadLine ();
				if( this. tabla . ContainsKey ( codigo )) {
					Persona  persona  =  ( Persona ) this . tabla [ codigo ];
					this . imprimePersona ( persona );
					this. capturarDatosPersona ( persona );
				} else {
					this. imprimeError ();
				}
			}
		}

		public void eliminar () {
			for ( int  i  =  0 ;  i  <  2 ;  i++) {
				Console .Clear ();
				string  codigo  =  "" ;
				Console . WriteLine ( "Código pára eliminar" );
				codigo  =  Console . ReadLine ();
				if( this . tabla . ContainsKey ( codigo )) {
					Persona  persona  =  ( Persona )  this . tabla [ codigo ];
					this. imprimePersona ( persona );
					this . confirmareliminado( persona . codigo );
				} else{
					this . imprimeError ();
				}
			}
		}

		private  void confirmareliminado ( string  codigo ) {
			Console . WriteLine ( "¿Seguro Que eliminar ?" );
			Console . WriteLine ( "0 = No, 1 = Si" );
			String  opcion  =  Console. ReadLine ();
			if ( opcion  !=  "0" ) {
				this. tabla . Remove ( codigo );
			}
		}

		private  void  imprimeError () {
			Console . WriteLine ( "No existe el Código." );
			Console . WriteLine ( "Presione Cualquier Tecla, pára Continuar");
			Console . ReadLine ();
		}

		public void imprimirTodos () {
			ICollection  personas =  this.tabla.Values;

	        Console . WriteLine ();
	       foreach(object objeto in personas)
	        {
			
				Persona  persona  =  (Persona) objeto;
				this. imprimePersona ( persona );
	        }
		}

		private void imprimePersona ( Persona  persona ) {
			Console . WriteLine ( "Código:"  +  persona . codigo );
			Console . WriteLine ( "Nombre:"  +  persona . Nombre );
			Console . WriteLine ( "Dirección:"  +  persona . direccion );
			Console . WriteLine ( "Teléfono:"  +  persona . telefono );
			Console . WriteLine ( "Facebook:"  +  persona . facebook );
			Console . WriteLine ( "" );
		}

	}
}