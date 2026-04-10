using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresas
{
    internal class Funcionario:Pessoa
    {
        public double salario;

        public void cadastrarSalario()
        {
            Console.WriteLine("Informe o salario do Funcionario: ");
        }

        public void mostrarDados()
        {
            Console.WriteLine("salario {0}," this.salario);

        }
        
        
}
