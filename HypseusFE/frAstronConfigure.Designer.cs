namespace HypseusFE
{
    partial class frAstronConfigure
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
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.cmbFullscreen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MtbROMFileLocation = new System.Windows.Forms.TextBox();
            this.MtbFrameFileLocation = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new System.Windows.Forms.Label();
            this.materialLabel1 = new System.Windows.Forms.Label();
            this.MbuClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCoinsPerCredit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MtbExtra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPlayTimer = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbExtraShips = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbGameType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbAttractSound = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbSound = new System.Windows.Forms.ComboBox();
            this.cmbSoundBuffers = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbY
            // 
            this.tbY.BackColor = System.Drawing.Color.Silver;
            this.tbY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbY.Location = new System.Drawing.Point(176, 48);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(47, 20);
            this.tbY.TabIndex = 30;
            this.tbY.Leave += new System.EventHandler(this.tbY_Leave);
            // 
            // tbX
            // 
            this.tbX.BackColor = System.Drawing.Color.Silver;
            this.tbX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbX.Location = new System.Drawing.Point(92, 48);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(47, 20);
            this.tbX.TabIndex = 28;
            this.tbX.Leave += new System.EventHandler(this.tbX_Leave);
            // 
            // cmbFullscreen
            // 
            this.cmbFullscreen.BackColor = System.Drawing.Color.Silver;
            this.cmbFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFullscreen.FormattingEnabled = true;
            this.cmbFullscreen.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
            this.cmbFullscreen.Location = new System.Drawing.Point(73, 20);
            this.cmbFullscreen.Name = "cmbFullscreen";
            this.cmbFullscreen.Size = new System.Drawing.Size(121, 21);
            this.cmbFullscreen.TabIndex = 31;
            this.cmbFullscreen.Text = "Disabled";
            this.cmbFullscreen.SelectedIndexChanged += new System.EventHandler(this.cmbFullscreen_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Y=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Fullscreen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "X=";
            // 
            // MtbROMFileLocation
            // 
            this.MtbROMFileLocation.BackColor = System.Drawing.Color.Silver;
            this.MtbROMFileLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MtbROMFileLocation.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbROMFileLocation.Location = new System.Drawing.Point(131, 74);
            this.MtbROMFileLocation.MaxLength = 255;
            this.MtbROMFileLocation.Name = "MtbROMFileLocation";
            this.MtbROMFileLocation.Size = new System.Drawing.Size(444, 22);
            this.MtbROMFileLocation.TabIndex = 23;
            this.MtbROMFileLocation.DoubleClick += new System.EventHandler(this.MtbROMFileLocation_DoubleClick);
            // 
            // MtbFrameFileLocation
            // 
            this.MtbFrameFileLocation.BackColor = System.Drawing.Color.Silver;
            this.MtbFrameFileLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MtbFrameFileLocation.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbFrameFileLocation.Location = new System.Drawing.Point(131, 47);
            this.MtbFrameFileLocation.MaxLength = 255;
            this.MtbFrameFileLocation.Name = "MtbFrameFileLocation";
            this.MtbFrameFileLocation.Size = new System.Drawing.Size(444, 22);
            this.MtbFrameFileLocation.TabIndex = 22;
            this.MtbFrameFileLocation.DoubleClick += new System.EventHandler(this.MtbFrameFileLocation_DoubleClick);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.materialLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel2.ForeColor = System.Drawing.Color.White;
            this.materialLabel2.Location = new System.Drawing.Point(65, 76);
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(53, 14);
            this.materialLabel2.TabIndex = 21;
            this.materialLabel2.Text = "ROM File";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.materialLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel1.ForeColor = System.Drawing.Color.White;
            this.materialLabel1.Location = new System.Drawing.Point(14, 47);
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(111, 14);
            this.materialLabel1.TabIndex = 20;
            this.materialLabel1.Text = "Frame File Location\r\n";
            // 
            // MbuClose
            // 
            this.MbuClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MbuClose.BackColor = System.Drawing.Color.Silver;
            this.MbuClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MbuClose.Location = new System.Drawing.Point(448, 448);
            this.MbuClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MbuClose.Name = "MbuClose";
            this.MbuClose.Size = new System.Drawing.Size(127, 32);
            this.MbuClose.TabIndex = 19;
            this.MbuClose.Text = "Close";
            this.MbuClose.UseVisualStyleBackColor = false;
            this.MbuClose.Click += new System.EventHandler(this.MbuClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbAttractSound);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbGameType);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbExtraShips);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbDifficulty);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbPlayTimer);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbCoinsPerCredit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(311, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 195);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // cmbCoinsPerCredit
            // 
            this.cmbCoinsPerCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCoinsPerCredit.FormattingEnabled = true;
            this.cmbCoinsPerCredit.Items.AddRange(new object[] {
            "1 Coin/1 Credit",
            "1 Coin/2 Credits",
            "1 Coin/3 Credits",
            "1 Coin/4 Credits",
            "1 Coin/5 Credits",
            "1 Coin/6 Credits",
            "2 Coins/1 Credit",
            "3 Coins/1 Credit",
            "4 Coins/1 Credit",
            "2 Coins/3 Credits"});
            this.cmbCoinsPerCredit.Location = new System.Drawing.Point(106, 17);
            this.cmbCoinsPerCredit.Name = "cmbCoinsPerCredit";
            this.cmbCoinsPerCredit.Size = new System.Drawing.Size(152, 21);
            this.cmbCoinsPerCredit.TabIndex = 1;
            this.cmbCoinsPerCredit.SelectedIndexChanged += new System.EventHandler(this.cmbCoinsPerCredit_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Coins Per Credit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Extra Command Line Arguments";
            // 
            // MtbExtra
            // 
            this.MtbExtra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MtbExtra.Location = new System.Drawing.Point(177, 419);
            this.MtbExtra.Name = "MtbExtra";
            this.MtbExtra.Size = new System.Drawing.Size(398, 20);
            this.MtbExtra.TabIndex = 35;
            this.MtbExtra.Leave += new System.EventHandler(this.MtbExtra_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Play Timer (Secs)";
            // 
            // cmbPlayTimer
            // 
            this.cmbPlayTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPlayTimer.FormattingEnabled = true;
            this.cmbPlayTimer.Items.AddRange(new object[] {
            "60",
            "50",
            "40",
            "Infinite"});
            this.cmbPlayTimer.Location = new System.Drawing.Point(106, 45);
            this.cmbPlayTimer.Name = "cmbPlayTimer";
            this.cmbPlayTimer.Size = new System.Drawing.Size(152, 21);
            this.cmbPlayTimer.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Difficulty";
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Items.AddRange(new object[] {
            "Normal",
            "Hard"});
            this.cmbDifficulty.Location = new System.Drawing.Point(106, 73);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(152, 21);
            this.cmbDifficulty.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Extra Ships";
            // 
            // cmbExtraShips
            // 
            this.cmbExtraShips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbExtraShips.FormattingEnabled = true;
            this.cmbExtraShips.Items.AddRange(new object[] {
            "5k,10k,20k",
            "5k,20k,40k",
            "10k,20k,30k",
            "10k,20k,40k"});
            this.cmbExtraShips.Location = new System.Drawing.Point(106, 102);
            this.cmbExtraShips.Name = "cmbExtraShips";
            this.cmbExtraShips.Size = new System.Drawing.Size(152, 21);
            this.cmbExtraShips.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Game Type";
            // 
            // cmbGameType
            // 
            this.cmbGameType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGameType.FormattingEnabled = true;
            this.cmbGameType.Items.AddRange(new object[] {
            "Continue",
            "Select"});
            this.cmbGameType.Location = new System.Drawing.Point(106, 130);
            this.cmbGameType.Name = "cmbGameType";
            this.cmbGameType.Size = new System.Drawing.Size(152, 21);
            this.cmbGameType.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Attract Sound";
            // 
            // cmbAttractSound
            // 
            this.cmbAttractSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAttractSound.FormattingEnabled = true;
            this.cmbAttractSound.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.cmbAttractSound.Location = new System.Drawing.Point(106, 161);
            this.cmbAttractSound.Name = "cmbAttractSound";
            this.cmbAttractSound.Size = new System.Drawing.Size(152, 21);
            this.cmbAttractSound.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbFullscreen);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbY);
            this.groupBox2.Controls.Add(this.tbX);
            this.groupBox2.Location = new System.Drawing.Point(17, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 106);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Video Options";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbSoundBuffers);
            this.groupBox3.Controls.Add(this.cmbSound);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(17, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 90);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Audio Options";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Sound";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Sound Buffer";
            // 
            // cmbSound
            // 
            this.cmbSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSound.FormattingEnabled = true;
            this.cmbSound.Items.AddRange(new object[] {
            "Emulated Sounds",
            "Sampled Sounds",
            "Disabled"});
            this.cmbSound.Location = new System.Drawing.Point(86, 23);
            this.cmbSound.Name = "cmbSound";
            this.cmbSound.Size = new System.Drawing.Size(182, 21);
            this.cmbSound.TabIndex = 2;
            this.cmbSound.SelectedIndexChanged += new System.EventHandler(this.cmbSound_SelectedIndexChanged);
            // 
            // cmbSoundBuffers
            // 
            this.cmbSoundBuffers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSoundBuffers.FormattingEnabled = true;
            this.cmbSoundBuffers.Items.AddRange(new object[] {
            "512",
            "1024",
            "2048",
            "4096"});
            this.cmbSoundBuffers.Location = new System.Drawing.Point(86, 52);
            this.cmbSoundBuffers.Name = "cmbSoundBuffers";
            this.cmbSoundBuffers.Size = new System.Drawing.Size(182, 21);
            this.cmbSoundBuffers.TabIndex = 3;
            this.cmbSoundBuffers.SelectedIndexChanged += new System.EventHandler(this.cmbSoundBuffers_SelectedIndexChanged);
            // 
            // frAstronConfigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 527);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.MtbExtra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MtbROMFileLocation);
            this.Controls.Add(this.MtbFrameFileLocation);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.MbuClose);
            this.Name = "frAstronConfigure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frAstronConfigure";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frAstronConfigure_FormClosing);
            this.Load += new System.EventHandler(this.frAstronConfigure_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.ComboBox cmbFullscreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MtbROMFileLocation;
        private System.Windows.Forms.TextBox MtbFrameFileLocation;
        private System.Windows.Forms.Label materialLabel2;
        private System.Windows.Forms.Label materialLabel1;
        private System.Windows.Forms.Button MbuClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCoinsPerCredit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MtbExtra;
        private System.Windows.Forms.ComboBox cmbPlayTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDifficulty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbExtraShips;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbGameType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbAttractSound;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbSoundBuffers;
        private System.Windows.Forms.ComboBox cmbSound;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}