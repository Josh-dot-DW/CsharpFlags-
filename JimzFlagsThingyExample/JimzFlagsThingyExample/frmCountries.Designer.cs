namespace JimzFlagsThingyExample
{
    partial class frmCountries
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCountries));
            this.lblTitle = new System.Windows.Forms.Label();
            this.chkTitle = new System.Windows.Forms.CheckBox();
            this.chkProgrammer = new System.Windows.Forms.CheckBox();
            this.chkVersion = new System.Windows.Forms.CheckBox();
            this.chkFlag = new System.Windows.Forms.CheckBox();
            this.chkInfo = new System.Windows.Forms.CheckBox();
            this.lblProgrammer = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.txtCountryInfo = new System.Windows.Forms.TextBox();
            this.rdoVirginIslands = new System.Windows.Forms.RadioButton();
            this.rdoCaymanIslands = new System.Windows.Forms.RadioButton();
            this.rdoCookIslands = new System.Windows.Forms.RadioButton();
            this.rdoFalklandIslands = new System.Windows.Forms.RadioButton();
            this.rdoPitcairnIslands = new System.Windows.Forms.RadioButton();
            this.rdoTurksAndCaicosIslands = new System.Windows.Forms.RadioButton();
            this.picFlags = new System.Windows.Forms.PictureBox();
            this.lstFlags = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picFlags)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(112, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(590, 52);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Jimz British Micro-Nation Infoviewer ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkTitle
            // 
            this.chkTitle.AutoSize = true;
            this.chkTitle.Checked = true;
            this.chkTitle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTitle.Location = new System.Drawing.Point(599, 62);
            this.chkTitle.Name = "chkTitle";
            this.chkTitle.Size = new System.Drawing.Size(117, 28);
            this.chkTitle.TabIndex = 2;
            this.chkTitle.Text = "Show Title";
            this.chkTitle.UseVisualStyleBackColor = true;
            this.chkTitle.CheckedChanged += new System.EventHandler(this.chkTitle_CheckedChanged);
            // 
            // chkProgrammer
            // 
            this.chkProgrammer.AutoSize = true;
            this.chkProgrammer.Checked = true;
            this.chkProgrammer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkProgrammer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkProgrammer.Location = new System.Drawing.Point(599, 96);
            this.chkProgrammer.Name = "chkProgrammer";
            this.chkProgrammer.Size = new System.Drawing.Size(187, 28);
            this.chkProgrammer.TabIndex = 3;
            this.chkProgrammer.Text = "Show Programmer";
            this.chkProgrammer.UseVisualStyleBackColor = true;
            this.chkProgrammer.CheckedChanged += new System.EventHandler(this.chkProgrammer_CheckedChanged);
            // 
            // chkVersion
            // 
            this.chkVersion.AutoSize = true;
            this.chkVersion.Checked = true;
            this.chkVersion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVersion.Location = new System.Drawing.Point(599, 130);
            this.chkVersion.Name = "chkVersion";
            this.chkVersion.Size = new System.Drawing.Size(147, 28);
            this.chkVersion.TabIndex = 4;
            this.chkVersion.Text = "Show Version";
            this.chkVersion.UseVisualStyleBackColor = true;
            this.chkVersion.CheckedChanged += new System.EventHandler(this.chkVersion_CheckedChanged);
            // 
            // chkFlag
            // 
            this.chkFlag.AutoSize = true;
            this.chkFlag.Checked = true;
            this.chkFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFlag.Location = new System.Drawing.Point(600, 200);
            this.chkFlag.Name = "chkFlag";
            this.chkFlag.Size = new System.Drawing.Size(119, 28);
            this.chkFlag.TabIndex = 5;
            this.chkFlag.Text = "Show Flag";
            this.chkFlag.UseVisualStyleBackColor = true;
            this.chkFlag.CheckedChanged += new System.EventHandler(this.chkFlag_CheckedChanged);
            // 
            // chkInfo
            // 
            this.chkInfo.AutoSize = true;
            this.chkInfo.Checked = true;
            this.chkInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInfo.Location = new System.Drawing.Point(599, 166);
            this.chkInfo.Name = "chkInfo";
            this.chkInfo.Size = new System.Drawing.Size(112, 28);
            this.chkInfo.TabIndex = 6;
            this.chkInfo.Text = "Show Info";
            this.chkInfo.UseVisualStyleBackColor = true;
            this.chkInfo.CheckedChanged += new System.EventHandler(this.chkInfo_CheckedChanged);
            // 
            // lblProgrammer
            // 
            this.lblProgrammer.AutoSize = true;
            this.lblProgrammer.Location = new System.Drawing.Point(674, 395);
            this.lblProgrammer.Name = "lblProgrammer";
            this.lblProgrammer.Size = new System.Drawing.Size(141, 24);
            this.lblProgrammer.TabIndex = 7;
            this.lblProgrammer.Text = "Written by Jim";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(12, 395);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(139, 24);
            this.lblVersion.TabIndex = 8;
            this.lblVersion.Text = "Version: 0.0.1";
            // 
            // lblCountryName
            // 
            this.lblCountryName.Location = new System.Drawing.Point(182, 216);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(412, 31);
            this.lblCountryName.TabIndex = 9;
            this.lblCountryName.Text = "British Virgin Islands";
            this.lblCountryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCountryInfo
            // 
            this.txtCountryInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountryInfo.Location = new System.Drawing.Point(15, 273);
            this.txtCountryInfo.Multiline = true;
            this.txtCountryInfo.Name = "txtCountryInfo";
            this.txtCountryInfo.ReadOnly = true;
            this.txtCountryInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCountryInfo.Size = new System.Drawing.Size(813, 99);
            this.txtCountryInfo.TabIndex = 10;
            this.txtCountryInfo.Text = resources.GetString("txtCountryInfo.Text");
            // 
            // rdoVirginIslands
            // 
            this.rdoVirginIslands.AutoSize = true;
            this.rdoVirginIslands.Checked = true;
            this.rdoVirginIslands.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoVirginIslands.Location = new System.Drawing.Point(19, 58);
            this.rdoVirginIslands.Name = "rdoVirginIslands";
            this.rdoVirginIslands.Size = new System.Drawing.Size(195, 28);
            this.rdoVirginIslands.TabIndex = 11;
            this.rdoVirginIslands.TabStop = true;
            this.rdoVirginIslands.Text = "British Virgin Islands";
            this.rdoVirginIslands.UseVisualStyleBackColor = true;
            this.rdoVirginIslands.Click += new System.EventHandler(this.rdoVirginIslands_Click);
            // 
            // rdoCaymanIslands
            // 
            this.rdoCaymanIslands.AutoSize = true;
            this.rdoCaymanIslands.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCaymanIslands.Location = new System.Drawing.Point(19, 92);
            this.rdoCaymanIslands.Name = "rdoCaymanIslands";
            this.rdoCaymanIslands.Size = new System.Drawing.Size(160, 28);
            this.rdoCaymanIslands.TabIndex = 12;
            this.rdoCaymanIslands.Text = "Cayman Islands";
            this.rdoCaymanIslands.UseVisualStyleBackColor = true;
            this.rdoCaymanIslands.Click += new System.EventHandler(this.rdoCaymanIslands_Click);
            // 
            // rdoCookIslands
            // 
            this.rdoCookIslands.AutoSize = true;
            this.rdoCookIslands.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCookIslands.Location = new System.Drawing.Point(19, 126);
            this.rdoCookIslands.Name = "rdoCookIslands";
            this.rdoCookIslands.Size = new System.Drawing.Size(135, 28);
            this.rdoCookIslands.TabIndex = 13;
            this.rdoCookIslands.Text = "Cook Islands";
            this.rdoCookIslands.UseVisualStyleBackColor = true;
            this.rdoCookIslands.Click += new System.EventHandler(this.rdoCookIslands_Click);
            // 
            // rdoFalklandIslands
            // 
            this.rdoFalklandIslands.AutoSize = true;
            this.rdoFalklandIslands.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFalklandIslands.Location = new System.Drawing.Point(19, 160);
            this.rdoFalklandIslands.Name = "rdoFalklandIslands";
            this.rdoFalklandIslands.Size = new System.Drawing.Size(162, 28);
            this.rdoFalklandIslands.TabIndex = 14;
            this.rdoFalklandIslands.Text = "Falkland Islands";
            this.rdoFalklandIslands.UseVisualStyleBackColor = true;
            this.rdoFalklandIslands.Click += new System.EventHandler(this.rdoFalklandIslands_Click);
            // 
            // rdoPitcairnIslands
            // 
            this.rdoPitcairnIslands.AutoSize = true;
            this.rdoPitcairnIslands.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPitcairnIslands.Location = new System.Drawing.Point(19, 194);
            this.rdoPitcairnIslands.Name = "rdoPitcairnIslands";
            this.rdoPitcairnIslands.Size = new System.Drawing.Size(152, 28);
            this.rdoPitcairnIslands.TabIndex = 15;
            this.rdoPitcairnIslands.Text = "Pitcairn Islands";
            this.rdoPitcairnIslands.UseVisualStyleBackColor = true;
            this.rdoPitcairnIslands.Click += new System.EventHandler(this.rdoPitcairnIslands_Click);
            // 
            // rdoTurksAndCaicosIslands
            // 
            this.rdoTurksAndCaicosIslands.AutoSize = true;
            this.rdoTurksAndCaicosIslands.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTurksAndCaicosIslands.Location = new System.Drawing.Point(19, 228);
            this.rdoTurksAndCaicosIslands.Name = "rdoTurksAndCaicosIslands";
            this.rdoTurksAndCaicosIslands.Size = new System.Drawing.Size(237, 28);
            this.rdoTurksAndCaicosIslands.TabIndex = 16;
            this.rdoTurksAndCaicosIslands.Text = "Turks and Caicos Islands";
            this.rdoTurksAndCaicosIslands.UseVisualStyleBackColor = true;
            this.rdoTurksAndCaicosIslands.Click += new System.EventHandler(this.rdoTurksAndCaicosIslands_Click);
            // 
            // picFlags
            // 
            this.picFlags.Image = ((System.Drawing.Image)(resources.GetObject("picFlags.Image")));
            this.picFlags.Location = new System.Drawing.Point(261, 66);
            this.picFlags.Name = "picFlags";
            this.picFlags.Size = new System.Drawing.Size(256, 128);
            this.picFlags.TabIndex = 17;
            this.picFlags.TabStop = false;
            // 
            // lstFlags
            // 
            this.lstFlags.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstFlags.ImageStream")));
            this.lstFlags.TransparentColor = System.Drawing.Color.Transparent;
            this.lstFlags.Images.SetKeyName(0, "Flag_of_the_British_Virgin_Islands.png");
            this.lstFlags.Images.SetKeyName(1, "Flag_of_the_Cayman_Islands.png");
            this.lstFlags.Images.SetKeyName(2, "Flag_of_the_Cook_Islands.png");
            this.lstFlags.Images.SetKeyName(3, "Flag_of_the_Falkland_Islands.png");
            this.lstFlags.Images.SetKeyName(4, "Flag_of_the_Pitcairn_Islands.png");
            this.lstFlags.Images.SetKeyName(5, "Flag_of_the_Turks_and_Caicos_Islands.png");
            // 
            // frmCountries
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(839, 438);
            this.Controls.Add(this.picFlags);
            this.Controls.Add(this.rdoTurksAndCaicosIslands);
            this.Controls.Add(this.rdoPitcairnIslands);
            this.Controls.Add(this.rdoFalklandIslands);
            this.Controls.Add(this.rdoCookIslands);
            this.Controls.Add(this.rdoCaymanIslands);
            this.Controls.Add(this.rdoVirginIslands);
            this.Controls.Add(this.txtCountryInfo);
            this.Controls.Add(this.lblCountryName);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblProgrammer);
            this.Controls.Add(this.chkInfo);
            this.Controls.Add(this.chkFlag);
            this.Controls.Add(this.chkVersion);
            this.Controls.Add(this.chkProgrammer);
            this.Controls.Add(this.chkTitle);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCountries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Micro-Nation Information";
            ((System.ComponentModel.ISupportInitialize)(this.picFlags)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox chkTitle;
        private System.Windows.Forms.CheckBox chkProgrammer;
        private System.Windows.Forms.CheckBox chkVersion;
        private System.Windows.Forms.CheckBox chkFlag;
        private System.Windows.Forms.CheckBox chkInfo;
        private System.Windows.Forms.Label lblProgrammer;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.TextBox txtCountryInfo;
        private System.Windows.Forms.RadioButton rdoVirginIslands;
        private System.Windows.Forms.RadioButton rdoCaymanIslands;
        private System.Windows.Forms.RadioButton rdoCookIslands;
        private System.Windows.Forms.RadioButton rdoFalklandIslands;
        private System.Windows.Forms.RadioButton rdoPitcairnIslands;
        private System.Windows.Forms.RadioButton rdoTurksAndCaicosIslands;
        private System.Windows.Forms.PictureBox picFlags;
        private System.Windows.Forms.ImageList lstFlags;
    }
}

