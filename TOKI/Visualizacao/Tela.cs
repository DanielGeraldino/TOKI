﻿using System;
using System.Collections.Generic;
using System.Text;
using TOKI.Entidade;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace TOKI.Visualizacao
{
    class Tela
    {

        private Almoxarifado almoxarifado;
        MySqlConnection Conn2 = new MySqlConnection("host=localhost;user=root;password=admin;database=toki;");
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

            //Console.Write("Digite o id: ");
            //int id = int.Parse(Console.ReadLine());


            // almoxarifado.addItem(descricao, codigoBarra, unidade, tipo, preco,id);

            string Query = "insert into produto(descricao,codigoBarra,tipounidade,tipo,preco) values('" + descricao + "','" + codigoBarra + "','" + unidade + "','" + tipo + "','" + preco + "');";

            MySqlCommand Command2 = new MySqlCommand(Query, Conn2);
            MySqlDataReader MyReader2;
            Conn2.Open();
            MyReader2 = Command2.ExecuteReader();
            while (MyReader2.Read())
            {
            }
            Conn2.Close();

            Console.WriteLine("Produto cadastrado!");
            Console.ReadKey();

            return true;
        }

        private TipoUnidade EscolhaUnidade(int escolha)
        {
            switch (escolha)
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

            if (p != null)
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
            Console.Write("Digite o movimento: ");
            int mov = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do produto: ");
            Produto p = almoxarifado.pesquisar(Console.ReadLine());

            Console.Write("Digite a data de movimento(ex.: 11/11/2000): ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Digite a quantidade de entrada: ");
            float quantidade = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o fornecedor: ");
            Fornecedor fornecedor = almoxarifado.pesquisarFornec(Console.ReadLine());

            if (p != null)
            {
                if (almoxarifado.entrada(mov, p, data, null, quantidade, fornecedor))
                {
                    Console.WriteLine("Movimento registrado");
                    Console.ReadKey();
                    return true;
                }
                else
                {
                    Console.WriteLine("Produto não encontrado!");
                    Console.ReadKey();
                    return false;
                }
            }

            Console.ReadKey();
            return false;
        }

        public bool TelaSaida()
        {
            Console.Write("Digite o movimento: ");
            int mov = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do produto: ");
            Produto p = almoxarifado.pesquisar(Console.ReadLine());

            Console.Write("Digite a data de movimento(ex.: 11/11/2000): ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Digite a quantidade de saida: ");
            float quantidade = float.Parse(Console.ReadLine());

            if (p != null)
            {
                if (almoxarifado.saida(mov, p, data, null, quantidade))
                {
                    Console.WriteLine("Movimento registrado");
                    Console.ReadKey();
                    return true;
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente!");
                    Console.ReadKey();
                    return false;
                }
            }

            Console.WriteLine("Produto não encontrado!");
            Console.ReadKey();
            return false;
        }

        public bool TelaMovimento()
        {
            Console.WriteLine("-----Movimento de estoque-----");

            almoxarifado.printMovimento();

            Console.WriteLine("-----Movimento de estoque fim-----");
            Console.ReadKey();
            return true;
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
