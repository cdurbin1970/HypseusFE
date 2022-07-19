namespace HypseusFE
{
    partial class FrMain
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
            this.PbMarquee = new System.Windows.Forms.PictureBox();
            this.MbuOptions = new MaterialSkin.Controls.MaterialButton();
            this.MlbGame = new MaterialSkin.Controls.MaterialListBox();
            this.MbuConfigure = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.PbMarquee)).BeginInit();
            this.SuspendLayout();
            // 
            // PbMarquee
            // 
            this.PbMarquee.BackColor = System.Drawing.SystemColors.Window;
            this.PbMarquee.Location = new System.Drawing.Point(6, 70);
            this.PbMarquee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PbMarquee.Name = "PbMarquee";
            this.PbMarquee.Size = new System.Drawing.Size(548, 206);
            this.PbMarquee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbMarquee.TabIndex = 1;
            this.PbMarquee.TabStop = false;
            // 
            // MbuOptions
            // 
            this.MbuOptions.AutoSize = false;
            this.MbuOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MbuOptions.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MbuOptions.Depth = 0;
            this.MbuOptions.HighEmphasis = true;
            this.MbuOptions.Icon = null;
            this.MbuOptions.Location = new System.Drawing.Point(273, 286);
            this.MbuOptions.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MbuOptions.MouseState = MaterialSkin.MouseState.HOVER;
            this.MbuOptions.Name = "MbuOptions";
            this.MbuOptions.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MbuOptions.Size = new System.Drawing.Size(136, 32);
            this.MbuOptions.TabIndex = 4;
            this.MbuOptions.Text = "Options";
            this.MbuOptions.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MbuOptions.UseAccentColor = false;
            this.MbuOptions.UseVisualStyleBackColor = true;
            this.MbuOptions.Click += new System.EventHandler(this.MbuOptions_Click);
            // 
            // MlbGame
            // 
            this.MlbGame.BackColor = System.Drawing.Color.White;
            this.MlbGame.BorderColor = System.Drawing.Color.LightGray;
            this.MlbGame.Depth = 0;
            this.MlbGame.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MlbGame.Location = new System.Drawing.Point(560, 70);
            this.MlbGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MlbGame.MouseState = MaterialSkin.MouseState.HOVER;
            this.MlbGame.Name = "MlbGame";
            this.MlbGame.SelectedIndex = -1;
            this.MlbGame.SelectedItem = null;
            this.MlbGame.Size = new System.Drawing.Size(197, 248);
            this.MlbGame.TabIndex = 5;
            this.MlbGame.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.MlbGame_SelectedIndexChanged);
            this.MlbGame.DoubleClick += new System.EventHandler(this.MlbGame_DoubleClick);
            // 
            // MbuConfigure
            // 
            this.MbuConfigure.AutoSize = false;
            this.MbuConfigure.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MbuConfigure.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MbuConfigure.Depth = 0;
            this.MbuConfigure.HighEmphasis = true;
            this.MbuConfigure.Icon = null;
            this.MbuConfigure.Location = new System.Drawing.Point(417, 286);
            this.MbuConfigure.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MbuConfigure.MouseState = MaterialSkin.MouseState.HOVER;
            this.MbuConfigure.Name = "MbuConfigure";
            this.MbuConfigure.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MbuConfigure.Size = new System.Drawing.Size(136, 32);
            this.MbuConfigure.TabIndex = 6;
            this.MbuConfigure.Text = "Configure";
            this.MbuConfigure.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MbuConfigure.UseAccentColor = false;
            this.MbuConfigure.UseVisualStyleBackColor = true;
            this.MbuConfigure.Click += new System.EventHandler(this.MbuConfigure_Click);
            // 
            // FrMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(767, 326);
            this.Controls.Add(this.MbuConfigure);
            this.Controls.Add(this.MlbGame);
            this.Controls.Add(this.MbuOptions);
            this.Controls.Add(this.PbMarquee);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrMain";
            this.Padding = new System.Windows.Forms.Padding(3, 56, 0, 0);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HypseusFE";
            this.Load += new System.EventHandler(this.FrMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbMarquee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PbMarquee;
        private MaterialSkin.Controls.MaterialButton MbuOptions;
        private MaterialSkin.Controls.MaterialListBox MlbGame;
        private MaterialSkin.Controls.MaterialButton MbuConfigure;
    }
}

