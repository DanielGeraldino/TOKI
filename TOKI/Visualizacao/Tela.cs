using System;
using System.Collections.Generic;
using System.Text;

namespace TOKI.Visualizacao
{
    class Tela
    {
        public Tela()
        {

        }

        public bool TelaLogin()
        {
            return false;
        }

        public bool TelaMenu()
        {

            Console.WriteLine("Seja bem-vindo(a) ao Sistema TOKI!");
            Console.WriteLine("Sistema de gerenciamento de estoque");

            Console.WriteLine("\nSelecione uma opção de 1 a n:");

            Console.WriteLine(
                "\n1. Consultar item\n"
                + "2.  Cadastrar item\n"
                + "3. Entrada\n"
                + "4. Saida.\n"
                + "5. Relatorio movimentação\n"
                + "6.Cadastrar fornecedor\n\n"
                );

            Console.Write("Escolha: ");

            int opcao = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (opcao)
            {
                case 1:
                    TelaConsulta();
                    break;
                case 2:
                    TelaCadastrarProduto();
                    break;
                case 3:
                    TelaEntrada();
                    break;
                case 4:
                    TelaSaida();
                    break;
                case 5:
                    TelaMovimento();
                    break;
                case 6:
                    TelaCadastraFornec();
                    break;
                default:
                    Console.WriteLine("Opção invalida!");
                    TelaMenu();
                    break;
            }

            return false;
        }

        public bool TelaCadastrarProduto()
        {
            return true;
        }

        public bool TelaConsulta()
        {
            Console.WriteLine("Consulta");
            return false;
        }

        public bool TelaEntrada()
        {
            Console.WriteLine("Informe o fornecedor: ");
            string fornecedor = Console.ReadLine();
            Console.WriteLine("Informe o produto: ");
            string produto = Console.ReadLine();
            return false;
        }

        public bool TelaSaida()
        {
            return false;
        }

        public bool TelaMovimento()
        {
            return false;
        }

        public bool TelaCadastraFornec()
        {
            Console.WriteLine("Informe o nome do fornecedor: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o CNPJ do fornecedor: ");
            int cnpj = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe um telefone para contato: ");
            string telefone = Console.ReadLine();
            Console.WriteLine("Informe um e-mail para cadastro: ");
            string email = Console.ReadLine();
            Console.WriteLine("Informe o endereço do fornecedor: ");
            string endereco = Console.ReadLine();
            Console.WriteLine("Informe a cidade: ");
            string cidade = Console.ReadLine();
            Console.WriteLine("Informe o estado: ");
            string estado = Console.ReadLine();

            return false;
        }
    }
}
