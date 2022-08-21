using System;
using System.Drawing;
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
                MtbFrameFileLocation.Text = clProfile.GetProfileValue(selectedGame, "Frame File Location");
                MtbROMFileLocation.Text = clProfile.GetProfileValue(selectedGame, "ROM File Location");
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
                clProfile.SetProfileValue(selectedGame, "Frame File Location", MtbFrameFileLocation.Text);
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
                MtbROMFileLocation.Text = file.FileName;
                clProfile.SetProfileValue(selectedGame, "ROM File Location", MtbROMFileLocation.Text);
            }
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