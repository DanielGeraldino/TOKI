using System;
using System.Collections.Generic;
using System.Text;

namespace TOKI.Entidade {
    class MovimentoEstoque {
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

        public string descreveMovimento() {
            return "Entrada ou saída ? "
                + movimento +
                "Produto: " +
                produto +
                "Data de processamento: " +
                data +
                almoxarifado +
                "quantidade: " +
                quantidade +
                "Usuário: " +
                usuario;
        }




    }
}
