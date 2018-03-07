using CharacterSheet.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet.DNDClasses
{
    public class Fighter
    {
        public static string Bab = "Good";
        public static string Fort = "Good";
        public static string Refl = "Poor";
        public static string Will = "Poor";
        public static int Hdie = 10;
        public static int SkillPoints = 2;
        private static Feats feat = new Feats();

        public static string[] Skills = { "Climb", "Craft", "Handle Animal", "Intimidate", "Jump", "Ride", "Swim" };

        public static string[] ArmorProf = { feat.ArmorProficiencyLight().Name, feat.ArmorProficiencyMedium().Name, feat.ArmorProficiencyHeavy().Name };
        public static string[] WeaponProf = { feat.SimpleWeaponProficiency().Name, feat.MartialWeaponProficiency(null).Name };
        public static string[] ShieldProf = { feat.ShieldProficiency().Name, feat.TowerShieldProficiency().Name };

        public List<KeyValuePair<int, string>> _listQualities;

        public Fighter(int _level)
        {
            _listQualities = new List<KeyValuePair<int,string>>();
            int feats = (_level / 2) + 1;
            int x = 1;
            for (int i = 0; i < feats; i++)
            {
                int z = (x-1)*2;
                if(z==0)
                    z = 1;
                _listQualities.Insert(i, new KeyValuePair<int, string>(z, "Fighter feat"));
                x++;
            }
        }
    }
}
