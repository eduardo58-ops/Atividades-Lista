using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario func1 = new Funcionario();
            func1.cadastrarNome();
            func1.cadastrarTelefone();
            func1.cadastrarSalario();       
        }

    }
}
