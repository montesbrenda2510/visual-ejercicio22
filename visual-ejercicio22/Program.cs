using System;

namespace visual_ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Mayor y Menor";

            Console.Write("Ingrese un numero entero: ");
            var numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro  numero entero: ");
            var numero2 = int.Parse(Console.ReadLine());

            if (numero1!=numero2)
            {
                if (numero1 > numero2)
                {
                    Console.WriteLine($"Mayor{numero1}");
                    Console.WriteLine($"Menor{numero2}");
                }
                else
                {
                    Console.WriteLine($"Mayor {numero2}");
                    Console.WriteLine($"Menor{numero1}");
                }
            }
            else
            {
                Console.WriteLine($"Los numeros ingresados son iguales.");
            }
            Console.ReadLine();
        }
    }
}
