namespace Exercício_Revisão_de_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CRIANDO PESSOA...\n");
            Thread.Sleep(1000);
            Pessoa pessoa = new Pessoa();

            Console.Write("Nome da Pessoa: ");
            pessoa.Nome = Console.ReadLine();

            bool sucesso;
            do
            {
                Console.Write($"Idade da(o) {pessoa.Nome}: ");
                sucesso = int.TryParse(Console.ReadLine(), out int idade);

                if (!sucesso)
                {
                    Console.WriteLine("Por Favor, utilize apenas numeros\n");
                    continue;
                }

                pessoa.Idade = idade;

            } while (!sucesso);

            Console.WriteLine("\nPESSOA CRIADA\n");

            Console.WriteLine($"Fazer {pessoa.Nome} Cumprimentar.");
            pessoa.Cumprimentar();
            Console.WriteLine($"\nFazer {pessoa.Nome} Dizer sua Idade.");
            pessoa.DizerIdade();

            Console.WriteLine("\n-------------------\n");

            Console.WriteLine("CRIANDO ALUNO...\n");
            Thread.Sleep(1000);
            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine($"Idade do(a) {aluno.Nome} : 21");
            aluno.Idade = 21;

            Console.WriteLine("\nALUNO CRIADO\n");

            Console.WriteLine($"Fazer {aluno.Nome} Ir para Escola.");
            aluno.IrParaEscola();
            Console.WriteLine($"\nFazer {aluno.Nome} Cumprimentar.");
            aluno.Cumprimentar();
            Console.WriteLine($"\nFazer {aluno.Nome} Dizer sua Idade.");
            aluno.DizerIdade();

            Console.WriteLine("\n-------------------\n");

            Console.WriteLine("CRIANDO PROFESSOR...\n");
            Thread.Sleep(1000);
            Professor professor = new Professor();

            Console.Write("Nome do Professor: ");
            professor.Nome = Console.ReadLine();

            Console.WriteLine($"Idade do(a) {professor.Nome} : 30");
            professor.Idade = 21;

            Console.WriteLine("\nPROFESSOR CRIADO\n");

            Console.WriteLine($"Fazer {professor.Nome} Cumprimentar.");
            professor.Cumprimentar();
            Console.WriteLine($"\nFazer {professor.Nome} Dizer sua Idade.");
            professor.DizerIdade();
            Console.WriteLine($"\nFazer {professor.Nome} Explicar um Assunto.");
            Console.Write("Assunto desejado: ");
            string assunto = Console.ReadLine();
            professor.Explicar(assunto);


        }
    }
}