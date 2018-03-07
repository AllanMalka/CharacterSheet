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
    public partial class StartStat : Form
    {
        private CharacterSheet charSheet;
        private static UniversalMethods uniMet = new UniversalMethods();

        public StartStat(bool useApp)
        {
            InitializeComponent();
            charSheet = (CharacterSheet)Application.OpenForms[Application.OpenForms.Count - 1];
            cbEnableApp.Checked = useApp;
        }

        private void btnStartStats_Click(object sender, EventArgs e)
        {
            try
            {
                List<KeyValuePair<string, string>> abil = new List<KeyValuePair<string, string>>();

                List<KeyValuePair<string, int>> racial = new List<KeyValuePair<string,int>>();

                abil.Add(new KeyValuePair<string, string>(lblStr.Text, txtStr.Text));
                abil.Add(new KeyValuePair<string, string>(lblDex.Text, txtDex.Text));
                abil.Add(new KeyValuePair<string, string>(lblCon.Text, txtCon.Text));
                abil.Add(new KeyValuePair<string, string>(lblInt.Text, txtInt.Text));
                abil.Add(new KeyValuePair<string, string>(lblWis.Text, txtWis.Text));
                abil.Add(new KeyValuePair<string, string>(lblCha.Text, txtCha.Text));

                racial.Add(new KeyValuePair<string,int>(lblStr.Text, (Int32)nudStr.Value));
                racial.Add(new KeyValuePair<string,int>(lblDex.Text, (Int32)nudDex.Value));
                racial.Add(new KeyValuePair<string,int>(lblCon.Text, (Int32)nudCon.Value));
                racial.Add(new KeyValuePair<string,int>(lblInt.Text, (Int32)nudInt.Value));
                racial.Add(new KeyValuePair<string,int>(lblWis.Text, (Int32)nudWis.Value));
                racial.Add(new KeyValuePair<string,int>(lblCha.Text, (Int32)nudCha.Value));

                if (cbEnableApp.Checked)
                {
                    abil.Add(new KeyValuePair<string, string>(lblApp.Text, txtApp.Text));
                    racial.Add(new KeyValuePair<string,int>(lblApp.Text, (Int32)nudApp.Value));
                }


                int intError = 0;
                int n;
                string errorText = "";
                int count = 0;

                foreach (KeyValuePair<string, string> item in abil)
                {
                    string sKey = item.Key;
                    string sVal = item.Value;
                    
                    #region Empty check
                    if (string.IsNullOrEmpty(sVal))
                    {
                        if (intError == 0)
                        {
                            errorText = sKey + " needed to be filled";
                            intError = 1;
                        }
                        else
                        {
                            errorText += "\r\n" + sKey + " needed to be filled";
                        }
                    }
                    #endregion
                    #region Number check
                    else if (!int.TryParse(sVal, out n))
                    {
                        if (intError == 0)
                        {
                            errorText = sKey + " needed to be a number";
                            intError = 1;
                        }
                        else
                        {
                            errorText += "\r\n" + sKey + " needed to be a number";
                        }
                    }
                    #endregion
                    #region Positive check
                    else if (Convert.ToInt32(sVal) <= 0)
                    {
                        if (intError == 0)
                        {
                            errorText = sKey + " can't be a negative number";
                            intError = 1;
                        }
                        else
                        {
                            errorText += "\r\n" + sKey + " can't be a negative number";
                        }
                    }
                    #endregion
                    #region Racial Check
                    else if ((Convert.ToInt32(sVal)+(Int32)racial[count].Value) <= 0)
                    {
                        if (intError == 0)
                        {
                            errorText = sKey + " total is to low";
                            intError = 1;
                        }
                        else
                        {
                            errorText += "\r\n" + sKey + " total is to low";
                        }
                    }
                    #endregion
                    count++;
                }
                if (intError == 1)
                {
                    MessageBox.Show(errorText);
                }
                else
                {
                    charSheet.btnAddStats.Text = "Add stats";
                    uniMet.CalculateAdding(Convert.ToInt32(abil[0].Value) + (Int32)nudStr.Value, 1, charSheet, false);
                    uniMet.CalculateAdding(Convert.ToInt32(abil[1].Value) + (Int32)nudDex.Value, 2, charSheet, false);
                    uniMet.CalculateAdding(Convert.ToInt32(abil[2].Value) + (Int32)nudCon.Value, 3, charSheet, false);
                    uniMet.CalculateAdding(Convert.ToInt32(abil[3].Value) + (Int32)nudInt.Value, 4, charSheet, false);
                    uniMet.CalculateAdding(Convert.ToInt32(abil[4].Value) + (Int32)nudWis.Value, 5, charSheet, false);
                    uniMet.CalculateAdding(Convert.ToInt32(abil[5].Value) + (Int32)nudCha.Value, 6, charSheet, false);

                    if (abil.Count == 7)
                    {
                        uniMet.CalculateAdding(Convert.ToInt32(abil[6].Value) + (Int32)nudApp.Value, 7, charSheet, false);
                    }
                    this.Close();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("No goose power here");
            }
        }

        private void cbEnableApp_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbEnableApp.Checked)
            {
                cbEnableApp.Text = "Disabled Appearance";
                txtApp.Enabled = false;
                charSheet.UsingApp(false);
            }
            if (cbEnableApp.Checked)
            {
                cbEnableApp.Text = "Enabled Appearance";
                txtApp.Enabled = true;
                charSheet.UsingApp(true);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
