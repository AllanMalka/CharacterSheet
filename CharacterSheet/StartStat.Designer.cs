namespace CharacterSheet
{
    partial class StartStat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudStr = new System.Windows.Forms.NumericUpDown();
            this.lblRace = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnStartStats = new System.Windows.Forms.Button();
            this.cbEnableApp = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblApp = new System.Windows.Forms.Label();
            this.lblCha = new System.Windows.Forms.Label();
            this.lblWis = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.lblDex = new System.Windows.Forms.Label();
            this.lblStr = new System.Windows.Forms.Label();
            this.txtDex = new System.Windows.Forms.TextBox();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.txtCha = new System.Windows.Forms.TextBox();
            this.txtApp = new System.Windows.Forms.TextBox();
            this.txtWis = new System.Windows.Forms.TextBox();
            this.txtInt = new System.Windows.Forms.TextBox();
            this.txtStr = new System.Windows.Forms.TextBox();
            this.nudDex = new System.Windows.Forms.NumericUpDown();
            this.nudCon = new System.Windows.Forms.NumericUpDown();
            this.nudInt = new System.Windows.Forms.NumericUpDown();
            this.nudWis = new System.Windows.Forms.NumericUpDown();
            this.nudCha = new System.Windows.Forms.NumericUpDown();
            this.nudApp = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudApp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.nudApp);
            this.panel1.Controls.Add(this.nudCha);
            this.panel1.Controls.Add(this.nudWis);
            this.panel1.Controls.Add(this.nudInt);
            this.panel1.Controls.Add(this.nudCon);
            this.panel1.Controls.Add(this.nudDex);
            this.panel1.Controls.Add(this.nudStr);
            this.panel1.Controls.Add(this.lblRace);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnStartStats);
            this.panel1.Controls.Add(this.cbEnableApp);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblApp);
            this.panel1.Controls.Add(this.lblCha);
            this.panel1.Controls.Add(this.lblWis);
            this.panel1.Controls.Add(this.lblInt);
            this.panel1.Controls.Add(this.lblCon);
            this.panel1.Controls.Add(this.lblDex);
            this.panel1.Controls.Add(this.lblStr);
            this.panel1.Controls.Add(this.txtDex);
            this.panel1.Controls.Add(this.txtCon);
            this.panel1.Controls.Add(this.txtCha);
            this.panel1.Controls.Add(this.txtApp);
            this.panel1.Controls.Add(this.txtWis);
            this.panel1.Controls.Add(this.txtInt);
            this.panel1.Controls.Add(this.txtStr);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 261);
            this.panel1.TabIndex = 0;
            // 
            // nudStr
            // 
            this.nudStr.Location = new System.Drawing.Point(184, 38);
            this.nudStr.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudStr.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.nudStr.Name = "nudStr";
            this.nudStr.Size = new System.Drawing.Size(43, 20);
            this.nudStr.TabIndex = 8;
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(181, 4);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(56, 26);
            this.lblRace.TabIndex = 32;
            this.lblRace.Text = "Racial\r\nstat bonus";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(100, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnStartStats
            // 
            this.btnStartStats.Location = new System.Drawing.Point(3, 229);
            this.btnStartStats.Name = "btnStartStats";
            this.btnStartStats.Size = new System.Drawing.Size(91, 25);
            this.btnStartStats.TabIndex = 16;
            this.btnStartStats.Text = "Add start stats";
            this.btnStartStats.UseVisualStyleBackColor = true;
            this.btnStartStats.Click += new System.EventHandler(this.btnStartStats_Click);
            // 
            // cbEnableApp
            // 
            this.cbEnableApp.AutoSize = true;
            this.cbEnableApp.Checked = true;
            this.cbEnableApp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEnableApp.Location = new System.Drawing.Point(6, 206);
            this.cbEnableApp.Name = "cbEnableApp";
            this.cbEnableApp.Size = new System.Drawing.Size(126, 17);
            this.cbEnableApp.TabIndex = 15;
            this.cbEnableApp.Text = "Enabled Appearance";
            this.cbEnableApp.UseVisualStyleBackColor = true;
            this.cbEnableApp.CheckedChanged += new System.EventHandler(this.cbEnableApp_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Abilities";
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.Location = new System.Drawing.Point(3, 181);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(68, 13);
            this.lblApp.TabIndex = 0;
            this.lblApp.Text = "Appearance ";
            // 
            // lblCha
            // 
            this.lblCha.AutoSize = true;
            this.lblCha.Location = new System.Drawing.Point(3, 158);
            this.lblCha.Name = "lblCha";
            this.lblCha.Size = new System.Drawing.Size(50, 13);
            this.lblCha.TabIndex = 0;
            this.lblCha.Text = "Charisma";
            // 
            // lblWis
            // 
            this.lblWis.AutoSize = true;
            this.lblWis.Location = new System.Drawing.Point(3, 135);
            this.lblWis.Name = "lblWis";
            this.lblWis.Size = new System.Drawing.Size(45, 13);
            this.lblWis.TabIndex = 0;
            this.lblWis.Text = "Wisdom";
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Location = new System.Drawing.Point(3, 112);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(61, 13);
            this.lblInt.TabIndex = 0;
            this.lblInt.Text = "Intelligence";
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Location = new System.Drawing.Point(3, 89);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(62, 13);
            this.lblCon.TabIndex = 0;
            this.lblCon.Text = "Constitution";
            // 
            // lblDex
            // 
            this.lblDex.AutoSize = true;
            this.lblDex.Location = new System.Drawing.Point(3, 66);
            this.lblDex.Name = "lblDex";
            this.lblDex.Size = new System.Drawing.Size(48, 13);
            this.lblDex.TabIndex = 0;
            this.lblDex.Text = "Dexterity";
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Location = new System.Drawing.Point(3, 43);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(47, 13);
            this.lblStr.TabIndex = 0;
            this.lblStr.Text = "Strength";
            // 
            // txtDex
            // 
            this.txtDex.Location = new System.Drawing.Point(74, 61);
            this.txtDex.Name = "txtDex";
            this.txtDex.Size = new System.Drawing.Size(100, 20);
            this.txtDex.TabIndex = 2;
            // 
            // txtCon
            // 
            this.txtCon.Location = new System.Drawing.Point(74, 84);
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(100, 20);
            this.txtCon.TabIndex = 3;
            // 
            // txtCha
            // 
            this.txtCha.Location = new System.Drawing.Point(74, 153);
            this.txtCha.Name = "txtCha";
            this.txtCha.Size = new System.Drawing.Size(100, 20);
            this.txtCha.TabIndex = 6;
            // 
            // txtApp
            // 
            this.txtApp.Location = new System.Drawing.Point(74, 176);
            this.txtApp.Name = "txtApp";
            this.txtApp.Size = new System.Drawing.Size(100, 20);
            this.txtApp.TabIndex = 7;
            // 
            // txtWis
            // 
            this.txtWis.Location = new System.Drawing.Point(74, 130);
            this.txtWis.Name = "txtWis";
            this.txtWis.Size = new System.Drawing.Size(100, 20);
            this.txtWis.TabIndex = 5;
            // 
            // txtInt
            // 
            this.txtInt.Location = new System.Drawing.Point(74, 107);
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(100, 20);
            this.txtInt.TabIndex = 4;
            // 
            // txtStr
            // 
            this.txtStr.Location = new System.Drawing.Point(74, 38);
            this.txtStr.Name = "txtStr";
            this.txtStr.Size = new System.Drawing.Size(100, 20);
            this.txtStr.TabIndex = 1;
            // 
            // nudDex
            // 
            this.nudDex.Location = new System.Drawing.Point(184, 61);
            this.nudDex.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudDex.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.nudDex.Name = "nudDex";
            this.nudDex.Size = new System.Drawing.Size(43, 20);
            this.nudDex.TabIndex = 9;
            // 
            // nudCon
            // 
            this.nudCon.Location = new System.Drawing.Point(184, 84);
            this.nudCon.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudCon.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.nudCon.Name = "nudCon";
            this.nudCon.Size = new System.Drawing.Size(43, 20);
            this.nudCon.TabIndex = 10;
            // 
            // nudInt
            // 
            this.nudInt.Location = new System.Drawing.Point(184, 107);
            this.nudInt.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudInt.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.nudInt.Name = "nudInt";
            this.nudInt.Size = new System.Drawing.Size(43, 20);
            this.nudInt.TabIndex = 11;
            // 
            // nudWis
            // 
            this.nudWis.Location = new System.Drawing.Point(184, 130);
            this.nudWis.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudWis.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.nudWis.Name = "nudWis";
            this.nudWis.Size = new System.Drawing.Size(43, 20);
            this.nudWis.TabIndex = 12;
            // 
            // nudCha
            // 
            this.nudCha.Location = new System.Drawing.Point(184, 153);
            this.nudCha.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudCha.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.nudCha.Name = "nudCha";
            this.nudCha.Size = new System.Drawing.Size(43, 20);
            this.nudCha.TabIndex = 13;
            // 
            // nudApp
            // 
            this.nudApp.Location = new System.Drawing.Point(184, 176);
            this.nudApp.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudApp.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.nudApp.Name = "nudApp";
            this.nudApp.Size = new System.Drawing.Size(43, 20);
            this.nudApp.TabIndex = 14;
            // 
            // StartStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 284);
            this.Controls.Add(this.panel1);
            this.Name = "StartStat";
            this.Text = "StartStat";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Label lblCha;
        private System.Windows.Forms.Label lblWis;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Label lblDex;
        private System.Windows.Forms.Label lblStr;
        private System.Windows.Forms.TextBox txtDex;
        private System.Windows.Forms.TextBox txtCon;
        private System.Windows.Forms.TextBox txtCha;
        private System.Windows.Forms.TextBox txtApp;
        private System.Windows.Forms.TextBox txtWis;
        private System.Windows.Forms.TextBox txtInt;
        private System.Windows.Forms.TextBox txtStr;
        private System.Windows.Forms.Button btnStartStats;
        private System.Windows.Forms.CheckBox cbEnableApp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nudStr;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.NumericUpDown nudApp;
        private System.Windows.Forms.NumericUpDown nudCha;
        private System.Windows.Forms.NumericUpDown nudWis;
        private System.Windows.Forms.NumericUpDown nudInt;
        private System.Windows.Forms.NumericUpDown nudCon;
        private System.Windows.Forms.NumericUpDown nudDex;

    }
}