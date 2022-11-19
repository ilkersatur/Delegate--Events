using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Ornek
{
    public delegate void OlayYakalayıcı();
    internal class Isıtıcı
    {
        public int Isı { get; set; } = 0;
        public event OlayYakalayıcı Kabarciklanma;
        public event OlayYakalayıcı SesCikar;
        public event OlayYakalayıcı Fokurdama;

        public void Baslat()
        {
            for (int i = 0; i < 120; i++)
            {
                Thread.Sleep(100);
                Isı++;
                Console.WriteLine(Isı);
                if (Isı > 20 && Kabarciklanma != null)
                    Kabarciklanma();
                if (Isı > 50 && SesCikar != null)
                    SesCikar();
                if (Isı > 90 && Fokurdama != null)
                    Fokurdama();

            }
        }

    }

}