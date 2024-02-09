using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuantasBancarias
{
    internal class Transaccion
    {
        private string Id { get; set; }
        
        private float Cantidad { get; set; }
        public Transaccion(float Cantidad) 
        {
            this.Id = Guid.NewGuid().ToString();
            this.Cantidad = Cantidad;
        }
    }
}
