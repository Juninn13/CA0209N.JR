using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0209N
{
    internal class Fornecedor
    {
        public string nome;
        public string cnpj;
        public string codigo;



        public void cadastroFornecedor()
        {
            Console.WriteLine("Digite o nome do Fornecedor:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o CNPJ do Fornecedor:");
            cnpj = Console.ReadLine();

            Console.WriteLine("Digite o Codigo de Cadastro do Fornecedor:");
            codigo = Console.ReadLine();
        }
        public void Exibir()
        {
            Console.WriteLine("nome: {0}", nome);
            Console.WriteLine("CNPJ : {0}", cnpj);
            Console.WriteLine("Codigo : {0}", codigo);
        }
    }
}

