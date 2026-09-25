using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class DvdPlayer
    {
        private Amplifier _amplifier;
        public DvdPlayer(Amplifier amplifier)
        {
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("DVD speler aan");
        }
        public void Off()
        {
            Console.WriteLine("DVD speler uit");
        }
        public void Eject()
        {
            Console.WriteLine("DVD speler eject");
        }
        public void Pause()
        {
            Console.WriteLine("DVD speler pauze");
        }
        public void Play(string movie)
        {
            Console.WriteLine($"DVD speler speelt \"{movie}\"");
        }
        public void SetSurroundAudio()
        {
            Console.WriteLine("DVD speler op surround audio");
        }
        public void SetTWoChannelAudio()
        {
            Console.WriteLine("DVD speler op two channel audio");
        }
        public void Stop()
        {
            Console.WriteLine("DVD speler gestopt");
        }
    }
}
