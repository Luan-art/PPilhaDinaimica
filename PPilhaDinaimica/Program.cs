using PPilhaDinaimica;

PilhaLivro minhapilha = new PilhaLivro();
int opc;

do
{
    Console.Clear();
    Console.WriteLine("Menu principal - Pilha de livros");
    Console.WriteLine("Opções");
    Console.WriteLine("1 - Inserir Livro");
    Console.WriteLine("2 - Remover Livro");
    Console.WriteLine("3 - Impimir Pilha");
    Console.WriteLine("4 - Procurar Livro por Titulo");
    Console.WriteLine("5 - Quantos livros tem?");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Informar a opção desejada: < >\b\b");

    opc = int.Parse(Console.ReadLine());

    switch (opc)
    {
        case 1:
            minhapilha.push(cadastro_livro());
            break;
        case 2:
            minhapilha.pop();
            break;
        case 3:
            minhapilha.print();
            break;
        case 4:
            if (minhapilha.vazia())
            {
                Console.WriteLine("Pilha vazia");
                Console.ReadKey();
            }
            else
            {
               minhapilha.procurarLivro(definirTitulo());
            }
            break;
        case 5:     
               minhapilha.contadorLivros();
            break;
        case 0:
            Console.WriteLine("volte sempre");
            break;
        default:
            Console.WriteLine("Não existe essa opção");
            break;
    }
} while (opc != 0);

string definirTitulo()
{
    string titulo;
    Console.WriteLine("Informe o título do Livro que deseja achar: ");
    titulo = Console.ReadLine();

    return titulo;
}

Livro cadastro_livro()
{
    string titulo;
    Console.WriteLine("Informe o título do novo Livro: ");
    titulo = Console.ReadLine();
    Livro livro = new Livro(titulo);

    return livro;
}