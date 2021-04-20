using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            //opciones 
            Console.WriteLine("Elige una opcion\n" +
             "\n1.- Suma" +
             "\n2.- Resta" +
             "\n3.- Multiplicacion" +
             "\n4.- Division" +
             "\n5.- Salir");

            String s1 = null;
            s1 = Console.ReadLine();

            switch (s1)
            {
                case "1":
                    Console.WriteLine("Seleccionaste suma");
                    break;

                case "2":
                    Console.WriteLine("Seleccionaste resta");
                    break;

                case "3":
                    Console.WriteLine("Seleccionaste multiplicacion");
                    break;

                case "4":
                    Console.WriteLine("Seleccionaste division");
                    break;

                case "5":
                    Console.WriteLine("Seleccionaste salir ");
                    break;
                default:
                    Console.WriteLine("La opcion es incorrecta try again");
                    break;
            }
            Console.ReadKey();
        }
    }
}
