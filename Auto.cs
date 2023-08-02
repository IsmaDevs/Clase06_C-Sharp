using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase006_Objetos
{
    public class Auto
    {
        //atributos o Argumentos

        //auto-implementacion

        public string color { get; set; }

        public int km { get; set; }

        public string modelo { get; set; }

        public string marca { get; set; }


        //metodos

        public void Arranque()
        {
            Console.WriteLine($"{marca} esta arrancando");
        }

        public void DetallesAuto()
        {

            Console.WriteLine("Los detalles de nuestro auto son: ");
            Console.WriteLine($"La marca de nuestro auto es {marca} ");
            Console.WriteLine($"El modelo de nuestro auto es {modelo} ");
            Console.WriteLine($"El color de nuestro auto es {color} ");
        }

        //constructor

        public Auto(string Color, int km, string modelo, string marca) 
            {


            this.modelo = modelo;
            this.km = km;
            this.marca = marca;
            this.color = Color;

        }


        /*

        public string getColor
        {
            
        }

        */







    }
}
