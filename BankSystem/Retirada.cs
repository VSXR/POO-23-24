﻿using BankSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem {
	public class Retirada : Transaccion {
		public Retirada(int Cantidad) : base(Cantidad) {

		}

		public override void Print() {
			Console.WriteLine($"Retirada: {this.Cantidad}");
		}




	}
}
