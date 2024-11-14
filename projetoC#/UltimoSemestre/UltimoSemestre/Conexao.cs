using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data; // Biblioteca da conexão SQL.
using MySql.Data.MySqlClient; // Bibllioteca da conexão SQL.

namespace UltimoSemestre
{
    class Conexao
    {
        public MySqlConnection conectar;
        public string servidor;
        public string database;
        public string usuario;
        public string senha;


        // Construindo a conexão


        public Conexao()
        {
            Inicializar();
        }


        //Inicializar conexão com o sql
        public void Inicializar()
        {
            servidor = "127.0.0.1";
            database = "ultimosemestre";
            usuario = "root";
            senha = "123456";

            string conexaoString;

            conexaoString = "SERVER=" + servidor + ";" + "DATABASE=" +
            database + ";" + "UID=" + usuario + ";" + "PASSWORD=" + senha + ";";


            conectar = new MySqlConnection(conexaoString);
        }


        // Abrindo a database
        public bool AbrirConexao()
        {
            try
            {
                conectar.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        System.Windows.Forms.MessageBox.Show("Não foi possível conectar.");
                        break;
                    case 1045:
                        System.Windows.Forms.MessageBox.Show("Usuário e senha inválidos! Verifique.");
                        break;
                }
                return false;
            }
        }


        // Fechar conexão
        public bool FecharConexao()
        {
            try
            {
                conectar.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
