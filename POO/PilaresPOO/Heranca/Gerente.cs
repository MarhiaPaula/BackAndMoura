using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Gerente : Funcionario
    {

        public float Bonus;
        public override float CalcularSalario()
        {
            return SalarioBase = +Bonus;
        }
    }
}