namespace Exercicio02
{
    public class Relatorio : IImprimivel
    {
        public string NomeResponsacel;

        public string TextoRelatorio;
        public void Imprimir()
        {
            Console.WriteLine($"Imprimindo o relatório...");
        }
    }
}