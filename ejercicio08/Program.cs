using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int min = 0;
            int ord = 0;

            for (int x = 0; x < 20; x ++)
            {
                Console.WriteLine("Ingrese un numero:");
                n = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    min = n;
                    ord = x + 1;
                }
                else if (n < min)
                {
                    min = n;
                    ord = x + 1;
                }
            }
            Console.WriteLine("El numero minimo es; " + min + " y el orden en el que fue ingresado es: " + ord);
        }
    }
}
