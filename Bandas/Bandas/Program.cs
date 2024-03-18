void Intro()
{
    Console.WriteLine(@"
░██████╗░█████╗░██╗░░██╗░█████╗░░█████╗░██╗░░░░░░██████╗  ░█████╗░██╗░░░██╗████████╗██╗
██╔════╝██╔══██╗██║░░██║██╔══██╗██╔══██╗██║░░░░░██╔════╝  ██╔══██╗██║░░░██║╚══██╔══╝██║
╚█████╗░██║░░╚═╝███████║██║░░██║██║░░██║██║░░░░░╚█████╗░  ██║░░██║██║░░░██║░░░██║░░░██║
░╚═══██╗██║░░██╗██╔══██║██║░░██║██║░░██║██║░░░░░░╚═══██╗  ██║░░██║██║░░░██║░░░██║░░░╚═╝
██████╔╝╚█████╔╝██║░░██║╚█████╔╝╚█████╔╝███████╗██████╔╝  ╚█████╔╝╚██████╔╝░░░██║░░░██╗
╚═════╝░░╚════╝░╚═╝░░╚═╝░╚════╝░░╚════╝░╚══════╝╚═════╝░  ░╚════╝░░╚═════╝░░░░╚═╝░░░╚═╝");
}

List<string> listaNome = new List<string>();
void MenuInicial()
{
    Intro();
    Console.WriteLine("MENU");
    Console.WriteLine("1 - Inserir nome");
    Console.WriteLine("2 - Listar pessoal");
    Console.WriteLine("3 - Avaliar nome");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");

    int opMenu = int.Parse(Console.ReadLine()!);
    
    Thread.Sleep(1000);
    Console.Clear();

    switch (opMenu)
    {
        case 1:
            InserirNome();
            break;

        case 2:
            ListarNome();
            break;

        case 3:
            Console.WriteLine();
            break;

        case 0:
            Console.WriteLine("Hasta la vista Hermano");
            break;

        default:
            Console.WriteLine("Opção Inexistente");
            break;
    }
}

void InserirNome()
{
    Console.Clear();
    ExibirTitulo("Inserir nomes");
    Console.Write("Insira o nome desejado: ");
    string nome = Console.ReadLine()!;
    Console.WriteLine($"Você cadastrou o nome: {nome}");
    listaNome.Add(nome);
    Thread.Sleep(1000);
    Console.Clear();
    MenuInicial();
}

void ListarNome()
{
    Console.Clear();
    ExibirTitulo("Listar nomes");
    
    if(listaNome.Count == 0)
    {
        Console.WriteLine("Lista vazia.");
    }
    else
    {
        Console.WriteLine("Nomes Registrados\n");
        foreach(var nome in listaNome) 
        {
            Console.WriteLine($"{nome}");
        }
    }
    Console.Write("Pressione qualquer tecla...");
    Console.ReadKey();
    Thread.Sleep(1000);
    Console.Clear();
    MenuInicial();
}

void ExibirTitulo(string titulo)
{
    int qtd = titulo.Length;
    string frufru = string.Empty.PadLeft(qtd, '*');
    Console.WriteLine(frufru);
    Console.WriteLine(titulo);
    Console.WriteLine(frufru+"\n");
}

MenuInicial();