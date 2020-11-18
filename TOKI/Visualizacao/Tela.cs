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
            return false;
        }
    }
}
