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
    public partial class AlignmentWheel : Form
    {
        private CharacterSheet charSheet;
        public AlignmentWheel()
        {
            charSheet = (CharacterSheet)Application.OpenForms[Application.OpenForms.Count - 1];
            InitializeComponent();
        }
        private void AlignmentChooser(string picked)
        {
            charSheet.Alignment = picked;
            this.Close();
        }

        private void btnLG_Click(object sender, EventArgs e)
        {
            AlignmentChooser("Lawful Good");
        }

        private void btnLN_Click(object sender, EventArgs e)
        {
            AlignmentChooser("Lawful Neutral");
        }

        private void btnLE_Click(object sender, EventArgs e)
        {
            AlignmentChooser("Lawful Evil");
        }

        private void btnNG_Click(object sender, EventArgs e)
        {
            AlignmentChooser("Neutral Good");
        }

        private void btnTN_Click(object sender, EventArgs e)
        {
            AlignmentChooser("True Neutral");
        }

        private void btnNE_Click(object sender, EventArgs e)
        {
            AlignmentChooser("Neutral Evil");
        }

        private void btnCG_Click(object sender, EventArgs e)
        {
            AlignmentChooser("Chaotic Good");
        }

        private void btnCN_Click(object sender, EventArgs e)
        {
            AlignmentChooser("Chaotic Neutral");
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            AlignmentChooser("Chaotic Evil");
        }
    }
}
