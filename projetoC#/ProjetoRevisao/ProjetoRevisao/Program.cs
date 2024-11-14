using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProjetoRevisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Curso ds = new Curso();
            ds.id = 1;
            ds.setNome("Desenvolvimento de Sistemas");

            Curso adm = new Curso();
            adm.id = 2;
            adm.setNome("Adiministração");

            Curso especex = new Curso();
            especex.id = 3;
            especex.setNome("Escola Preparatória de Cadetes do Exército");

            Curso afa = new Curso();
            afa.id = 4;
            afa.setNome("Academia da Força Aérea");

            Curso en = new Curso();
            en.id = 5;
            en.setNome("Escola Naval");

            Curso esa = new Curso();
            esa.id = 6;
            esa.setNome("Escola de Sargentos das Armas");

            Professor professor1 = new Professor();
            professor1.setMatricula(1);
            professor1.setNome("Tone");

            Professor professor2 = new Professor();
            professor2.setMatricula(2);
            professor2.setNome("Franklin");

            Professor professor3 = new Professor();
            professor3.setMatricula(3);
            professor3.setNome("Isabela");

            Professor professor4 = new Professor();
            professor4.setMatricula(4);
            professor4.setNome("Glebson");

            Professor professor5 = new Professor();
            professor5.setMatricula(5);
            professor5.setNome("Gustavo Guanabara");

            ds.prof = professor1;
            afa.prof = professor4;
            especex.prof = professor5;

            Curso Padaria = new Curso();
            Padaria.id = 10;
            Padaria.setNome("paozada");
            Padaria.prof = new Professor();
            Padaria.prof.setMatricula(80);
            Padaria.prof.setNome("Paolinho Silva");

            Modalidade hibrida = new Modalidade();
            hibrida.setCodigo(1);
            hibrida.setModalidade("hibrida");


            Curso ita = new Curso();
            ita.id = 99;
            ita.setNome("Instituto tecnologica da aeronautica");
            ita.prof = professor2;
            ita.codigo = hibrida;
            ita.modalidade = hibrida;
        }
    }
}
