using System.Runtime.CompilerServices;

namespace ConsoleEngineRevamp
{
    class Scene
    {
        private static int _id = 0;
        public int Id { get; private set; }

        public List<MonoBehaviour> Objects = new List<MonoBehaviour>();


        public Scene()
        {
            _id += 1;
            Id = _id;
        }

        
        public void Render()
        {

        }

        public async Task Update()
        {
            var updateTasks = Objects.Select(component => Task.Run(() => component.Update()));
            await Task.WhenAll(updateTasks);
        }
    }
}
