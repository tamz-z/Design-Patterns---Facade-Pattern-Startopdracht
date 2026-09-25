namespace GameApp
{
    // Facade: één simpele interface voor alle subsystemen
    public class GameFacade
    {
        private readonly GraphicsSystem graphics = new GraphicsSystem();
        private readonly AudioSystem audio = new AudioSystem();
        private readonly SaveSystem saveSystem = new SaveSystem();
        private readonly NetworkService network = new NetworkService();
        private readonly GameEngine gameEngine = new GameEngine();
        private readonly DebugConsole debugConsole = new DebugConsole();

        private bool developerMode;
        private bool online;

        public void StartGame(bool developerMode, bool online)
        {
            this.developerMode = developerMode;
            this.online = online;

            graphics.Initialize();
            graphics.SetResolution(1920, 1080);

            audio.Initialize();
            audio.SetVolume(70);

            saveSystem.LoadSettings();
            saveSystem.LoadPlayer();

            if (online)
            {
                network.Connect();
                network.Login();
            }

            if (developerMode)
            {
                debugConsole.Open();
            }

            gameEngine.LoadWorld();
            gameEngine.Start();
        }

        public void StopGame()
        {
            gameEngine.Stop();

            if (developerMode)
            {
                debugConsole.Close();
            }

            saveSystem.SavePlayer();

            if (online)
            {
                network.Logout();
                network.Disconnect();
            }

            audio.Shutdown();
            graphics.Shutdown();
        }
    }
}
