namespace GameApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Developer mode? (j/n): ");
            bool developerMode = Console.ReadLine() == "j";

            Console.Write("Online spelen? (j/n): ");
            bool online = Console.ReadLine() == "j";

            GameFacade game = new GameFacade();

            game.StartGame(developerMode, online);

            Console.WriteLine("\nDruk op Enter om de game te stoppen...");
            Console.ReadLine();

            game.StopGame();

            Console.ReadLine();
        }
    }
}
