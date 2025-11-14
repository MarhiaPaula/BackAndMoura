
namespace Heranca
{
    public class Gerente : Funcionario
    {
        public float Bonus;

        public float CalcularSalario()
        {
            return SalarioBase += Bonus;
        }
    }

    
}