using System;
using System.Collections.Generic;
using System.Text;

namespace TOKI.Entidade
{
    class EntradaEstoque : MovimentoEstoque
    {
        private Fornecedor fornecedor { get; set; }

        public EntradaEstoque(int mov, Produto p, DateTime data, Almoxarifado alm, Usuario user, float quant, Fornecedor forn) : base(mov, p, data, alm, quant, user)
        {
            this.movimento = mov;
            this.produto = p;
            this.data = data;
            this.almoxarifado = alm;
            this.usuario = user;
            this.fornecedor = forn;
            this.quantidade = quant;

        }

        public void finalizar()
        {
            this.produto.entradaSaldo(this.quantidade);
            this.almoxarifado.AddMovimento(this);
        }

        public override string descreveMovimento()
        {
            return
                "Movimento: " + movimento
                + "/nTipo: Entrada" 
                + "/nProduto: " + produto.getdrescri()
                + "/nData de processamento: " + data.ToString()
                + "/nAlmoxarifado: " + almoxarifado.GetNome()
                + "/nquantidade: " + quantidade
                + "/nUsuário: " + usuario.nome;
        }
    }
}
