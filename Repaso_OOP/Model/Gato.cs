using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_OOP.Model
{
    public class Gato : IAnimal
    {
        public void animalSound()               //metodo
        {
            Console.WriteLine("Miau Miau");
        }

        public int contarEdad(int edad)         //metodo
        {
            return edad;
        }
    }
}
