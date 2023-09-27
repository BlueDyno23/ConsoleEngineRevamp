namespace ConsoleEngineRevamp
{
    abstract class MonoBehaviour
    {
        public Transform transform;
        public Texture texture;

        public abstract void Start();

        public abstract void Update();
    }
}
