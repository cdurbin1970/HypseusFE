using System;
using System.Windows.Forms;
using ThemeLoader;
using XCoolForm;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Diagnostics;

namespace HypseusFE
{
    public partial class FrOptions : XCoolForm.XCoolForm
    {       
        public FrOptions()
        {
            InitializeComponent();
        }

        private void FrOptions_Load(object sender, EventArgs e)
        {
            XmlThemeLoader xtl = new XmlThemeLoader();
            this.TitleBar.TitleBarCaption = "HypseusFE Options";
            xtl.ThemeForm = this;
            MtbHypseusLocation.Text = clProfile.GetProfileValue("HypseusFE Options", "Hypseus Location").ToString();
            var theme = clProfile.GetProfileValue("HypseusFE Options", "Theme").ToString();

            try
            {
                xtl.ApplyTheme(@"resources\themes\" + theme);
                clApplyTheme.ApplyTheme(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            String[] files = Directory.GetFiles(@"resources\themes\", "*.xml").Select(fileName => Path.GetFileNameWithoutExtension(fileName)).ToArray();
            foreach (String file in files)
            { 
                CbTheme.Items.Add(file.ToString());
                if (file.ToString() == theme.Substring(0, theme.Length - 4))
                {
                    CbTheme.SelectedItem = file;
                }
                
            }
            cmbVideoPlayback.SelectedItem = clProfile.GetProfileValue("HypseusFE Options", "Video Playback");
            cmbMuteVideo.SelectedItem = clProfile.GetProfileValue("HypseusFE Options", "Mute Video");

            lblVersion.Text = ReturnHypseusVersion(MtbHypseusLocation.Text);            

        }
        
        private string ReturnHypseusVersion(string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    return "Invalid EXE";
                }
                // Get Hypseus version
                if (path != "")
                {
                    string workingdir = path.Substring(0, path.LastIndexOf(@"\") + 1);

                    var proc = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = path,
                            Arguments = "-v",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true,
                            WorkingDirectory = workingdir
                        }
                    };
                    proc.Start();
                    var line = proc.StandardOutput.ReadLine();
                    return line.Substring(line.IndexOf(':') + 1, line.Length - line.IndexOf(':') - 1);
                }
            }
            catch (Exception)
            {
                return "Unknown";
            }
            return "Unknown";
        }

        private void MbuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MtbHypseusLocation_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog()
            {
                Filter = "Hypseus Executable|hypseus.exe"
            };
            if (file.ShowDialog() == DialogResult.OK)
            {
                MtbHypseusLocation.Text = file.FileName;                
                clProfile.SetProfileValue("HypseusFE Options", "Hypseus Location", MtbHypseusLocation.Text);
            }
            lblVersion.Text = ReturnHypseusVersion(file.FileName);
        }      

        private void CbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlThemeLoader xtl = new XmlThemeLoader();
            xtl.ThemeForm = this;
            xtl.ApplyTheme(@"resources\themes\" + CbTheme.SelectedItem + ".xml");
            clProfile.SetProfileValue("HypseusFE Options", "Theme", CbTheme.SelectedItem + ".xml");
            clApplyTheme.ApplyTheme(this);
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

        private void cmbVideoPlayback_SelectedIndexChanged(object sender, EventArgs e)
        {
            clProfile.SetProfileValue("HypseusFE Options", "Video Playback", cmbVideoPlayback.Text);
        }

        private void cmbMuteVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            clProfile.SetProfileValue("HypseusFE Options", "Mute Video", cmbMuteVideo.Text);
        }
    }
}
