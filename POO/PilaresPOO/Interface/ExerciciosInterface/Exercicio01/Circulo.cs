namespace Exercicio01
{
    public class Circulo : IForma
    {


        public void CalcularArea()
        {
            float area = (float)Math.PI * Raio * Raio;
            Console.WriteLine($"A area do circulo e : {area}");
        }
    }
}
