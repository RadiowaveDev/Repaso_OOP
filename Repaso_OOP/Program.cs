using Repaso_OOP.Model;

namespace Repaso_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("Something about us","Daft Punk","Electronic","Discovery",240);
            Console.WriteLine("Nombre: "+song1.Name);
            Console.WriteLine("Artista: "+song1.artist);
            Console.WriteLine("Genero: "+song1.genre);
            Console.WriteLine("Album: "+song1.albumName);
            Console.WriteLine("Duracion: "+song1.durationSeconds);
            Console.WriteLine();

            var car = new Carro();
            Console.WriteLine(car._marca);
            car.tocarClaxon();
            Console.WriteLine();

            var gato = new Gato();
            gato.animalSound();
            int edadGato = gato.contarEdad(2);
            Console.WriteLine(edadGato);
            Console.WriteLine();    


            var backDev = new BackendDev();
            backDev.Name = "Jose";
            Console.WriteLine(backDev.Name);
            backDev.coding();
            Console.WriteLine(backDev.funcionalidad);
            Console.WriteLine();

            var frontDev = new FrontendDev();
            frontDev.code();
            frontDev.debug();
            
        }
    }
}
