using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet.Other
{
    public class Feat
    {
        public string Name { get; set; }
        public string FType { get; set; }
        public string Content { get; set; }
        public string Benefit { get; set; }
        public List<object> Prerequisite { get; set; }
        public List<string> ClassBonus { get; set; }
        public string NormalWithout { get; set; }
        public string Special { get; set; }
        public string Property { get; set; }
        public bool Multiple { get; set; }

        public Feat()
        {
            Name = "";
            FType = "";
            Content = "";
            Benefit = "";
            Prerequisite = new List<object>();
            ClassBonus = new List<string>();
            NormalWithout = null;
            Special = null;
            Property = "";
            Multiple = false;
        }
    }
}
