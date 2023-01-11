using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Revisão_de_POO
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Cumprimentar()
        {
            Thread.Sleep(1000);
            Console.WriteLine("- Ola, meu nome é " + Nome);
            Thread.Sleep(1000);
        } 

        public void DizerIdade()
        {
            Thread.Sleep(1000);
            Console.WriteLine("- Eu tenho " + Idade + " anos");
            Thread.Sleep(1000);
        }
    }
}
