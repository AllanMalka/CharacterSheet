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
    public partial class SpellsKnownAdd : Form
    {
        private Container.Spells spells;
        private UniversalMethods uni;
        public SpellsKnownAdd(string _class, List<KeyValuePair<int, int>> _known)
        {
            InitializeComponent();
            spells = new Container.Spells();
            uni = new UniversalMethods();
            DisplayAllSpells(_class, _known);
            DisplaySpellsKnown(_known);
        }
        private void DisplaySpellsKnown(List<KeyValuePair<int, int>> _known)
        {
            bool first = true;

            foreach (var item in _known)
            {

                if (first)
                {
                    lblDispaly.Text = item.Value.ToString();
                    lblLevel.Text = item.Value.ToString();
                }
                else
                {
                    lblDispaly.Text += "/" + item.Value.ToString();
                    lblLevel.Text += "/" + item.Value.ToString();
                }
                first = false;

            }

        }
        private void DisplayAllSpells(string _class, List<KeyValuePair<int, int>> _known)
        {

            List<Other.Spell> allspells = spells.AllSpells(0);


            int levelKnown = 0;
            int increaser = 32;
            bool addspace = false;
            string res = "";

            foreach (Other.Spell known in allspells)
            {
                foreach (KeyValuePair<int, string> levelclass in known.LevelAndClass)
                {
                    foreach (KeyValuePair<int, int> item in _known)
                    {
                        if (item.Key == levelclass.Key)
                        {
                            if (levelclass.Value.Equals(_class))
                            {
                                int seperator = (levelKnown * increaser);

                                uni.LabelSpellsKnownCreatorRepeater(known.Name, "lblN" + levelKnown, pSpellsKnown, 4, 35, false, 0, BorderStyle.None, 32, 115, seperator, ContentAlignment.TopLeft, true, false);
                                uni.LabelSpellsKnownCreatorRepeater(known.ShortDescription, "lblD" + levelKnown, pSpellsKnown, 119, 35, false, 0, BorderStyle.None, 32, 180, seperator, ContentAlignment.TopLeft, true, false);
                                foreach (string component in known.Components)
                                {
                                    if (addspace)
                                        res += ", ";
                                    res += uni.ComponentGetter(component);

                                    addspace = true;
                                }

                                uni.LabelSpellsKnownCreatorRepeater(res, "lblC" + levelKnown, pSpellsKnown, 302, 35, true, 0, BorderStyle.None, 0, 0, seperator, ContentAlignment.TopLeft, true, false);
                                uni.LabelSpellsKnownCreatorRepeater(known.Range, "lblR" + levelKnown, pSpellsKnown, 393, 35, true, 0, BorderStyle.None, 0, 0, seperator, ContentAlignment.TopLeft, true, false);
                                uni.LabelSpellsKnownCreatorRepeater(known.TarEffAer, "lblTAE" + levelKnown, pSpellsKnown, 471, 35, false, 0, BorderStyle.None, 32, 133, seperator, ContentAlignment.TopLeft, true, false);
                                uni.LabelSpellsKnownCreatorRepeater(known.Duration, "lblDu" + levelKnown, pSpellsKnown, 603, 35, true, 0, BorderStyle.None, 0, 0, seperator, ContentAlignment.TopLeft, true, false);
                                uni.LabelSpellsKnownCreatorRepeater(known.SavingThrow, "lblS" + levelKnown, pSpellsKnown, 680, 35, false, 0, BorderStyle.None, 32, 56, seperator, ContentAlignment.TopLeft, true, false);
                                uni.LabelSpellsKnownCreatorRepeater(uni.SpellResistanceConverter(known.SpellResistance), "lblSR" + levelKnown, pSpellsKnown, 739, 35, true, 0, BorderStyle.None, 0, 0, seperator, ContentAlignment.TopLeft, true, false);
                                uni.ImagedButtonCreatorRepeater(758, 35, seperator, 20, 20, "btnInfo" + known.Name, "", pSpellsKnown, new EventHandler(this.SpellInfo), false, true);
                                uni.ImagedButtonCreatorRepeater(780, 35, seperator, 20, 20, "btnAdd" + known.Name, "", pSpellsKnown, new EventHandler(this.AddToSpellsKnown), false, true);
                                levelKnown++;
                                res = "";
                                addspace = false;
                            }
                        }
                    }
                }

            }
        }
        private void AddToSpellsKnown(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show("To be added");

            CharacterSheet charSheet = (CharacterSheet)Application.OpenForms[Application.OpenForms.Count - 1];

        }
        private Other.Spell SendSpell { get; set; }
        private void SpellInfo(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            //string spnam = btn.Name.Substring(btn.Name.IndexOf("/") + 1);
            //string levelcaster = btn.Name.Substring(7);
            //levelcaster = levelcaster.Remove(levelcaster.IndexOf("/"));
            //int spelevel = Convert.ToInt32(levelcaster.Remove(1));

            //foreach (KeyValuePair<int, List<Other.Spell>> item in SpellsKnown)
            //{
            //    if (item.Key == spelevel)
            //    {
            //        foreach (Other.Spell known in item.Value)
            //        {
            //            if (known.Name.Equals(spnam))
            //            {
            //                SendSpell = known;
            //                Thread t = new Thread(new ThreadStart(SpellInfo));
            //                t.Start();
            //                break;
            //            }
            //        }
            //    }
            //}

        }
        private void SpellInfo()
        {
            Application.Run(new SpellInfo(SendSpell));
        }

    }
}
