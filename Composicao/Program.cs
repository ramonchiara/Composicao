using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            // ENTRADA
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            // PROCESSAMENTO
            Aluno aluno = new Aluno(nome);

            bool sair = false;
            do
            {
                // ENTRADA
                Console.Write("Disciplina: ");
                string nomeDisciplina = Console.ReadLine();
                if (nomeDisciplina == "")
                {
                    sair = true;
                    continue;
                }

                Console.Write("Prova 1: ");
                double p1 = double.Parse(Console.ReadLine());

                Console.Write("Prova 2: ");
                double p2 = double.Parse(Console.ReadLine());

                // PROCESSAMENTO
                Disciplina disciplina = new Disciplina(nomeDisciplina, p1, p2);
                aluno.Guarde(disciplina);
            } while (!sair);

            sair = false;
            do
            {
                // ENTRADA
                Console.Write("Qual disciplina você quer saber? ");
                string nomeDisciplina = Console.ReadLine();
                if (nomeDisciplina == "")
                {
                    sair = true;
                    continue;
                }

                // PROCESSAMENTO
                double media = aluno.GetMedia(nomeDisciplina);
                bool aprovado = aluno.GetAprovado(nomeDisciplina);

                // SAÍDA
                Console.WriteLine("O aluno {0} {1} na disciplina {2} com média {3}.",
                    aluno.Nome, aprovado ? "passou" : "não passou", nomeDisciplina, media);
            } while (!sair);
        }
    }
}
