using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula003
{
    internal class Aluno
    {
        public String nomeAluno;
        public int idadeAluno;
        public String nomePai;
        public String nomeMae;
        public double pesoAluno;

        public void mostrarDados()
        {
            Console.WriteLine($"nome do aluno: {nomeAluno} idade: {idadeAluno} peso do aluno: {pesoAluno} nome do pai: {nomePai} nome da mãe: {nomeMae} ");
        }
    }
}
