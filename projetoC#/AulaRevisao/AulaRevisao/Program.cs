using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AulaRevisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] carros = new string[3];
            carros[0] = "Gtr r35";
            carros[1] = "Porche 911";
            carros[2] = "Audi tt";


            for (int inicio= carros.Length-1; inicio >= 0; inicio-- ){
                Console.WriteLine($" o numero {inicio} é o : {carros[inicio]}");
            }
        }
        */

            ArrayList nome = new ArrayList();
            nome.Add("joao");
            nome.Add("pedro");
            nome.Add("juliana");

            for (int inicio = 0; inicio < nome.Count; inicio++)
            {
                Console.WriteLine(nome[inicio]);
            }
        }
    }
}
