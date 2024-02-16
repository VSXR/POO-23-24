using BankSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem {
	public class Cuenta_Bancaria {

		//Atributos de nuestra clase 
		public string Id { get; set; }
		private float Saldo { get; set; }
		public int Cantidad { get; set; }



		public List<Transaccion> ListaTransacciones; //Lista de tranasacciones 

		public Cuenta_Bancaria() //Constructor vacio 
		{
			ListaTransacciones = new List<Transaccion>(); //Creo la lista 
		}


		public Cuenta_Bancaria(float saldo, int cantidad) //Constructor lleno 
		{
			//Igualo mis atributos a los datos que paso por referencia 
			Saldo = saldo;
			Cantidad = cantidad;
			this.ListaTransacciones = new List<Transaccion>();

		}

		public void crearCuenta() //Funcion para crear la cuenta 
		{

			Console.Write("\nIngrese su nombre de titular: ");
			Id = Console.ReadLine();
			this.Ingresar();
		}

		public void Ingresar() //Funcion para la cantidad a ingresar  
		{
			Console.Write("\n¿Que cantidad de dinero desea ingresar?: ");
			Cantidad = int.Parse(Console.ReadLine());
			this.Saldo += Cantidad;
			Console.WriteLine($"Despues del ingreso la nueva cantidad de dinero en su cuenta es de: {this.Saldo} euros");
			Ingreso miIngreso = new Ingreso(Cantidad);
			this.ListaTransacciones.Add(miIngreso);
		}

		public void Retirar() //Funcion para retirar 
		{
			Console.Write("\n¿Que cantidad de dinero desea retirar?: ");
			Cantidad = int.Parse(Console.ReadLine());
			if (Cantidad > this.Saldo) //En caso de que se quiera sacar mas dinero del que se tiene 
			{
				Console.WriteLine("ERES POBRE");
			}
			else {
				this.Saldo -= Cantidad; //saldoInicial = saldoInicial - Cantidad
				Console.WriteLine($"Depues de la retirada la nueva cantidad de dinero en su cuenta es de: {this.Saldo} euros");
				Retirada miRetiro = new Retirada(Cantidad);
				this.ListaTransacciones.Add(miRetiro);
			}

		}



		public void Transferencia(Cuenta_Bancaria Cuenta_Destino) //Funcion para cuando se quiera hacer la transferencia 
		{

			Console.WriteLine("Introduzca la cantidad de dinero que desea transferir: ");
			Cantidad = int.Parse(Console.ReadLine());
			if (Cantidad > this.Saldo) //En caso de que se quiera hacer una transferencia de mas dinero que hay en la cuenta 
			{
				Console.WriteLine("No hay suficiente dinero en la cuenta como para poder hacer la transferencia");
			}
			else {
				Console.WriteLine($"Se ha realizado la transferencia de {Cantidad} euros con exito a la cuenta {Id}");
				this.Saldo -= Cantidad; //saldoInicial = saldoInicial - Cantidad 
				Console.WriteLine($"El nuevo saldo de tu cuenta es de {this.Saldo}");
				Transferencia transferencia = new Transferencia(Cantidad, Cuenta_Destino);
				this.ListaTransacciones.Add(transferencia);
			}
		}



		public void MostrarHistorial() {
			foreach (Transaccion transaccion in this.ListaTransacciones) {
				transaccion.Print();
			}
		}
	}
}
