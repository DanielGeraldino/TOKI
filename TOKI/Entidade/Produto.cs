﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TOKI.Entidade
{
    class Produto
    {
        private string descricao;
        private float saldo;
        private int codigoBarra;
        private TipoUnidade unidade;
        private string tipo;
        private double preco;

        public Produto(string descri, float saldo, int codBarra, TipoUnidade unidade, string tipoProduto, double preco)
        {
            this.descricao = descri;
            this.saldo = saldo;
            this.codigoBarra = codBarra;
            this.unidade = unidade;
            this.tipo = tipoProduto;
            this.preco = preco;
        }

        public bool saidaSaldo(float v)
        {
            float novoSaldo = this.getSaldo() - v;

            if ((novoSaldo) >= 0)
            {
                this.setSaldo(novoSaldo);
                return true;
            }

            return false;
        }

        public bool entradaSaldo(float v)
        {
            this.setSaldo(this.getSaldo() + v);
            return true;
        }

        public void setSaldo(float v)
        {
            this.saldo = v;
        }

        public float getSaldo()
        {
            return this.saldo;
        }

        public void setDescri(string descri)
        {
            this.descricao = descri;
        }

        public string getdrescri()
        {
            return this.descricao;
        }

        public void setCodigoBarra(int codigo)
        {
            this.codigoBarra = codigo;
        }

        public int getCodigoBarra()
        {
            return this.codigoBarra;
        }

        public void setUnidade(TipoUnidade un)
        {
            this.unidade = un;
        }

        public TipoUnidade getUnidade()
        {
            return this.unidade;
        }

        public void setTipoProduto(string tipo)
        {
            this.tipo = tipo;
        }

        public string getTipoProduto()
        {
            return this.tipo;
        }

        public void setPreco(double valor)
        {
            this.preco = valor;
        }

        public double getPreco()
        {
            return this.preco;
        }
        
    }
}