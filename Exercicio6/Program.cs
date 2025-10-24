float media;
float frequencia;

Console.WriteLine($"Ola digite a media do aluno do senai");
media = float.Parse(Console.ReadLine());

Console.WriteLine($"Ola digite a frequancia do aluno do senai");
frequencia = float.Parse(Console.ReadLine());




if (frequencia < 75)
{
    Console.WriteLine("Aluno reprovado por frequência insuficiente!");
}


else if (frequencia >= 75 && media >= 7)
{
    Console.WriteLine($"aprovado");
}
else if (frequencia >= 75 && media >= 3)
{
    Console.WriteLine($"recuperação");
}
else
{
    Console.WriteLine($"reprovado");
}

