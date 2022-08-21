using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using AMS.Profile;
using LogEntry;
using ThemeLoader;

namespace HypseusFE
{
    public partial class FrMain : XCoolForm.XCoolForm
    {
        private string selectedGame = String.Empty;
        private string theme = String.Empty;
        private XmlThemeLoader xtl = new XmlThemeLoader();
        public FrMain()
        {
            InitializeComponent();
                       
        }
        private void FrMain_Load(object sender, EventArgs e)
        {
            this.TitleBar.TitleBarCaption = "HypseusFE v" + Application.ProductVersion;
            xtl.ThemeForm = this;
            
            axWindowsMediaPlayer1.uiMode = "none";

            Xml thelist = new Xml(@"resources\gamelist.xml");

            string[] gameslist = thelist.GetValue("gamelist", "games").ToString().Split(',');
            string[] shortnames = thelist.GetValue("gamelist", "shortname").ToString().Split(',');

            MlbGame.Items.Clear();
            
            for(int i = 0; i < gameslist.Length; i++)
            {                
                MlbGame.Items.Add(gameslist[i]);
            }

            if (!File.Exists(@"resources\HypseusFE.xml"))
            {
                clProfile.SetProfileValue("HypseusFE Options", "Debug", "false");
                clProfile.SetProfileValue("HypseusFE Options", "Hypseus Location","");
                clProfile.SetProfileValue("HypseusFE Options", "Theme", "DarkSystemTheme.xml");

                for (int i = 0; i < gameslist.Length; i++)
                {
                    clProfile.SetProfileValue(gameslist[i], "Short Name", shortnames[i]);
                    clProfile.SetProfileValue(gameslist[i], "Frame File Location", "");
                    clProfile.SetProfileValue(gameslist[i], "ROM File Location", "");

                }
                theme = "DarkSystemTheme.xml";
            }
            else
            {                
                theme = clProfile.GetProfileValue("HypseusFE Options", "Theme").ToString();
            }
            try
            {
                xtl.ApplyTheme(@"resources\themes\" + theme);
                clApplyTheme.ApplyTheme(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
       
        private void MlbGame_DoubleClick(object sender, EventArgs e)
        {
            if (MlbGame.SelectedItem == null || MlbGame.SelectedItem.ToString() == "")
            {
                return;
            }
            try
            {
                string fileName = clProfile.GetProfileValue("HypseusFE Options", "Hypseus Location");
                string arguments = @" " + clProfile.GetProfileValue(selectedGame, "Short Name") + " vldp -fullscreen -framefile \"" + clProfile.GetProfileValue(selectedGame, "Frame File Location") + "\"";
                string workingdir = fileName.Substring(0, fileName.LastIndexOf(@"\") + 1);
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                if (clProfile.GetProfileValue("HypseusFE Options", "Debug") == "true")
                {
                    ClLogEntry.WriteLogEntry(fileName + arguments);
                }                

                var proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = fileName,
                        Arguments = arguments,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true,
                        WorkingDirectory = workingdir
                    }
                };                
                proc.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void MbuOptions_Click(object sender, EventArgs e)
        {
            Form options = new FrOptions();
            options.ShowDialog();
            if(theme.ToString() != clProfile.GetProfileValue("HypseusFE Options","Theme").ToString())
            {
                theme = clProfile.GetProfileValue("HypseusFE Options", "Theme").ToString();
                xtl.ApplyTheme(@"resources\themes\" + theme);
                clApplyTheme.ApplyTheme(this);
            }
        }
        private void MbuConfigure_Click(object sender, EventArgs e)
        {
            if (MlbGame.SelectedItem != null)
            {
                Form configure = new FrConfigure(MlbGame.SelectedItem.ToString());
                configure.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select A Game Before Pressing Configure!");
            }
        }

        private void MlbGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MlbGame.SelectedItem == null || MlbGame.SelectedItem.ToString() == "" )
            {
                return;
            }
            selectedGame = MlbGame.SelectedItem.ToString();
            try
            {
                PbMarquee.Load(@"resources\wheel\" + clProfile.GetProfileValue(selectedGame, "Short Name") + ".png");
                axWindowsMediaPlayer1.URL = @"resources\snap\" + clProfile.GetProfileValue(selectedGame, "Short Name") + ".mp4";
            }
            catch (Exception)
            {

            }
        }       
    }
}
