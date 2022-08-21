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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrMain));
            this.PbMarquee = new System.Windows.Forms.PictureBox();
            this.MbuOptions = new System.Windows.Forms.Button();
            this.MlbGame = new System.Windows.Forms.ListBox();
            this.MbuConfigure = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.PbMarquee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // PbMarquee
            // 
            this.PbMarquee.BackColor = System.Drawing.Color.Black;
            this.PbMarquee.Location = new System.Drawing.Point(8, 39);
            this.PbMarquee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PbMarquee.Name = "PbMarquee";
            this.PbMarquee.Size = new System.Drawing.Size(312, 158);
            this.PbMarquee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbMarquee.TabIndex = 1;
            this.PbMarquee.TabStop = false;
            // 
            // MbuOptions
            // 
            this.MbuOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MbuOptions.BackColor = System.Drawing.Color.Silver;
            this.MbuOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MbuOptions.ForeColor = System.Drawing.Color.Black;
            this.MbuOptions.Location = new System.Drawing.Point(248, 422);
            this.MbuOptions.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MbuOptions.Name = "MbuOptions";
            this.MbuOptions.Size = new System.Drawing.Size(136, 32);
            this.MbuOptions.TabIndex = 4;
            this.MbuOptions.Text = "Options";
            this.MbuOptions.UseVisualStyleBackColor = false;
            this.MbuOptions.Click += new System.EventHandler(this.MbuOptions_Click);
            // 
            // MlbGame
            // 
            this.MlbGame.BackColor = System.Drawing.Color.Black;
            this.MlbGame.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MlbGame.ForeColor = System.Drawing.Color.White;
            this.MlbGame.ItemHeight = 14;
            this.MlbGame.Location = new System.Drawing.Point(332, 39);
            this.MlbGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MlbGame.Name = "MlbGame";
            this.MlbGame.Size = new System.Drawing.Size(197, 368);
            this.MlbGame.TabIndex = 5;
            this.MlbGame.SelectedIndexChanged += new System.EventHandler(this.MlbGame_SelectedIndexChanged);
            this.MlbGame.DoubleClick += new System.EventHandler(this.MlbGame_DoubleClick);
            // 
            // MbuConfigure
            // 
            this.MbuConfigure.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MbuConfigure.BackColor = System.Drawing.Color.Silver;
            this.MbuConfigure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MbuConfigure.ForeColor = System.Drawing.Color.Black;
            this.MbuConfigure.Location = new System.Drawing.Point(392, 422);
            this.MbuConfigure.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MbuConfigure.Name = "MbuConfigure";
            this.MbuConfigure.Size = new System.Drawing.Size(136, 32);
            this.MbuConfigure.TabIndex = 6;
            this.MbuConfigure.Text = "Configure";
            this.MbuConfigure.UseVisualStyleBackColor = false;
            this.MbuConfigure.Click += new System.EventHandler(this.MbuConfigure_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(8, 203);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(311, 208);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            // 
            // FrMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(540, 489);
            this.ControlBox = false;
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.MbuConfigure);
            this.Controls.Add(this.MlbGame);
            this.Controls.Add(this.MbuOptions);
            this.Controls.Add(this.PbMarquee);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(540, 489);
            this.MinimumSize = new System.Drawing.Size(540, 489);
            this.Name = "FrMain";
            this.Padding = new System.Windows.Forms.Padding(3, 56, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HypseusFE";
            this.Load += new System.EventHandler(this.FrMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbMarquee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PbMarquee;
        private System.Windows.Forms.Button MbuOptions;
        private System.Windows.Forms.ListBox MlbGame;
        private System.Windows.Forms.Button MbuConfigure;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

