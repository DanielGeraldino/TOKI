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
        }
    }
}
