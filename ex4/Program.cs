using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, f;
            Console.WriteLine("informe a temperatura em Celsius: ");
            c = double.Parse(Console.ReadLine());
            f = c * 9 / 5 + 32;
            Console.WriteLine("em Fahrenheit esta: " + f);

        }
    }
}
