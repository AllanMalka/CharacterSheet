namespace CharacterSheet
{
    partial class SpellsKnownAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pSpellsKnown = new System.Windows.Forms.Panel();
            this.lblDispaly = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pSpellsKnown
            // 
            this.pSpellsKnown.AutoScroll = true;
            this.pSpellsKnown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pSpellsKnown.Location = new System.Drawing.Point(5, 39);
            this.pSpellsKnown.Name = "pSpellsKnown";
            this.pSpellsKnown.Size = new System.Drawing.Size(825, 607);
            this.pSpellsKnown.TabIndex = 0;
            // 
            // lblDispaly
            // 
            this.lblDispaly.AutoSize = true;
            this.lblDispaly.Location = new System.Drawing.Point(259, 19);
            this.lblDispaly.Name = "lblDispaly";
            this.lblDispaly.Size = new System.Drawing.Size(35, 13);
            this.lblDispaly.TabIndex = 1;
            this.lblDispaly.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(186, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Spellsknown";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(259, 4);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(35, 13);
            this.lblLevel.TabIndex = 3;
            this.lblLevel.Text = "label2";
            // 
            // SpellsKnownAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 658);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDispaly);
            this.Controls.Add(this.pSpellsKnown);
            this.Name = "SpellsKnownAdd";
            this.Text = "SpellsKnownAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pSpellsKnown;
        private System.Windows.Forms.Label lblDispaly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLevel;
    }
}