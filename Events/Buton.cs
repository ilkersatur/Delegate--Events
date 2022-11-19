using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void OlayYakalayıcı();
    internal class Buton
    {
        public event OlayYakalayıcı Tıkla;
        public void Tetikle()
        {
            if (Tıkla != null)
                Tıkla();
            //Tıkla?.Invoke();
        }
    }
}
