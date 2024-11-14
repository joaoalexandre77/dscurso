using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome;
            int idade = 0;

            Console.WriteLine("Chegamos ao c#");
            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("informe a sua idade:");

            try
            {
                idade = int.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("O seu esquisito, não foi possível realizar o cadastro.");
            }
            

            Console.WriteLine("Seja bem vindo (a)" + nome + idade);
            Console.WriteLine($"Seja bem vindo (a) {nome} estamos na aula de c#, notei que sua idade é: {idade} anos");

            

        }
    }
}
