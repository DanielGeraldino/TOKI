using System;
using System.Collections.Generic;
using System.Text;

namespace TOKI.Entidade
{
    public class Usuario:Pessoa
    {
        private string login, senha;
        private int cpf;

        public Usuario(int ucpf,string ulogin,string usenha, string unome, string uendereco, string ucidade, string uestado, string uemail, int ucontato)
        {
            this.login = ulogin;
            this.senha = usenha;
            this.cpf = ucpf;
            this.nome = unome;
            this.email = uemail;
            this.endereco = uendereco;
            this.cidade = ucidade;
            this.estado = uestado;
            this.contato = ucontato;
        }
    }

}

