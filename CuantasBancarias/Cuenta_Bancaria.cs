using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuantasBancarias
{
    internal class Cuenta_Bancaria
    {

        //atributos

        private string Titular { get; set; }
        private float Saldo { get; set; }
        private int Contador { get; set; }

        private List<Transaccion> transacciones;

        public Cuenta_Bancaria(string Titular, float Saldo)
        {
            this.Titular = Titular;
            this.Saldo = Saldo;
            this.Contador = 0;
            this.transacciones = new List<Transaccion>();
        }

        //metodos

        public void Ingresar(float Cantidad)
        {
            this.Saldo += Cantidad;
            this.Agregar(Cantidad);
        }

        public void Retirar(float Cantidad)
        {
            if (this.Saldo < Cantidad)
            {
                Console.WriteLine("Error");
            }
            else
            {

                this.Saldo -= Cantidad;
                this.Agregar(Cantidad);
            }

        }

        private void Agregar(float Cantidad)
        {
            this.transacciones.Add(new Transaccion(Cantidad));
            this.Contador++;
        }
    }
}
