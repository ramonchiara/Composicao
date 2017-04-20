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
            double resultado = 0;

            Disciplina disciplina = Encontra(nomeDisciplina);
            if (disciplina != null)
            {
                resultado = disciplina.Media;
            }

            return resultado;
        }

        public bool GetAprovado(string nomeDisciplina)
        {
            bool resultado = false;

            Disciplina disciplina = Encontra(nomeDisciplina);
            if (disciplina != null)
            {
                resultado = disciplina.Aprovado;
            }

            return resultado;
        }

        private Disciplina Encontra(string nomeDisciplina)
        {
            Disciplina resultado = null;

            foreach (Disciplina disciplina in disciplinas)
            {
                if (disciplina.Nome == nomeDisciplina)
                {
                    resultado = disciplina;
                    break;
                }
            }

            return resultado;
        }
    }
}
