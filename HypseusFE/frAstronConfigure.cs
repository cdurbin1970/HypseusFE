using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
