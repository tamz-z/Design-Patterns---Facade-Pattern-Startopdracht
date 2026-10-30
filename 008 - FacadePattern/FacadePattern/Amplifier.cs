using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Amplifier
    {
        // Nullable (?): de input wordt pas later gekozen via SetTuner/SetDvd/SetCd
        private Tuner? _tuner;
        private DvdPlayer? _dvdPlayer;
        private CdPlayer? _cdPlayer;

        public void On()
        {
            Console.WriteLine("Amplifier aan");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier uit");
        }
        public void SetCd(CdPlayer cdPlayer)
        {
            this._cdPlayer = cdPlayer;
            Console.WriteLine("Amplifier input op CD");
        }
        public void SetDvd(DvdPlayer dvdPlayer)
        {
            this._dvdPlayer = dvdPlayer;
            Console.WriteLine("Amplifier input op DVD");
        }
        public void SetStereoSound()
        {
            Console.WriteLine("Amplifier op stereo geluid");
        }
        public void SetSurroundSound()
        {
            Console.WriteLine("Amplifier op surround geluid");
        }
        public void SetTuner(Tuner tuner)
        {
            this._tuner = tuner;
            Console.WriteLine("Amplifier input op tuner");
        }
        public void SetVolume(int volume)
        {
            Console.WriteLine($"Amplifier volume op {volume}");
        }

    }
}
