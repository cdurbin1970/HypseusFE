using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ThemeLoader;
using XCoolForm;

namespace HypseusFE
{
    public partial class FrConfigure : XCoolForm.XCoolForm
    {
        
        private string selectedGame = String.Empty;

        public FrConfigure()
        {
            InitializeComponent();
        }

        public FrConfigure(string selectedGame)
        {
            InitializeComponent();
            this.selectedGame = selectedGame;
        }

        private void FrConfigure_Load(object sender, EventArgs e)
        {

            this.TitleBar.TitleBarCaption = "HypseusFE Configure - " + selectedGame;
            XmlThemeLoader xtl = new XmlThemeLoader
            {
                ThemeForm = this
            };

            try
            {
                MtbFrameFileLocation.Text = clProfile.GetProfileValue(selectedGame, "Frame File");
                MtbROMFileLocation.Text = clProfile.GetProfileValue(selectedGame, "ROM File");
                cmbFullscreen.SelectedItem = clProfile.GetProfileValue(selectedGame, "Full Screen");
                /*if (cmbFullscreen.Text == "Enabled")
                {                    
                    tbX.Enabled = false;
                    tbY.Enabled = false;
                }
                else
                {                 
                    tbX.Enabled = true;
                    tbY.Enabled = true;
                }*/
                tbX.Text = clProfile.GetProfileValue(selectedGame, "Screen X");
                tbY.Text = clProfile.GetProfileValue(selectedGame, "Screen Y");

                cmbFastboot.SelectedItem = clProfile.GetProfileValue(selectedGame, "Fastboot");
                cmbCheats.SelectedItem = clProfile.GetProfileValue(selectedGame, "Cheat");
                                
            }
            catch (Exception)
            {

            }

            try
            {
                xtl.ApplyTheme(@"resources\themes\" + clProfile.GetProfileValue("HypseusFE Options", "Theme").ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            clApplyTheme.ApplyTheme(this);
        }

        private void MbuClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                clProfile.SetProfileValue(selectedGame, "Frame File", MtbFrameFileLocation.Text);
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
                clProfile.SetProfileValue(selectedGame, "ROM File", MtbROMFileLocation.Text);
            }
        }
        private void cmbFastboot_SelectedIndexChanged(object sender, EventArgs e)
        {
            clProfile.SetProfileValue(selectedGame, "Fastboot", cmbFastboot.Text);

        }

        private void cmbFullscreen_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if (cmbFullscreen.Text == "Disabled")
            {
                tbX.Enabled = true;
                tbY.Enabled = true;
            }
            else
            {
                tbX.Enabled = false;
                tbY.Enabled = false;
            }*/
            clProfile.SetProfileValue(selectedGame, "Full Screen", cmbFullscreen.Text);
        }       

        private void tbX_Leave(object sender, EventArgs e)
        {
            clProfile.SetProfileValue(selectedGame, "Screen X", tbX.Text);
        }

        private void tbY_Leave(object sender, EventArgs e)
        {
            clProfile.SetProfileValue(selectedGame, "Screen Y", tbY.Text);
        }

        private void cmbCheats_SelectedIndexChanged(object sender, EventArgs e)
        {
            clProfile.SetProfileValue(selectedGame, "Cheat", cmbCheats.Text);
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
    }
}