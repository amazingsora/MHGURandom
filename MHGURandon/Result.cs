using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHGURandon
{
    class Result
    {
      private  String mhStyle;
       private  String weaponName;

        public string WeaponName { get => weaponName; set => weaponName = value; }
        public string MhStyle { get => mhStyle; set => mhStyle = value; }
    }

}
