using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPilhaDinaimica
{
    internal class Livro
    {
        string titulo;
        Livro anterior;

        public Livro(string titulo)
        {
            this.titulo = titulo;
            anterior = null;
        }

        public override string? ToString()
        {
            return "\nTitulo do livro: " + this.titulo;
        }

        public void setAnterior(Livro aux)
        {
            this.anterior = aux;
        }

        public Livro getAnterior()
        {
            return anterior;
        }

        public string getTitulo()
        {
            return titulo;
        }
    }
}
