using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Ingrese tres numeros diferentes: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)  
            {
                Console.WriteLine($"{num1} es el mayor numero");
            } 
            if (num2 > num1 && num2 > num3) 
            {
                Console.WriteLine($"{num2} es el mayor numero");
            }         
            if (num3 > num1 && num3 > num2) 
            {
                Console.WriteLine($"{num3} es el mayor numero");
            }
        }
    }
}
