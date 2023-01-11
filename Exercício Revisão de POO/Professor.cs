using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Revisão_de_POO
{
    public class Professor : Pessoa
    {
        public void Explicar(string assunto)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"- Como eu não sei muito sobre {assunto}, em casa eu pesquiso e te explico na proxima aula");
            Thread.Sleep(1000);
        }
    }
}
