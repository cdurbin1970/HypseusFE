using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMS.Profile;
using MaterialSkin.Controls;
using MaterialSkin;
using LogEntry;

namespace HypseusFE
{
    public partial class FrMain : MaterialForm
    {
        private string selectedGame = String.Empty;
       
        public FrMain()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);            
        }
        private void FrMain_Load(object sender, EventArgs e)
        {
            Xml thelist = new Xml(@"resources\gamelist.xml");

            string[] gameslist = thelist.GetValue("gamelist", "games").ToString().Split(',');
            string[] shortnames = thelist.GetValue("gamelist", "shortname").ToString().Split(',');

            MlbGame.Items.Clear();
            
            for(int i = 0; i < gameslist.Length; i++)
            {                
                MlbGame.Items.Add(new MaterialListBoxItem(gameslist[i]));
            }

            if (!File.Exists(@"resources\HypseusFE.xml"))
            {
                Xml profile = new Xml(@"resources\HypseusFE.xml");
                profile.SetValue("HypseusFE Options", "Debug", "false");
                profile.SetValue("HypseusFE Options", "Hypseus Location","");                

                for (int i = 0; i < gameslist.Length; i++)
                {
                    //MlbGame.Items.Add(new MaterialListBoxItem(gameslist[i]));
                    profile.SetValue(gameslist[i], "Short Name", shortnames[i]);
                    profile.SetValue(gameslist[i], "Frame File Location", "");
                    profile.SetValue(gameslist[i], "ROM File Location", "");

                }               

            }
        }
        private void MlbGame_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {           
            selectedGame = MlbGame.SelectedItem.Text;
            try
            {
                PbMarquee.Load(@"resources\wheel\" + clProfile.GetProfileValue(selectedGame, "Short Name") + ".png");
            }
            catch (Exception)
            {

            }
        }
        private void MlbGame_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string fileName = clProfile.GetProfileValue("HypseusFE Options", "Hypseus Location");
                string arguments = @" " + clProfile.GetProfileValue(selectedGame, "Short Name") + " vldp -fullscreen -framefile \"" + clProfile.GetProfileValue(selectedGame, "Frame File Location") + "\"";
                string workingdir = fileName.Substring(0, fileName.LastIndexOf(@"\") + 1);

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
        }
        private void MbuConfigure_Click(object sender, EventArgs e)
        {
            if (MlbGame.SelectedItem != null)
            {
                Form configure = new FrConfigure(MlbGame.SelectedItem.Text);
                configure.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select A Game Before Pressing Configure!");
            }
        }
    }
}
