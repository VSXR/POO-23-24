using BankSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem {
	public class Transferencia : Transaccion {
		public Cuenta_Bancaria Cuenta_Destino { get; set; }


		public Transferencia(int Cantidad, Cuenta_Bancaria Cuenta_Destino) : base(Cantidad) {
			this.Cuenta_Destino = Cuenta_Destino;
		}



		public override void Print() {
			Console.WriteLine($"Transferencia de {this.Cantidad} euros, a la cuenta {this.Cuenta_Destino.Id}");

		}




	}
}
