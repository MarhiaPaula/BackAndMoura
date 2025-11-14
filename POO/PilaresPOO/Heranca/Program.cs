class Program
    {
        static void Main(string[])
        {
           
            Animal meuCachorro = new Cachorro();
            Animal meuGato = new Gato();

            
            meuCachorro.FazerSom(); 
            meuGato.FazerSom();     

            Console.ReadKey();
        }
    }
}
