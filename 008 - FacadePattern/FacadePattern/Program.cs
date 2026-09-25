namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            CdPlayer cdPlayer = new CdPlayer(amp);
            DvdPlayer dvdPlayer = new DvdPlayer(amp);
            PopcornPopper popcornPopper = new PopcornPopper();
            Projector projector = new Projector();
            Screen screen = new Screen();
            TheaterLights lights = new TheaterLights();
            Tuner tuner = new Tuner(amp);

            // Facade instantiëren met alle componenten van het subsysteem
            HomeTheaterFacade homeTheater = new HomeTheaterFacade(amp, tuner, dvdPlayer, cdPlayer,
                                                                  projector, screen, lights, popcornPopper);

            // Versimpelde methodes gebruiken om een film te starten en te stoppen
            homeTheater.WatchMovie("Die Hard");
            Console.WriteLine();
            homeTheater.EndMovie();
        }
    }
}
