using System.Drawing;

namespace MHGURandon
{
    class Weapon
    {
        public int    No    { get; }
        public string Name  { get; }
        public Image  Image { get; }

        public Weapon(int no, string name, Image image)
        {
            No    = no;
            Name  = name;
            Image = image;
        }
    }
}
