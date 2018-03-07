namespace CharacterSheet
{
    partial class AlignmentWheel
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
            this.btnLG = new System.Windows.Forms.Button();
            this.btnNG = new System.Windows.Forms.Button();
            this.btnCG = new System.Windows.Forms.Button();
            this.btnLN = new System.Windows.Forms.Button();
            this.btnTN = new System.Windows.Forms.Button();
            this.btnCN = new System.Windows.Forms.Button();
            this.btnLE = new System.Windows.Forms.Button();
            this.btnNE = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLG
            // 
            this.btnLG.Location = new System.Drawing.Point(13, 13);
            this.btnLG.Name = "btnLG";
            this.btnLG.Size = new System.Drawing.Size(87, 23);
            this.btnLG.TabIndex = 0;
            this.btnLG.Text = "Lawful Good";
            this.btnLG.UseVisualStyleBackColor = true;
            this.btnLG.Click += new System.EventHandler(this.btnLG_Click);
            // 
            // btnNG
            // 
            this.btnNG.Location = new System.Drawing.Point(111, 13);
            this.btnNG.Name = "btnNG";
            this.btnNG.Size = new System.Drawing.Size(87, 23);
            this.btnNG.TabIndex = 1;
            this.btnNG.Text = "Neutral Good";
            this.btnNG.UseVisualStyleBackColor = true;
            this.btnNG.Click += new System.EventHandler(this.btnNG_Click);
            // 
            // btnCG
            // 
            this.btnCG.Location = new System.Drawing.Point(211, 13);
            this.btnCG.Name = "btnCG";
            this.btnCG.Size = new System.Drawing.Size(95, 23);
            this.btnCG.TabIndex = 2;
            this.btnCG.Text = "Chaotic Good";
            this.btnCG.UseVisualStyleBackColor = true;
            this.btnCG.Click += new System.EventHandler(this.btnCG_Click);
            // 
            // btnLN
            // 
            this.btnLN.Location = new System.Drawing.Point(13, 43);
            this.btnLN.Name = "btnLN";
            this.btnLN.Size = new System.Drawing.Size(87, 23);
            this.btnLN.TabIndex = 3;
            this.btnLN.Text = "Lawful Neutral";
            this.btnLN.UseVisualStyleBackColor = true;
            this.btnLN.Click += new System.EventHandler(this.btnLN_Click);
            // 
            // btnTN
            // 
            this.btnTN.Location = new System.Drawing.Point(111, 42);
            this.btnTN.Name = "btnTN";
            this.btnTN.Size = new System.Drawing.Size(87, 23);
            this.btnTN.TabIndex = 4;
            this.btnTN.Text = "True Neutral";
            this.btnTN.UseVisualStyleBackColor = true;
            this.btnTN.Click += new System.EventHandler(this.btnTN_Click);
            // 
            // btnCN
            // 
            this.btnCN.Location = new System.Drawing.Point(211, 43);
            this.btnCN.Name = "btnCN";
            this.btnCN.Size = new System.Drawing.Size(95, 23);
            this.btnCN.TabIndex = 5;
            this.btnCN.Text = "Chaotic Neutral";
            this.btnCN.UseVisualStyleBackColor = true;
            this.btnCN.Click += new System.EventHandler(this.btnCN_Click);
            // 
            // btnLE
            // 
            this.btnLE.Location = new System.Drawing.Point(13, 73);
            this.btnLE.Name = "btnLE";
            this.btnLE.Size = new System.Drawing.Size(87, 23);
            this.btnLE.TabIndex = 6;
            this.btnLE.Text = "Lawful Evil";
            this.btnLE.UseVisualStyleBackColor = true;
            this.btnLE.Click += new System.EventHandler(this.btnLE_Click);
            // 
            // btnNE
            // 
            this.btnNE.Location = new System.Drawing.Point(111, 72);
            this.btnNE.Name = "btnNE";
            this.btnNE.Size = new System.Drawing.Size(87, 23);
            this.btnNE.TabIndex = 7;
            this.btnNE.Text = "Neutral Evil";
            this.btnNE.UseVisualStyleBackColor = true;
            this.btnNE.Click += new System.EventHandler(this.btnNE_Click);
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(211, 72);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(95, 23);
            this.btnCE.TabIndex = 8;
            this.btnCE.Text = "Chaotic Evil";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // AlignmentWheel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 105);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnNE);
            this.Controls.Add(this.btnLE);
            this.Controls.Add(this.btnCN);
            this.Controls.Add(this.btnTN);
            this.Controls.Add(this.btnLN);
            this.Controls.Add(this.btnCG);
            this.Controls.Add(this.btnNG);
            this.Controls.Add(this.btnLG);
            this.Name = "AlignmentWheel";
            this.Text = "AlignmentWheel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLG;
        private System.Windows.Forms.Button btnNG;
        private System.Windows.Forms.Button btnCG;
        private System.Windows.Forms.Button btnLN;
        private System.Windows.Forms.Button btnTN;
        private System.Windows.Forms.Button btnCN;
        private System.Windows.Forms.Button btnLE;
        private System.Windows.Forms.Button btnNE;
        private System.Windows.Forms.Button btnCE;
    }
}