using System.Drawing;

namespace ConsoleEngineRevamp
{
    class Texture
    {
        public enum TextureType
        {
            Single,
            Rectangle
        }

        private Color[] colors;
        private string chars;
        private TextureType type;
        public Color[] Colors { get { return colors; } set { colors = value; } }
        public string Chars { get { return chars; } set {  chars = value; } }
        public TextureType Type { get { return type; } set { type = value; } }

        public Texture(TextureType type, string chars, Color[] colors)
        {
            this.chars = chars;
            this.colors = colors;
            this.type = type;
        }

    }
}
