using System;
using TOKI.Entidade;
using TOKI.Visualizacao;

namespace TOKI
{
    class Program
    {
        static void Main(string[] args)
        {

            Almoxarifado a = new Almoxarifado("teste", "teste end");
            Tela t = new Tela(a);

            t.TelaMenu();

            t.TelaCadastraFornec();

            
            /*

            a.addItem("teste", 123456, TipoUnidade.UNIDADE, "limpeza", 18.0, 1);

            a.printProdutos();*/
        }
    }
}
