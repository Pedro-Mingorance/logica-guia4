using System;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool pares = false;
            bool impares = false;
            int n;
            int maximopar = 0;
            int minimoimpar = 0;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un numero:");
                n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    if (!pares)
                    {
                        maximopar = n;
                        pares = true;
                    }
                    else if (n > maximopar)
                    {
                        maximopar = n;
                    }
                }
                else if (!impares)
                {
                    minimoimpar = n;
                    impares = true;
                }
                else if (n < minimoimpar)
                {
                    minimoimpar = n;
                }
            }
            Console.WriteLine("El maximo par es: " + maximopar + ", y el minimo impar es: " + minimoimpar);
        }
    }
}
