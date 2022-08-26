namespace HypseusFE
{
    partial class FrOptions
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
            this.materialLabel1 = new System.Windows.Forms.Label();
            this.MtbHypseusLocation = new System.Windows.Forms.TextBox();
            this.MbuClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CbTheme = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbVideoPlayback = new System.Windows.Forms.ComboBox();
            this.cmbMuteVideo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.BackColor = System.Drawing.Color.Silver;
            this.materialLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel1.ForeColor = System.Drawing.Color.Black;
            this.materialLabel1.Location = new System.Drawing.Point(10, 48);
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(102, 14);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Hypseus Location";
            // 
            // MtbHypseusLocation
            // 
            this.MtbHypseusLocation.BackColor = System.Drawing.Color.Silver;
            this.MtbHypseusLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MtbHypseusLocation.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbHypseusLocation.Location = new System.Drawing.Point(118, 46);
            this.MtbHypseusLocation.MaxLength = 255;
            this.MtbHypseusLocation.Name = "MtbHypseusLocation";
            this.MtbHypseusLocation.Size = new System.Drawing.Size(345, 22);
            this.MtbHypseusLocation.TabIndex = 5;
            this.MtbHypseusLocation.DoubleClick += new System.EventHandler(this.MtbHypseusLocation_DoubleClick);
            // 
            // MbuClose
            // 
            this.MbuClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MbuClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MbuClose.BackColor = System.Drawing.Color.Silver;
            this.MbuClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MbuClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MbuClose.ForeColor = System.Drawing.Color.Black;
            this.MbuClose.Location = new System.Drawing.Point(342, 323);
            this.MbuClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MbuClose.Name = "MbuClose";
            this.MbuClose.Size = new System.Drawing.Size(127, 32);
            this.MbuClose.TabIndex = 6;
            this.MbuClose.Text = "Close";
            this.MbuClose.UseVisualStyleBackColor = false;
            this.MbuClose.Click += new System.EventHandler(this.MbuClose_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(66, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Theme";
            // 
            // CbTheme
            // 
            this.CbTheme.BackColor = System.Drawing.Color.Silver;
            this.CbTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbTheme.FormattingEnabled = true;
            this.CbTheme.Location = new System.Drawing.Point(118, 168);
            this.CbTheme.Name = "CbTheme";
            this.CbTheme.Size = new System.Drawing.Size(156, 21);
            this.CbTheme.TabIndex = 8;
            this.CbTheme.SelectedIndexChanged += new System.EventHandler(this.CbTheme_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Video Playback";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mute Video";
            // 
            // cmbVideoPlayback
            // 
            this.cmbVideoPlayback.BackColor = System.Drawing.Color.Silver;
            this.cmbVideoPlayback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVideoPlayback.FormattingEnabled = true;
            this.cmbVideoPlayback.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
            this.cmbVideoPlayback.Location = new System.Drawing.Point(118, 96);
            this.cmbVideoPlayback.Name = "cmbVideoPlayback";
            this.cmbVideoPlayback.Size = new System.Drawing.Size(121, 21);
            this.cmbVideoPlayback.TabIndex = 11;
            this.cmbVideoPlayback.Text = "Enabled";
            this.cmbVideoPlayback.SelectedIndexChanged += new System.EventHandler(this.cmbVideoPlayback_SelectedIndexChanged);
            // 
            // cmbMuteVideo
            // 
            this.cmbMuteVideo.BackColor = System.Drawing.Color.Silver;
            this.cmbMuteVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMuteVideo.FormattingEnabled = true;
            this.cmbMuteVideo.Items.AddRange(new object[] {
            "Enabled",
            "Disabled"});
            this.cmbMuteVideo.Location = new System.Drawing.Point(118, 123);
            this.cmbMuteVideo.Name = "cmbMuteVideo";
            this.cmbMuteVideo.Size = new System.Drawing.Size(121, 21);
            this.cmbMuteVideo.TabIndex = 12;
            this.cmbMuteVideo.Text = "Disabled";
            this.cmbMuteVideo.SelectedIndexChanged += new System.EventHandler(this.cmbMuteVideo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Version: ";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(169, 71);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 13);
            this.lblVersion.TabIndex = 14;
            // 
            // FrOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 390);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMuteVideo);
            this.Controls.Add(this.cmbVideoPlayback);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbTheme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MbuClose);
            this.Controls.Add(this.MtbHypseusLocation);
            this.Controls.Add(this.materialLabel1);
            this.MaximumSize = new System.Drawing.Size(480, 390);
            this.MinimumSize = new System.Drawing.Size(480, 390);
            this.Name = "FrOptions";
            this.Padding = new System.Windows.Forms.Padding(3, 56, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HypseusFE Options";
            this.Load += new System.EventHandler(this.FrOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label materialLabel1;
        private System.Windows.Forms.TextBox MtbHypseusLocation;
        private System.Windows.Forms.Button MbuClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbTheme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbVideoPlayback;
        private System.Windows.Forms.ComboBox cmbMuteVideo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVersion;
    }
}