using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora;
using NUnit.Framework;

namespace Calculadora
{
	[TestFixture]
	public class Calculator_Test
	{
		[Test]
		public void Sum_ShouldReturnCorrectSum()
		{
			// Arrange
			Calculator calculator = new Calculator();

			// Act
			int result = calculator.Sum(3, 5);

			// Assert
			Assert.AreEqual(8, result);
		}

		[Test]
		public void Rest_ShouldReturnCorrectDifference()
		{
			// Arrange
			Calculator calculator = new Calculator();

			// Act
			int result = calculator.Rest(10, 5);

			// Assert
			Assert.AreEqual(5, result);
		}

		[Test]
		public void Multiplication_ShouldReturnCorrectProduct()
		{
			// Arrange
			Calculator calculator = new Calculator();

			// Act
			int result = calculator.Multiplication(4, 6);

			// Assert
			Assert.AreEqual(24, result);
		}

		[Test]
		public void Division_ShouldReturnCorrectQuotient()
		{
			// Arrange
			Calculator calculator = new Calculator();

			// Act
			int result = calculator.Division(15, 3);

			// Assert
			Assert.AreEqual(5, result);
		}

		[Test]
		public void Division_ShouldThrowDivideByZeroException()
		{
			// Arrange
			Calculator calculator = new Calculator();

			// Act & Assert
			Assert.Throws<DivideByZeroException>(() => calculator.Division(10, 0));
		}
	}
}
