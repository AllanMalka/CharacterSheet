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
    public partial class StatIncrease : Form
    {
        private List<string> stats;
        private CharacterSheet charSheet;
        private static UniversalMethods uniMet = new UniversalMethods();
        private bool _temporary;
        private int tempStr;
        private int tempDex;
        private int tempCon;
        private int tempInt;
        private int tempWis;
        private int tempCha;
        private int tempApp;

        public StatIncrease(bool useApp, bool temporary)
        {
            InitializeComponent();
            stats = new List<string>();
            stats.Add("Strength");
            stats.Add("Dexterity");
            stats.Add("Constitution");
            stats.Add("Intelligence");
            stats.Add("Wisdom");
            stats.Add("Charisma");
            if (useApp)
            {
                stats.Add("Appearance");
            }
            ddbStats.DataSource = stats;

            charSheet = (CharacterSheet)Application.OpenForms[Application.OpenForms.Count - 1];
            if (temporary)
            {
                _temporary = true;
                tempStr = charSheet.TempStr;
                tempDex = charSheet.TempDex;
                tempCon = charSheet.TempCon;
                tempInt = charSheet.TempInt;
                tempWis = charSheet.TempWis;
                tempCha = charSheet.TempCha;
                tempApp = charSheet.TempApp;
            }
            else
            {
                _temporary = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int stat = 0;
            switch (ddbStats.SelectedItem.ToString())
            {
                case "Strength": stat = 1; break;
                case "Dexterity": stat = 2; break;
                case "Constitution": stat = 3; break;
                case "Intelligence": stat = 4; break;
                case "Wisdom": stat = 5; break;
                case "Charisma": stat = 6; break;
                case "Appearance": stat = 7; break;
            }
            uniMet.CalculateAdding((Int32)nudIncrease.Value, stat, charSheet, _temporary);

            DialogResult diaRes = MessageBox.Show("Add more?", "Adding", MessageBoxButtons.YesNo);
            if (diaRes == DialogResult.No)
                this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
