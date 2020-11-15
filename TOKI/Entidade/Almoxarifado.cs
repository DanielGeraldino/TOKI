using System;
using System.Collections.Generic;
using System.Text;
using TOKI.Interface;

namespace TOKI.Entidade {
    class Almoxarifado : IEstoque {
        private string nome;
        private string endereco;
        public List<Produto> listProduto = new List<Produto>();
        private List<MovimentoEstoque> listMovimento = new List<MovimentoEstoque>();

        public Almoxarifado() {
        }

        public Almoxarifado(string nome, string endereco, List<Produto> listProduto) {
            this.nome = nome;
            this.endereco = endereco;
            this.listProduto = listProduto;
        }

        public void AddMovimento(MovimentoEstoque me)
        {
            this.listMovimento.Add(me);
        }

        public string GetNome() {
            return nome;
        }

        public void SetNome(string nome) {
            this.nome = nome;
        }

        public string GetEndereco() {
            return endereco;
        }

        public void SetEndereco(string endereco) {
            this.endereco = endereco;
        }

        //Retorna o valor total de produtos no estoque
        public float SaldoTotalProduto(int idProduto) {
            float saldo = 0f;
            foreach (Produto p in listProduto) {
                if (p.GetId() == idProduto) {
                    saldo = p.getSaldo();
                }
            }
            return saldo;

        }

        public Produto pesquisar(string descricao)
        {

            foreach(var produto in listProduto)
            {
                if(produto.getdrescri() == descricao)
                {
                    return produto;
                }
            }

            return null;

        }


        public bool saida(int movimento, Produto produto, DateTime data, Usuario usuario, float quantidade)
        {

            MovimentoEstoque saida = new SaidaEstoque(
                movimento, 
                produto, 
                data, 
                this, 
                usuario, 
                quantidade
                );

            return saida.Finalizar();
            
        }

        public bool entrada(int movimento, Produto produto, DateTime data, Usuario usuario, float quantidade, Fornecedor fornecedor)
        {

            MovimentoEstoque entrada = new EntradaEstoque(
                movimento,
                produto,
                data,
                this,
                usuario,
                quantidade,
                fornecedor
                );

            return entrada.Finalizar();

        }
    }
}
