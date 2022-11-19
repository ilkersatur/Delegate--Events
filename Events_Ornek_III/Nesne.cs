using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Ornek_III
{
    delegate void OlayYakalayıcı();
    internal class Nesne
    {
        public event OlayYakalayıcı Tıkla;
        public void Tetikle()
        {
            if (Tıkla != null)
            {
                Tıkla();
            }
        }
    }
}