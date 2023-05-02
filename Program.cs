using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{ 
internal class Programa
{
    public static void Main()
    {
        double precio,precioFinal;
        int cantidad;
        Console.WriteLine("Ingrese el precio del producto:");
        precio = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad del producto a llevar:");
        cantidad = Convert.ToInt32(Console.ReadLine());
            precioFinal = cantidad * precio;
        Console.WriteLine("Su precio final es:" + precioFinal);
        Console.ReadKey();
    }
}
}