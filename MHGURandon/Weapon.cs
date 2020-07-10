using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHGURandon
{
    class Weapon
    {
        private int no;
        private string name;
        private Image image;

        public Weapon(int no, string name, Image image)
        {
            this.No = no;
            this.Name = name;
            this.Image = image;
        }

        public int No { get => no; set => no = value; }
        public string Name { get => name; set => name = value; }
        public Image Image { get => image; set => image = value; }
    }

}
