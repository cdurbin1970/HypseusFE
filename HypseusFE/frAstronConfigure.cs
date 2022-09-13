using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ThemeLoader;
using XCoolForm;


namespace HypseusFE
{
    public partial class frAstronConfigure : XCoolForm.XCoolForm
    {
        public frAstronConfigure()
        {
            InitializeComponent();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            foreach (XTitleBarButton xbtn in m_xTitleBar.TitleBarButtons)
            {
                if (PointInRect(
                e.Location,
                new Rectangle(
                xbtn.XButtonLeft,
                xbtn.XButtonTop,
                xbtn.XButtonWidth,
                xbtn.XButtonHeight
                )))
                {
                    if (xbtn.XButtonType == XTitleBarButton.XTitleBarButtonType.Close)
                    {
                        Close();
                        return;
                    }
                }
            }

            // It wasn't the close button that was clicked, so run the base handler.
            base.OnMouseDown(e);
        }
        private void MbuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frAstronConfigure_Load(object sender, EventArgs e)
        {
            XmlThemeLoader xtl = new XmlThemeLoader();
            xtl.ThemeForm = this;
            try
            {
                xtl.ApplyTheme(@"resources\themes\" + clProfile.GetProfileValue("HypseusFE Options", "Theme").ToString());
                clApplyTheme.ApplyTheme(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            this.TitleBar.TitleBarCaption = "Configure - Astron Belt";

            try
            {
                MtbFrameFileLocation.Text = clProfile.GetProfileValue("Astron Belt", "Frame File");
                MtbROMFileLocation.Text = clProfile.GetProfileValue("Astron Belt", "ROM File");
                cmbFullscreen.SelectedItem = clProfile.GetProfileValue("Astron Belt", "Full Screen");
              
                tbX.Text = clProfile.GetProfileValue("Astron Belt", "Screen X");
                tbY.Text = clProfile.GetProfileValue("Astron Belt", "Screen Y");

                cmbSound.Text = clProfile.GetProfileValue("Astron Belt", "Sound");
                cmbSoundBuffers.Text = clProfile.GetProfileValue("Astron Belt", "Sound Samples");

                MtbExtra.Text = clProfile.GetProfileValue("Astron Belt", "Extra");

                switch (clProfile.GetProfileValue("Astron Belt", "Bank 0"))
                {
                    case "00000000":
                        cmbCoinsPerCredit.SelectedText = "1 Coin/1 Credit";
                        break;
                    case "00010001":
                        cmbCoinsPerCredit.SelectedText = "1 Coin/2 Credits";
                        break;
                    case "00100010":
                        cmbCoinsPerCredit.SelectedText = "1 Coin/3 Credits";
                        break;
                    case "00110011":
                        cmbCoinsPerCredit.SelectedText = "1 Coin/4 Credits";
                        break;
                    case "01000100":
                        cmbCoinsPerCredit.SelectedText = "1 Coin/5 Credits";
                        break;
                    case "01010101":
                        cmbCoinsPerCredit.SelectedText = "1 Coin/6 Credits";
                        break;
                    case "01100110":
                        cmbCoinsPerCredit.SelectedText = "2 Coins/1 Credit";
                        break;
                    case "01110111":
                        cmbCoinsPerCredit.SelectedText = "3 Coins/1 Credit";
                        break;
                    case "10001000":
                        cmbCoinsPerCredit.SelectedText = "4 Coins/1 Credit";
                        break;
                    case "10011001":
                        cmbCoinsPerCredit.SelectedText = "2 Coins/3 Credits";
                        break;
                }
            }
            catch (Exception)
            {
                
            }    
            
            try
            {
                string bank1 = clProfile.GetProfileValue("Astron Belt", "Bank 1");

                if(bank1.Length != 8)
                {
                    MessageBox.Show("Bank 1 setting is not the correct length. It should be 8 characters.");
                    return;
                }

                //Set the player timer
                if (!clBitCheck.CheckBit(5, bank1) && !clBitCheck.CheckBit(6, bank1))
                {
                    cmbPlayTimer.SelectedText = "60";
                }
                else if (!clBitCheck.CheckBit(5, bank1) && clBitCheck.CheckBit(6, bank1))
                {
                    cmbPlayTimer.SelectedText = "50";
                }
                else if (clBitCheck.CheckBit(5, bank1) && !clBitCheck.CheckBit(6,bank1))
                {
                    cmbPlayTimer.SelectedText = "40";
                }
                else if (clBitCheck.CheckBit(5, bank1) && clBitCheck.CheckBit(6, bank1))
                {
                    cmbPlayTimer.SelectedText = "Infinite";
                }
                else
                {
                    cmbPlayTimer.SelectedText = "60";
                }
                //Set the difficulty
                if (clBitCheck.CheckBit(4, bank1))
                {
                    cmbDifficulty.SelectedText = "Hard";
                }
                else
                {
                    cmbDifficulty.SelectedText = "Normal";
                }
                //Set Extra Ships
                if (!clBitCheck.CheckBit(2, bank1) && !clBitCheck.CheckBit(3, bank1))
                {
                    cmbExtraShips.SelectedText = "5k,10k,20k";
                }
                else if (!clBitCheck.CheckBit(2, bank1) && clBitCheck.CheckBit(3, bank1))
                {
                    cmbExtraShips.SelectedText = "5k,20k,40k";
                }
                else if (clBitCheck.CheckBit(2, bank1) && !clBitCheck.CheckBit(3, bank1))
                {
                    cmbExtraShips.SelectedText = "10k,20k,30k";
                }
                else if (clBitCheck.CheckBit(2, bank1) && clBitCheck.CheckBit(3, bank1))
                {
                    cmbExtraShips.SelectedText = "10k,20k,40k";
                }
                else
                {
                    cmbExtraShips.SelectedText = "5k,10k,20k";
                }
                //Set game type
                if (clBitCheck.CheckBit(1, bank1))
                {
                   cmbGameType.SelectedText = "Select";
                }
                else
                {
                    cmbGameType.SelectedText = "Continue";
                }
                //Set Attract Mode sound
                if (clBitCheck.CheckBit(7, bank1))
                {
                    cmbAttractSound.SelectedText = "Off";
                }
                else
                {
                    cmbAttractSound.SelectedText = "On";
                }
            }
            catch (Exception)
            {

            }
        }      

        private void cmbCoinsPerCredit_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbCoinsPerCredit.Text)
            {
                case "1 Coin/1 Credit":
                    clProfile.SetProfileValue("Astron Belt", "Bank 0", "00000000");
                    break;
                case "1 Coin/2 Credits":
                    clProfile.SetProfileValue("Astron Belt", "Bank 0", "00010001");
                    break;
                case "1 Coin/3 Credits":
                    clProfile.SetProfileValue("Astron Belt", "Bank 0", "00100010");
                    break;
                case "1 Coin/4 Credits":
                    clProfile.SetProfileValue("Astron Belt", "Bank 0", "00110011");
                    break;
                case "1 Coin/5 Credits":
                    clProfile.SetProfileValue("Astron Belt", "Bank 0", "01000100");
                    break;
                case "1 Coin/6 Credits":
                    clProfile.SetProfileValue("Astron Belt", "Bank 0", "01010101");
                    break;
                case "2 Coins/1 Credit":
                    clProfile.SetProfileValue("Astron Belt", "Bank 0", "01100110");
                    break;
                case "3 Coins/1 Credit":
                    clProfile.SetProfileValue("Astron Belt", "Bank 0", "01110111");
                    break;
                case "4 Coins/1 Credit":
                    clProfile.SetProfileValue("Astron Belt", "Bank 0", "10001000");
                    break;
                case "2 Coins/3 Credits":
                    clProfile.SetProfileValue("Astron Belt", "Bank 0", "10011001");
                    break;
            }
        }

        private void MtbExtra_Leave(object sender, EventArgs e)
        {
            clProfile.SetProfileValue("Astron Belt", "Extra", MtbExtra.Text);         
        }

        private void MtbFrameFileLocation_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog()
            {
                Filter = "Frame File (*.txt)|*.txt"
            };
            if (file.ShowDialog() == DialogResult.OK)
            {
                MtbFrameFileLocation.Text = file.FileName;
                clProfile.SetProfileValue("Astron Belt", "Frame File", MtbFrameFileLocation.Text);
            }
        }

        private void MtbROMFileLocation_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog()
            {
                Filter = "ROM File (*.zip)|*.zip"
            };
            if (file.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo dir = new DirectoryInfo(file.FileName);
                MtbROMFileLocation.Text = Path.GetFileNameWithoutExtension(dir.Name);
                clProfile.SetProfileValue("Astron Belt", "ROM File", MtbROMFileLocation.Text);
            }
        }

        private void frAstronConfigure_FormClosing(object sender, FormClosingEventArgs e)
        {
            int bits = 0;
            //Set Bank 1 in the xml file
            /*
                Play Timer 60					00000000		00000000 - 0
                Play Timer 50					00000000		00000010 - 2            
                Play Timer 40					00000000		00000100 - 4
                Play Timer Infinite				00000000		00000110 - 6            

                Difficulty Normal				00000000		00000000 - 0
                Difficulty Hard					00000000		00001000 - 8

                Reserve Ship Score 5k,10k,20k	00000000		00000000 - 0
                Reserve Ship Score 5k,20k,40k	00000000		00010000 - 16
                Reserve Ship Score 10k,20k,30k	00000000		00100000 - 32
                Reserve Ship Score 10k,20k,40k	00000000		00110000 - 48

                Game Type Continue				00000000		00000000 - 0
                Game Type Select				00000000		01000000 - 64

                Sound in Attract On				00000000		00000000 - 0
                Sound in Attract Off			00000000		00000001 - 1
             */
            switch (cmbPlayTimer.Text)
            {
                case "50":
                    bits += 2;
                    break;
                case "40":
                    bits += 4;
                    break;
                case "Infinite":
                    bits += 6;
                    break;
            }
            switch (cmbExtraShips.Text)
            {
                case "5k,20k,40k":
                    bits += 16;
                    break;
                case "10k,20k,30k":
                    bits += 32;
                    break;
                case "10k,20k,40k":
                    bits += 48;
                    break;
            }
            if(cmbAttractSound.Text == "Off")
            {
                bits += 1;
            }
            if(cmbGameType.Text == "Select")
            {
                bits += 64;
            }
            if (cmbDifficulty.Text == "Hard")
            {
                bits += 8;
            }
            clProfile.SetProfileValue("Astron Belt","Bank 1",Convert.ToString(bits, 2).PadLeft(8,'0'));
        }

        private void cmbFullscreen_SelectedIndexChanged(object sender, EventArgs e)
        {
            clProfile.SetProfileValue("Astron Belt", "Full Screen", cmbFullscreen.Text);
        }

        private void tbX_Leave(object sender, EventArgs e)
        {
            clProfile.SetProfileValue("Astron Belt", "Screen X", tbX.Text);
        }

        private void tbY_Leave(object sender, EventArgs e)
        {
            clProfile.SetProfileValue("Astron Belt", "Screen Y", tbY.Text);
        }

        private void cmbSound_SelectedIndexChanged(object sender, EventArgs e)
        {
            clProfile.SetProfileValue("Astron Belt", "Sound", cmbSound.Text);
        }

        private void cmbSoundBuffers_SelectedIndexChanged(object sender, EventArgs e)
        {
            clProfile.SetProfileValue("Astron Belt", "Sound Samples", cmbSoundBuffers.Text);
        }
    }
}
