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
                clProfile.SetProfileValue("HypseusFE Options", "Hypseus Location","hypseus.exe");
                clProfile.SetProfileValue("HypseusFE Options", "Show Splash Screen", "Enabled");
                clProfile.SetProfileValue("HypseusFE Options", "Video Playback", "Enabled");
                clProfile.SetProfileValue("HypseusFE Options", "Mute Video", "Disabled");
                clProfile.SetProfileValue("HypseusFE Options", "Theme", "DarkSystemTheme.xml");

                for (int i = 0; i < gameslist.Length; i++)
                {
                    clProfile.SetProfileValue(gameslist[i], "Short Name", shortnames[i]);
                    clProfile.SetProfileValue(gameslist[i], "Frame File", "framefile.txt");
                    clProfile.SetProfileValue(gameslist[i], "ROM File", "game.rom");
                    clProfile.SetProfileValue(gameslist[i], "Full Screen", "Disabled");
                    clProfile.SetProfileValue(gameslist[i], "Screen X", "1024");
                    clProfile.SetProfileValue(gameslist[i], "Screen Y", "768");
                    clProfile.SetProfileValue(gameslist[i], "Bank 0", "00000000");
                    clProfile.SetProfileValue(gameslist[i], "Bank 1", "00000000");
                    clProfile.SetProfileValue(gameslist[i], "Bank 2", "00000000");
                    clProfile.SetProfileValue(gameslist[i], "Fastboot", "Disabled");
                    clProfile.SetProfileValue(gameslist[i], "Cheat", "Disabled");
                    clProfile.SetProfileValue(gameslist[i], "Extra", "");
                    clProfile.SetProfileValue(gameslist[i], "Sound", "Emulated Sounds");
                    clProfile.SetProfileValue(gameslist[i], "Sound Samples", "2048");

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
            if (clProfile.GetProfileValue("HypseusFE Options", "Show Splash Screen").ToString() == "Enabled") {
                try
                {
                    frSplash splash = new frSplash();
                    splash.ShowDialog();
                }
                catch (Exception)
                {

                }
            }

            if (Convert.ToBoolean(clProfile.GetProfileValue("HypseusFE Options", "Debug")))
            {
                this.StatusBar.BarItems.Add(new XCoolForm.XStatusBar.XBarItem(100, "DEBUG MODE"));
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
                if (clProfile.GetProfileValue(MlbGame.SelectedItem.ToString(), "Full Screen") == "Enabled") {
                    argument += " -fullscreen";
                }
                
                argument += " -x " + clProfile.GetProfileValue(MlbGame.SelectedItem.ToString(), "Screen X") + " -y " + clProfile.GetProfileValue(MlbGame.SelectedItem.ToString(), "Screen Y");
                
                //These two items only work for certain games
                if (clProfile.GetProfileValue(MlbGame.SelectedItem.ToString(), "Fastboot") == "Enabled")
                {
                    argument += " -fastboot";
                }
                if (clProfile.GetProfileValue(MlbGame.SelectedItem.ToString(), "Cheat") == "Enabled")
                {
                    argument += " -cheat";
                }

                //Set sound parameters
                argument += " -sound_buffer " + clProfile.GetProfileValue(MlbGame.SelectedItem.ToString(), "Sound Samples");
                if(clProfile.GetProfileValue(MlbGame.SelectedItem.ToString(), "Sound") == "Sampled Sounds")
                {
                    argument += " -prefer_samples";
                }
                else if(clProfile.GetProfileValue(MlbGame.SelectedItem.ToString(), "Sound") == "Disabled") {
                    argument += " -nosound";
                }

                if (clProfile.GetProfileValue(MlbGame.SelectedItem.ToString(), "Fastboot") == "Enabled")
                {
                    argument += " -fastboot";
                }

                //Set the DIP switches
                argument += " -bank 0 " + clProfile.GetProfileValue(MlbGame.SelectedItem.ToString(), "Bank 0");
                argument += " -bank 1 " + clProfile.GetProfileValue(MlbGame.SelectedItem.ToString(), "Bank 1");
                if (MlbGame.SelectedItem.ToString() == "Cliff Hanger")
                {
                    argument += " -bank 2 " + clProfile.GetProfileValue(MlbGame.SelectedItem.ToString(), "Bank 2");
                }                

                string fileName = clProfile.GetProfileValue("HypseusFE Options", "Hypseus Location");
                string arguments = @" " + clProfile.GetProfileValue(MlbGame.SelectedItem.ToString(), "ROM File") + " vldp" + argument + " -framefile \"" + clProfile.GetProfileValue(MlbGame.SelectedItem.ToString(), "Frame File") + "\"";
                string workingdir = fileName.Substring(0, fileName.LastIndexOf(@"\") + 1);
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                
                
                if (clProfile.GetProfileValue("HypseusFE Options", "Debug") == "True")
                {
                    frDebug debug = new frDebug(fileName + arguments);
                    debug.Show();   
                    ClLogEntry.WriteLogEntry(fileName + arguments);
                    return;
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
            //Form configure = new FrConfigure(MlbGame.SelectedItem.ToString());
            //Astron Belt,Bad Lands,Bega's Battle,Cliff Hanger,Cobra Command,Dragon's Lair,Dragon's Lair II,Esh's Aurunmilla,Galaxy Ranger,GP World,Interstellar,M.A.C.H. 3
            //Road Blaster,Space Ace,Star Blazer,Super Don Quix-ote,Thayer's Quest,Us vs Them
            Form configure;
            switch (MlbGame.SelectedItem.ToString())
            {                
                case "Astron Belt":
                    configure = new frAstronConfigure();
                    configure.ShowDialog();
                    break;
                case "Bad Lands":
                    configure = new frBadLandsConfigure();
                    configure.ShowDialog();
                    break;
                case "Bega's Battle":
                    configure = new frBegaConfigure();
                    configure.ShowDialog();
                    break;
                case "Cliff Hanger":
                    configure = new frCliffConfigure();
                    configure.ShowDialog();
                    break;
                case "Cobra Command":
                    configure = new frCobraConfigure();
                    configure.ShowDialog();
                    break;
                case "Dragon's Lair":
                    configure = new frDragonConfigure();
                    configure.ShowDialog();
                    break;
                case "Dragon's Lair II":
                    configure = new frDragon2Configure();
                    configure.ShowDialog();
                    break;
                case "Esh's Aurunmilla":
                    configure = new frEshConfigure();
                    configure.ShowDialog();
                    break;
                case "Galaxy Ranger":
                    configure = new frGalaxyConfigure();
                    configure.ShowDialog();
                    break;
                case "GP World":
                    configure = new frGPConfigure();
                    configure.ShowDialog();
                    break;
                case "Interstellar":
                    configure = new frInterstellarConfigure();
                    configure.ShowDialog();
                    break;
                case "M.A.C.H. 3":
                    configure = new frMachConfigure();
                    configure.ShowDialog();
                    break;
                case "Road Blaster":
                    configure = new frRoadBlasterConfigure();
                    configure.ShowDialog();
                    break;
                case "Space Ace":
                    configure = new frSpaceAceConfigure();
                    configure.ShowDialog();
                    break;
                case "Star Blazer":
                    configure = new frStarBlazerConfigure();
                    configure.ShowDialog();
                    break;
                case "Super Don Quix-ote":
                    configure = new frSuperDonConfigure();
                    configure.ShowDialog();
                    break;
                case "Thayer's Quest":
                    configure = new frThayerConfigure();
                    configure.ShowDialog();
                    break;
                case "Us vs Them":
                    configure = new frUVTConfigure();
                    configure.ShowDialog();
                    break;
            }           
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
                if (clProfile.GetProfileValue("HypseusFE Options", "Video Playback") == "Enabled")
                {
                    if (clProfile.GetProfileValue("HypseusFE Options", "Mute Video") == "Enabled")
                    {
                        axWindowsMediaPlayer1.settings.volume = 0;
                    }
                    else
                    {
                        axWindowsMediaPlayer1.settings.volume = 50;
                    }  
                    axWindowsMediaPlayer1.URL = @"resources\snap\" + clProfile.GetProfileValue(MlbGame.SelectedItem.ToString(), "Short Name") + ".mp4";
                }
            }
            catch (Exception)
            {

            }
        }       
    }
}
