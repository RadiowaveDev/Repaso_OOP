using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_OOP.Model
{
    public abstract class Animal
    {
        public abstract void animalSound(); // metodo abstracto

        public void dormir()
        {
            Console.WriteLine("zzzz");
        }
    }
}
