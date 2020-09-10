using System;

namespace Pulsacione
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;

            int edad;
            String sexo;

            int pulsaciones = 0;
            Console.WriteLine("Digite el nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Digite el Sexo (f/m)");
            sexo = Console.ReadLine();
            Console.WriteLine("Digite la Edad");
            edad = Convert.ToInt32(Console.ReadLine());
           
            if (sexo == "f")
            {
                pulsaciones = (220 - edad) / 10;

            }
            else if (sexo == "m")
            {
                pulsaciones = (210 - edad) / 10;

            }


            Console.WriteLine("las pulsaciones de " + nombre + "  son de  " + pulsaciones);
            Console.ReadLine();
            }
        }
    }

