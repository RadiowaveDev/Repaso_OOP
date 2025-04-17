using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_OOP.Model
{
    public class Vehiculo
    {
        public string marca = "Lamborghini";

        // Metodo de la clase vehiculo
        public void tocarClaxon()
        {
            Console.WriteLine("Tuu, tuu, tuuu");
        }

        public virtual void encender()
        {
            Console.WriteLine("Encender");
        }

        public virtual void apagar()
        {
            Console.WriteLine("Encender");
        }
    }
}
