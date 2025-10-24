    using System.Linq.Expressions;
    using System.Runtime.CompilerServices;
    int opcao = -1;

do
{
    Console.WriteLine($"-------------------------------------------------------------");
    Console.WriteLine($"                           Bem Vindo                         ");
    Console.WriteLine($"                              ao                             ");
    Console.WriteLine($"                           Jacareca Food                     ");
    Console.WriteLine($"-------------------------------------------------------------");


    Console.WriteLine($"");
    Console.WriteLine($"                    Escolha uma das opções                   ");

    Console.WriteLine($"");
    Console.WriteLine($"  1)   Hot Holl .....................................  $29,90");
    Console.WriteLine($"  2)   Temaki   .....................................  $17,00");
    Console.WriteLine($"  3)   Sashimi  .....................................  $19,50");
    Console.WriteLine($"  4)   Yakisoba .....................................  $20,00");
    Console.WriteLine($"  5)   Guioza   .....................................  $25,90");
    Console.WriteLine($"  6)   shimeji  .....................................  $29,90");
    Console.WriteLine($"  0)   Sair");
    Console.WriteLine($"Opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo...");

            break;
        case 1:
            HotHoll();
            break;
        case 2:
            Temaki();
            break;
        case 3:
            Sashimi();
            break;
        case 4:
            Yakisoba();
            break;
        case 5:
            Guioza();
            break;
        case 6:
            shimeji();
            break;

        default:
            Console.WriteLine($"Opção Inválida");
            break;
    }

    Console.WriteLine($"Digite <Enter> para continuar...");
    Console.ReadLine();

} while (opcao != 0);


void HotHoll()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Hot Holl com carinho");
}
void Temaki()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Temaki com carinho");
}
void Sashimi()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Sashimi com carinho");
}
void Yakisoba()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Yakisoba com carinho");
}
void Guioza()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Guioza com carinho");
}
void shimeji()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu shimeji com carinho");
}



