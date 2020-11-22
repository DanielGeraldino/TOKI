using System;
using System.Collections.Generic;
using System.Text;

namespace TOKI.Entidade {
    abstract class MovimentoEstoque {
        public int movimento { get; set; }
        public Produto produto { get; set; }
        public DateTime data { get; set; }
        public Almoxarifado almoxarifado { get; set; }
        public float quantidade { get; set; }
        public Usuario usuario { get; set; }


        public MovimentoEstoque() {
        }

        public MovimentoEstoque(int movimento, Produto produto, DateTime data, Almoxarifado almoxarifado, float quantidade, Usuario usuario) {
            this.movimento = movimento;
            this.produto = produto;
            this.data = data;
            this.almoxarifado = almoxarifado;
            this.quantidade = quantidade;
            this.usuario = usuario;
        }

        public abstract bool Finalizar();

        public virtual string descreveMovimento() {
            return
                "------------------------------------------------------------"
                + "Movimento: " + movimento
                + "Produto: " + produto.getdrescri()
                + "\nData de processamento: " + data.ToString()
                + "\nAlmoxarifado: " + almoxarifado.GetNome()
                + "\nquantidade: " + quantidade
                //+ "\nUsuário: " + usuario.nome
                + "------------------------------------------------------------";
        }




    }
}
