
namespace Heranca
{
    public class Moto : Aviao
    {
        public int QtdRodas;

        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Quantas rodas: {QtdRodas}");


        }

    }
}