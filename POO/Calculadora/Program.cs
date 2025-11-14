using Calculadora;

Console.Clear();
Console.WriteLine("========================================");
Console.WriteLine("          BEM-VINDO À CALCULADORA       ");
Console.WriteLine("========================================");
Console.WriteLine();


Calculator calc = new Calculator();

int opcao = -1;

do
{

    Console.WriteLine("Menu");
    Console.WriteLine("   1) Somar");
    Console.WriteLine("   2) Subtrair");
    Console.WriteLine("   3) Multiplicar");
    Console.WriteLine("   4) Dividir");
    Console.WriteLine("   0) Sair");
    Console.Write("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    Console.Write("Digite o primeiro número: ");
    calc.Numero1 = int.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    calc.Numero2 = int.Parse(Console.ReadLine());

    Console.WriteLine($"Resultado da Soma: {calc.Somar()}");


    switch (opcao)

    {
        case 1:
            Console.WriteLine($"Resultado da soma: {calc.Somar()}");
            break;

        case 2:
            Console.WriteLine($"Resultado da subtração: {calc.Subtrair()}");
            break;

        case 3:
            Console.WriteLine($"Resultado da multiplicação: {calc.Multiplicar()}");
            break;

        case 4:
            Console.WriteLine($"Resultado da divisão: {calc.Dividir()}");
            break;

        case 0:
            Console.WriteLine($"Obrigado por utilizar o programa! Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida! Tente novamente.");
            break;
    }


    Console.WriteLine("Digite <Enter> para sair");
    Console.WriteLine();

} while (opcao != 0);

