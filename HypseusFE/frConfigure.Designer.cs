namespace HypseusFE
{
    partial class FrConfigure
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
            this.MbuClose = new System.Windows.Forms.Button();
            this.materialLabel1 = new System.Windows.Forms.Label();
            this.materialLabel2 = new System.Windows.Forms.Label();
            this.MtbFrameFileLocation = new System.Windows.Forms.TextBox();
            this.MtbROMFileLocation = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFastboot = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFullscreen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCheats = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // MbuClose
            // 
            this.MbuClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MbuClose.BackColor = System.Drawing.Color.Silver;
            this.MbuClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MbuClose.Location = new System.Drawing.Point(493, 476);
            this.MbuClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MbuClose.Name = "MbuClose";
            this.MbuClose.Size = new System.Drawing.Size(127, 32);
            this.MbuClose.TabIndex = 5;
            this.MbuClose.Text = "Close";
            this.MbuClose.UseVisualStyleBackColor = false;
            this.MbuClose.Click += new System.EventHandler(this.MbuClose_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.materialLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel1.ForeColor = System.Drawing.Color.White;
            this.materialLabel1.Location = new System.Drawing.Point(7, 45);
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(111, 14);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Frame File Location\r\n";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.materialLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel2.ForeColor = System.Drawing.Color.White;
            this.materialLabel2.Location = new System.Drawing.Point(58, 74);
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(53, 14);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "ROM File";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MtbFrameFileLocation
            // 
            this.MtbFrameFileLocation.BackColor = System.Drawing.Color.Silver;
            this.MtbFrameFileLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MtbFrameFileLocation.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbFrameFileLocation.Location = new System.Drawing.Point(124, 45);
            this.MtbFrameFileLocation.MaxLength = 255;
            this.MtbFrameFileLocation.Name = "MtbFrameFileLocation";
            this.MtbFrameFileLocation.Size = new System.Drawing.Size(496, 22);
            this.MtbFrameFileLocation.TabIndex = 8;
            this.MtbFrameFileLocation.DoubleClick += new System.EventHandler(this.MtbFrameFileLocation_DoubleClick);
            // 
            // MtbROMFileLocation
            // 
            this.MtbROMFileLocation.BackColor = System.Drawing.Color.Silver;
            this.MtbROMFileLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MtbROMFileLocation.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbROMFileLocation.Location = new System.Drawing.Point(124, 72);
            this.MtbROMFileLocation.MaxLength = 255;
            this.MtbROMFileLocation.Name = "MtbROMFileLocation";
            this.MtbROMFileLocation.Size = new System.Drawing.Size(496, 22);
            this.MtbROMFileLocation.TabIndex = 9;
            this.MtbROMFileLocation.DoubleClick += new System.EventHandler(this.MtbROMFileLocation_DoubleClick);
            // 
            // tbY
            // 
            this.tbY.BackColor = System.Drawing.Color.Silver;
            this.tbY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbY.Location = new System.Drawing.Point(227, 166);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(47, 22);
            this.tbY.TabIndex = 16;
            this.tbY.Leave += new System.EventHandler(this.tbY_Leave);
            // 
            // tbX
            // 
            this.tbX.BackColor = System.Drawing.Color.Silver;
            this.tbX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbX.Location = new System.Drawing.Point(143, 166);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(47, 22);
            this.tbX.TabIndex = 15;
            this.tbX.Leave += new System.EventHandler(this.tbX_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 14);
            this.label2.TabIndex = 14;
            this.label2.Text = "Y=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "X=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fastboot";
            // 
            // cmbFastboot
            // 
            this.cmbFastboot.BackColor = System.Drawing.Color.Silver;
            this.cmbFastboot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFastboot.FormattingEnabled = true;
            this.cmbFastboot.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
            this.cmbFastboot.Location = new System.Drawing.Point(124, 107);
            this.cmbFastboot.Name = "cmbFastboot";
            this.cmbFastboot.Size = new System.Drawing.Size(121, 22);
            this.cmbFastboot.TabIndex = 14;
            this.cmbFastboot.Text = "Disabled";
            this.cmbFastboot.SelectedIndexChanged += new System.EventHandler(this.cmbFastboot_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fullscreen";
            // 
            // cmbFullscreen
            // 
            this.cmbFullscreen.BackColor = System.Drawing.Color.Silver;
            this.cmbFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFullscreen.FormattingEnabled = true;
            this.cmbFullscreen.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
            this.cmbFullscreen.Location = new System.Drawing.Point(124, 138);
            this.cmbFullscreen.Name = "cmbFullscreen";
            this.cmbFullscreen.Size = new System.Drawing.Size(121, 22);
            this.cmbFullscreen.TabIndex = 16;
            this.cmbFullscreen.Text = "Disabled";
            this.cmbFullscreen.SelectedIndexChanged += new System.EventHandler(this.cmbFullscreen_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 14);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cheat";
            // 
            // cmbCheats
            // 
            this.cmbCheats.BackColor = System.Drawing.Color.Silver;
            this.cmbCheats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCheats.FormattingEnabled = true;
            this.cmbCheats.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
            this.cmbCheats.Location = new System.Drawing.Point(124, 194);
            this.cmbCheats.Name = "cmbCheats";
            this.cmbCheats.Size = new System.Drawing.Size(121, 22);
            this.cmbCheats.TabIndex = 18;
            this.cmbCheats.Text = "Disabled";
            this.cmbCheats.SelectedIndexChanged += new System.EventHandler(this.cmbCheats_SelectedIndexChanged);
            // 
            // FrConfigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 545);
            this.Controls.Add(this.cmbCheats);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.cmbFullscreen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFastboot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MtbROMFileLocation);
            this.Controls.Add(this.MtbFrameFileLocation);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.MbuClose);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrConfigure";
            this.Padding = new System.Windows.Forms.Padding(4, 69, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HypseusFE Configure";
            this.Load += new System.EventHandler(this.FrConfigure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button MbuClose;
        private System.Windows.Forms.Label materialLabel1;
        private System.Windows.Forms.Label materialLabel2;
        private System.Windows.Forms.TextBox MtbFrameFileLocation;
        private System.Windows.Forms.TextBox MtbROMFileLocation;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFastboot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFullscreen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCheats;
    }
}