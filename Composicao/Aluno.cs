using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao
{
    class Aluno
    {
        private string nome;
        private List<Disciplina> disciplinas = new List<Disciplina>();

        public Aluno(string nome)
        {
            this.nome = nome;
        }

        public string Nome
        {
            get { return nome; }
        }

        public void Guarde(Disciplina disciplina)
        {
            disciplinas.Add(disciplina);
        }

        public double GetMedia(string nomeDisciplina)
        {
            foreach(Disciplina disciplina in disciplinas)
            {
                if (disciplina.Nome == nomeDisciplina)
                {
                    return disciplina.Media;
                }
            }

            return 0;
        }

        public bool GetAprovado(string nomeDisciplina)
        {
            foreach (Disciplina disciplina in disciplinas)
            {
                if (disciplina.Nome == nomeDisciplina)
                {
                    return disciplina.Aprovado;
                }
            }

            return false;
        }
    }
}
