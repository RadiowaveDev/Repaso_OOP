using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_OOP.Model
{
    public class FrontendDev:IDev
    {
        public void debug()
        {
            Console.WriteLine("Buscar errores en el proyecto de ReactJS");
        }

        public void code()
        {
            Console.WriteLine("Desarrollador FrontEnd");
            Console.WriteLine("Escribir codigo en HTML, CSS, JavaScript");
        }
    }
}
