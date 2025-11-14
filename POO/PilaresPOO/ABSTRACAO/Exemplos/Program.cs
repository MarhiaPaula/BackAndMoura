using Exemplos;

// Animal birobinha = new Gato();
// Animal Milly = new Cachorro();
// Pessoa Marhia = new Pessoa();
 
// Marhia.Nome = "Marhia Paula";
// Marhia.Idade = 16;

// Marhia.FazerSom();
// Marhia.Mover();
// Marhia.Dormir();



Console.Clear();
Console.WriteLine($"CONTA CORRENTE");
ContaCorrente cc = new ContaCorrente(10);
Console.WriteLine($"Saldo inicial da conta: {cc.saldo}");
cc.Depositar(0.5);
Console.WriteLine($"Saldo apos deposito: R${cc.saldo}");
cc.Sacar(10.01);
Console.WriteLine($"Saldo apos o saque: R${cc.saldo}");

Console.WriteLine($"");


Console.WriteLine($"CONTA POUPANÇA");
ContaPoupanca cp = new ContaPoupanca(10);
Console.WriteLine($"Saldo inicial da poupança: {cp.saldo}");
cc.Depositar(0.5);
Console.WriteLine($"Saldo apos deposito: R${cp.saldo}");
cc.Sacar(10.01);
Console.WriteLine($"Saldo apos o saque: R${cp.saldo}");


