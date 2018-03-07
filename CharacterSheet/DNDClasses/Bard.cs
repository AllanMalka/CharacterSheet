using CharacterSheet.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterSheet.DNDClasses
{
    public class Bard
    {
        private CharacterSheet charSheet;
        public static string Bab = "Average";
        public static string Fort = "Poor";
        public static string Refl = "Good";
        public static string Will = "Good";
        public static int Hdie = 6;
        public static int SkillPoints = 6;
        private static Feats feat = new Feats();

        public static string[] Skills = { "Appraise", "Balance", "Bluff", "Climb", "Concentration", "Craft", "Decipher Script", "Diplomacy", "Disguise", "Escape Artist", "Gather Information", "Hide", "Jump", "Knowledge(Arcana)", "Knowledge(Architecture and Engineering)", "Knowledge(Dungeoneering)", "Knowledge(Geography)", "Knowledge(History)", "Knowledge(Local)", "Knowledge(Nature)", "Knowledge(Nobility and Royality)", "Knowledge(Psionics)", "Knowledge(Religion)", "Knowledge(The Planes)", "Listen", "Move Silently", "Perform", "Profession", "Sense Motive", "Sleight of Hand", "Speak Language", "Spellcraft", "Swim", "Tumble", "Use Magic Device" };

        public static string[] ArmorProf = { feat.ArmorProficiencyLight().Name };
        public static string[] WeaponProf = { feat.SimpleWeaponProficiency().Name, feat.MartialWeaponProficiency("Longsword").Name, feat.MartialWeaponProficiency("Rapier").Name, feat.MartialWeaponProficiency("Sap").Name, feat.MartialWeaponProficiency("Short sword").Name, feat.MartialWeaponProficiency("Shortbow").Name, feat.MartialWeaponProficiency("Whip").Name };
        public static string[] ShieldProf = { feat.ShieldProficiency().Name };

        public SpellCaster spc;

        private string BardicMusic(int _level)
        {
            return "Bardic music " + _level + "/day";
        }

        private string BardicKnowledge(int _level)
        {
            int _modifier = 0;
            if (Application.OpenForms.Count > 0 )
            {
                charSheet = (CharacterSheet)Application.OpenForms[Application.OpenForms.Count - 1];
                _modifier = (charSheet.TempInt - 10) / 2;
            }
            //Need to make synergy bonus directly from skills
            int res = _level + _modifier; //+ _synergy;
            return "Bardic Knowledge +" + res;
        }

        public List<string> Songs(int _level)
        {
            List<string> listres = new List<string>();
            listres.Add("Countersong");
            listres.Add("Fascinate");
            #region Inspire Courage
            if (_level >= 20)
                listres.Add("Inspire Courage +4");
            else if (_level >= 14)
                listres.Add("Inspire Courage +3");
            else if (_level >= 8)
                listres.Add("Inspire Courage +2");
            else if (_level >= 1)
                listres.Add("Inspire Courage +1");
            #endregion
            if (_level >= 3)
                listres.Add("Inspire Competence");
            if (_level >= 6)
                listres.Add("Suggestion");
            if (_level >= 9)
                listres.Add("Inspire Greatness");
            if (_level >= 12)
                listres.Add("Song of Freedom");
            if (_level >= 15)
                listres.Add("Inspire Heroics");
            if (_level >= 18)
                listres.Add("Mass Suggestion");
            return listres;
        }

        public List<KeyValuePair<int, string>> _listQualities = new List<KeyValuePair<int, string>>();

        public Bard(int _level)
        {
            _listQualities.Insert(0, new KeyValuePair<int, string>(1, BardicMusic(_level)));
            _listQualities.Insert(1, new KeyValuePair<int, string>(1, BardicKnowledge(_level)));

            spc = new SpellCaster("Bard", _level);
        }
    }
}
