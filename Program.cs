using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Programa
    {
        public static void Main()
        {
            double promedio;
            int suma;
            int valor1 = 5; int valor2 = 7; int valor3 = 9; int valor4 = 15;
            suma = valor1 + valor2 + valor3 + valor4;
            promedio = suma / 4;
            Console.WriteLine("Su Suma es:{0} y el promedio es:{1}", suma, promedio);
            Console.ReadKey();
        }
    }
}