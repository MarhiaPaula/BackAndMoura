namespace Exercicio02
{
    public class Contrato : IImprimivel
    {
        public string Nome;

        public string TextoClausula;
        public void Imprimir()
        {
            Console.WriteLine($"Imprimindo o contrato...");
        }
    }
}