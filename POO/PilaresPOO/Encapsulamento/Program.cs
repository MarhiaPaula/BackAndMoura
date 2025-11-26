using Encapsulamento;

ContaBancaria contaMapa = new ContaBancaria();
ContaBancaria contaEdu = new ContaBancaria(1500);

contaMapa.Depositar (-180);
contaMapa.Depositar(20);
contaMapa.Sacar(-200);
contaEdu.Sacar(300);

Console.WriteLine();



Console.WriteLine($"Saldo atual da Mapa: {contaMapa.GetSaldo()}");
Console.WriteLine($"Saldo atual do Edu: {contaEdu.GetSaldo()}");

