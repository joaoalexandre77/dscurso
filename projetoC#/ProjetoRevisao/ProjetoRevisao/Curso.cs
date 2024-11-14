using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRevisao
{
    internal class Curso
    {
        public int id;
        private string nome;
        public Professor prof;
        public Modalidade codigo;
        public Modalidade modalidade;

        public void setNome(string nome)
        {
            this.nome = nome.ToUpper();
        }
    }
}
