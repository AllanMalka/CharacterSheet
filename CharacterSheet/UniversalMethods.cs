using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterSheet
{
    public class UniversalMethods : Control
    {
        /// <summary>
        /// Calculates the stats modifier.
        /// </summary>
        /// <param name="stat"></param>
        /// <returns></returns>
        public int StatCalculator(int stat)
        {
            int modifier = 0;
            if (stat > 10)
                modifier = (stat - 10) / 2;
            else
            {
                double negMod = 0;
                negMod = (10 - stat);
                negMod = Math.Ceiling(negMod / 2);
                modifier = (Int32)Math.Ceiling(negMod);
            }
            return modifier;
        }
        /// <summary>
        /// Adds a positive or negative infront of the stats modifier and makes it into a string.
        /// </summary>
        /// <param name="stat"></param>
        /// <returns></returns>
        public string PosiNegi(int stat)
        {
            string result = "";
            if (stat >= 10)
                result = "+";
            else
                result = "-";
            return result + StatCalculator(stat);
        }

        public void CalculateAdding(int adding, int stat, CharacterSheet charSheet, bool temporary)
        {
            switch (stat)
            {
                case 1:
                    #region Strength
                    if (temporary)
                    {
                        charSheet.TempStr = charSheet.TempStr + adding;
                        charSheet.LabelTempStr = charSheet.TempStr + PosiNegi(charSheet.TempStr);
                    }
                    else
                    {
                        charSheet.PrimStr = charSheet.PrimStr + adding;
                        charSheet.LabelPrimStr = charSheet.PrimStr + PosiNegi(charSheet.PrimStr);
                        charSheet.TempStr = charSheet.TempStr + adding;
                        charSheet.LabelTempStr = charSheet.TempStr + PosiNegi(charSheet.TempStr);
                    }
                    #endregion
                    break;
                case 2:
                    #region Dexterity
                    if (temporary)
                    {
                        charSheet.TempDex = charSheet.TempDex + adding;
                        charSheet.LabelTempDex = charSheet.TempDex + PosiNegi(charSheet.TempDex);
                    }
                    else
                    {
                        charSheet.PrimDex = charSheet.PrimDex + adding;
                        charSheet.LabelPrimDex = charSheet.PrimDex + PosiNegi(charSheet.PrimDex);
                        charSheet.TempDex = charSheet.TempDex + adding;
                        charSheet.LabelTempDex = charSheet.TempDex + PosiNegi(charSheet.TempDex);
                    }
                    #endregion
                    break;
                case 3:
                    #region Constitution
                    if (temporary)
                    {
                        charSheet.TempCon = charSheet.TempCon + adding;
                        charSheet.LabelTempCon = charSheet.TempCon + PosiNegi(charSheet.TempCon);
                    }
                    else
                    {
                        charSheet.PrimCon = charSheet.PrimCon + adding;
                        charSheet.LabelPrimCon = charSheet.PrimCon + PosiNegi(charSheet.PrimCon);
                        charSheet.TempCon = charSheet.TempCon + adding;
                        charSheet.LabelTempCon = charSheet.TempCon + PosiNegi(charSheet.TempCon);
                    }
                    #endregion
                    break;
                case 4:
                    #region Intelligence
                    if (temporary)
                    {
                        charSheet.TempInt = charSheet.TempInt + adding;
                        charSheet.LabelTempInt = charSheet.TempInt + PosiNegi(charSheet.TempInt);
                    }
                    else
                    {
                        charSheet.PrimInt = charSheet.PrimInt + adding;
                        charSheet.LabelPrimInt = charSheet.PrimInt + PosiNegi(charSheet.PrimInt);
                        charSheet.TempInt = charSheet.TempInt + adding;
                        charSheet.LabelTempInt = charSheet.TempInt + PosiNegi(charSheet.TempInt);
                    }
                    #endregion
                    break;
                case 5:
                    #region Wisdom
                    if (temporary)
                    {
                        charSheet.TempWis = charSheet.TempWis + adding;
                        charSheet.LabelTempWis = charSheet.TempWis + PosiNegi(charSheet.TempWis);
                    }
                    else
                    {
                        charSheet.PrimWis = charSheet.PrimWis + adding;
                        charSheet.LabelPrimWis = charSheet.PrimWis + PosiNegi(charSheet.PrimWis);
                        charSheet.TempWis = charSheet.TempWis + adding;
                        charSheet.LabelTempWis = charSheet.TempWis + PosiNegi(charSheet.TempWis);
                    }
                    #endregion
                    break;
                case 6:
                    #region Charisma
                    if (temporary)
                    {
                        charSheet.TempCha = charSheet.TempCha + adding;
                        charSheet.LabelTempCha = charSheet.TempCha + PosiNegi(charSheet.TempCha);
                    }
                    else
                    {
                        charSheet.PrimCha = charSheet.PrimCha + adding;
                        charSheet.LabelPrimCha = charSheet.PrimCha + PosiNegi(charSheet.PrimCha);
                        charSheet.TempCha = charSheet.TempCha + adding;
                        charSheet.LabelTempCha = charSheet.TempCha + PosiNegi(charSheet.TempCha);
                    }
                    #endregion
                    break;
                case 7:
                    #region Appearance
                    if (temporary)
                    {
                        charSheet.TempApp = charSheet.TempApp + adding;
                        charSheet.LabelTempApp = charSheet.TempApp + PosiNegi(charSheet.TempApp);
                    }
                    else
                    {
                        charSheet.PrimApp = charSheet.PrimApp + adding;
                        charSheet.LabelPrimApp = charSheet.PrimApp + PosiNegi(charSheet.PrimApp);
                        charSheet.TempApp = charSheet.TempApp + adding;
                        charSheet.LabelTempApp = charSheet.TempApp + PosiNegi(charSheet.TempApp);
                    }
                    #endregion
                    break;
            }
        }

        public string BaseAttackBonus(int _level, string _bab)
        {
            string res = "";
            switch (_bab)
            {
                case "Good": res = MultipleAttacks(_level); break;
                case "Average": res = MultipleAttacks(Convert.ToInt32(Math.Floor(_level * 0.75))); break;
                case "Poor": res = MultipleAttacks(Convert.ToInt32(_level / 2)); break;
                default: break;
            }
            return res;
        }

        public string SavingThrows(int _level, string _saves)
        {
            string res = "";
            switch (_saves)
            {
                case "Good": res = "" + ((_level / 2) + 2); break;
                case "Poor": res = "" + (_level / 3); break;
                default: break;
            }
            return res;
        }

        private string MultipleAttacks(int _attack)
        {
            string res = ""+_attack;
            int nexAtt = 0;

            if (_attack > 5)
            {
                nexAtt = _attack - 5;
                res += "/" + nexAtt;
                if (_attack > 10)
                {
                    nexAtt = _attack - 10;
                    res += "/" + nexAtt;
                    if (_attack > 15)
                    {
                        nexAtt = _attack - 15;
                        res += "/" + nexAtt;
                    }
                }
            }

            return res;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_uc">Level to get Uncanny Dodge</param>
        /// <param name="_iuc">Level to get Improved Uncanny Dodge</param>
        /// <returns></returns>
        public string UncannyDodge(int _level, int _uc, int _iuc)
        {
            string res = "";

            if (_level >= _iuc)
            {
                res = "Improved Uncanny Dodge";
            }
            else if (_level >= _uc)
            {
                res = "Uncanny Dodge";
            }
            return res;
        }

        public string SpellDuration(int _level, string _duration)
        {
            int x = SplitInt(_duration);
            string res = "";
            switch (SplitString(_duration))
            {
                case "1": res = x * _level + " round" + AddS(_level); break;
                case "2": res = x * _level + " minute" + AddS(_level); break;
                case "3": res = x * _level + " hour" + AddS(_level); break;
                default: res = _duration; break;
            }
            return res;
        }
        private string AddS(int x)
        {
            string res = "";
            if (x>1)
                res = "s";
            return res;
        }
        private string SplitString(string _split)
        {
            string res = "";
            if (_split.Contains("?"))
            {
            int index = _split.LastIndexOf("?");
            if (index > 0)
                res = _split.Substring(index);
            }
            else
            {
                res = _split;
            }
            return res;
        }
        private int SplitInt(string _split)
        {
            string res = "0";
            if (_split.Contains("?"))
            {
                int index = _split.LastIndexOf("?");
                if (index > 0)
                    res = _split.Substring(0, index);
            }
            return Convert.ToInt32(res);
        }

        public bool RequirementPassed(Other.Feat _feat, KeyValuePair<string, int> _ibab, KeyValuePair<string, int> _iskill, Other.Feat _ifeat)
        {
            bool res = false;

            foreach (object item in _feat.Prerequisite)
            {
                if (item is Other.Feat)
                {
                    res = ReqFeat((Other.Feat)item, _ifeat);
                }
                else if (item is int)
                {

                }
                else if (item is List<KeyValuePair<string, int>>)
                {
                    foreach (KeyValuePair<string, int> valuepair in (List<KeyValuePair<string, int>>)item)
                    {
                        res = ReqSkill(valuepair, _iskill);
                    }
                }
                else if (item is string)
                {

                }
                if (res)
                {
                    break;
                }
            }

            return res;
        }
        private bool ReqFeat(Other.Feat _feat, Other.Feat _ifeat)
        {
            bool found = false;

            if (_feat.Equals(_ifeat))
            {
                found = true;
            }

            return found;
        }
        private bool ReqSkill(KeyValuePair<string, int> _skill, KeyValuePair<string, int> _iskill)
        {
            bool found = false;

            if (_skill.Equals(_iskill))
            {
                found = true;
            }

            return found;
        }
        private bool ReqClassFeature(string _iclassfeature)
        {
            bool res = false;
            CharacterSheet charSheet = (CharacterSheet)Application.OpenForms[Application.OpenForms.Count - 1];
            foreach (Label item in charSheet.pQualities.Controls)
            {
                if (item.Text.Equals(_iclassfeature))
                {
                    res = true;
                }
            }

            return res;
        }
        private bool ReqStat(string _stat, int _val)
        {
            bool res = false;
            CharacterSheet charSheet = (CharacterSheet)Application.OpenForms[Application.OpenForms.Count - 1];
            int chosen = 0;
            switch (_stat)
            {
                case "Strength": chosen = charSheet.PrimStr; break;
                case  "Dexterity": chosen = charSheet.PrimDex; break;
                case "Constitution": chosen = charSheet.PrimCon; break;
                case "Intelligence": chosen = charSheet.PrimInt; break;
                case "Wisdom": chosen = charSheet.PrimWis; break;
                case "Charisma": chosen = charSheet.PrimCha; break;
                case "Appearance": chosen = charSheet.PrimApp; break;
                default: break;
            }
            if (chosen >= _val)
            {
                res = true;
            }

            return res;
        }
        private bool ReqBAB(int _val)
        {
            bool res = false;
            CharacterSheet charSheet = (CharacterSheet)Application.OpenForms[Application.OpenForms.Count - 1];
            string newBab = charSheet.BAB;
            if (newBab.Contains('/'))
            {
                int indexof = newBab.IndexOf('/');
                newBab = newBab.Substring(0, indexof);
            }
            int result = Convert.ToInt32(newBab);
            if (result >= _val)
            {
                res = true;
            }

            return res;
        }
        private bool ReqLevel(int _val)
        {
            bool res = false;
            CharacterSheet charSheet = (CharacterSheet)Application.OpenForms[Application.OpenForms.Count - 1];
            int currentLevel = Convert.ToInt32(charSheet.TotalLevel);
            if (currentLevel >= _val)
            {
                res = true;
            }

            return res;
        }
        private bool ReqClass(string _val)
        {
            bool res = false;
            CharacterSheet charSheet = (CharacterSheet)Application.OpenForms[Application.OpenForms.Count - 1];
            string allClasses = charSheet.AllClasses;
            if (allClasses.Contains(_val))
            {
                res = true;
            }

            return res;
        }
        private bool ReqSpellcaster(int _val)
        {
            bool res = false;
            bool iscaster = false;
            CharacterSheet charSheet = (CharacterSheet)Application.OpenForms[Application.OpenForms.Count - 1];
            TabControl tbc = charSheet.UsingTapcontrol;
            int currentLevel = Convert.ToInt32(charSheet.TotalLevel);

            foreach (TabPage item in tbc.TabPages)
            {
                if (item.Name.Contains("Spells"))
                {
                    iscaster = true;
                }
            }
            if (iscaster)
            {
                if (currentLevel >= _val)
                {
                    res = true;
                }
            }

            return res;
        }


        private void LabelQualityCreator(int times, string value, string lblname, Panel pane, int px, int py, int separation)
        {
            Label lblQualNew = new Label();
            lblQualNew.Location = new Point(px, py + (separation * times));
            lblQualNew.Text = value;
            lblQualNew.AutoSize = true;
            lblQualNew.Name = lblname;
            pane.Controls.Add(lblQualNew);
        }
        public void LabelSpellsKnownCreatorRepeater(string _value, string _lblname, Panel _pane, int _px, int _py, bool _autosize, int _fSize, BorderStyle _bstyle, int _lh, int _lw, int _seperator, ContentAlignment _placement, bool _goY, bool _goX)
        {
            Label lbl = new Label();
            int newX = _px;
            if (_goX)
                newX += _seperator;
            int newY = _py;
            if (_goY)
                newY += _seperator;
            lbl.Location = new Point(newX, newY);
            lbl.Text = _value;
            lbl.AutoSize = _autosize;
            if (!_autosize)
            {
                lbl.Height = _lh;
                lbl.Width = _lw;
            }
            lbl.Name = _lblname;
            lbl.TextAlign = _placement;
            if (_fSize > 0)
            {
                lbl.Font = new Font(Font.FontFamily, _fSize);
            }
            lbl.BorderStyle = _bstyle;
            _pane.Controls.Add(lbl);
        }
        public void LabelSpellsKnownCreator(string _value, string _lblname, Panel _pane, int _px, int _py, bool _autosize, int _fSize, BorderStyle _bstyle, int _lh, int _lw)
        {
            Label lbl = new Label();
            lbl.Location = new Point(_px, _py);
            lbl.Text = _value;
            lbl.AutoSize = _autosize;
            if (!_autosize)
            {
                lbl.Height = _lh;
                lbl.Width = _lw;
            }
            lbl.Name = _lblname;
            if (_fSize > 0)
            {
                lbl.Font = new Font(Font.FontFamily, _fSize);
            }
            lbl.BorderStyle = _bstyle;
            _pane.Controls.Add(lbl);
        }
        public void ImagedButtonCreatorRepeater(int _px, int _py, int _seperator, int _sx, int _sy, string _name, string _imagename, Panel _pane, EventHandler _event, bool _goX, bool _goY)
        {
            var resources = Properties.Resources.ResourceManager;

            Button btn = new Button();
            int newX = _px;
            int newY = _py;
            if (_goX)
                newX += _seperator;
            if (_goY)
                newY += _seperator;
            btn.Location = new Point(newX,newY);
            btn.Size = new Size(_sx, _sy);
            btn.Name = _name;
            btn.Cursor = Cursors.Hand;
            btn.Text = "";
            btn.FlatStyle = FlatStyle.Flat;

            try
            {
                if (!resources.GetObject(_imagename).Equals(null))
                {
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Image = (Image)resources.GetObject(_imagename);
                    btn.Image = ((Image)(resources.GetObject(_imagename)));
                }
                else
                {
                    btn.FlatAppearance.BorderSize = 1;
                    btn.FlatAppearance.BorderColor = Color.Red;
                }
            }
            catch (Exception e)
            {
                btn.FlatAppearance.BorderSize = 1;
                btn.FlatAppearance.BorderColor = Color.Blue;
            }

            btn.Click += _event;

            _pane.Controls.Add(btn);
        }

        public void ButtonSpellsKnownCreator(int _px, int _py, int _sx, int _sy, string _name, string _text, Panel _pane, EventHandler _event)
        {
            Button but = new Button();
            but.Location = new Point(_px, _py);
            but.Size = new Size(_sx, _sy);
            but.Name = _name;
            but.AutoSize = false;
            but.Cursor = Cursors.Hand;
            but.FlatStyle = FlatStyle.Standard;


            but.Text = _text;

            but.Click += _event;

            _pane.Controls.Add(but);
        }
        public string SpellResistanceConverter(bool _isresistance)
        {
            string res = "-";

            if (_isresistance)
            {
                res = "Y";
            }

            return res;
        }
        public string ComponentGetter(string _component)
        {
            string res = "";
            string temp = _component;
            if (temp.Contains(":"))
                temp = _component.Remove(_component.IndexOf(":"));
            switch (temp)
            {
                case "Verbal": res += "V"; break;
                case "Somatic": res += "S"; break;
                case "Material": res += "M"; break;
                case "Focus": res += "F"; break;
                case "Divine Focus": res += "DF"; break;
                case "XP cost": res += "XP"; break;
                default:
                    break;
            }
            return res;
        }

    }
}
