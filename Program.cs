using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1OperadoresRelacionalesTp
{
    internal class Program
    {
        static void Main()
        {
            bool comp;
            int suma, multiplicacion;
            Console.Write("Ingrese el primer numero a sumar:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo numero a sumar:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el primer numero a multiplicar:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el Segundo numero a multiplicar:");
            int num4 = Convert.ToInt32(Console.ReadLine());
            suma = num1+ num2;
            multiplicacion = num3 * num4;
            comp= suma >= multiplicacion;
            Console.WriteLine("El resultado de la comparacion es: {0}",comp);
            Console.ReadKey();
        }
    }
}
