using System;
using TOKI.Entidade;
using TOKI.Visualizacao;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;



namespace TOKI
{
    class Program
    {

        static void Main(string[] args)
        {

            // connection con = new connection();

            
            string sql = " SELECT * FROM usuarios  ";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=admin;database=toki;");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            inicio:
            Console.WriteLine("Digite o seu login:");
            string login = Console.ReadLine();
            Console.WriteLine("Digite a sua senha:");
            string senha = Console.ReadLine();
            //MySqlDataReader reader = cmd.ExecuteReader();
            MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from usuarios where login ='"+login+"'AND senha='"+senha+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            
            if (dt.Rows[0][0].ToString()=="1")
            {
                Console.WriteLine("Usuario e Senha validos");
                Console.Clear();
                Almoxarifado a = new Almoxarifado("teste", "teste end");
                Tela t = new Tela(a);

                t.TelaMenu();
            }
            else
            {
                
                Console.Clear();
                Console.WriteLine("Usuario ou Senha invalido");
                goto inicio;
            }

        }
    }
}
