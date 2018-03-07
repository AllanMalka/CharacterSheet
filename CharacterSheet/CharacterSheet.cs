using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterSheet
{
    public partial class CharacterSheet : Form
    {
        private bool _useApp;
        private bool _tempAdd;
        private string[] _sizes = { "Fine", "Diminutive", "Tiny", "Small", "Medium", "Large", "Huge", "Gargantuan", "Colossal" };
        private string[] _classNames = { "Choose class", "Bard", "Barbarian", "Fighter" };
        private int _rowsAdded;
        private int _classAdded;
        private int oldLevel;
        private Container.Spells spells = new Container.Spells();
        private Container.Feats feats = new Container.Feats();

        private UniversalMethods uniMet = new UniversalMethods();

        public CharacterSheet()
        {
            InitializeComponent();

            btnAddStats.Text = "Start stats";
            btnAlignment.Text = "Click to choose";

            ddbSize.DataSource = _sizes;
            ddbSize.SelectedIndex = 4;
            _rowsAdded = 1;
            _classAdded = 1;

            PrimStr = 0;
            PrimDex = 0;
            PrimCon = 0;
            PrimInt = 0;
            PrimWis = 0;
            PrimCha = 0;
            PrimApp = 0;
            TempStr = 0;
            TempDex = 0;
            TempCon = 0;
            TempInt = 0;
            TempWis = 0;
            TempCha = 0;
            TempApp = 0;
            _tempAdd = false;
            UseApp = true;
            oldLevel = 0;
            ddbClasses.DataSource = _classNames;
        }

        private void btnAddStats_Click(object sender, EventArgs e)
        {
            if (btnAddStats.Text.Equals("Start stats"))
            {
                Thread t = new Thread(new ThreadStart(StartStats));

                t.Start();
            }
            else
            {
                _tempAdd = false;
                Thread t = new Thread(new ThreadStart(StatIncrease));
                t.Start();
            }
        }
        private void btnItemEnhancement_Click(object sender, EventArgs e)
        {
            _tempAdd = true;
            Thread t = new Thread(new ThreadStart(StatIncrease));
            t.Start();
        }

        private void AlignmentWheel()
        {
            Application.Run(new AlignmentWheel());
        }
        private void StatIncrease()
        {
            bool isTempAdd = _tempAdd;
            Application.Run(new StatIncrease(UseApp, isTempAdd));
        }

        private void StartStats()
        {
            Application.Run(new StartStat(UseApp));
        }

        public void UsingApp(bool DoUse)
        {
            if (DoUse)
            {
                cbApp.Checked = true;
                UseApp = true;
            }
            if (!DoUse)
            {
                cbApp.Checked = false;
                UseApp = false;
            }
        }

        #region Primary stats
        private int primStr;
        private int primDex;
        private int primCon;
        private int primInt;
        private int primWis;
        private int primCha;
        private int primApp;

        public int PrimStr
        {
            get { return primStr; }
            set { primStr = value; }
        }
        public int PrimDex
        {
            get { return primDex; }
            set { primDex = value; }
        }
        public int PrimCon
        {
            get { return primCon; }
            set { primCon = value; }
        }
        public int PrimInt
        {
            get { return primInt; }
            set { primInt = value; }
        }
        public int PrimWis
        {
            get { return primWis; }
            set { primWis = value; }
        }
        public int PrimCha
        {
            get { return primCha; }
            set { primCha = value; }
        }
        public int PrimApp
        {
            get { return primApp; }
            set { primApp = value; }
        }

        public string TotalLevel
        {
            get { return lblTotalLevel.Text; }
        }
        public string BAB
        {
            get { return lblBAB.Text; }
        }
        public string AllClasses
        {
            get { return lblClassName.Text; }
        }
        public TabControl UsingTapcontrol
        {
            get { return tabControl1; }
        }
        public List<KeyValuePair<int, List<Other.Spell>>> SpellsKnown { get; set; }

        public string LabelPrimStr
        {
            get
            {
                return this.lblPrimStr.Text;
            }
            set
            {
                this.lblPrimStr.Text = value;
            }
        }
        public string LabelPrimDex
        {
            get
            {
                return this.lblPrimDex.Text;
            }
            set
            {
                this.lblPrimDex.Text = value;
            }
        }
        public string LabelPrimCon
        {
            get
            {
                return this.lblPrimCon.Text;
            }
            set
            {
                this.lblPrimCon.Text = value;
            }
        }
        public string LabelPrimInt
        {
            get
            {
                return this.lblPrimInt.Text;
            }
            set
            {
                this.lblPrimInt.Text = value;
            }
        }
        public string LabelPrimWis
        {
            get
            {
                return this.lblPrimWis.Text;
            }
            set
            {
                this.lblPrimWis.Text = value;
            }
        }
        public string LabelPrimCha
        {
            get
            {
                return this.lblPrimCha.Text;
            }
            set
            {
                this.lblPrimCha.Text = value;
            }
        }
        public string LabelPrimApp
        {
            get
            {
                return this.lblPrimApp.Text;
            }
            set
            {
                this.lblPrimApp.Text = value;
            }
        }
        #endregion
        #region Temporary stats
        private int tempStr;
        private int tempDex;
        private int tempCon;
        private int tempInt;
        private int tempWis;
        private int tempCha;
        private int tempApp;

        public int TempStr
        {
            get { return tempStr; }
            set { tempStr = value; }
        }
        public int TempDex
        {
            get { return tempDex; }
            set { tempDex = value; }
        }
        public int TempCon
        {
            get { return tempCon; }
            set { tempCon = value; }
        }
        public int TempInt
        {
            get { return tempInt; }
            set { tempInt = value; }
        }
        public int TempWis
        {
            get { return tempWis; }
            set { tempWis = value; }
        }
        public int TempCha
        {
            get { return tempCha; }
            set { tempCha = value; }
        }
        public int TempApp
        {
            get { return tempApp; }
            set { tempApp = value; }
        }

        public string LabelTempStr
        {
            get
            {
                return this.lblTempStr.Text;
            }
            set
            {
                this.lblTempStr.Text = value;
            }
        }
        public string LabelTempDex
        {
            get
            {
                return this.lblTempDex.Text;
            }
            set
            {
                this.lblTempDex.Text = value;
            }
        }
        public string LabelTempCon
        {
            get
            {
                return this.lblTempCon.Text;
            }
            set
            {
                this.lblTempCon.Text = value;
            }
        }
        public string LabelTempInt
        {
            get
            {
                return this.lblTempInt.Text;
            }
            set
            {
                this.lblTempInt.Text = value;
            }
        }
        public string LabelTempWis
        {
            get
            {
                return this.lblTempWis.Text;
            }
            set
            {
                this.lblTempWis.Text = value;
            }
        }
        public string LabelTempCha
        {
            get
            {
                return this.lblTempCha.Text;
            }
            set
            {
                this.lblTempCha.Text = value;
            }
        }
        public string LabelTempApp
        {
            get
            {
                return this.lblTempApp.Text;
            }
            set
            {
                this.lblTempApp.Text = value;
            }
        }
        #endregion

        public bool UseApp
        {
            get { return _useApp; }
            set { _useApp = value; }
        }

        private void cbApp_CheckedChanged(object sender, EventArgs e)
        {
            if (cbApp.Checked)
            {
                lblApp.Visible = true;
                lblPrimApp.Visible = true;
                lblTempApp.Visible = true;
                UseApp = true;
            }
            if (!cbApp.Checked)
            {
                lblApp.Visible = false;
                lblPrimApp.Visible = false;
                lblTempApp.Visible = false;
                UseApp = false;
            }
        }

        private void cbUseTemporary_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbUseTemporary.Checked)
            {
                LabelTempStr = LabelPrimStr;
                LabelTempDex = LabelPrimDex;
                LabelTempCon = LabelPrimCon;
                LabelTempInt = LabelPrimInt;
                LabelTempWis = LabelPrimWis;
                LabelTempCha = LabelPrimCha;
                LabelTempApp = LabelPrimApp;
            }
            if (cbUseTemporary.Checked)
            {
                LabelTempStr = TempStr + uniMet.PosiNegi(TempStr);
                LabelTempDex = TempDex + uniMet.PosiNegi(TempDex);
                LabelTempCon = TempCon + uniMet.PosiNegi(TempCon);
                LabelTempInt = TempInt + uniMet.PosiNegi(TempInt);
                LabelTempWis = TempWis + uniMet.PosiNegi(TempWis);
                LabelTempCha = TempCha + uniMet.PosiNegi(TempCha);
                LabelTempApp = TempApp + uniMet.PosiNegi(TempApp);
            }
        }

        private void CharacterSheet_Load(object sender, EventArgs e)
        {
            this.ActiveControl = panel2;
            txtName.GotFocus += new EventHandler(this.NameGotFocus);
            txtName.LostFocus += new EventHandler(this.NameLostFocus);

            txtRace.GotFocus += new EventHandler(this.RaceGotFocus);
            txtRace.LostFocus += new EventHandler(this.RaceLostFocus);

            txtSex.GotFocus += new EventHandler(this.SexGotFocus);
            txtSex.LostFocus += new EventHandler(this.SexLostFocus);

            txtAge.GotFocus += new EventHandler(this.AgeGotFocus);
            txtAge.LostFocus += new EventHandler(this.AgeLostFocus);

            txtSkin.GotFocus += new EventHandler(this.SkinGotFocus);
            txtSkin.LostFocus += new EventHandler(this.SkinLostFocus);

            txtEyes.GotFocus += new EventHandler(this.EyesGotFocus);
            txtEyes.LostFocus += new EventHandler(this.EyesLostFocus);

            txtHair.GotFocus += new EventHandler(this.HairGotFocus);
            txtHair.LostFocus += new EventHandler(this.HairLostFocus);

            txtHeight.GotFocus += new EventHandler(this.HeightGotFocus);
            txtHeight.LostFocus += new EventHandler(this.HeightLostFocus);

            txtWeight.GotFocus += new EventHandler(this.WeightGotFocus);
            txtWeight.LostFocus += new EventHandler(this.WeightLostFocus);

            txtDeity.GotFocus += new EventHandler(this.DeityGotFocus);
            txtDeity.LostFocus += new EventHandler(this.DeityLostFocus);

            txtQuirks.GotFocus += new EventHandler(this.QuirksGotFocus);
            txtQuirks.LostFocus += new EventHandler(this.QuirksLostFocus);

            txtCreature.GotFocus += new EventHandler(this.CreatureGotFocus);
            txtCreature.LostFocus += new EventHandler(this.CreatureLostFocus);

            txtTemplate.GotFocus += new EventHandler(this.TemplateGotFocus);
            txtTemplate.LostFocus += new EventHandler(this.TemplateLostFocus);

            txtRaceSpeed.GotFocus += new EventHandler(this.RaceSpeedGotFocus);
            txtRaceSpeed.LostFocus += new EventHandler(this.RaceSpeedLostFocus);

            txtEthics.GotFocus += new EventHandler(this.AlignCalcPoint);
            txtEthics.LostFocus += new EventHandler(this.AlignCalcPoint);

            txtMorale.GotFocus += new EventHandler(this.AlignCalcPoint);
            txtMorale.LostFocus += new EventHandler(this.AlignCalcPoint);

            btnAlignment.GotFocus += new EventHandler(this.AlignButtonPoints);
            btnAlignment.LostFocus += new EventHandler(this.AlignButtonPoints);

            ToolTip toTp = new ToolTip();

            // Set up the delays for the ToolTip.
            //toTp.AutoPopDelay = 5000;
            toTp.InitialDelay = 500;
            toTp.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toTp.ShowAlways = true;

            toTp.SetToolTip(this.txtRaceSpeed, "Please only insert numbers");
            toTp.SetToolTip(this.lblLNC, "Lawful, Neutral or Chaotic");
            toTp.SetToolTip(this.lblENG, "Evil, Neutral or Good");
        }

        #region Focus
        private void NameGotFocus(object sender, EventArgs e)
        {
            GotFocusTextChecker(sender, "Enter name here");
        }
        private void NameLostFocus(object sender, EventArgs e)
        {
            LostFocusTextChecker(sender, "Enter name here");
        }

        private void RaceGotFocus(object sender, EventArgs e)
        {
            GotFocusTextChecker(sender, "Enter race");
        }
        private void RaceLostFocus(object sender, EventArgs e)
        {
            LostFocusTextChecker(sender, "Enter race");
        }

        private void SexGotFocus(object sender, EventArgs e)
        {
            GotFocusTextChecker(sender, "Enter sex");
        }
        private void SexLostFocus(object sender, EventArgs e)
        {
            LostFocusTextChecker(sender, "Enter sex");
        }

        private void AgeGotFocus(object sender, EventArgs e)
        {
            GotFocusTextChecker(sender, "Enter age");
        }
        private void AgeLostFocus(object sender, EventArgs e)
        {
            LostFocusTextChecker(sender, "Enter age");
        }

        private void SkinGotFocus(object sender, EventArgs e)
        {
            GotFocusTextChecker(sender, "Enter skintone");
        }
        private void SkinLostFocus(object sender, EventArgs e)
        {
            LostFocusTextChecker(sender, "Enter skintone");
        }

        private void EyesGotFocus(object sender, EventArgs e)
        {
            GotFocusTextChecker(sender, "Enter eyecolor");
        }
        private void EyesLostFocus(object sender, EventArgs e)
        {
            LostFocusTextChecker(sender, "Enter eyecolor");
        }

        private void HairGotFocus(object sender, EventArgs e)
        {
            GotFocusTextChecker(sender, "Enter hair color");
        }
        private void HairLostFocus(object sender, EventArgs e)
        {
            LostFocusTextChecker(sender, "Enter hair color");
        }

        private void HeightGotFocus(object sender, EventArgs e)
        {
            GotFocusTextChecker(sender, "Enter height");
        }
        private void HeightLostFocus(object sender, EventArgs e)
        {
            LostFocusTextChecker(sender, "Enter height");
        }

        private void WeightGotFocus(object sender, EventArgs e)
        {
            GotFocusTextChecker(sender, "Enter weight");
        }
        private void WeightLostFocus(object sender, EventArgs e)
        {
            LostFocusTextChecker(sender, "Enter weight");
        }

        private void DeityGotFocus(object sender, EventArgs e)
        {
            GotFocusTextChecker(sender, "Enter deity");
        }
        private void DeityLostFocus(object sender, EventArgs e)
        {
            LostFocusTextChecker(sender, "Enter deity");
        }

        private void QuirksGotFocus(object sender, EventArgs e)
        {
            GotFocusTextChecker(sender, "Enter quirks");
        }
        private void QuirksLostFocus(object sender, EventArgs e)
        {
            LostFocusTextChecker(sender, "Enter quirks");
        }

        private void CreatureGotFocus(object sender, EventArgs e)
        {
            GotFocusTextChecker(sender, "Creature type");
        }
        private void CreatureLostFocus(object sender, EventArgs e)
        {
            LostFocusTextChecker(sender, "Creature type");
        }

        private void TemplateGotFocus(object sender, EventArgs e)
        {
            GotFocusTextChecker(sender, "Template");
        }
        private void TemplateLostFocus(object sender, EventArgs e)
        {
            LostFocusTextChecker(sender, "Template");
        }

        private void ClassNameGotFocus(object sender, EventArgs e)
        {
            GotFocusTextChecker(sender, "Class name");
        }
        private void ClassNameLostFocus(object sender, EventArgs e)
        {
            LostFocusTextChecker(sender, "Class name");
        }

        private void SkillPointsGotFocus(object sender, EventArgs e)
        {
            GotFocusTextChecker(sender, "Skill points");
        }
        private void SkillPointsLostFocus(object sender, EventArgs e)
        {
            LostFocusTextChecker(sender, "Skill points");
        }

        private void RaceSpeedGotFocus(object sender, EventArgs e)
        {
            GotFocusTextChecker(sender, "Race speed");
        }
        private void RaceSpeedLostFocus(object sender, EventArgs e)
        {
            LostFocusTextChecker(sender, "Race speed");
        }

        private void GotFocusTextChecker(object sender, string _t)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Equals(_t))
            {
                txt.Text = "";
                txt.ForeColor = Color.Black;
            }
        }
        private void LostFocusTextChecker(object sender, string _t)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Equals(""))
            {
                txt.Text = _t;
                txt.ForeColor = Color.DarkGray;
            }
        }
        #endregion

        private void ddbSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public string Alignment
        {
            get { return this.btnAlignment.Text; }
            set { this.btnAlignment.Text = value; }
        }
        private void btnAlignment_Click(object sender, EventArgs e)
        {
            txtMorale.Text = "";
            txtEthics.Text = "";
            Thread t = new Thread(new ThreadStart(AlignmentWheel));
            t.Start();
        }
        private void txtRaceSpeed_TextChanged(object sender, EventArgs e)
        {
            int n;
            string raceSpeed = txtRaceSpeed.Text;
            if (!int.TryParse(raceSpeed, out n))
            {
                txtSpeedResult.Text = "Walk/Run speed";
            }
            else
            {
                int running = 4;
                if (cbRun.Checked)
                {
                    running = 5;
                }
                int raceSpeedInt = Convert.ToInt32(raceSpeed);
                if (ddbClasses.SelectedItem.Equals("Barbarian"))
                {
                    raceSpeedInt += 10;
                }
                txtSpeedResult.Text = raceSpeedInt + "ft / " + raceSpeedInt * running + "ft";
            }
        }

        private void cbRun_CheckedChanged(object sender, EventArgs e)
        {
            txtRaceSpeed_TextChanged(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Other.Spell tempspell = new Other.Spell();
            //tempspell = spells.Aid(7);
            //string tempm = tempspell.Name;
            //tempm += "\r\n" + tempspell.Description;
            //string tempm = "";
            //List<Other.Spell> tempList = spells.AllSpells(5);
            //foreach (Other.Spell item in tempList)
            //{
            //    tempm += "Name: " + item.Name + "\r\n";
            //    tempm += "Description: " + item.Description + "\r\n\r\n";
            //}
            //MessageBox.Show(tempm);


            //Other.Feat feat = new Other.Feat("1", "bla", null, null, true);

            //Other.Feat feat2 = new Other.Feat("Focus", "Focus da shit", null, null, false);

            //MessageBox.Show(feat.Name + " " + feat.Content + "\r\n" + feat2.Name + " " + feat2.Content);

            //Point poClasLoc = new Point();
            //ComboBox ddbNew = new ComboBox();
            //ddbNew.DataSource = _classNames;
            //ddbNew.DropDownStyle = ComboBoxStyle.DropDownList;
            //ddbNew.SelectedIndexChanged += new EventHandler(ddbClasses_SelectedIndexChanged);
            //poClasLoc = ddbClasses.Location;
            //ddbNew.Location = new Point(poClasLoc.X, poClasLoc.Y + (32 * _rowsAdded));

            //Label lblNewClass = new Label();
            //lblNewClass.Text = "Class level";
            //lblNewClass.Size = lblLevels.Size;
            //poClasLoc = lblLevels.Location;
            //lblNewClass.Location = new Point(poClasLoc.X, poClasLoc.Y + (32 * _rowsAdded));

            //NumericUpDown nudNew = new NumericUpDown();
            //nudNew.Size = nudLevel.Size;
            //poClasLoc = nudLevel.Location;
            //nudNew.Location = new Point(poClasLoc.X, poClasLoc.Y + (32 * _rowsAdded));

            //Button btnNew = new Button();
            //btnNew.Size = btnDeleteClass.Size;
            //btnNew.FlatStyle = btnDeleteClass.FlatStyle;
            //btnNew.FlatAppearance.BorderSize = 0;
            //btnNew.Image = btnDeleteClass.Image;
            //btnNew.Cursor = btnDeleteClass.Cursor;
            //poClasLoc = btnDeleteClass.Location;
            //btnNew.Location = new Point(poClasLoc.X, poClasLoc.Y + (32 * _rowsAdded));
            //btnNew.Click += new EventHandler(this.btnDeleteClass_Click);

            //panel4.Controls.Add(ddbNew);
            //panel4.Controls.Add(lblNewClass);
            //panel4.Controls.Add(nudNew);
            //panel4.Controls.Add(btnNew);
            //_rowsAdded++;
            //_classAdded++;
        }

        private void cbAlignmentPoints_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AlignCalcPoint(object sender, EventArgs e)
        {
            if (cbAlignmentPoints.Checked)
            {
                int n;
                string stringEthics = "";
                string stringMorale = "";
                #region Check if strings are empty
                if (!string.IsNullOrEmpty(txtEthics.Text))
                {
                    stringEthics = txtEthics.Text;
                }
                else
                {
                    stringEthics = "50";
                }
                if (!string.IsNullOrEmpty(txtMorale.Text))
                {
                    stringMorale = txtMorale.Text;
                }
                else
                {
                    stringMorale = "50";
                }
                #endregion
                if (int.TryParse(stringEthics, out n) && int.TryParse(stringMorale, out n))
                {
                    int pointsEthics = Convert.ToInt32(stringEthics);
                    int pointsMorale = Convert.ToInt32(stringMorale);

                    btnAlignment.Text = AlignmentWheel(pointsEthics, pointsMorale);
                }

            }
        }

        private void AlignButtonPoints(object sender, EventArgs e)
        {
            if (cbAlignmentPoints.Checked)
            {
                string btnAlignText = btnAlignment.Text;
                if (btnAlignText.Equals("True Neutral"))
                {
                    txtEthics.Text = "50";
                    txtMorale.Text = "50";
                }
                else
                {
                    string ethic = btnAlignText.Remove(btnAlignText.IndexOf(" ", +1));
                    string morale = btnAlignText.Substring(btnAlignText.IndexOf(" "));
                    morale = morale.Replace(" ", "");
                    switch (ethic)
                    {
                        case "Chaotic": txtEthics.Text = "75"; break;
                        case "Neutral": txtEthics.Text = "50"; break;
                        case "Lawful": txtEthics.Text = "25"; break;
                        default:
                            break;
                    }
                    switch (morale)
                    {
                        case "Good": txtMorale.Text = "75"; break;
                        case "Neutral": txtMorale.Text = "50"; break;
                        case "Evil": txtMorale.Text = "25"; break;
                        default:
                            break;
                    }
                }
            }
        }

        private string AlignmentWheel(int _ethics, int _morale)
        {
            string resEth = "";
            string resMor = "";
            #region Ethics
            if (_ethics >= 75)
            {
                resEth = "Chaotic";
            }
            else if (_ethics <= 25)
            {
                resEth = "Lawful";
            }
            else
            {
                resEth = "Neutral";
            }
            #endregion
            #region Morale
            if (_morale >= 75)
            {
                resMor = "Good";
            }
            else if (_morale <= 25)
            {
                resMor = "Evil";
            }
            else
            {
                resMor = "Neutral";
            }
            #endregion
            if (resMor.Equals(resEth))
            {
                resEth = "True";
            }

            return resEth + " " + resMor;
        }

        private void ClassSelect(string _selected)
        {
            switch (_selected)
            {
                case "Bard": Bard(); break;
                case "Barbarian": Barbarian(); break;

                case "Fighter": Fighter(); break;
                default:
                    break;
            }
        }

        private void ddbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox drop = sender as ComboBox;
            ClassSelect(ddbClasses.SelectedItem.ToString());
            if (!drop.SelectedItem.Equals("Choose class"))
            {
                drop.Enabled = false;
            }
        }

        private void nudLevel_ValueChanged(object sender, EventArgs e)
        {
            int level = Convert.ToInt32(nudLevel.Value);
            //if (oldLevel > level)
            //{
            pQualities.Controls.Clear();
            ClassSelect(ddbClasses.SelectedItem.ToString());
            lblTotalLevel.Text = "" + level;
            #region Delete not working
            //List<Label> listLbl = new List<Label>();
            //foreach (Control item in pQualities.Controls)
            //{
            //    if (item is Label)
            //    {
            //        Label lbl = (Label)item;
            //        int index = lbl.Text.IndexOf(" ");
            //        string z = lbl.Text.Substring(0, index);

            //        if (Convert.ToInt32(z) <= level)
            //        {
            //            listLbl.Add(lbl);
            //        }
            //    }
            //}
            //pQualities.Controls.Clear();
            //ClassSelect(ddbClasses.SelectedItem.ToString());
            //int i = 0;
            //foreach (Control item in pQualities.Controls)
            //{
            //    if (item is Label)
            //    {
            //        Label templbl = (Label)item;
            //        templbl = listLbl[i];

            //        pQualities.Controls.Add(templbl);
            //    }

            //    i++;
            //}
            #endregion
            //}
            //else
            //{
            //    pQualities.Controls.Clear();
            //    ClassSelect(ddbClasses.SelectedItem.ToString());
            //}
            //oldLevel = level;
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            lblClassName.Text = "";
            lblBAB.Text = "";
            lblFort.Text = "";
            lblRef.Text = "";
            lblWill.Text = "";
            pQualities.Controls.Clear();
            ddbClasses.SelectedItem = "Choose class";
            nudLevel.Value = 0;
            ddbClasses.Enabled = true;
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
       
        private void AddCasterTap(SpellCaster _spc, string _class)
        {
            #region test
            SpellsKnown = new List<KeyValuePair<int, List<Other.Spell>>>();
            Other.Spell temps = new Other.Spell();
            temps = spells.AcidSplash(1);
            List<Other.Spell> listspell = new List<Other.Spell>();
            List<Other.Spell> listspellN = new List<Other.Spell>();
            listspell.Add(temps);
            temps = spells.Aid(1);
            listspell.Add(temps);
            temps = spells.Atonement(10);
            listspellN.Add(temps);
            temps = spells.BalefulPolymorph(10);
            listspellN.Add(temps);
            SpellsKnown.Insert(0, new KeyValuePair<int, List<Other.Spell>>(0, listspell));
            SpellsKnown.Insert(1, new KeyValuePair<int, List<Other.Spell>>(1, listspellN));
            #endregion

            bool original = true;
            TabControl tbc = tabControl1;
            foreach (TabPage item in tbc.Controls)
            {
                if (item.Text.Equals(_class + " Spells"))
                {
                    original = false;
                }
            }
            if (original)
            {
                TabPage tbp = new TabPage();
                tbp.Text = _class + " Spells";
                tbp.BackColor = Color.Transparent;
                tbp.Size = new Size(840, 468);
                tbp.UseVisualStyleBackColor = true;



                tbc.TabPages.Add(tbp);
                Panel casterPanel = new Panel();
                casterPanel.Name = "CasterTab" + _class;
                casterPanel.Location = new Point(0, 0);
                casterPanel.BackColor = Color.Transparent;
                casterPanel.Size = new Size(825, 430);

                Panel pSpellsKnown = new Panel();
                pSpellsKnown.BackColor = Color.Transparent;
                pSpellsKnown.AutoSize = false;
                pSpellsKnown.Name = "pSpellsKnown" + _class;
                pSpellsKnown.BorderStyle = BorderStyle.Fixed3D;
                pSpellsKnown.Location = new Point(0, 175);
                pSpellsKnown.Size = new Size(825, 258);
                pSpellsKnown.AutoScroll = true;
                
                uniMet.LabelSpellsKnownCreator("Spells for " + _class, "lblCasterClass" + _class, casterPanel, 4, 4, true, 14, BorderStyle.None, 0, 0);
                uniMet.LabelSpellsKnownCreator("Ranges", "lblRanges" + _class, casterPanel, 455, 14, true, 12, BorderStyle.FixedSingle, 0, 0);
                uniMet.LabelSpellsKnownCreator("Close", "lblCloseText" + _class, casterPanel, 409, 45, true, 0, BorderStyle.FixedSingle, 0, 0);
                uniMet.LabelSpellsKnownCreator(_spc.SpellRangeCloseStr, "lblCloseCal" + _class, casterPanel, 409, 70, true, 0, BorderStyle.FixedSingle, 0, 0);
                uniMet.LabelSpellsKnownCreator("Medium", "lblMediumText" + _class, casterPanel, 471, 45, true, 0, BorderStyle.FixedSingle, 0, 0);
                uniMet.LabelSpellsKnownCreator(_spc.SpellRangeMediumStr, "lblMediumCal" + _class, casterPanel, 471, 70, true, 0, BorderStyle.FixedSingle, 0, 0);
                uniMet.LabelSpellsKnownCreator("Long", "lblLongText" + _class, casterPanel, 533, 45, true, 0, BorderStyle.FixedSingle, 0, 0);
                uniMet.LabelSpellsKnownCreator(_spc.SpellRangeLongStr, "lblLongCal" + _class, casterPanel, 533, 70, true, 0, BorderStyle.FixedSingle, 0, 0);
                uniMet.LabelSpellsKnownCreator("Spells pr day", "lblSpellsPrDay" + _class, casterPanel, 5, 45, true, 12, BorderStyle.None, 0, 0);
                uniMet.LabelSpellsKnownCreator("Spell level", "lblSpellLevel" + _class, casterPanel, 8, 74, true, 0, BorderStyle.None, 0, 0);
                uniMet.LabelSpellsKnownCreator("Pr day", "lblAmount" + _class, casterPanel, 8, 97, true, 0, BorderStyle.None, 0, 0);
                uniMet.LabelSpellsKnownCreator("Save DC", "lblSave" + _class, casterPanel, 8, 119, true, 0, BorderStyle.None, 0, 0);
                uniMet.ButtonSpellsKnownCreator(8, 144, 110, 23, "btnSpellsKnown" + _class, "Select Spells Known", casterPanel, new EventHandler(this.SpellsKnownAdd));
                uniMet.ButtonSpellsKnownCreator(726, 4, 75, 23, "btnRest" + _class, "Rest", casterPanel, null);
                uniMet.ButtonSpellsKnownCreator(726, 34, 75, 23, "btnOtherSheet" + _class, "Other Sheet", casterPanel, null);
                uniMet.ButtonSpellsKnownCreator(726, 64, 75, 23, "btnNewSheet" + _class, "New Sheet", casterPanel, null);

                SendMaxLevel = _spc.SpellsKnown;
                int highest = _spc.HighestLevel + 1;
                int start = 0;
                if (!_spc.StartZero)
                    start = 1;

                int stat = 0;
                switch (_spc.CasterStat)
                {
                    case "Int": stat = uniMet.StatCalculator(TempInt); break;
                    case "Wis": stat = uniMet.StatCalculator(TempWis); break;
                    case "Cha": stat = uniMet.StatCalculator(TempCha); break;
                    default:
                        break;
                }


                int levelKnown = 0;
                int levelPos = 0;
                int increaser = 32;
                bool addspace = false;
                string res = "";
                for (int i = start; i < highest; i++)
                {
                    int dc = 10 + i + stat;
                    uniMet.LabelSpellsKnownCreatorRepeater("" + i, "lblSLevel" + i + _class, casterPanel, 65, 70, false, 0, BorderStyle.FixedSingle, 21, 21, (i * 22), ContentAlignment.MiddleCenter, false, true);
                    uniMet.LabelSpellsKnownCreatorRepeater("" + dc, "lblSaveLevel" + i + _class, casterPanel, 65, 114, false, 0, BorderStyle.FixedSingle, 21, 21, (i * 22), ContentAlignment.MiddleCenter, false, true);

                    foreach (KeyValuePair<int, int> item in _spc.SpellsPrDay)
                    {
                        if (item.Key == i)
                        {
                            uniMet.LabelSpellsKnownCreatorRepeater("" + item.Value, "lblAmountLevel" + i + _class, casterPanel, 65, 92, false, 0, BorderStyle.FixedSingle, 21, 21, (i * 22), ContentAlignment.MiddleCenter, false, true);
                        }
                    }

                    foreach (KeyValuePair<int, List<Other.Spell>> item in SpellsKnown)
                    {
                        if (item.Key == i)
                        {
                            uniMet.LabelSpellsKnownCreator("Level " + i, "lblSLK" + i + _class, pSpellsKnown, 12, levelPos, true, 14, BorderStyle.None, 0, 0);
                            foreach (Other.Spell known in item.Value)
                            {
                                int seperator = (levelKnown * increaser) +levelPos;

                                uniMet.LabelSpellsKnownCreatorRepeater(known.Name, "lblN" + i + levelKnown + _class, pSpellsKnown, 30, 35, false, 0, BorderStyle.None, 32, 115, seperator, ContentAlignment.TopLeft, true, false);
                                uniMet.LabelSpellsKnownCreatorRepeater(known.ShortDescription, "lblD" + i + levelKnown + _class, pSpellsKnown, 145, 35, false, 0, BorderStyle.None, 32, 180, seperator, ContentAlignment.TopLeft, true, false);
                                foreach (string component in known.Components)
                                {
                                    if (addspace)
                                        res += ", ";
                                    res += uniMet.ComponentGetter(component);

                                    addspace = true;
                                }
                                uniMet.ImagedButtonCreatorRepeater(5, 35, seperator, 20, 20, "btnPlus" + i + _class, "AddAnother", pSpellsKnown, new EventHandler(this.SpellUsage), false, true);
                                uniMet.LabelSpellsKnownCreatorRepeater(res, "lblC" + i + _class, pSpellsKnown, 324, 35, true, 0, BorderStyle.None, 0, 0, seperator, ContentAlignment.TopLeft, true, false);
                                uniMet.LabelSpellsKnownCreatorRepeater(known.Range, "lblR" + i + _class, pSpellsKnown, 415, 35, true, 0, BorderStyle.None, 0, 0, seperator, ContentAlignment.TopLeft, true, false);
                                uniMet.LabelSpellsKnownCreatorRepeater(known.TarEffAer, "lblTAE" + i + _class, pSpellsKnown, 493, 35, false, 0, BorderStyle.None, 32, 133, seperator, ContentAlignment.TopLeft, true, false);
                                uniMet.LabelSpellsKnownCreatorRepeater(known.Duration, "lblDu" + i + _class, pSpellsKnown, 625, 35, true, 0, BorderStyle.None, 0, 0, seperator, ContentAlignment.TopLeft, true, false);
                                uniMet.LabelSpellsKnownCreatorRepeater(known.SavingThrow, "lblS" + i + _class, pSpellsKnown, 702, 35, false, 0, BorderStyle.None, 32, 56, seperator, ContentAlignment.TopLeft, true, false);
                                uniMet.LabelSpellsKnownCreatorRepeater(uniMet.SpellResistanceConverter(known.SpellResistance), "lblSR" + i + _class, pSpellsKnown, 761, 35, true, 0, BorderStyle.None, 0, 0, seperator, ContentAlignment.TopLeft, true, false);
                                uniMet.ImagedButtonCreatorRepeater(780, 35, seperator, 20, 20, "btnInfo" + i + _class + "/" + known.Name, "AddAnother", pSpellsKnown, new EventHandler(this.SpellInfo), false, true);
                                levelKnown++;
                                res = "";
                                addspace = false;
                            }
                            levelPos += (35 * levelKnown) + 40;
                            levelKnown = 0;
                        }
                    }
                }



                casterPanel.Controls.Add(pSpellsKnown);
                tbp.Controls.Add(casterPanel);
            }
        }
        private void SpellUsage(object sender, EventArgs e)
        {


            Button btn = (Button)sender;

            string levelcaster = btn.Name.Substring(7);
            string caster = levelcaster.Substring(1);
            string spelllevel = levelcaster.Remove(1);

            Panel casterpanel = new Panel();

            TabControl tbc = tabControl1;
            foreach (TabPage item in tbc.Controls)
            {
                if (item.Text.Equals(caster + " Spells"))
                {
                    casterpanel = (Panel)item.Controls["CasterTab" + caster];
                }
            }

            foreach (Control item in casterpanel.Controls)
            {
                if (item.Name.Equals("lblAmountLevel" + levelcaster))
                {

                    int val = Convert.ToInt32(item.Text);
                    if (val > 0)
                    {
                        val--;
                        item.Text = val.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No more spells for level " + spelllevel);
                    }
                }
            }
        }
        private void SpellInfo(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            string spnam = btn.Name.Substring(btn.Name.IndexOf("/") + 1);
            string levelcaster = btn.Name.Substring(7);
            levelcaster = levelcaster.Remove(levelcaster.IndexOf("/"));
            int spelevel = Convert.ToInt32(levelcaster.Remove(1));

            foreach (KeyValuePair<int, List<Other.Spell>> item in SpellsKnown)
            {
                if (item.Key == spelevel)
                {
                    foreach (Other.Spell known in item.Value)
                    {
                        if (known.Name.Equals(spnam))
                        {
                            SendSpell = known;
                            Thread t = new Thread(new ThreadStart(SpellInfo));
                            t.Start();
                            break;
                        }
                    }
                }
            }

        }
        private void SpellsKnownAdd(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            SendCaster = btn.Name.Substring(14);
            Thread t = new Thread(new ThreadStart(SpellsKnownAdd));
            t.Start();
        }
        private string SendCaster { get; set; }
        private List<KeyValuePair<int, int>> SendMaxLevel { get; set; }
        private void SpellsKnownAdd()
        {
            Application.Run(new SpellsKnownAdd(SendCaster, SendMaxLevel));
        }
        private Other.Spell SendSpell { get; set; }
        private void SpellInfo()
        {
            Application.Run(new SpellInfo(SendSpell));
        }

        #region Initialize Classes
        private void Barbarian()
        {
            int _level = Convert.ToInt32(nudLevel.Value);
            int qualities = 0;
            bool other = false;
            if (_classAdded > 1)
                other = true;
            DNDClasses.Barbarian barb = new DNDClasses.Barbarian(_level, other);
            lblClassName.Text = "Barbarian";
            lblBAB.Text = uniMet.BaseAttackBonus(_level, DNDClasses.Barbarian.Bab);
            lblFort.Text = uniMet.SavingThrows(_level, DNDClasses.Barbarian.Fort);
            lblRef.Text = uniMet.SavingThrows(_level, DNDClasses.Barbarian.Refl);
            lblWill.Text = uniMet.SavingThrows(_level, DNDClasses.Barbarian.Will);
            foreach (KeyValuePair<int, string> item in barb._listQualities)
            {
                if (_level < item.Key)
                    break;
                LabelQualityCreator(qualities, item.Value, "lblQualNew" + qualities, pQualities, 22, 10, 32);
                qualities++;
            }
        }
        private void Bard()
        {
            int _level = Convert.ToInt32(nudLevel.Value);
            int qualities = 0;
            DNDClasses.Bard bard = new DNDClasses.Bard(_level);
            lblClassName.Text = "Bard";
            lblBAB.Text = uniMet.BaseAttackBonus(_level, DNDClasses.Bard.Bab);
            lblFort.Text = uniMet.SavingThrows(_level, DNDClasses.Bard.Fort);
            lblRef.Text = uniMet.SavingThrows(_level, DNDClasses.Bard.Refl);
            lblWill.Text = uniMet.SavingThrows(_level, DNDClasses.Bard.Will);
            List<string> songs = bard.Songs(_level);

            AddCasterTap(bard.spc, "Bard");

            foreach (KeyValuePair<int, string> item in bard._listQualities)
            {
                LabelQualityCreator(qualities, item.Value, "lblQualNew" + qualities, pQualities, 22, 10, 32);
                qualities++;
            }
            foreach (string item in songs)
            {
                LabelQualityCreator(qualities, item, "lblQualNew" + qualities, pQualities, 22, 10, 32);
                qualities++;
            }
        }
        private void Fighter()
        {
            int _level = Convert.ToInt32(nudLevel.Value);
            int qualities = 0;
            DNDClasses.Fighter fig = new DNDClasses.Fighter(_level);
            lblClassName.Text = "Fighter";
            lblBAB.Text = uniMet.BaseAttackBonus(_level, DNDClasses.Fighter.Bab);
            lblFort.Text = uniMet.SavingThrows(_level, DNDClasses.Fighter.Fort);
            lblRef.Text = uniMet.SavingThrows(_level, DNDClasses.Fighter.Refl);
            lblWill.Text = uniMet.SavingThrows(_level, DNDClasses.Fighter.Will);

            foreach (KeyValuePair<int, string> item in fig._listQualities)
            {
                LabelQualityCreator(qualities, item.Key + " " + item.Value, "lblQualNew" + qualities, pQualities, 22, 10, 32);
                uniMet.ImagedButtonCreatorRepeater(260, 6, 32 * qualities, 20, 20, "lblQualNew" + qualities,"AddAnother", pQualities, new EventHandler(this.FighterFeatsAdd), false, true);
                Label lbl = new Label();
                lbl.Name = "" + item.Key;
                lbl.Hide();
                pQualities.Controls.Add(lbl);
                qualities++;
            }
        }
        private void FighterFeatsAdd(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string fFeats = "";
            //searcher to go through all skills
            //searcher to go through all feats
            foreach (Other.Feat feat in feats.FighterFeats())
            {
                fFeats += feat.Name + "\r\n";
            }
            foreach (Control item in pQualities.Controls)
            {
                if (item.Name.Equals(btn.Tag))
                {
                    MessageBox.Show(fFeats);
                }
            }
        }
        #endregion
    }
}