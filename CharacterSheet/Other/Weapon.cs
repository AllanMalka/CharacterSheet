using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet.Other
{
    public class Weapon
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string DamageDie { get; set; }
        public string Critical { get; set; }
        public int RangeIncrement { get; set; }
        public double Weight { get; set; }
        public string Type { get; set; }
        public bool WeaponFiness { get; set; }
        public bool ZenArchery { get; set; }
        public string ExtraRule { get; set; }


        public Weapon(string _cat, string _name, string _size, string _ddie, string _crti, int _range, double _weight, string _type)
        {
            Category = _cat;
            Name = _name;
            Size = _size;
            DamageDie = _ddie;
            Critical = _crti;
            RangeIncrement = _range;
            Weight = _weight;
            Type = _type;
            WeaponFiness = false;
            ZenArchery = false;
            ExtraRule = "";
        }
    }
}
