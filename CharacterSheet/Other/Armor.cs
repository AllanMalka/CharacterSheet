using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet.Other
{
    public class Armor
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public int ArmorBonus { get; set; }
        public int ShieldBonus { get; set; }
        public int MaxDex { get; set; }
        public int ArmorPenalty { get; set; }
        public int ArcaneFailure { get; set; }
        public int Speed { get; set; }
        public double Weight { get; set; }

        public Armor(string _cat, string _name, int _bonus, int _maxdex, int _apen, int _arcane, int _speed, double _weight)
        {
            Category = _cat;
            Name = _name;
            if (_cat.Equals("Shields"))
            {
                MaxDex = 100;
                ArmorBonus = 0;
                ShieldBonus = _bonus;
            }
            else
            {
                MaxDex = _maxdex;
                ShieldBonus = 0;
                ArmorBonus = _bonus;
            }
            ArmorPenalty = _apen;
            ArcaneFailure = _arcane;
            Speed = _speed;
            Weight = _weight;
        }
    }
}
