using System;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, promedio;
            int acumulador = 0;
            int contador = 0;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un numero:");
                n = int.Parse(Console.ReadLine());

                if (n > 18)
                {
                    acumulador += n;
                    contador++;
                }
            }
            promedio = acumulador / contador;

            Console.WriteLine("El promedio de las edades mayores de 18 es: " + promedio);
        }
    }
}
