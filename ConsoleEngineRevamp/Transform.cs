namespace ConsoleEngineRevamp
{
    class Transform
    {
        private int x;
        private int y;
        private int z;
        public int X { get { return x; } set {  x = ChangeX(value); } }
        public int Y { get { return y; } set { y = ChangeY(value); } }
        public int Z { get { return z; } set { z = ChangeZ(value); } }

        private int ChangeX(int x)
        {
            this.x = x;
            return x;
        }
        private int ChangeY(int y)
        { 
            this.y = y;
            return y;
        }

        private int ChangeZ(int z)
        {
            this.z = z;
            return z;
        }
    }
}
