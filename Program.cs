using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioOpLogicos_Relacionales
{
    internal class Program
    {
        static void Main()
        {
            int a = 12;
            bool comp1,comp2;
            comp1 = !((a>10) && (a<20));
            Console.WriteLine("El resultado de la primera comparacion es: {0}",comp1);
            Console.ReadKey();
            comp2 = !((a > 10) || !(a < 20));
            Console.WriteLine("El resultado de la segunda comparacion es: {0}", comp2);
            Console.ReadKey();
        }
    }
}
