using System;
using System.Windows.Forms;

namespace MHGURandon
{
    public partial class Form1 : Form
    {
        private readonly Random _random = new Random();

        private readonly string[] _styleNames =
        {
            "公會風格", "強襲風格", "空戰風格",
            "武士道",   "英勇風格", "煉金風格"
        };

        private readonly Weapon[] _weapons;

        private bool _includeCat = true;
        private int _rollCount = 0;

        private const int CatIndex = 14;

        public Form1()
        {
            _weapons = new[]
            {
                new Weapon(0,  "大劍",   Properties.Resources._000),
                new Weapon(1,  "太刀",   Properties.Resources._001),
                new Weapon(2,  "單手劍", Properties.Resources._002),
                new Weapon(3,  "雙劍",   Properties.Resources._003),
                new Weapon(4,  "大槌",   Properties.Resources._004),
                new Weapon(5,  "狩獵笛", Properties.Resources._005),
                new Weapon(6,  "長槍",   Properties.Resources._006),
                new Weapon(7,  "銃槍",   Properties.Resources._007),
                new Weapon(8,  "斬擊斧", Properties.Resources._008),
                new Weapon(9,  "操蟲棍", Properties.Resources._009),
                new Weapon(10, "充能斧", Properties.Resources._010),
                new Weapon(11, "輕弩",   Properties.Resources._011),
                new Weapon(12, "重弩",   Properties.Resources._012),
                new Weapon(13, "弓",     Properties.Resources._013),
                new Weapon(14, "獵喵",   Properties.Resources._014),
            };

            InitializeComponent();
        }

        // 回傳 (武器索引, 風格索引)；獵喵時風格索引為 -1
        private (int weaponIndex, int styleIndex) Roll()
        {
            int limit = _includeCat ? _weapons.Length : _weapons.Length - 1;
            int weaponIndex = _random.Next(0, limit);
            int styleIndex  = weaponIndex == CatIndex ? -1 : _random.Next(0, _styleNames.Length);
            return (weaponIndex, styleIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var (wi, si) = Roll();
            _rollCount++;

            weaponBox.Image      = _weapons[wi].Image;
            weponnamelabel.Text  = _weapons[wi].Name;
            stylenamelabel.Text  = si >= 0 ? _styleNames[si] : "";

            string entry = wi == CatIndex
                ? $"第{_rollCount}次結果：獵喵"
                : $"第{_rollCount}次結果：{_styleNames[si]} X {_weapons[wi].Name}";
            listBox.Items.Add(entry);
        }

        private void random4_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            for (int player = 1; player <= 4; player++)
            {
                var (wi, si) = Roll();
                string entry = wi == CatIndex
                    ? $"P{player} 請用：獵喵"
                    : $"P{player} 請用：{_styleNames[si]} X {_weapons[wi].Name}";
                listBox.Items.Add(entry);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e) => ToggleCat();
        private void Catlabel_Click(object sender, EventArgs e)    => ToggleCat();

        private void ToggleCat()
        {
            _includeCat = !_includeCat;
            if (_includeCat)
            {
                pictureBox3.Image = Properties.Resources._014no;
                Catlabel.Text     = "不要獵喵";
                catmessage.Text   = "";
            }
            else
            {
                pictureBox3.Image = Properties.Resources._014;
                Catlabel.Text     = "加入獵喵";
                catmessage.Text   = "已移除獵喵";
            }
        }

        private void panel3_Paint(object sender, System.Windows.Forms.PaintEventArgs e) { }
    }
}
