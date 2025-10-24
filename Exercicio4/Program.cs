int senha = 1234;

Console.WriteLine($"Ola usuario digite a sua senha:");
senha = int.Parse(System.Console.ReadLine());

if (senha == 1234)
{
    Console.WriteLine($"Acesso permitido!!!");
}
else
{
    Console.WriteLine($"Acesso negado tente novamente ");
}

