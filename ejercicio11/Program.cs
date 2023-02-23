using System;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool primerprimo = false;
            int numero;
            int maximoprimo = 0;

            for (int x = 0; x < 10; x++)
            {
                int contador = 0;

                Console.WriteLine("ingrese un numero:");
                numero = int.Parse(Console.ReadLine());

                for (int y = 1; y <= numero; y++)
                {
                    if (numero % y == 0)
                    {
                        contador++;
                    }
                }
                
                if (contador == 2)
                {
                    if (!primerprimo)
                    {
                        maximoprimo = numero;
                        primerprimo = true;
                    }
                   else if (numero > maximoprimo)
                    {
                    maximoprimo = numero;
                    }
                }

            }
            if (primerprimo)
            {
                Console.WriteLine("el mayor numero primo ingresado es: " + maximoprimo);
            }
            else
            {
                Console.WriteLine("No ingreso numeros primos");
            }
        }
    }
}
