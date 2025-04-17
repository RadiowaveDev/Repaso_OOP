using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_OOP.Model
{
    public class Perro:Animal
    {
        public string nombre { get; set; }
        // Sobreescritura o overriding del metodo abstracto
        public override void animalSound()
        {
            Console.WriteLine($"El perro de nombre {nombre} hace guau guau guau");
        }

        public Perro(string nombrePerro)
        {
            nombre = nombrePerro;
        }
    }
}
