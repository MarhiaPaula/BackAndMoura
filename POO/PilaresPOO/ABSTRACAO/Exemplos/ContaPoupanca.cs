namespace Exemplos
{
    public class ContaPoupanca : ContaBancaria

    { public double saldo = 0;
  
        public override void Depositar(double valor)
        {
           if(valor <= 0)
            {
                Console.WriteLine($"O valor do deposito deve ser positivo");
                return;
                
            }

            saldo += valor;
        }

        public override void Sacar(double valor)
        {
            throw new NotImplementedException();
        }
    }
}
