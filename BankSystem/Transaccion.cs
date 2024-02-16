using BankSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem {
	public abstract class Transaccion {
		public string Id { get; set; }
		public int Cantidad { get; set; }

		public Transaccion(int Cantidad) {
			this.Cantidad = Cantidad;
			this.Id = Guid.NewGuid().ToString(); //Evita colisiones con strings iguales 
		}
		public virtual void Print() {

		}


	}

}
