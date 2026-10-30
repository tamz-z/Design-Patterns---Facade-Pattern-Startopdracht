using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    // Facade: één simpele interface voor het hele home theater subsysteem
    internal class HomeTheaterFacade
    {
        // HAS-A relatie met alle subsystemen
        private Amplifier _amp;
        private Tuner _tuner;
        private DvdPlayer _dvdPlayer;
        private CdPlayer _cdPlayer;
        private Projector _projector;
        private Screen _screen;
        private TheaterLights _lights;
        private PopcornPopper _popcornPopper;

        // Referentie naar ieder component van het subsysteem via de constructor
        public HomeTheaterFacade(Amplifier amp, Tuner tuner, DvdPlayer dvdPlayer, CdPlayer cdPlayer,
                                 Projector projector, Screen screen, TheaterLights lights, PopcornPopper popcornPopper)
        {
            _amp = amp;
            _tuner = tuner;
            _dvdPlayer = dvdPlayer;
            _cdPlayer = cdPlayer;
            _projector = projector;
            _screen = screen;
            _lights = lights;
            _popcornPopper = popcornPopper;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("--- Film starten ---");

            _popcornPopper.On();
            _popcornPopper.Pop();

            _lights.Dim(10);

            _screen.Down();

            _projector.On();
            _projector.SetInput(_dvdPlayer);
            _projector.WideScreenMode();

            _amp.On();
            _amp.SetDvd(_dvdPlayer);
            _amp.SetSurroundSound();
            _amp.SetVolume(5);

            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("--- Film stoppen ---");

            _popcornPopper.Off();

            _lights.On();

            _screen.Up();

            _projector.Off();

            _amp.Off();

            _dvdPlayer.Stop();
            _dvdPlayer.Eject();
            _dvdPlayer.Off();
        }

        public void ListenToCd()
        {
            Console.WriteLine("--- CD luisteren ---");

            _lights.On();

            _amp.On();
            _amp.SetCd(_cdPlayer);
            _amp.SetStereoSound();
            _amp.SetVolume(5);

            _cdPlayer.On();
            _cdPlayer.Play();
        }

        public void EndCd()
        {
            Console.WriteLine("--- CD stoppen ---");

            _cdPlayer.Stop();
            _cdPlayer.Eject();
            _cdPlayer.Off();

            _amp.Off();
        }

        public void ListenToRadio()
        {
            Console.WriteLine("--- Radio luisteren ---");

            _tuner.On();
            _tuner.SetFM();
            _tuner.SetFrequency();

            _amp.On();
            _amp.SetTuner(_tuner);
            _amp.SetStereoSound();
            _amp.SetVolume(5);
        }

        public void EndRadio()
        {
            Console.WriteLine("--- Radio stoppen ---");

            _tuner.Off();

            _amp.Off();
        }
    }
}
