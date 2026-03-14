using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1;
            Console.WriteLine("informe um numero: ");
            n1 = double.Parse(Console.ReadLine());
            n1 = n1 * 2;
            Console.WriteLine("o doblo dele é: " + n1);
        }
    }
}
