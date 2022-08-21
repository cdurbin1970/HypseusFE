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
            this.materialLabel2.Location = new System.Drawing.Point(15, 72);
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(103, 14);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "ROM File Location";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MtbFrameFileLocation
            // 
            this.MtbFrameFileLocation.BackColor = System.Drawing.Color.Silver;
            this.MtbFrameFileLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MtbFrameFileLocation.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbFrameFileLocation.Location = new System.Drawing.Point(124, 45);
            this.MtbFrameFileLocation.MaxLength = 255;
            this.MtbFrameFileLocation.Name = "MtbFrameFileLocation";
            this.MtbFrameFileLocation.Size = new System.Drawing.Size(496, 15);
            this.MtbFrameFileLocation.TabIndex = 8;
            this.MtbFrameFileLocation.DoubleClick += new System.EventHandler(this.MtbFrameFileLocation_DoubleClick);
            // 
            // MtbROMFileLocation
            // 
            this.MtbROMFileLocation.BackColor = System.Drawing.Color.Silver;
            this.MtbROMFileLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MtbROMFileLocation.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbROMFileLocation.Location = new System.Drawing.Point(124, 72);
            this.MtbROMFileLocation.MaxLength = 255;
            this.MtbROMFileLocation.Name = "MtbROMFileLocation";
            this.MtbROMFileLocation.Size = new System.Drawing.Size(496, 15);
            this.MtbROMFileLocation.TabIndex = 9;
            this.MtbROMFileLocation.DoubleClick += new System.EventHandler(this.MtbROMFileLocation_DoubleClick);
            // 
            // FrConfigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 545);
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
    }
}