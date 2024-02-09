using System;

namespace Calculadora
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Calculator calculator = new Calculator();
			int option;
			int num1;
			int num2;

            do
			{
				Console.WriteLine("--- MENU ---\n");
				Console.WriteLine("1. SUM\n");
				Console.WriteLine("2. REST\n");
				Console.WriteLine("3. MULTIPLICATION\n");
				Console.WriteLine("4. DIVISION\n");
				Console.WriteLine("5. EXIT\n");
				Console.Write("CHOOSE AN OPTION: ");
				option = int.Parse(Console.ReadLine());

				Console.WriteLine("\n");
				Console.Write("NUMBER 1: ");
				num1 = int.Parse(Console.ReadLine());
				Console.Write("NUMBER 2: ");
				num2 = int.Parse(Console.ReadLine());

				switch (option)
				{
					case 1:
						calculator.Sum(num1, num2);
						break;
					case 2:
						calculator.Rest(num1, num2);
						break;
					case 3:
						calculator.Multiplication(num1, num2);
						break;
					case 4:
						calculator.Division(num1, num2);
						break;
					case 5:
						break;
					default:
						Console.WriteLine("INVALID OPTION");
						break;
				}
				
			} while (option != 5);
		}
	}
}