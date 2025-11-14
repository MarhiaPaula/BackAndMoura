using Primeiraclasse;

Console.WriteLine($"=== PROGRAMA PRIMEIRA CLASSE ===");

Carro mclaren = new Carro();
mclaren.marca = "Mclaren";
mclaren.cor = "Laranja";
mclaren.modelo = "750s";
mclaren.potencia = 800;


Console.WriteLine($"Ligando a {mclaren.marca} {mclaren.cor}");
mclaren.Ligar();
Console.WriteLine($"Acelerar a {mclaren.marca} {mclaren.potencia} cv");
mclaren.Acelerar();


mclaren.Ligar();
mclaren.Acelerar();




