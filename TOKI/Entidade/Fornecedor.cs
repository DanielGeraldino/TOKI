using System;
using System.Collections.Generic;
using System.Text;

namespace TOKI.Entidade
{
    public class Fornecedor:Pessoa
    {
        private int cnpj;
        
        public Fornecedor(int fcnpj,string fnome, string fendereco,string fcidade, string festado, string femail, int fcontato)
        {
            this.cnpj = fcnpj;
            this.nome = fnome;
            this.email = femail;
            this.endereco = fendereco;
            this.cidade = fcidade;
            this.estado = festado;
            this.contato = fcontato;
        }
    }
}
