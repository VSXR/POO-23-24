using System;

namespace Array {
	public class Program {
		static void Main() {

			Array_Colections array = new Array_Colections(4);

			array.Add(3, 0);
			array.Add(4, 1);
			array.Add(5, 2);
			array.Add(6, 3);
			array.Add(7, 4); //EXCEPCION IndexOutOfRangeException

			array.Print();
			Console.ReadKey();
		}
	}
}