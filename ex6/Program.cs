using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d, r;
            Console.WriteLine("informe o valor: ");
            d = double.Parse(Console.ReadLine());
            r = d * 5.33; 
            Console.WriteLine("o valor em real é: " + r);
        }
    }
}
