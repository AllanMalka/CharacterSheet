using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterSheet
{
    public partial class SpellInfo : Form
    {
        private List<KeyValuePair<string, string>> readList;

        private int seperate;
        public SpellInfo(Other.Spell _spell)
        {
            InitializeComponent();
            this.Text += " " + _spell.Name;
            seperate = 0;
            readList = new List<KeyValuePair<string, string>>();

            lblSpellName.Text = _spell.Name;
            lblSchool.Text = LoopedStrings(_spell.School, "/");
            lblSubSchool.Text = LoopedStrings(_spell.Subschool, ", ");
            lblDescriptor.Text = LoopedStrings(_spell.Descriptor, ", ");
            lblCastingTime.Text = _spell.CastingTime;
            lblRange.Text = _spell.Range;
            LoopedComponents(_spell.Components);
            lblTaEfAr.Text = SplitTaEfArName(_spell.TarEffAer);
            lblTarEffAre.Text = SplitTaEfArEffect(_spell.TarEffAer);
            lblDuration.Text = _spell.Duration;
            lblSavingThrow.Text = _spell.SavingThrow + " " + HarmlessObject(_spell.isHarmless, _spell.onlyObject);
            lblSpellResistance.Text = SpellResistance(_spell.SpellResistance) + " " + HarmlessObject(_spell.isHarmless, _spell.onlyObject);
            txtDescription.Text = _spell.Description;
        }
        private string LoopedStrings(List<string> _list, string _seperatorsymbol)
        {
            string res = "";
            int rounds = 0;

            if (_list.Count > 0)
            {
                foreach (string item in _list)
                {
                    if (rounds > 0)
                    {
                        res += _seperatorsymbol;
                    }
                    res += item;
                    rounds++;
                }
            }

            return res;
        }

        private void LoopedComponents(List<string> _list)
        {
            if (_list.Count > 0)
            {
                foreach (string item in _list)
                {
                    if (item.Contains(":"))
                    {
                        string _type = item.Remove(item.IndexOf(":"));
                        string _desc = item.Substring(item.IndexOf(":") + 1);
                        readList.Insert(0, new KeyValuePair<string, string>(_type, _desc));

                        LabelLinkComponent(_type, "lbl" + _type, panel1);

                    }
                    else
                    {
                        LabelComponent(item, "lbl" + item, panel1);
                    }
                }
            }

        }
        private void LabelComponent(string _value, string _lblname, Panel _pane)
        {
            Label lbl = new Label();
            lbl.Location = new Point(116 + seperate, 117);
            lbl.Text = _value;
            lbl.AutoSize = true;
            lbl.Name = _lblname;
            _pane.Controls.Add(lbl);
            seperate += lbl.Size.Width + 10;
        }
        private void LabelLinkComponent(string _value, string _lblname, Panel _pane)
        {
            LinkLabel lbl = new LinkLabel();
            lbl.Location = new Point(116 + seperate, 117);
            lbl.AutoSize = true;
            lbl.Text = _value;
            lbl.Name = _lblname;
            lbl.Click += new EventHandler(this.BoxInfo);
            _pane.Controls.Add(lbl);
            seperate += lbl.Size.Width + 10;
        }
        private void BoxInfo(object sender, EventArgs e)
        {
            LinkLabel lbl = (LinkLabel)sender;
            foreach (KeyValuePair<string, string> item in readList)
            {
                if (item.Key.Equals(lbl.Text))
                {
                    MessageBox.Show(item.Value);
                }
            }
        }
        private string SplitTaEfArName(string _split)
        {
            return _split.Remove(_split.IndexOf(":"));
        }
        private string SplitTaEfArEffect(string _split)
        {
            return _split.Substring(_split.IndexOf(":") + 2);
        }
        private string SpellResistance(bool _isresistant)
        {
            string res = "No";

            if (_isresistant)
            {
                res = "Yes";
            }

            return res;
        }
        private string HarmlessObject(bool _isharmless, bool _isobject)
        {
            string res = "";

            if (_isharmless && _isobject)
            {
                res = "(Harmless, object)";
            }
            else if (_isharmless)
            {
                res = "(Harmless)";
            }
            else if (_isobject)
            {
                res = "(Object)";
            }

            return res;
        }
    }
}
