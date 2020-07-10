using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHGURandon
{
    public partial class Form1 : Form
    {
        int index = 0;
        string[] styleName ;
        Weapon[] weapons;
        public Form1()
        {
            styleName = new string[7];
            styleName[0]="公會風格";
            styleName[1] = "強襲風格";
            styleName[2] = "空戰風格";
            styleName[3] = "武士道";

            styleName[4] = "英勇風格";
            styleName[5] = "煉金風格";
            styleName[6] = "";

            weapons = new Weapon[15];
            weapons[0]=new Weapon(0,"大劍",Properties.Resources._000);
            weapons[1]=new Weapon(1, "太刀", Properties.Resources._001);
            weapons[2]=new Weapon(2, "單手劍", Properties.Resources._002);
            weapons[3]=new Weapon(3, "雙劍", Properties.Resources._003);
            weapons[4]=new Weapon(4, "大槌", Properties.Resources._004);
            weapons[5]=new Weapon(5, "狩獵笛", Properties.Resources._005);
            weapons[6] = new Weapon(6, "長槍", Properties.Resources._006);
            weapons[7] = new Weapon(7, "銃槍", Properties.Resources._007);
            weapons[8] = new Weapon(8, "斬擊斧", Properties.Resources._008);
            weapons[9] = new Weapon(9, "操蟲棍", Properties.Resources._009);
            weapons[10] = new Weapon(10, "充能斧", Properties.Resources._010);
            weapons[11] = new Weapon(11, "輕弩", Properties.Resources._011);
            weapons[12] = new Weapon(12, "重弩", Properties.Resources._012);
            weapons[13] = new Weapon(13, "弓", Properties.Resources._013);
            weapons[14] = new Weapon(14, "獵喵", Properties.Resources._014);

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index++;
            Random r = new Random();
            int i1 = r.Next(0, 15);
            int i2 = r.Next(0,6);
          
            if (i1 == 14) {
                i2 = 6;
            }

            stylenamelabel.Text = styleName[i2];
            weaponBox.Image = weapons[i1].Image;
            weponnamelabel.Text = weapons[i1].Name;
            if (i1 < 14)
            {
                listBox.Items.Add("第" + index + "次結果:" + styleName[i2] + "X" + weapons[i1].Name);
            }
            else if(i1==14){
                listBox.Items.Add("第" + index + "次結果: 獵喵");

            }
        }
    }
}
