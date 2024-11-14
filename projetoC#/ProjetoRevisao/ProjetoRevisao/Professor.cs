using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRevisao
{
    internal class Professor
    {

        private int matricula;
        private string nome;

        public void setMatricula(int matricula)
        {
            this.matricula = matricula;
        }

        public void setNome(string nome) 
        {
            this.nome = nome.ToUpper();
        }
    }
}
