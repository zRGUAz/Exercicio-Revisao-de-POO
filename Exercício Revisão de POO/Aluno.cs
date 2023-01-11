using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Revisão_de_POO
{
    public class Aluno : Pessoa
    {
        public void IrParaEscola()
        {
            Thread.Sleep(1000);
            Console.WriteLine("- Estou andando até a escola");
            Thread.Sleep(1000);
        }
    }
}
