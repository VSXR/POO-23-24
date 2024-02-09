using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
	internal class Calculator
	{
		int result;

		public int Sum(int num1, int num2)
		{
			result = num1 + num2;
			Console.WriteLine("THE RESULT IS: " + result + "\n");
			return result;
		}
		public int Rest(int num1, int num2)
		{
			result = num1 - num2;
			Console.WriteLine("THE RESULT IS: " + result + "\n");
			return result;
		}

		public int Multiplication(int num1, int num2)
		{
			result = num1 * num2;
			Console.WriteLine("THE RESULT IS: " + result + "\n");
			return result;
		}

		public int Division(int num1, int num2)
		{
			try {
				result = num1 / num2;
				Console.WriteLine("THE RESULT IS: " + result + "\n");

				if (num2 == 0)
				{
					throw new DivideByZeroException();
				}
			}
			catch (DivideByZeroException e)
			{
				Console.WriteLine("ERROR: " + e.Message);
			}

			return result;
		}
	}
}
