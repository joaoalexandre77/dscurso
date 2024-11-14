using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoUserPass
{
    internal class Program
    {
        static string strConexao = "server=localhost;database=bduserpass;uid=root;pwd=123456";
        static MySqlConnection conexao;
        static void Main(string[] args)
        {
            bool sairMenu = false;
            int codigomenu = 0;
            int codMenu = 0;
            while (!sairMenu)
            {
                Console.WriteLine("menu");
                Console.WriteLine(gerarMunu());

                try
                {
                    codMenu = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                switch (codMenu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("listar");
                        listar();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("ADICIONAR");
                        adicionar();
                        break;

                    case 3:
                        Console.Clear();
                        sairMenu = true;
                        break;
                }
            }
        }

        static void adicionar()
        {
            try
            {
                conexao = new MySqlConnection(strConexao);
                conexao.Open();
                Console.WriteLine("Digite o nome");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o email");
                string email = Console.ReadLine();

                Console.WriteLine("Digite o senha");
                string senha = Console.ReadLine();

                var strComando = new MySqlCommand("INSERT INTO tbusuarios (nome, email, senha) values(@NOME, @EMAIL, @SENHA)", conexao);
                strComando.Parameters.Add(new MySqlParameter("@NOME", nome));
                strComando.Parameters.Add(new MySqlParameter("@EMAIL", email));
                strComando.Parameters.Add(new MySqlParameter("@SENHA", senha));
                var cmdExec = strComando.ExecuteNonQuery();
                if (cmdExec > 0)
                {
                    Console.WriteLine("sucesso!");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conexao.Clone();
            }
        }

        static void listar()
        {
            try
            {

                conexao = new MySqlConnection(strConexao);
                conexao.Open();
                var strComando = new MySqlCommand("SELECT * FROM tbusuarios ", conexao);
                var resultado = strComando.ExecuteReader();
                while (resultado.Read())
                {
                    Console.WriteLine($"\nnome: {resultado["nome"]}, email: {resultado["email"]}, senha{resultado["senha"]}");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        static string gerarMunu()
        {
            string menu = "(1)listar";
            menu += "\n(2)adicionar";
            menu += "\n(3) sair";

            return menu;
        }
    }
}
