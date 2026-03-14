using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, m;
            Console.WriteLine("informe a primeira nota: ");
            n1 =double.Parse(Console.ReadLine());
            Console.WriteLine("informe a segunda nota nota: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("informe a terceira nota nota: ");
            n3 = double.Parse(Console.ReadLine());
            m = (n1 + n2 + n3) / 3;
            Console.WriteLine("A media é igual a: " + m);
            if (m > 7) {
                Console.WriteLine("passou :)");
            }
            else {
                Console.WriteLine("repetiu :(");
            }
        }
    }
}
