using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0209N
{
   internal class Cliente
    {
        public int ID;
        public string cpf;
        public string nome;
        public int idade;
        public string endereco;
        public string email;

    public void Cadastrar()
        {
            Console.WriteLine("Insira o ID do Cliente");
            ID = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o CPF do Cliente");
            cpf = Console.ReadLine();

            Console.WriteLine("Insira o nome do Cliente");
            nome = Console.ReadLine();

            Console.WriteLine("Insira a idade do Cliente");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o endereço do Cliente");
            endereco = Console.ReadLine();

            Console.WriteLine("Insira o email do Cliente");
            email = Console.ReadLine();
        }

        public void Consultar()
        {
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("CPF: {0}", cpf);
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Idade: {0}", idade);
            Console.WriteLine("Endereço: {0}", endereco);
            Console.WriteLine("Email: {0}", email);

        }

    }
}

