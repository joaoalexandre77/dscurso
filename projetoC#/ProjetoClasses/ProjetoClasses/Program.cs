using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cliente clien01 = new cliente();
            clien01.codigo = 666;
            clien01.nome = "Jubiscreudo Andras";
            clien01.peso = 66.6;

            veiculo vei01 = new veiculo();
            vei01.setPlaca("ABC1666");
            vei01.setCor("Vermelho");
            vei01.SetAno(1999);

            Console.WriteLine("----------------");
            Console.WriteLine($"Este é o cliente de codigo : {clien01.codigo}");
            Console.WriteLine($"O nome é: {clien01.nome}");
            Console.WriteLine($"O peso é: {clien01.peso}");
            Console.WriteLine("----------------");
            Console.WriteLine($"A placa é: {vei01.getPlaca()}");
            Console.WriteLine($"A cor é : {vei01.getCor()}");
            Console.WriteLine($"O ano deste carro é: {vei01.getAno()}");
            

        }
    }
}
