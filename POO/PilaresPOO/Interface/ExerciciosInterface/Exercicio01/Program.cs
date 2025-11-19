Console.Clear();
Console.WriteLine($"--Bem Vindo ao programa de Geometria--");
Console.WriteLine();


Console.WriteLine($"Vamos calcular a area do retangulo");

Console.WriteLine($"Informe a altura: ");
float altura = float.Parse(Console.ReadLine());
Console.WriteLine($"Informa a largura: ");
float largura = float.Parse(Console.ReadLine());


Retangulo retangulo = new Retangulo(largura, altura);
Console.WriteLine();


Console.WriteLine($"Agora vamos calcular a area do circulo");
Console.WriteLine($"Informe o raio do circulo");
float raio = float.Parse(Console.ReadLine());

Circulo circulo = new Circulo();
circulo.Raio = raio;

Console.WriteLine();

retangulo.CalcularArea();
circulo.CalcularArea();

