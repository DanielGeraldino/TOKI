
using System;
using TOKI.Entidade;

namespace TOKI.Interface {
    interface IEstoque {

        public Produto pesquisar(string descricao);
        public Fornecedor pesquisarFornec(string nome);
        public bool entrada(int movimento, Produto produto, DateTime data, Usuario usuario, float quantidade, Fornecedor fornecedor);
        public bool saida(int movimento, Produto produto, DateTime data, Usuario usuario, float quantidade);
    }
}
