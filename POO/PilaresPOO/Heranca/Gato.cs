
namespace Heranca
{
    public class Gato : Animal
    {
        public string nome;

        public string raça;

        public int idade;

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {nome}, raça {raça}, idade {idade}");

        }
        
        public void FazerSom()
        {
            Console.WriteLine($"Miau");
            
        }
    }
}