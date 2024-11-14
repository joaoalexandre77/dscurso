using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula003
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Aluno primeiroAluno = new Aluno();
            primeiroAluno.nomeAluno = "João Alexandre Pinto Camargo";
            primeiroAluno.idadeAluno = 18;
            primeiroAluno.pesoAluno = 106.0 ;
            primeiroAluno.nomePai = "Laércio Camargo Junior";
            primeiroAluno.nomeMae = "Teodora Pinto";
            primeiroAluno.mostrarDados();

            Aluno segundoAluno = new Aluno();
            segundoAluno.nomeAluno = "Pedroso da Silva";
            segundoAluno.idadeAluno = 16;
            segundoAluno.pesoAluno = 40.0;
            segundoAluno.nomePai = "Cabuloso da Silva Alexandria";
            segundoAluno.nomeMae = "Rosa dos Alpes";
            segundoAluno.mostrarDados();

            Aluno terceiroAluno = new Aluno();
            terceiroAluno.nomeAluno = "Jacinto Pedrinha";
            terceiroAluno.idadeAluno = 21;
            terceiroAluno.pesoAluno = 200;
            terceiroAluno.nomePai = "Jaqison Pedrinha Junior";
            terceiroAluno.nomeMae = "Jubiscreuza Fortes Camargo";
            terceiroAluno.mostrarDados();


            Turma primeiraTurma = new Turma();
            primeiraTurma.codigo = 1;
            primeiraTurma.serie = "3 serie B";
            primeiraTurma.mostrar();

            Turma segundaTurma = new Turma();
            segundaTurma.codigo = 2;
            segundaTurma.serie = "1 ano A";
            segundaTurma.mostrar();
        }
    }
}
