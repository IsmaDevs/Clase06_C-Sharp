using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase006_Objetos
{
   public class Dog
    {

        //atributos

        //implementación tradicional

        public string nombre;
        public int edad;
        public string raza;
        public string color;


        //propiedades

        public string Nombre //encapsulamiento 
        {
            get //obtener
            {
                return nombre;
            }
            set //poner
            {
                nombre = value;

            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public string Raza
        {
            get
            {
                return raza;
            }
            set
            {
                raza = value;
            }
        }

        //metodos (son funciones, acciones que pueden hacer las clases)

        public void Ladrar()
        {
            Console.WriteLine($"{nombre} esta ladrando ");
        }

        public void Dormir()
        {
            Console.WriteLine($"{nombre} esta durmiendo (ZzZ) ");
        }

        public void Detalles()
        {
            Console.WriteLine($"Detalles de mi perrito");
            Console.WriteLine("El nombre de nuestro perrito es: "+nombre);
            Console.WriteLine("La edad de nuestro perrito es: " + edad+ " años");
            Console.WriteLine("El color de nuestro perrito es: " + color);
            Console.WriteLine("La raza de nuestro perrito es: " + raza);
        }
    }


}
