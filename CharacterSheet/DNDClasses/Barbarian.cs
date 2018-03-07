using CharacterSheet.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet.DNDClasses
{
    public class Barbarian
    {
        public static string Bab = "Good";
        public static string Fort = "Good";
        public static string Refl = "Poor";
        public static string Will = "Poor";
        public static int Hdie = 12;
        public static int SkillPoints = 4;
        private static Feats feat = new Feats();

        public static string[] Skills = { "Climb", "Craft", "Handle Animal", "Intimidate", "Jump", "Listen", "Ride", "Survival", "Swim" }; 

        public static string[] ArmorProf = { feat.ArmorProficiencyLight().Name, feat.ArmorProficiencyMedium().Name };
        public static string[] WeaponProf = { feat.SimpleWeaponProficiency().Name, feat.MartialWeaponProficiency(null).Name };
        public static string[] ShieldProf = { feat.ShieldProficiency().Name };

        private static string _fastMovement = "Fast Movement";
        private string Illiterate(bool _can)
        {
            string res = "Illiterate";
            if (_can)
                res = "Litterate";
            return res;
        }
        private string Rage(int _level)
        {
            string res = "Rage ";
            if (_level >= 20)
                res = "Mighty Rage ";
            else if (_level >= 11)
                res = "Greater Rage ";
            int prDay = (_level / 4) + 1;
            return res + prDay + "/day";
        }
        private string DamageReduction(int _level)
        {
            string res = "";

            if (_level > 6)
            {
                int reduct = (_level - 7)/3+1;
                res = "Damage Reduction " + reduct + "/-";
            }

            return res;
        }
        private string TrapSense(int _level)
        {
            string res = "";
            if (_level > 2)
                res = "Trap sense +" + _level / 3;
            return res;
        }
        private static string _indoWll = "Indomitable Will";
        private static string _tirRag = "Tireless Rage";
        public List<KeyValuePair<int, string>> _listQualities = new List<KeyValuePair<int, string>>();
        private UniversalMethods uni = new UniversalMethods();

        public Barbarian(int _level, bool _otherClass)
        {
            _listQualities.Insert(0, new KeyValuePair<int, string>(1, _fastMovement));
            _listQualities.Insert(1, new KeyValuePair<int, string>(1, Illiterate(_otherClass)));
            _listQualities.Insert(2, new KeyValuePair<int, string>(1, Rage(_level)));
            _listQualities.Insert(3, new KeyValuePair<int, string>(2, uni.UncannyDodge(_level, 2, 5)));
            _listQualities.Insert(4, new KeyValuePair<int, string>(3, TrapSense(_level)));
            _listQualities.Insert(5, new KeyValuePair<int, string>(7, DamageReduction(_level)));
            _listQualities.Insert(6, new KeyValuePair<int, string>(14, _indoWll));
            _listQualities.Insert(7, new KeyValuePair<int, string>(17, _tirRag));
        }
    }
}
