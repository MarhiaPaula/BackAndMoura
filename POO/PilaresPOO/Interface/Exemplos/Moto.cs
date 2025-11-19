

namespace Exemplos
{
    public class Moto : IMotor
     {

        public string cor;
        public string Marca;
        public string Modelo;
         public int Ano;

        //construtores
        public Moto(string c, string m, string md, int a )
        {
            cor = c;
            Marca = m;
            Modelo = md;
            Ano = a;
        }


        //metodos
        public void ExibirInfo()
        {
            Console.WriteLine($@"Informações do Veículo
                Marca: {Marca}
                Modelo: {Modelo}
                Ano: {Ano}
                Cor: {cor}
            ");
            
        }


        public void Acelerar()
       
        {
            Console.WriteLine($"Acelerando a motoka");
            
        }

        public void Freiar()
        {
            Console.WriteLine($"Freando a moto com ABS");
            
        }
    }
}