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
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Silver;
            this.materialLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel1.ForeColor = System.Drawing.Color.Black;
            this.materialLabel1.Location = new System.Drawing.Point(11, 51);
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(102, 14);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Hypseus Location";
            // 
            // MtbHypseusLocation
            // 
            this.MtbHypseusLocation.BackColor = System.Drawing.Color.Silver;
            this.MtbHypseusLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MtbHypseusLocation.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbHypseusLocation.Location = new System.Drawing.Point(119, 51);
            this.MtbHypseusLocation.MaxLength = 255;
            this.MtbHypseusLocation.Name = "MtbHypseusLocation";
            this.MtbHypseusLocation.Size = new System.Drawing.Size(428, 15);
            this.MtbHypseusLocation.TabIndex = 5;
            this.MtbHypseusLocation.DoubleClick += new System.EventHandler(this.MtbHypseusLocation_DoubleClick);
            // 
            // MbuClose
            // 
            this.MbuClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MbuClose.BackColor = System.Drawing.Color.Silver;
            this.MbuClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MbuClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MbuClose.ForeColor = System.Drawing.Color.Black;
            this.MbuClose.Location = new System.Drawing.Point(420, 195);
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
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(67, 76);
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
            this.CbTheme.Location = new System.Drawing.Point(120, 74);
            this.CbTheme.Name = "CbTheme";
            this.CbTheme.Size = new System.Drawing.Size(121, 21);
            this.CbTheme.TabIndex = 8;
            this.CbTheme.SelectedIndexChanged += new System.EventHandler(this.CbTheme_SelectedIndexChanged);
            // 
            // FrOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 262);
            this.Controls.Add(this.CbTheme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MbuClose);
            this.Controls.Add(this.MtbHypseusLocation);
            this.Controls.Add(this.materialLabel1);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "FrOptions";
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
    }
}