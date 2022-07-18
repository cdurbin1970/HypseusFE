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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.MtbHypseusLocation = new MaterialSkin.Controls.MaterialTextBox();
            this.MbuClose = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 77);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(128, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Hypseus Location";
            // 
            // MtbHypseusLocation
            // 
            this.MtbHypseusLocation.AnimateReadOnly = false;
            this.MtbHypseusLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MtbHypseusLocation.Depth = 0;
            this.MtbHypseusLocation.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MtbHypseusLocation.LeadingIcon = null;
            this.MtbHypseusLocation.Location = new System.Drawing.Point(143, 75);
            this.MtbHypseusLocation.MaxLength = 255;
            this.MtbHypseusLocation.MouseState = MaterialSkin.MouseState.OUT;
            this.MtbHypseusLocation.Multiline = false;
            this.MtbHypseusLocation.Name = "MtbHypseusLocation";
            this.MtbHypseusLocation.Size = new System.Drawing.Size(428, 36);
            this.MtbHypseusLocation.TabIndex = 5;
            this.MtbHypseusLocation.Text = "";
            this.MtbHypseusLocation.TrailingIcon = null;
            this.MtbHypseusLocation.UseTallSize = false;
            this.MtbHypseusLocation.DoubleClick += new System.EventHandler(this.MtbHypseusLocation_DoubleClick);
            // 
            // MbuClose
            // 
            this.MbuClose.AutoSize = false;
            this.MbuClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MbuClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MbuClose.Depth = 0;
            this.MbuClose.HighEmphasis = true;
            this.MbuClose.Icon = null;
            this.MbuClose.Location = new System.Drawing.Point(444, 143);
            this.MbuClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MbuClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.MbuClose.Name = "MbuClose";
            this.MbuClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MbuClose.Size = new System.Drawing.Size(127, 32);
            this.MbuClose.TabIndex = 6;
            this.MbuClose.Text = "Close";
            this.MbuClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MbuClose.UseAccentColor = false;
            this.MbuClose.UseVisualStyleBackColor = true;
            this.MbuClose.Click += new System.EventHandler(this.MbuClose_Click);
            // 
            // FrOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 234);
            this.Controls.Add(this.MbuClose);
            this.Controls.Add(this.MtbHypseusLocation);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HypseusFE Options";
            this.Load += new System.EventHandler(this.FrOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox MtbHypseusLocation;
        private MaterialSkin.Controls.MaterialButton MbuClose;
    }
}