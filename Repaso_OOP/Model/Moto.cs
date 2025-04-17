using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_OOP.Model
{
    public class Moto : Vehiculo
    {
        public string asientoDoble;

        public override void encender()
        {
            Console.WriteLine("Encender desde moto");
        }

        public override void apagar()
        {
            Console.WriteLine("Apagar desde moto");
        }
    }
}
