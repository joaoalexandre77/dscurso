using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula003
{
    internal class Turma
    {

        public int codigo;
        public String serie;

        public void mostrar() {
            Console.WriteLine($"codigo da turma é: {codigo} série da turma é: {serie}");
        }
    }
}
