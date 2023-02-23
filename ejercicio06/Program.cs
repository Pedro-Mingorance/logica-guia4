using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
        int numero, resto;
        int contador = 0;

        Console.WriteLine("Ingrese un numero:");
        numero = int.Parse(Console.ReadLine());

        for ( int x = 1; x <= numero; x ++ )
        {
            resto = numero % x;

            if (resto == 0)
                contador ++;
        }
        if (contador == 2)
            Console.WriteLine("Es un numero primo");
        else
            Console.WriteLine("No es numero primo");
        }
    }
}
