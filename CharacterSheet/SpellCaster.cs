using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    public class SpellCaster
    {
        /// <summary>
        /// First int is spell level, second is amount
        /// </summary>
        public List<KeyValuePair<int, int>> SpellsPrDay;
        /// <summary>
        /// First int is spell level, second is amount
        /// </summary>
        public List<KeyValuePair<int, int>> SpellsKnown;
        public string SpellRangeCloseStr { get; set; }
        public string SpellRangeMediumStr { get; set; }
        public string SpellRangeLongStr { get; set; }
        public int HighestLevel { get; set; }
        public bool StartZero { get; set; }
        public string CasterStat { get; set; }
        private static string _intelligence = "Int";
        private static string _wisdom = "Wis";
        private static string _charisma = "Cha";

        /// <summary>
        /// Input the specific class for its spells pr day and maybe spells known.
        /// </summary>
        /// <param name="_classname">The classes: Bard, Cleric, Druid, Paladin, Ranger, Sorcerer, Wizard</param>
        /// <param name="_level">Character level</param>
        public SpellCaster(string _classname, int _level)
        {
            SpellsPrDay = new List<KeyValuePair<int, int>>();
            SpellsKnown = new List<KeyValuePair<int, int>>();


            int temp = 0;
            if (_level > 0)
            {
                temp = _level;
            }
            else
            {
                temp = 1;
            }

            switch (_classname)
            {
                case "Bard": Bard(temp); break;
                case "Cleric": Cleric(temp); break;
                case "Druid": Druid(temp); break;
                case "Paladin": Paladin(temp); break;
                case "Ranger": Ranger(temp); break;
                case "Sorcerer": Sorcerer(temp); break;
                case "Wizard": Wizard(temp); break;
                default:
                    break;
            }
        }

        private string SpellRangeClose(int _level)
        {
            int res = 0;
            double prSecond = _level / 2;
            res = 25 + (Convert.ToInt32(Math.Floor(prSecond)*5));
            return res + " ft";
        }
        private string SpellRangeMedium(int _level)
        {
            int res = 100+(10*_level);
            return res + "ft";
        }
        private string SpellRangeLong(int _level)
        {
            int res = 400 + (40 * _level);
            return res + "ft";
        }

        private void Bard(int _level)
        {
            HighestLevel = 6;
            StartZero = true;
            SpellRangeCloseStr = "" + SpellRangeClose(_level);
            SpellRangeMediumStr = "" + SpellRangeMedium(_level);
            SpellRangeLongStr = "" + SpellRangeLong(_level);
            CasterStat = _charisma;

            #region Spells pr day
            #region Level 0
            if (_level >= 14)
            {
                SpellsPrDay.Insert(0, new KeyValuePair<int, int>(0, 4));
            }
            else if (_level >= 2)
            {
                SpellsPrDay.Insert(0, new KeyValuePair<int, int>(0, 3));
            }
            else if (_level == 1)
            {
                SpellsPrDay.Insert(0, new KeyValuePair<int, int>(0, 2));
            }
            #endregion
            #region Level 1
            if (_level >= 15)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 4));
            }
            else if (_level >= 5)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 3));
            }
            else if (_level >= 4)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 2));
            }
            else if (_level >= 3)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 1));
            }
            else if (_level >= 2)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 0));
            }
            #endregion
            #region Level 2
            if (_level >= 16)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 4));
            }
            else if (_level >= 8)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 3));
            }
            else if (_level >= 6)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 2));
            }
            else if (_level >= 5)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 1));
            }
            else if (_level >= 4)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 0));
            }
            #endregion
            #region Level 3
            if (_level >= 17)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 4));
            }
            else if (_level >= 11)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 3));
            }
            else if (_level >= 9)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 2));
            }
            else if (_level >= 8)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 1));
            }
            else if (_level >= 7)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 0));
            }
            #endregion
            #region Level 4
            if (_level >= 18)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 4));
            }
            else if (_level >= 14)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 3));
            }
            else if (_level >= 12)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 2));
            }
            else if (_level >= 11)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 1));
            }
            else if (_level >= 10)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 0));
            }
            #endregion
            #region Level 5
            if (_level >= 19)
            {
                SpellsPrDay.Insert(5, new KeyValuePair<int, int>(5, 4));
            }
            else if (_level >= 17)
            {
                SpellsPrDay.Insert(5, new KeyValuePair<int, int>(5, 3));
            }
            else if (_level >= 15)
            {
                SpellsPrDay.Insert(5, new KeyValuePair<int, int>(5, 2));
            }
            else if (_level >= 14)
            {
                SpellsPrDay.Insert(5, new KeyValuePair<int, int>(5, 1));
            }
            else if (_level >= 13)
            {
                SpellsPrDay.Insert(5, new KeyValuePair<int, int>(5, 0));
            }
            #endregion
            #region Level 6
            if (_level >= 20)
            {
                SpellsPrDay.Insert(6, new KeyValuePair<int, int>(6, 4));
            }
            else if (_level >= 19)
            {
                SpellsPrDay.Insert(6, new KeyValuePair<int, int>(6, 3));
            }
            else if (_level >= 18)
            {
                SpellsPrDay.Insert(6, new KeyValuePair<int, int>(6, 2));
            }
            else if (_level >= 17)
            {
                SpellsPrDay.Insert(6, new KeyValuePair<int, int>(6, 1));
            }
            else if (_level >= 16)
            {
                SpellsPrDay.Insert(6, new KeyValuePair<int, int>(6, 0));
            }
            #endregion
            #endregion

            #region Spells Known
            #region Level 0
            if (_level >= 3)
            {
                SpellsKnown.Insert(0, new KeyValuePair<int, int>(0, 6));
            }
            else if (_level == 2)
            {
                SpellsKnown.Insert(0, new KeyValuePair<int, int>(0, 5));
            }
            else if (_level == 1)
            {
                SpellsKnown.Insert(0, new KeyValuePair<int, int>(0, 4));
            }
            #endregion
            #region Level 1
            if (_level >= 16)
            {
                SpellsKnown.Insert(1, new KeyValuePair<int, int>(1, 5));
            }
            else if (_level >= 5)
            {
                SpellsKnown.Insert(1, new KeyValuePair<int, int>(1, 4));
            }
            else if (_level >= 3)
            {
                SpellsKnown.Insert(1, new KeyValuePair<int, int>(1, 3));
            }
            else if (_level >= 2)
            {
                SpellsKnown.Insert(1, new KeyValuePair<int, int>(1, 2));
            }
            #endregion
            #region Level 2
            if (_level >= 17)
            {
                SpellsKnown.Insert(2, new KeyValuePair<int, int>(2, 5));
            }
            else if (_level >= 7)
            {
                SpellsKnown.Insert(2, new KeyValuePair<int, int>(2, 4));
            }
            else if (_level >= 5)
            {
                SpellsKnown.Insert(2, new KeyValuePair<int, int>(2, 3));
            }
            else if (_level >= 4)
            {
                SpellsKnown.Insert(2, new KeyValuePair<int, int>(2, 2));
            }
            #endregion
            #region Level 3
            if (_level >= 18)
            {
                SpellsKnown.Insert(3, new KeyValuePair<int, int>(3, 5));
            }
            else if (_level >= 10)
            {
                SpellsKnown.Insert(3, new KeyValuePair<int, int>(3, 4));
            }
            else if (_level >= 8)
            {
                SpellsKnown.Insert(3, new KeyValuePair<int, int>(3, 3));
            }
            else if (_level >= 7)
            {
                SpellsKnown.Insert(3, new KeyValuePair<int, int>(3, 2));
            }
            #endregion
            #region Level 4
            if (_level >= 19)
            {
                SpellsKnown.Insert(4, new KeyValuePair<int, int>(4, 5));
            }
            else if (_level >= 13)
            {
                SpellsKnown.Insert(4, new KeyValuePair<int, int>(4, 4));
            }
            else if (_level >= 11)
            {
                SpellsKnown.Insert(4, new KeyValuePair<int, int>(4, 3));
            }
            else if (_level >= 10)
            {
                SpellsKnown.Insert(4, new KeyValuePair<int, int>(4, 2));
            }
            #endregion
            #region Level 5
            if (_level >= 20)
            {
                SpellsKnown.Insert(5, new KeyValuePair<int, int>(5, 5));
            }
            else if (_level >= 16)
            {
                SpellsKnown.Insert(5, new KeyValuePair<int, int>(5, 4));
            }
            else if (_level >= 14)
            {
                SpellsKnown.Insert(5, new KeyValuePair<int, int>(5, 3));
            }
            else if (_level >= 13)
            {
                SpellsKnown.Insert(5, new KeyValuePair<int, int>(5, 2));
            }
            #endregion
            #region Level 6
            if (_level >= 19)
            {
                SpellsKnown.Insert(6, new KeyValuePair<int, int>(6, 4));
            }
            else if (_level >= 17)
            {
                SpellsKnown.Insert(6, new KeyValuePair<int, int>(6, 3));
            }
            else if (_level >= 16)
            {
                SpellsKnown.Insert(6, new KeyValuePair<int, int>(6, 2));
            }
            #endregion
            #endregion
        }
        private void Cleric(int _level)
        {
            #region Spells pr day
            #region Level 0
            if (_level >= 7)
            {
                SpellsPrDay.Insert(0, new KeyValuePair<int, int>(0, 6));
            }
            else if (_level >= 4)
            {
                SpellsPrDay.Insert(0, new KeyValuePair<int, int>(0, 5));
            }
            else if (_level >= 2)
            {
                SpellsPrDay.Insert(0, new KeyValuePair<int, int>(0, 4));
            }
            else if (_level == 1)
            {
                SpellsPrDay.Insert(0, new KeyValuePair<int, int>(0, 3));
            }
            #endregion
            #region Level 1
            if (_level >= 11)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 5));
            }
            else if (_level >= 7)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 4));
            }
            else if (_level >= 4)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 3));
            }
            else if (_level >= 2)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 2));
            }
            else if (_level >= 1)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 1));
            }
            #endregion
            #region Level 2
            if (_level >= 13)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 5));
            }
            else if (_level >= 9)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 4));
            }
            else if (_level >= 6)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 3));
            }
            else if (_level >= 4)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 2));
            }
            else if (_level >= 3)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 1));
            }
            #endregion
            #region Level 3
            if (_level >= 15)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 5));
            }
            else if (_level >= 11)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 4));
            }
            else if (_level >= 8)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 3));
            }
            else if (_level >= 6)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 2));
            }
            else if (_level >= 5)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 1));
            }
            #endregion
            #region Level 4
            if (_level >= 17)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 5));
            }
            else if (_level >= 13)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 4));
            }
            else if (_level >= 10)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 3));
            }
            else if (_level >= 8)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 2));
            }
            else if (_level >= 7)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 1));
            }
            #endregion
            #region Level 5
            if (_level >= 19)
            {
                SpellsPrDay.Insert(5, new KeyValuePair<int, int>(5, 5));
            }
            else if (_level >= 15)
            {
                SpellsPrDay.Insert(5, new KeyValuePair<int, int>(5, 4));
            }
            else if (_level >= 12)
            {
                SpellsPrDay.Insert(5, new KeyValuePair<int, int>(5, 3));
            }
            else if (_level >= 10)
            {
                SpellsPrDay.Insert(5, new KeyValuePair<int, int>(5, 2));
            }
            else if (_level >= 9)
            {
                SpellsPrDay.Insert(5, new KeyValuePair<int, int>(5, 1));
            }
            #endregion
            #region Level 6
            if (_level >= 17)
            {
                SpellsPrDay.Insert(6, new KeyValuePair<int, int>(6, 4));
            }
            else if (_level >= 14)
            {
                SpellsPrDay.Insert(6, new KeyValuePair<int, int>(6, 3));
            }
            else if (_level >= 12)
            {
                SpellsPrDay.Insert(6, new KeyValuePair<int, int>(6, 2));
            }
            else if (_level >= 11)
            {
                SpellsPrDay.Insert(6, new KeyValuePair<int, int>(6, 1));
            }
            #endregion
            #region Level 7
            if (_level >= 19)
            {
                SpellsPrDay.Insert(7, new KeyValuePair<int, int>(7, 4));
            }
            else if (_level >= 16)
            {
                SpellsPrDay.Insert(7, new KeyValuePair<int, int>(7, 3));
            }
            else if (_level >= 14)
            {
                SpellsPrDay.Insert(7, new KeyValuePair<int, int>(7, 2));
            }
            else if (_level >= 13)
            {
                SpellsPrDay.Insert(7, new KeyValuePair<int, int>(7, 1));
            }
            #endregion
            #region Level 8
            if (_level >= 20)
            {
                SpellsPrDay.Insert(8, new KeyValuePair<int, int>(8, 4));
            }
            else if (_level >= 18)
            {
                SpellsPrDay.Insert(8, new KeyValuePair<int, int>(8, 3));
            }
            else if (_level >= 16)
            {
                SpellsPrDay.Insert(8, new KeyValuePair<int, int>(8, 2));
            }
            else if (_level >= 15)
            {
                SpellsPrDay.Insert(8, new KeyValuePair<int, int>(8, 1));
            }
            #endregion
            #region Level 9
            if (_level >= 20)
            {
                SpellsPrDay.Insert(9, new KeyValuePair<int, int>(9, 4));
            }
            else if (_level >= 19)
            {
                SpellsPrDay.Insert(9, new KeyValuePair<int, int>(9, 3));
            }
            else if (_level >= 18)
            {
                SpellsPrDay.Insert(9, new KeyValuePair<int, int>(9, 2));
            }
            else if (_level >= 17)
            {
                SpellsPrDay.Insert(9, new KeyValuePair<int, int>(9, 1));
            }
            #endregion
            #endregion
        }
        private void Druid(int _level)
        {
            #region Spells pr day
            #region Level 0
            if (_level >= 7)
            {
                SpellsPrDay.Insert(0, new KeyValuePair<int, int>(0, 6));
            }
            else if (_level >= 4)
            {
                SpellsPrDay.Insert(0, new KeyValuePair<int, int>(0, 5));
            }
            else if (_level >= 2)
            {
                SpellsPrDay.Insert(0, new KeyValuePair<int, int>(0, 4));
            }
            else if (_level == 1)
            {
                SpellsPrDay.Insert(0, new KeyValuePair<int, int>(0, 3));
            }
            #endregion
            #region Level 1
            if (_level >= 11)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 5));
            }
            else if (_level >= 7)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 4));
            }
            else if (_level >= 4)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 3));
            }
            else if (_level >= 2)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 2));
            }
            else if (_level >= 1)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 1));
            }
            #endregion
            #region Level 2
            if (_level >= 13)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 5));
            }
            else if (_level >= 9)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 4));
            }
            else if (_level >= 6)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 3));
            }
            else if (_level >= 4)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 2));
            }
            else if (_level >= 3)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 1));
            }
            #endregion
            #region Level 3
            if (_level >= 15)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 5));
            }
            else if (_level >= 11)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 4));
            }
            else if (_level >= 8)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 3));
            }
            else if (_level >= 6)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 2));
            }
            else if (_level >= 5)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 1));
            }
            #endregion
            #region Level 4
            if (_level >= 17)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 5));
            }
            else if (_level >= 13)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 4));
            }
            else if (_level >= 10)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 3));
            }
            else if (_level >= 8)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 2));
            }
            else if (_level >= 7)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 1));
            }
            #endregion
            #region Level 5
            if (_level >= 19)
            {
                SpellsPrDay.Insert(5, new KeyValuePair<int, int>(5, 5));
            }
            else if (_level >= 15)
            {
                SpellsPrDay.Insert(5, new KeyValuePair<int, int>(5, 4));
            }
            else if (_level >= 12)
            {
                SpellsPrDay.Insert(5, new KeyValuePair<int, int>(5, 3));
            }
            else if (_level >= 10)
            {
                SpellsPrDay.Insert(5, new KeyValuePair<int, int>(5, 2));
            }
            else if (_level >= 9)
            {
                SpellsPrDay.Insert(5, new KeyValuePair<int, int>(5, 1));
            }
            #endregion
            #region Level 6
            if (_level >= 17)
            {
                SpellsPrDay.Insert(6, new KeyValuePair<int, int>(6, 4));
            }
            else if (_level >= 14)
            {
                SpellsPrDay.Insert(6, new KeyValuePair<int, int>(6, 3));
            }
            else if (_level >= 12)
            {
                SpellsPrDay.Insert(6, new KeyValuePair<int, int>(6, 2));
            }
            else if (_level >= 11)
            {
                SpellsPrDay.Insert(6, new KeyValuePair<int, int>(6, 1));
            }
            #endregion
            #region Level 7
            if (_level >= 19)
            {
                SpellsPrDay.Insert(7, new KeyValuePair<int, int>(7, 4));
            }
            else if (_level >= 16)
            {
                SpellsPrDay.Insert(7, new KeyValuePair<int, int>(7, 3));
            }
            else if (_level >= 14)
            {
                SpellsPrDay.Insert(7, new KeyValuePair<int, int>(7, 2));
            }
            else if (_level >= 13)
            {
                SpellsPrDay.Insert(7, new KeyValuePair<int, int>(7, 1));
            }
            #endregion
            #region Level 8
            if (_level >= 20)
            {
                SpellsPrDay.Insert(8, new KeyValuePair<int, int>(8, 4));
            }
            else if (_level >= 18)
            {
                SpellsPrDay.Insert(8, new KeyValuePair<int, int>(8, 3));
            }
            else if (_level >= 16)
            {
                SpellsPrDay.Insert(8, new KeyValuePair<int, int>(8, 2));
            }
            else if (_level >= 15)
            {
                SpellsPrDay.Insert(8, new KeyValuePair<int, int>(8, 1));
            }
            #endregion
            #region Level 9
            if (_level >= 20)
            {
                SpellsPrDay.Insert(9, new KeyValuePair<int, int>(9, 4));
            }
            else if (_level >= 19)
            {
                SpellsPrDay.Insert(9, new KeyValuePair<int, int>(9, 3));
            }
            else if (_level >= 18)
            {
                SpellsPrDay.Insert(9, new KeyValuePair<int, int>(9, 2));
            }
            else if (_level >= 17)
            {
                SpellsPrDay.Insert(9, new KeyValuePair<int, int>(9, 1));
            }
            #endregion
            #endregion
        }
        private void Paladin(int _level)
        {
            #region Spells pr day
            #region Level 1
            if (_level >= 18)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 3));
            }
            else if (_level >= 14)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 2));
            }
            else if (_level >= 6)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 1));
            }
            else if (_level >= 4)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 0));
            }
            #endregion
            #region Level 2
            if (_level >= 19)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 3));
            }
            else if (_level >= 16)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 2));
            }
            else if (_level >= 10)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 1));
            }
            else if (_level >= 8)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 0));
            }
            #endregion
            #region Level 3
            if (_level >= 19)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 3));
            }
            else if (_level >= 17)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 2));
            }
            else if (_level >= 12)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 1));
            }
            else if (_level >= 11)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 0));
            }
            #endregion
            #region Level 4
            if (_level >= 20)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 3));
            }
            else if (_level >= 19)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 2));
            }
            else if (_level >= 15)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 1));
            }
            else if (_level >= 14)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 0));
            }
            #endregion
            #endregion
        }
        private void Ranger(int _level)
        {
            #region Spells pr day
            #region Level 1
            if (_level >= 18)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 3));
            }
            else if (_level >= 14)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 2));
            }
            else if (_level >= 6)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 1));
            }
            else if (_level >= 4)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 0));
            }
            #endregion
            #region Level 2
            if (_level >= 19)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 3));
            }
            else if (_level >= 16)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 2));
            }
            else if (_level >= 10)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 1));
            }
            else if (_level >= 8)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 0));
            }
            #endregion
            #region Level 3
            if (_level >= 19)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 3));
            }
            else if (_level >= 17)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 2));
            }
            else if (_level >= 12)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 1));
            }
            else if (_level >= 11)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 0));
            }
            #endregion
            #region Level 4
            if (_level >= 20)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 3));
            }
            else if (_level >= 19)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 2));
            }
            else if (_level >= 15)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 1));
            }
            else if (_level >= 14)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 0));
            }
            #endregion
            #endregion
        }
        private void Sorcerer(int _level)
        {
            #region Spells pr day
            #region Level 0
            if (_level >= 2)
            {
                SpellsPrDay.Insert(0, new KeyValuePair<int, int>(0, 6));
            }
            else if (_level == 1)
            {
                SpellsPrDay.Insert(0, new KeyValuePair<int, int>(0, 5));
            }
            #endregion
            #region Level 1
            if (_level >= 4)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 6));
            }
            else if (_level >= 3)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 5));
            }
            else if (_level >= 2)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 4));
            }
            else if (_level >= 1)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 3));
            }
            #endregion
            #region Level 2
            if (_level >= 7)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 6));
            }
            else if (_level >= 6)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 5));
            }
            else if (_level >= 5)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 4));
            }
            else if (_level >= 4)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 3));
            }
            #endregion
            #region Level 3
            if (_level >= 9)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 6));
            }
            else if (_level >= 8)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 5));
            }
            else if (_level >= 7)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 4));
            }
            else if (_level >= 6)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 3));
            }
            #endregion
            #region Level 4
            if (_level >= 11)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 6));
            }
            else if (_level >= 10)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 5));
            }
            else if (_level >= 9)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 4));
            }
            else if (_level >= 8)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 3));
            }
            #endregion
            #region Level 5
            if (_level >= 13)
            {
                SpellsPrDay.Insert(5, new KeyValuePair<int, int>(5, 6));
            }
            else if (_level >= 12)
            {
                SpellsPrDay.Insert(5, new KeyValuePair<int, int>(5, 5));
            }
            else if (_level >= 11)
            {
                SpellsPrDay.Insert(5, new KeyValuePair<int, int>(5, 4));
            }
            else if (_level >= 10)
            {
                SpellsPrDay.Insert(5, new KeyValuePair<int, int>(5, 3));
            }
            #endregion
            #region Level 6
            if (_level >= 15)
            {
                SpellsPrDay.Insert(6, new KeyValuePair<int, int>(6, 6));
            }
            else if (_level >= 14)
            {
                SpellsPrDay.Insert(6, new KeyValuePair<int, int>(6, 5));
            }
            else if (_level >= 13)
            {
                SpellsPrDay.Insert(6, new KeyValuePair<int, int>(6, 4));
            }
            else if (_level >= 12)
            {
                SpellsPrDay.Insert(6, new KeyValuePair<int, int>(6, 3));
            }
            #endregion
            #region Level 7
            if (_level >= 17)
            {
                SpellsPrDay.Insert(7, new KeyValuePair<int, int>(7, 6));
            }
            else if (_level >= 16)
            {
                SpellsPrDay.Insert(7, new KeyValuePair<int, int>(7, 5));
            }
            else if (_level >= 15)
            {
                SpellsPrDay.Insert(7, new KeyValuePair<int, int>(7, 4));
            }
            else if (_level >= 14)
            {
                SpellsPrDay.Insert(7, new KeyValuePair<int, int>(7, 3));
            }
            #endregion
            #region Level 8
            if (_level >= 19)
            {
                SpellsPrDay.Insert(8, new KeyValuePair<int, int>(8, 6));
            }
            else if (_level >= 18)
            {
                SpellsPrDay.Insert(8, new KeyValuePair<int, int>(8, 5));
            }
            else if (_level >= 17)
            {
                SpellsPrDay.Insert(8, new KeyValuePair<int, int>(8, 4));
            }
            else if (_level >= 16)
            {
                SpellsPrDay.Insert(8, new KeyValuePair<int, int>(8, 3));
            }
            #endregion
            #region Level 9
            if (_level >= 20)
            {
                SpellsPrDay.Insert(9, new KeyValuePair<int, int>(9, 6));
            }
            else if (_level >= 19)
            {
                SpellsPrDay.Insert(9, new KeyValuePair<int, int>(9, 4));
            }
            else if (_level >= 18)
            {
                SpellsPrDay.Insert(9, new KeyValuePair<int, int>(9, 3));
            }
            #endregion
            #endregion

            #region Spells Known
            #region Level 0
            if (_level >= 10)
            {
                SpellsKnown.Insert(0, new KeyValuePair<int, int>(0, 9));
            }
            else if (_level >= 8)
            {
                SpellsKnown.Insert(0, new KeyValuePair<int, int>(0, 8));
            }
            else if (_level >= 6)
            {
                SpellsKnown.Insert(0, new KeyValuePair<int, int>(0, 7));
            }
            else if (_level >= 4)
            {
                SpellsKnown.Insert(0, new KeyValuePair<int, int>(0, 6));
            }
            else if (_level >= 2)
            {
                SpellsKnown.Insert(0, new KeyValuePair<int, int>(0, 5));
            }
            else if (_level >= 1)
            {
                SpellsKnown.Insert(0, new KeyValuePair<int, int>(0, 4));
            }
            #endregion
            #region Level 1
            if (_level >= 7)
            {
                SpellsKnown.Insert(1, new KeyValuePair<int, int>(1, 5));
            }
            else if (_level >= 5)
            {
                SpellsKnown.Insert(1, new KeyValuePair<int, int>(1, 4));
            }
            else if (_level >= 3)
            {
                SpellsKnown.Insert(1, new KeyValuePair<int, int>(1, 3));
            }
            else if (_level >= 1)
            {
                SpellsKnown.Insert(1, new KeyValuePair<int, int>(1, 2));
            }
            #endregion
            #region Level 2
            if (_level >= 11)
            {
                SpellsKnown.Insert(2, new KeyValuePair<int, int>(2, 5));
            }
            else if (_level >= 9)
            {
                SpellsKnown.Insert(2, new KeyValuePair<int, int>(2, 4));
            }
            else if (_level >= 7)
            {
                SpellsKnown.Insert(2, new KeyValuePair<int, int>(2, 3));
            }
            else if (_level >= 5)
            {
                SpellsKnown.Insert(2, new KeyValuePair<int, int>(2, 2));
            }
            else if (_level >= 4)
            {
                SpellsKnown.Insert(2, new KeyValuePair<int, int>(2, 1));
            }
            #endregion
            #region Level 3
            if (_level >= 11)
            {
                SpellsKnown.Insert(3, new KeyValuePair<int, int>(3, 4));
            }
            else if (_level >= 9)
            {
                SpellsKnown.Insert(3, new KeyValuePair<int, int>(3, 3));
            }
            else if (_level >= 7)
            {
                SpellsKnown.Insert(3, new KeyValuePair<int, int>(3, 2));
            }
            else if (_level >= 6)
            {
                SpellsKnown.Insert(3, new KeyValuePair<int, int>(3, 1));
            }
            #endregion
            #region Level 4
            if (_level >= 13)
            {
                SpellsKnown.Insert(4, new KeyValuePair<int, int>(4, 4));
            }
            else if (_level >= 11)
            {
                SpellsKnown.Insert(4, new KeyValuePair<int, int>(4, 3));
            }
            else if (_level >= 9)
            {
                SpellsKnown.Insert(4, new KeyValuePair<int, int>(4, 2));
            }
            else if (_level >= 8)
            {
                SpellsKnown.Insert(4, new KeyValuePair<int, int>(4, 1));
            }
            #endregion
            #region Level 5
            if (_level >= 15)
            {
                SpellsKnown.Insert(5, new KeyValuePair<int, int>(5, 4));
            }
            else if (_level >= 13)
            {
                SpellsKnown.Insert(5, new KeyValuePair<int, int>(5, 3));
            }
            else if (_level >= 11)
            {
                SpellsKnown.Insert(5, new KeyValuePair<int, int>(5, 2));
            }
            else if (_level >= 10)
            {
                SpellsKnown.Insert(5, new KeyValuePair<int, int>(5, 1));
            }
            #endregion
            #region Level 6
            if (_level >= 15)
            {
                SpellsKnown.Insert(6, new KeyValuePair<int, int>(6, 3));
            }
            else if (_level >= 13)
            {
                SpellsKnown.Insert(6, new KeyValuePair<int, int>(6, 2));
            }
            else if (_level >= 12)
            {
                SpellsKnown.Insert(6, new KeyValuePair<int, int>(6, 1));
            }
            #endregion
            #region Level 7
            if (_level >= 17)
            {
                SpellsKnown.Insert(7, new KeyValuePair<int, int>(7, 4));
            }
            else if (_level >= 15)
            {
                SpellsKnown.Insert(7, new KeyValuePair<int, int>(7, 3));
            }
            else if (_level >= 14)
            {
                SpellsKnown.Insert(7, new KeyValuePair<int, int>(7, 2));
            }
            #endregion
            #region Level 8
            if (_level >= 19)
            {
                SpellsKnown.Insert(8, new KeyValuePair<int, int>(8, 3));
            }
            else if (_level >= 17)
            {
                SpellsKnown.Insert(8, new KeyValuePair<int, int>(8, 2));
            }
            else if (_level >= 16)
            {
                SpellsKnown.Insert(8, new KeyValuePair<int, int>(8, 1));
            }
            #endregion
            #region Level 9
            if (_level >= 20)
            {
                SpellsKnown.Insert(9, new KeyValuePair<int, int>(6, 3));
            }
            else if (_level >= 19)
            {
                SpellsKnown.Insert(9, new KeyValuePair<int, int>(6, 2));
            }
            else if (_level >= 18)
            {
                SpellsKnown.Insert(9, new KeyValuePair<int, int>(6, 1));
            }
            #endregion
            #endregion
        }
        private void Wizard(int _level)
        {

            #region Spells pr day
            #region Level 0
            if (_level >= 2)
            {
                SpellsPrDay.Insert(0, new KeyValuePair<int, int>(0, 4));
            }
            else if (_level == 1)
            {
                SpellsPrDay.Insert(0, new KeyValuePair<int, int>(0, 3));
            }
            #endregion
            #region Level 1
            if (_level >= 7)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 4));
            }
            else if (_level >= 4)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 3));
            }
            else if (_level >= 2)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 2));
            }
            else if (_level >= 1)
            {
                SpellsPrDay.Insert(1, new KeyValuePair<int, int>(1, 1));
            }
            #endregion
            #region Level 2
            if (_level >= 9)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 4));
            }
            else if (_level >= 6)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 3));
            }
            else if (_level >= 4)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 2));
            }
            else if (_level >= 3)
            {
                SpellsPrDay.Insert(2, new KeyValuePair<int, int>(2, 1));
            }
            #endregion
            #region Level 3
            if (_level >= 11)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 4));
            }
            else if (_level >= 8)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 3));
            }
            else if (_level >= 6)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 2));
            }
            else if (_level >= 5)
            {
                SpellsPrDay.Insert(3, new KeyValuePair<int, int>(3, 1));
            }
            #endregion
            #region Level 4
            if (_level >= 13)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 4));
            }
            else if (_level >= 10)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 3));
            }
            else if (_level >= 8)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 2));
            }
            else if (_level >= 7)
            {
                SpellsPrDay.Insert(4, new KeyValuePair<int, int>(4, 1));
            }
            #endregion
            #region Level 5
            if (_level >= 15)
            {
                SpellsPrDay.Insert(5, new KeyValuePair<int, int>(5, 4));
            }
            else if (_level >= 12)
            {
                SpellsPrDay.Insert(5, new KeyValuePair<int, int>(5, 3));
            }
            else if (_level >= 10)
            {
                SpellsPrDay.Insert(5, new KeyValuePair<int, int>(5, 2));
            }
            else if (_level >= 9)
            {
                SpellsPrDay.Insert(5, new KeyValuePair<int, int>(5, 1));
            }
            #endregion
            #region Level 6
            if (_level >= 17)
            {
                SpellsPrDay.Insert(6, new KeyValuePair<int, int>(6, 4));
            }
            else if (_level >= 14)
            {
                SpellsPrDay.Insert(6, new KeyValuePair<int, int>(6, 3));
            }
            else if (_level >= 12)
            {
                SpellsPrDay.Insert(6, new KeyValuePair<int, int>(6, 2));
            }
            else if (_level >= 11)
            {
                SpellsPrDay.Insert(6, new KeyValuePair<int, int>(6, 1));
            }
            #endregion
            #region Level 7
            if (_level >= 19)
            {
                SpellsPrDay.Insert(7, new KeyValuePair<int, int>(7, 4));
            }
            else if (_level >= 16)
            {
                SpellsPrDay.Insert(7, new KeyValuePair<int, int>(7, 3));
            }
            else if (_level >= 14)
            {
                SpellsPrDay.Insert(7, new KeyValuePair<int, int>(7, 2));
            }
            else if (_level >= 13)
            {
                SpellsPrDay.Insert(7, new KeyValuePair<int, int>(7, 1));
            }
            #endregion
            #region Level 8
            if (_level >= 20)
            {
                SpellsPrDay.Insert(8, new KeyValuePair<int, int>(8, 4));
            }
            else if (_level >= 18)
            {
                SpellsPrDay.Insert(8, new KeyValuePair<int, int>(8, 3));
            }
            else if (_level >= 16)
            {
                SpellsPrDay.Insert(8, new KeyValuePair<int, int>(8, 2));
            }
            else if (_level >= 15)
            {
                SpellsPrDay.Insert(8, new KeyValuePair<int, int>(8, 1));
            }
            #endregion
            #region Level 9
            if (_level >= 20)
            {
                SpellsPrDay.Insert(9, new KeyValuePair<int, int>(9, 4));
            }
            else if (_level >= 19)
            {
                SpellsPrDay.Insert(9, new KeyValuePair<int, int>(9, 3));
            }
            else if (_level >= 18)
            {
                SpellsPrDay.Insert(9, new KeyValuePair<int, int>(9, 2));
            }
            else if (_level >= 17)
            {
                SpellsPrDay.Insert(9, new KeyValuePair<int, int>(9, 1));
            }
            #endregion
            #endregion
        }
    }
}
