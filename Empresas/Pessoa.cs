using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresas
{
    internal class Pessoa
    {
        public double Telefone;
            public string Nome;
        
            public void cadastrarTelefone() {
                Console.WriteLine("Informe o Telefone do Funcionario: ");
        }

            public void cadastrarNome()
        {
            Console.WriteLine("Informe o Nome do Funcionario: ");
        }

    }
}
