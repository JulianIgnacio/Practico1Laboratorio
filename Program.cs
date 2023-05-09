using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Op_Log_Relac
{
    internal class Program
    {
        static void Main()
        {
            int a = 10,b=a,c=15,d=5;
            bool comp;
            comp = ((a==b) || (b>c) ||(c<d));
            Console.WriteLine("El resultado de la comparacion es: {0}",comp);
            Console.ReadKey();
        }
    }
}
