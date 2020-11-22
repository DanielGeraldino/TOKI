using System;
using System.Collections.Generic;
using System.Text;
using TOKI.Entidade;

namespace TOKI.Visualizacao
{
    class Tela
    {
        private Almoxarifado almoxarifado;

        public Tela(Almoxarifado a)
        {
            almoxarifado = a;
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

            bool parar = true;

            while (parar)
            {
                Console.WriteLine(
                    "\n1. Consultar item\n"
                    + "2. Cadastrar item\n"
                    + "3. Entrada\n"
                    + "4. Saida.\n"
                    + "5. Relatorio movimentação\n"
                    + "6. Cadastrar fornecedor\n\n"
                    + "7. Sair"
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
                    case 7:
                        parar = false;
                        break;
                    default:
                        Console.WriteLine("Opção invalida!");
                        TelaMenu();
                        break;
                }

                Console.Clear();
            }

            Console.WriteLine("Programa finalizado!");

            return false;
        }

        public bool TelaCadastrarProduto()
        {

            Console.Write("Digite a descrição do produto: ");
            string descricao = Console.ReadLine();

            Console.Write("Digite o codigo de barra do produto: ");
            int codigoBarra = int.Parse(Console.ReadLine());

            Console.Write("Escolha uma unidade(1 - Grama; 2 - Kilograma; 3 - Litro; 4 - Mililitro; 5 - unidade): ");
            TipoUnidade unidade = EscolhaUnidade(int.Parse(Console.ReadLine()));

            Console.Write("Descreva o tipo de produto: ");
            string tipo = Console.ReadLine();

            Console.Write("Digite o preço de venda: ");
            double preco = double.Parse(Console.ReadLine());

            Console.Write("Digite o id: ");
            int id = int.Parse(Console.ReadLine());


            almoxarifado.addItem(descricao, codigoBarra, unidade, tipo, preco, id);

            Console.WriteLine("Produto cadastrado!");
            Console.ReadKey();

            return true;
        }

        private TipoUnidade EscolhaUnidade(int escolha)
        {
            switch(escolha)
            {
                case 1:
                    return TipoUnidade.GRAMA;
                case 2:
                    return TipoUnidade.KILOGRAMA;
                case 3:
                    return TipoUnidade.LITRO;
                case 4:
                    return TipoUnidade.MILILITRO;
                case 5:
                    return TipoUnidade.UNIDADE;
                default:
                    return TipoUnidade.UNIDADE;
            }
        }

        public bool TelaConsulta()
        {
            Console.Write("Digiteo o nome do item: ");
            String texto = Console.ReadLine();

            Produto p = almoxarifado.pesquisar(texto);

            if(p != null)
            {
                p.printProduto();
                Console.ReadKey();
            } 
            else
            {
                Console.WriteLine("produto não encotrado");
                Console.ReadKey();
            }

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
            int telefone = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe um e-mail para cadastro: ");
            string email = Console.ReadLine();
            
            Console.WriteLine("Informe o endereço do fornecedor: ");
            string endereco = Console.ReadLine();
            
            Console.WriteLine("Informe a cidade: ");
            string cidade = Console.ReadLine();

            Console.WriteLine("Informe o estado: ");
            string estado = Console.ReadLine();

            almoxarifado.addFornecedor(cnpj, nome, cidade, estado, email, telefone);

            Console.WriteLine("Fornecedor cadastrado!");
            Console.ReadKey();

            return true;
        }
    }
}
