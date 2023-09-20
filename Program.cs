using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema04_sem05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número máximo: ");
            int numeroMaximo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Elija una opción:");
            Console.WriteLine("1. Mostrar números pares.");
            Console.WriteLine("2. Mostrar números impares.");
            Console.WriteLine("3. Calcular el factorial.");
            Console.Write("Opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    MostrarPares(numeroMaximo);
                    break;
                case 2:
                    MostrarImpares(numeroMaximo);
                    break;
                case 3:
                    Console.WriteLine($"El factorial de {numeroMaximo} es {CalcularFactorial(numeroMaximo)}");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
        static void MostrarPares(int maximo)
        {
            Console.WriteLine("Números pares:");
            for (int i = 2; i <= maximo; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void MostrarImpares(int maximo)
        {
            Console.WriteLine("Números impares:");
            for (int i = 1; i <= maximo; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static long CalcularFactorial(int n)
        {
            if (n == 0)
                return 1;
            long resultado = 1;
            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
    }

}
    

