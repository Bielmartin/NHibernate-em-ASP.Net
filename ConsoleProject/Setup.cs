using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    static class Setup
    {
        public static void Iniciar()
        {
            string opcao = string.Empty;

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n1 - Cadastrar Clientes.");
                Console.WriteLine("2 - Listar Clientes.");
                Console.WriteLine("3 - Sair.");
                //opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Usuario usuario = new Usuario();

                    Console.WriteLine("\Insira o Cnpj: ");
                    usuario.CNPJ = Console.ReadLine();

                    Console.WriteLine("\nInsira a Nome: ");
                    usuario.Nome = Console.ReadLine();
                }

            }

        }
    }
}
