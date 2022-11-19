using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Ornek_II
{
    public delegate void OlayYakalayıcı();
    internal class Araba
    {
        public int Zaman { get; set; } = 0;
        public event OlayYakalayıcı Patlama;
        public event EventHandler LastikPat;
        Random random = new Random();
        public void Baslat()
        {
            for (int i = 0; i < 120; i++)
            {
                Thread.Sleep(100);
                Zaman++;
                int sayi = random.Next(20, 60);
                Console.WriteLine("hınnnnn"); //zamanı kaldırıp randomdan değer alıp if(sayi==rand) değer vermemiz halinde istediğimiz zaman patlata biliriz. Bu algoritmayi while içine koyman gerekir. 
                if (Zaman == sayi && Patlama != null)
                {
                    Patlama();
                    break;
                }
            }
        }
        public void Sur()
        {
            while (true)
            {
                Thread.Sleep(100);
                int sayi = random.Next(70);
                Console.WriteLine("aaaaaaaaaa" + sayi);
                if (sayi == 10 && LastikPat != null)
                {
                    LastikPat(this, new EventArgs());
                    break;
                }
            }
        }
    }
}
