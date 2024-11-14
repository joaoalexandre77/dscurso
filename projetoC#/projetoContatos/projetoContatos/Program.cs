using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoContatos
{
    internal class Program
    {
        static string strConexao = "server=localhost;database=prjconexao;uid=root;pwd=123456";
        static MySqlConnection conexao;
        static void Main(string[] args)
        {
            bool sairMenu = false;
            int codigoMenu = 0;
            int id = 0;

            while (!sairMenu)
            {
                Console.WriteLine("MENU DE OPÇÔES!");
                Console.WriteLine(gerarMenu());

                try
                {
                    codigoMenu = int.Parse(Console.ReadLine());

                }

                catch (Exception e)
                {
                    Console.WriteLine("Ocorreu um erro:\n" + e.Message);
                }

                switch (codigoMenu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("=======================");
                        Console.WriteLine("LISTAR CONTATOS");
                        listarContatos();
                        Console.WriteLine("=======================");
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("=======================");
                        Console.WriteLine("CRIAR UM NOVO CONTATO");
                        adicionarContato();
                        Console.WriteLine("=======================");
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("=======================");
                        Console.WriteLine("BUSCAR UM CONTATO POR ID");
                        Console.WriteLine("Digite o id Procurado");

                        try
                        {
                            id = int.Parse(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        buscarId( id);
                        Console.WriteLine("=======================");
                        break;

                    case 4:
                        Console.WriteLine("=======================");
                        Console.WriteLine("EXCLUIR CONTATO POR ID");
                        Console.WriteLine("DIGITE O ID");
                        try
                        {
                            id = int.Parse(Console.ReadLine());
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        Console.WriteLine("=======================");
                        excluirId(id);

                        break;

                    case 9:
                        Console.Clear();
                        sairMenu = true;
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            }
        }

        static string gerarMenu()
        {
            string menu = "(1) - LISTAR CONTATOS";
            menu += "\n(2) - ADICIONAR NOVO CONTATO";
            menu += "\n(3) - BUSCAR CONTATO POR ID";
            menu += "\n(4) - EXCLUIR CONTATO POR ID";
            menu += "\n(9) - SAIR";

            return menu;
        }

        static void adicionarContato()
        {
            try
            {
                conexao = new MySqlConnection(strConexao);
                conexao.Open();
                Console.WriteLine("Digite o nome para o novo contato");
                string nome = Console.ReadLine();

                var strComando = new MySqlCommand("INSERT INTO contatos (nome) VALUES (@NOME)", conexao);
                strComando.Parameters.Add(new MySqlParameter("@NOME", nome));

                var cmdExec = strComando.ExecuteNonQuery();

                if (cmdExec > 0)
                {
                    Console.WriteLine($"Comando executado! {cmdExec} registro(s) afetado(s)");
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

        static void listarContatos()
        {
            try
            {
                conexao = new MySqlConnection(strConexao);
                conexao.Open();

                var strComando = new MySqlCommand("SELECT * FROM contatos", conexao);

                var resultado = strComando.ExecuteReader();

                while (resultado.Read())
                {
                    Console.WriteLine($"{resultado["id"]} - {resultado["nome"]}");
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

        static bool buscarId(int id)
        {
            try
            {
                conexao = new MySqlConnection(strConexao);
                conexao.Open();

                var strComando = new MySqlCommand("SELECT * FROM contatos WHERE id = @ID", conexao);

                strComando.Parameters.Add(new MySqlParameter("@ID", id));

                var resultado = strComando.ExecuteReader();
                resultado.Read();

                Console.WriteLine($"{resultado["id"]} - {resultado["nome"]}");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            finally
            {
                conexao.Close();
            }
        }

        static void excluirId(int id)
        {
            if (buscarId(id))
            {
                Console.WriteLine("Tem certeza que deseja excluir o registro?");
                Console.WriteLine("(S) - sim ou (N) - não");
                string resposta = Console.ReadLine();
                switch (resposta)
                {
                    case "S":
                        try
                        {
                            conexao = new MySqlConnection(strConexao);
                            conexao.Open();

                            var strComando = new MySqlCommand("Delete From contatos WHERE id =@ID", conexao);

                            strComando.Parameters.Add(new MySqlParameter("@ID", id));

                            var cmdExc = strComando.ExecuteNonQuery();

                            if(cmdExc > 0)
                            {
                                if (cmdExc == 1)
                                {
                                    Console.Write($"Contato excluido com sucesso. {cmdExc} registro afetado");
                                }
                            }
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);  
                        }
                        break;

                    default:
                        Console.WriteLine("Registro não excluido");
                        break;
                }
            }

        }
    }
}
