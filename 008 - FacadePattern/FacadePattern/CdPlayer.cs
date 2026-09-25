using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class CdPlayer
    {
        private Amplifier _amplifier;
        public CdPlayer(Amplifier amplifier)
        {
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("CD speler aan");
        }
        public void Off()
        {
            Console.WriteLine("CD speler uit");
        }
        public void Eject()
        {
            Console.WriteLine("CD speler eject");
        }
        public void Pause()
        {
            Console.WriteLine("CD speler pauze");
        }
        public void Play()
        {
            Console.WriteLine("CD speler speelt");
        }
        public void Stop()
        {
            Console.WriteLine("CD speler gestopt");
        }
    }
}
