using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet.Other
{
    public class Spell
    {
        public string Name { get; set; }
        public List<string> School { get; set; }
        public List<string> Subschool { get; set; }
        public List<string> Descriptor { get; set; }
        public List<KeyValuePair<int, string>> LevelAndClass { get; set; }
        public List<string> Components { get; set; }
        public string CastingTime { get; set; }
        public string Range { get; set; }
        public string TarEffAer { get; set; }
        public string Duration { get; set; }
        public string SavingThrow { get; set; }
        public bool SpellResistance { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public bool isHarmless { get; set; }
        public bool onlyObject { get; set; }

        public Spell() 
        {
            Name = "";
            School = new List<string>();
            Subschool = new List<string>();
            Descriptor = new List<string>();
            LevelAndClass = new List<KeyValuePair<int, string>>();
            Components = new List<string>();
            CastingTime = "";
            Range = "";
            TarEffAer = "";
            Duration = "";
            SavingThrow = "";
            SpellResistance = false;
            Description = "";
            ShortDescription = "";
            isHarmless = false;
            onlyObject = false;
        }
    }
}
