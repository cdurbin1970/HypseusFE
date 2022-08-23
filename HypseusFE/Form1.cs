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
        //private string selectedGame = String.Empty;
        
        public FrMain()
        {
            InitializeComponent();
                       
        }
        private void FrMain_Load(object sender, EventArgs e)
        {
            this.TitleBar.TitleBarCaption = "HypseusFE v" + Application.ProductVersion;
            XmlThemeLoader xtl = new XmlThemeLoader();
            xtl.ThemeForm = this;
            
            axWindowsMediaPlayer1.uiMode = "none";

            Xml thelist = new Xml(@"resources\gamelist.xml");

            string[] gameslist = thelist.GetValue("gamelist", "games").ToString().Split(',');
            string[] shortnames = thelist.GetValue("gamelist", "shortname").ToString().Split(',');

            MlbGame.Items.Clear();

            foreach (string game in gameslist) {
                MlbGame.Items.Add(game);
            }

            if (!File.Exists(@"resources\HypseusFE.xml"))
            {
                clProfile.SetProfileValue("HypseusFE Options", "Debug", "False");
                clProfile.SetProfileValue("HypseusFE Options", "Hypseus Location","");
                clProfile.SetProfileValue("HypseusFE Options", "Theme", "DarkSystemTheme.xml");

                for (int i = 0; i < gameslist.Length; i++)
                {
                    clProfile.SetProfileValue(gameslist[i], "Short Name", shortnames[i]);
                    clProfile.SetProfileValue(gameslist[i], "Frame File Location", "");
                    clProfile.SetProfileValue(gameslist[i], "ROM File Location", "");
                    clProfile.SetProfileValue(gameslist[i], "Full Screen", "False");
                    clProfile.SetProfileValue(gameslist[i], "Screen X", "1024");
                    clProfile.SetProfileValue(gameslist[i], "Screen Y", "768");
                }               
            }
            
            try
            {
                xtl.ApplyTheme(@"resources\themes\" + clProfile.GetProfileValue("HypseusFE Options", "Theme").ToString());
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
                string argument = string.Empty;
                if (clProfile.GetProfileValue(MlbGame.SelectedItem.ToString(), "Full Screen") == "true") {
                    argument = " -fullscreen";
                }
                else if (clProfile.GetProfileValue(MlbGame.SelectedItem.ToString(), "Full Screen") == "false"){
                    argument = " -x " + clProfile.GetProfileValue(MlbGame.SelectedItem.ToString(), "Screen X") + " -y " + clProfile.GetProfileValue(MlbGame.SelectedItem.ToString(), "Screen Y");
                }








                string fileName = clProfile.GetProfileValue("HypseusFE Options", "Hypseus Location");
                string arguments = @" " + clProfile.GetProfileValue(MlbGame.SelectedItem.ToString(), "Short Name") + " vldp" + argument + " -framefile \"" + clProfile.GetProfileValue(MlbGame.SelectedItem.ToString(), "Frame File Location") + "\"";
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

            XmlThemeLoader xtl = new XmlThemeLoader
            {
                ThemeForm = this
            };
            xtl.ApplyTheme(@"resources\themes\" + clProfile.GetProfileValue("HypseusFE Options", "Theme").ToString());
            clApplyTheme.ApplyTheme(this);
            
        }
        private void MbuConfigure_Click(object sender, EventArgs e)
        {
            if (MlbGame.SelectedItem == null || MlbGame.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Please Select A Game Before Pressing Configure!");
                return;
            }
            Form configure = new FrConfigure(MlbGame.SelectedItem.ToString());
            configure.ShowDialog();
            
        }

        private void MlbGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MlbGame.SelectedItem == null || MlbGame.SelectedItem.ToString() == "" )
            {
                return;
            }
            //selectedGame = MlbGame.SelectedItem.ToString();
            try
            {
                PbMarquee.Load(@"resources\wheel\" + clProfile.GetProfileValue(MlbGame.SelectedItem.ToString(), "Short Name") + ".png");
                axWindowsMediaPlayer1.URL = @"resources\snap\" + clProfile.GetProfileValue(MlbGame.SelectedItem.ToString(), "Short Name") + ".mp4";
            }
            catch (Exception)
            {

            }
        }       
    }
}
