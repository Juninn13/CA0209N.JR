﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0209N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Cadastrar();
            cliente.Consultar();

            Fornecedor fornecedor = new Fornecedor();
            fornecedor.cadastroFornecedor();
            fornecedor.Exibir();
        }
    }
}
