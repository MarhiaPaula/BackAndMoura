
string nome;
string sobrenomeDoFulano;
int idade;
float saldoBancario;
float investimentos;


Console.WriteLine("Olá, qual o seu nome?");
nome = Console.ReadLine();

Console.WriteLine("Qual é o seu sobrenome?");
sobrenomeDoFulano = Console.ReadLine();

Console.WriteLine("Qual é a sua idade?");
idade = int.Parse(Console.ReadLine());

Console.WriteLine("Qual é o saldo bancário?");
saldoBancario = float.Parse(Console.ReadLine());

Console.WriteLine("Qual é o investimento para esse ano?");
investimentos = float.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine($"Nome  {nome} {sobrenomeDoFulano}");
Console.WriteLine($"Idade do {nome} é {idade}");
Console.WriteLine($"Saldo Bancário {saldoBancario}");
Console.WriteLine($"Investimento este ano {investimentos}" );