
using System.Security;

namespace PPilhaDinaimica
{
    internal class PilhaLivro
    {
        Livro topo;

        public PilhaLivro()
        {
            topo = null;
        }

        public void push(Livro aux)
        {
            if (vazia())
            {
                this.topo = aux;
            }
            else
            {
                aux.setAnterior(topo);
                this.topo = aux;
            }
        }

        public void print()
        {
            Livro aux = topo;

            if (vazia())
            {
                Console.WriteLine("Pilha vazia");
                Console.WriteLine("Pressione qualqeur tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.getAnterior();

                } while (aux != null);

                Console.WriteLine("\nFim da impreesão");
                Console.WriteLine("\nPressione qualqeur tecla para continuar...");
                Console.ReadKey();
            }
        }

        public Boolean vazia()
        {
            if (topo == null)
                return true;
            else
                return false;
        }

        public void pop()
        {
            if (vazia())
            {
                Console.WriteLine("Pilha vazia, impossivel remover");
                Console.WriteLine("Pressione qualqeur tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                topo = topo.getAnterior();
            }
        }

        public void procurarLivro(string titulo)
        {
            Livro aux = topo;
            int i = 0;

            do
            {
                if (titulo.Equals(aux.getTitulo()))
                {
                    Console.WriteLine(aux.ToString());
                    i++;
                }


                aux = aux.getAnterior();

            } while (aux != null);

            Console.WriteLine("Livro encontrado " + i + " vezes");
            Console.WriteLine("\nFim da impreesão");
            Console.WriteLine("\nPressione qualqeur tecla para continuar...");
            Console.ReadKey();

        }

        internal void contadorLivros()
        {
            Livro aux = topo;
            int i = 0;
             
            while(aux != null )
            {
                i++;
                aux = aux.getAnterior();
            }

            Console.WriteLine("\nTemos " + i + " Livros");
            Console.WriteLine("\nFim da impreesão");
            Console.WriteLine("\nPressione qualqeur tecla para continuar...");
            Console.ReadKey();

        }
    }
}
