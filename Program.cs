using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog miPerrito = new Dog();

            miPerrito.Nombre = "Thor";
            miPerrito.Edad = 2;
            miPerrito.Raza = "Aleman";
            miPerrito.Color = "gris";

            //Console.WriteLine("La edad de mi perrito es de: " + miPerrito.Edad);
            miPerrito.Detalles();


            Console.WriteLine();

            Dog otroPerrito = new Dog();

            otroPerrito.Nombre = "Doki";
            otroPerrito.Edad = 8;
            otroPerrito.Raza = "Metizo";
            otroPerrito.Color = "Blanco";
            otroPerrito.Detalles();

            Console.WriteLine();

            Auto autito = new Auto("azul", 125000, "Fitito", "Fiat");

            //autito.marca = "audi";
            //autito.color = "rojo";
            //autito.km = 100;
            //autito.modelo = "TT";
            autito.DetallesAuto();

            Console.ReadKey();



        }
    }
}
