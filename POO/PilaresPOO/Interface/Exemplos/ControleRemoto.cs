

namespace Exemplos
{
    public class ControleRemoto : IControle
    {
        public int NivelVolume = 30;
        public int VolumeMaximo = 30;

        public void Ligar()
        {
            Console.WriteLine($"Desligando a TV...");

        }

        public void AumentarVolume()
        {
            if (NivelVolume == VolumeMaximo)
            {
                Console.WriteLine($"Volume maximo atingido {NivelVolume}");
                return;

            }

            NivelVolume++;
            Console.WriteLine($"Volume: {NivelVolume}");

        }

        public void DiminuirVolume()
        {
             if (NivelVolume == 0)
            {
                Console.WriteLine($"Volume já está no mínimo {NivelVolume}");
                return;

            }
            
            NivelVolume--;
            Console.WriteLine($"Volume: {NivelVolume}");
        }
        public void Desligar()
        {
            Console.WriteLine($"Ligando a TV...");

        }

       
    }
}