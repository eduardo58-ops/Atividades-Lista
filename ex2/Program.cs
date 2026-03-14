using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2; 
            Console.WriteLine("informe um numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("informe um outro numero: ");
            n2 = int.Parse(Console.ReadLine());
            n1 = n1 + n2;
            Console.WriteLine("A soma deu: " + n1);
        }
    }
}
