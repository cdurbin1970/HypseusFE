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
            this.MbuClose = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.MtbFrameFileLocation = new MaterialSkin.Controls.MaterialTextBox();
            this.MtbROMFileLocation = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // MbuClose
            // 
            this.MbuClose.AutoSize = false;
            this.MbuClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MbuClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MbuClose.Depth = 0;
            this.MbuClose.HighEmphasis = true;
            this.MbuClose.Icon = null;
            this.MbuClose.Location = new System.Drawing.Point(541, 164);
            this.MbuClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MbuClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.MbuClose.Name = "MbuClose";
            this.MbuClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MbuClose.Size = new System.Drawing.Size(127, 32);
            this.MbuClose.TabIndex = 5;
            this.MbuClose.Text = "Close";
            this.MbuClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MbuClose.UseAccentColor = false;
            this.MbuClose.UseVisualStyleBackColor = true;
            this.MbuClose.Click += new System.EventHandler(this.MbuClose_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(14, 78);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(152, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Frame File Location\r\n";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(14, 119);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(131, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "ROM File Location";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MtbFrameFileLocation
            // 
            this.MtbFrameFileLocation.AnimateReadOnly = false;
            this.MtbFrameFileLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MtbFrameFileLocation.Depth = 0;
            this.MtbFrameFileLocation.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MtbFrameFileLocation.LeadingIcon = null;
            this.MtbFrameFileLocation.Location = new System.Drawing.Point(172, 72);
            this.MtbFrameFileLocation.MaxLength = 255;
            this.MtbFrameFileLocation.MouseState = MaterialSkin.MouseState.OUT;
            this.MtbFrameFileLocation.Multiline = false;
            this.MtbFrameFileLocation.Name = "MtbFrameFileLocation";
            this.MtbFrameFileLocation.Size = new System.Drawing.Size(496, 36);
            this.MtbFrameFileLocation.TabIndex = 8;
            this.MtbFrameFileLocation.Text = "";
            this.MtbFrameFileLocation.TrailingIcon = null;
            this.MtbFrameFileLocation.UseTallSize = false;
            this.MtbFrameFileLocation.DoubleClick += new System.EventHandler(this.MtbFrameFileLocation_DoubleClick);
            // 
            // MtbROMFileLocation
            // 
            this.MtbROMFileLocation.AnimateReadOnly = false;
            this.MtbROMFileLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MtbROMFileLocation.Depth = 0;
            this.MtbROMFileLocation.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MtbROMFileLocation.LeadingIcon = null;
            this.MtbROMFileLocation.Location = new System.Drawing.Point(172, 119);
            this.MtbROMFileLocation.MaxLength = 255;
            this.MtbROMFileLocation.MouseState = MaterialSkin.MouseState.OUT;
            this.MtbROMFileLocation.Multiline = false;
            this.MtbROMFileLocation.Name = "MtbROMFileLocation";
            this.MtbROMFileLocation.Size = new System.Drawing.Size(496, 36);
            this.MtbROMFileLocation.TabIndex = 9;
            this.MtbROMFileLocation.Text = "";
            this.MtbROMFileLocation.TrailingIcon = null;
            this.MtbROMFileLocation.UseTallSize = false;
            this.MtbROMFileLocation.DoubleClick += new System.EventHandler(this.MtbROMFileLocation_DoubleClick);
            // 
            // FrConfigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 238);
            this.Controls.Add(this.MtbROMFileLocation);
            this.Controls.Add(this.MtbFrameFileLocation);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.MbuClose);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrConfigure";
            this.Padding = new System.Windows.Forms.Padding(4, 69, 4, 4);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HypseusFE Configure";
            this.Load += new System.EventHandler(this.FrConfigure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton MbuClose;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox MtbFrameFileLocation;
        private MaterialSkin.Controls.MaterialTextBox MtbROMFileLocation;
    }
}