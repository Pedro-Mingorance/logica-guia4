using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
        int n;
        int contador = 0;

        for (int x = 0; x < 20; x ++)
        {
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            if (n > 0)
                contador ++;
        }
        Console.WriteLine("El total de numeros positivos es: " + contador);
        }
    }
}
