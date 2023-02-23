using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
        int n = 0;
        int max = 0;

        for (int x = 0; x < 10; x ++)
        {
            Console.WriteLine("Ingrese un numero por favor");
            n = int.Parse(Console.ReadLine());

            if (x == 0)
                max = n;
            else if (n > max)
                    max = n;
        }
        Console.WriteLine("El numero maximo es: " + max);
        }
    }
}
