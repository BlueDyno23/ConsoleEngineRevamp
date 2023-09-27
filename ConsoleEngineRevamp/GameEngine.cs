namespace ConsoleEngineRevamp
{
    class GameEngine
    {
        #region Singleton
        private static GameEngine _instance;

        public GameEngine GetInstance()
        {
            if (_instance == null)
            {
                _instance = new GameEngine();
            }
            return _instance;
        }
        #endregion

        #region Scene
        private List<Scene> scenes = new List<Scene>();
        private Scene currentScene;

        public void SetCurrentScene(Scene scene)
        {
            currentScene = scene;
        }
        public void AddScene(Scene scene)
        {
            scenes.Add(scene);
        }
        #endregion

        private bool isRunning;

        public int SleepDuration { get; set; }

        #region Running Methods
        public async void Run()
        {
            isRunning = true;
            var startTasks = currentScene.Objects.Select(component => Task.Run(() => component.Start()));
            await Task.WhenAll(startTasks);

            while (isRunning)
            {
                await currentScene.Update();
                await Task.Delay(SleepDuration);
            }
        }

        public void Stop()
        {
            isRunning = false;
        }
        #endregion
    }
}
