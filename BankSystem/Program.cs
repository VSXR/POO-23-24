using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem {
	internal class Program {
		static int Contador { get; set; } //A traves de static podemos acceder a la propiedad a traves del nombre de la clase 
		static void Main(string[] args) {
			Cuenta_Bancaria miBanco = new Cuenta_Bancaria(); //Me creo un constructor que lo voy a utilizar para llamar luego a todas las funciones
			Cuenta_Bancaria miBancoDos = new Cuenta_Bancaria(); //Otro constructor el cual sera la cuenta de nuestro 2º usuario
			int opcion;

			//Menu con cada una de las opciones 
			miBanco.crearCuenta(); //Llamo a los datos del primer usuario
			Console.WriteLine("Cuenta Dos:");
			miBancoDos.crearCuenta(); //Llamo a los datos del segundo usuario
			do {
				Console.Clear();
				Console.Write("1º) Ingresar dinero");
				Console.Write("\n2º) Retirar dinero");
				Console.Write("\n3º) Realizar una transferencia");
				Console.Write("\n4º) Mostrar historial de  transacciones");
				Console.WriteLine("\n=======================================");
				Console.Write("Porfavor seleccione una de las opciones: ");
				opcion = int.Parse(Console.ReadLine());
				switch (opcion) {
					case 1: //Caso de ingreso 
						miBanco.Ingresar();
						Console.WriteLine("Pulse cualquier boton para continuar");
						Console.ReadKey();
						break;

					case 2: //Caso de retirada 
						miBanco.Retirar();
						Console.WriteLine("Pulse cualquier boton para continuar");
						Console.ReadKey();
						break;

					case 3: //Caso de transaccion
						miBanco.Transferencia(miBancoDos);
						Console.WriteLine("Pulse cualquier boton para continuar");
						Console.ReadKey();
						break;

					case 4: //Caso de historial
						miBanco.MostrarHistorial();
						Console.WriteLine("Pulse cualquier boton para continuar");
						Console.ReadKey();
						break;

						//No hacemos caso de registrar una transaccion ya que cada vez que realiza cualquier operacion la registramos 

				}
			} while (opcion != 5);









		}
	}
}
