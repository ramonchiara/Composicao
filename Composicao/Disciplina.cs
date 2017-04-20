using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao
{
    class Disciplina
    {
        private string nome;
        private double p1, p2;

        public Disciplina(string nome, double p1, double p2)
        {
            this.nome = nome;
            this.p1 = p1;
            this.p2 = p2;
        }

        public string Nome
        {
            get { return nome; }
        }

        public double Media
        {
            get
            {
                return (p1 + p2) / 2;
            }
        }

        public bool Aprovado
        {
            get
            {
                return Media >= 6;
            }
        }
    }
}
