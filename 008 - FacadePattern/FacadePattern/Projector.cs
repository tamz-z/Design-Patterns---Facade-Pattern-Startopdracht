using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Projector
    {
        // Nullable (?): de input wordt pas later gekozen via SetInput
        private DvdPlayer? _dvdPlayer;
        public Projector()
        {
        }

        public void SetInput(DvdPlayer dvdPlayer)
        {
            this._dvdPlayer = dvdPlayer;
            Console.WriteLine("Projector input op DVD");
        }

        public void On()
        {
            Console.WriteLine("Projector aan");
        }

        public void Off()
        {
            Console.WriteLine("Projector uit");
        }

        public void TvMode()
        {
            Console.WriteLine("Projector in TV mode");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Projector in widescreen mode");
        }
    }
}
