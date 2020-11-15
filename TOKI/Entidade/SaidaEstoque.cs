using System;
using System.Collections.Generic;
using System.Text;

namespace TOKI.Entidade
{
    class SaidaEstoque : MovimentoEstoque
    {
        public SaidaEstoque(int mov, Produto p, DateTime data, Almoxarifado alm, Usuario user, float quant) : base(mov, p, data, alm, quant, user)
        {
            this.movimento = mov;
            this.produto = p;
            this.data = data;
            this.almoxarifado = alm;
            this.usuario = user;
            this.quantidade = quant;

        }

        public override bool Finalizar()
        {
            this.produto.saidaSaldo(this.quantidade);
            this.almoxarifado.AddMovimento(this);

            return true;
        }

        public override string descreveMovimento()
        {
            return
                "Movimento: " + movimento
                + "/nTipo: Saida"
                + "/nProduto: " + produto.getdrescri()
                + "/nData de processamento: " + data.ToString()
                + "/nAlmoxarifado: " + almoxarifado.GetNome()
                + "/nquantidade: " + quantidade
                + "/nUsuário: " + usuario.nome;
        }
    }
}
