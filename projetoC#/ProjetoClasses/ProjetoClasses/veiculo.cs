using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClasses
{
    internal class veiculo
    {
        private String placa;
        private String cor;
        private int ano;

        public void setPlaca(String p)
        {
            placa = p.ToUpper();
        }

        public String getPlaca()
        {
            return placa;
        }

        public void setCor(String c)
        {
            cor = c;
        }

        public String getCor()
        {
            return cor;
        }

        public void SetAno(int a)
        {
            ano = a;
        }

        public int getAno()
        {
            return ano;
        }


    }
}
