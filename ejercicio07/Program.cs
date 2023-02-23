using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int max = 0;
            int ord = 0;

            for (int x = 0; x < 10; x ++)
            {
                Console.WriteLine("Ingrese un numero:");
                n = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    max = n;
                    ord = x + 1;
                }
                else if (n > max)
                {
                    max = n;
                    ord = x + 1;
                }
            }
            Console.WriteLine("El numero maximo es; " + max + " y el orden en el que fue ingresado es: " + ord);
        }
    }
}
