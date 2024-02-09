using System;

namespace Array {
	public class Array_Colections {

		int[] colections;

		public Array_Colections(int size) {
			this.colections = new int[size];
		}

		public void Add(int value, int position) {
			try {
				this.colections[position] = value;
			}
			catch (IndexOutOfRangeException e) {
				Console.WriteLine(e);
			}
		}

		public void Print() {
			for (int i = 0; i < this.colections.Length; i++) {
				Console.Write("EL ARRAY EN LA POSICION" + i + " ES " + this.colections[i] + "\n\n");
			}
		}
	}
}
