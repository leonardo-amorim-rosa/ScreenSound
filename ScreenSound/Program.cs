void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
}

void ExibirMenuDeOpcoes()
{
    Console.WriteLine("\nBem vindos ao Screen Sound!");
    Console.WriteLine("Digite 1 para cadastrar uma nova música");
    Console.WriteLine("Digite 2 para exibir todas as musicas cadastrasas");
    Console.WriteLine("Digite 3 para avaliar uma música");
    Console.WriteLine("Digite 4 para ver o detalhe de uma música");
    Console.WriteLine("Digite -1 para sair do programa");

    Console.Write("Digite a opção escolhida: ");
    string opecaoEscolhida = Console.ReadLine()!;
    switch (int.Parse(opecaoEscolhida))
    {
        case 1: 
            Console.WriteLine("Cadastro de música");
            break;
        case 2:
            Console.WriteLine("Exibição das músicas cadastradas");
            break;
        case 3:
            Console.WriteLine("Avaliação de uma música");
            break;
        case 4:
            Console.WriteLine("Detalhe de uma música");
            break;
        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

ExibirLogo();
ExibirMenuDeOpcoes();