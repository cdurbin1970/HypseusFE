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
            if (!File.Exists("HypseusFE.xml"))
            {
                Xml profile = new Xml("HypseusFE.xml");
                profile.SetValue("HypseusFE Options", "Hypseus Location","");
                profile.SetValue("Astron Belt", "Short Name", "astron");
                profile.SetValue("Astron Belt", "Frame File Location", "");
                profile.SetValue("Astron Belt", "ROM File Location", "");
                profile.SetValue("Bad Lands", "Short Name", "badlands");
                profile.SetValue("Bad Lands", "Frame File Location", "");
                profile.SetValue("Bad Lands", "ROM File Location", "");
                profile.SetValue("Bega's Battle", "Short Name", "bega");
                profile.SetValue("Bega's Battle", "Frame File Location", "");
                profile.SetValue("Bega's Battle", "ROM File Location", "");
                profile.SetValue("Cliff Hanger", "Short Name", "cliff");
                profile.SetValue("Cliff Hanger", "Frame File Location", "");
                profile.SetValue("Cliff Hanger", "ROM File Location", "");
                profile.SetValue("Cobra Command", "Short Name", "cobra");
                profile.SetValue("Cobra Command", "Frame File Location", "");
                profile.SetValue("Cobra Command", "ROM File Location", "");
                profile.SetValue("Dragon's Lair", "Short Name", "lair");
                profile.SetValue("Dragon's Lair", "Frame File Location", "");
                profile.SetValue("Dragon's Lair", "ROM File Location", "");
                profile.SetValue("Dragon's Lair II", "Short Name", "lair2");
                profile.SetValue("Dragon's Lair II", "Frame File Location", "");
                profile.SetValue("Dragon's Lair II", "ROM File Location", "");
                profile.SetValue("Esh's Aurunmilla", "Short Name", "esh");
                profile.SetValue("Esh's Aurunmilla", "Frame File Location", "");
                profile.SetValue("Esh's Aurunmilla", "ROM File Location", "");
                profile.SetValue("Galaxy Ranger", "Short Name", "galaxy");
                profile.SetValue("Galaxy Ranger", "Frame File Location", "");
                profile.SetValue("Galaxy Ranger", "ROM File Location", "");
                profile.SetValue("GP World", "Short Name", "gpworld");
                profile.SetValue("GP World", "Frame File Location", "");
                profile.SetValue("GP World", "ROM File Location", "");
                profile.SetValue("Interstellar", "Short Name", "interstellar");
                profile.SetValue("Interstellar", "Frame File Location", "");
                profile.SetValue("Interstellar", "ROM File Location", "");
                profile.SetValue("M.A.C.H. 3", "Short Name", "mach3");
                profile.SetValue("M.A.C.H. 3", "Frame File Location", "");
                profile.SetValue("M.A.C.H. 3", "ROM File Location", "");
                profile.SetValue("Road Blaster", "Short Name", "rb");
                profile.SetValue("Road Blaster", "Frame File Location", "");
                profile.SetValue("Road Blaster", "ROM File Location", "");
                profile.SetValue("Space Ace", "Short Name", "ace");
                profile.SetValue("Space Ace", "Frame File Location", "");
                profile.SetValue("Space Ace", "ROM File Location", "");
                profile.SetValue("Star Blazer", "Short Name", "");
                profile.SetValue("Star Blazer", "Frame File Location", "");
                profile.SetValue("Star Blazer", "ROM File Location", "");
                profile.SetValue("Super Don Quix-ote", "Short Name", "sdq");
                profile.SetValue("Super Don Quix-ote", "Frame File Location", "");
                profile.SetValue("Super Don Quix-ote", "ROM File Location", "");
                profile.SetValue("Thayer's Quest", "Short Name", "tq");
                profile.SetValue("Thayer's Quest", "Frame File Location", "");
                profile.SetValue("Thayer's Quest", "ROM File Location", "");
                profile.SetValue("Us vs Them", "Short Name", "uvt");
                profile.SetValue("Us vs Them", "Frame File Location", "");
                profile.SetValue("Us vs Them", "ROM File Location", "");              

            }
        }
        private void MlbGame_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            /*Astron Belt
                         Bad Lands
                         Bega's Battle
                         Cliff Hanger
                         Cobra Command
                         Dragon's Lair
                         Dragon's Lair II
                         Esh's Aurunmilla
                         Galaxy Ranger
                         GP World
                         Interstellar
                         M.A.C.H. 3
                         Road Blaster
                         Space Ace
                         Star Blazer
                         Super Don Quix-ote
                         Thayer's Quest
                         Us vs Them*/
            selectedGame = MlbGame.SelectedItem.Text;
            Xml profile = new Xml("HypseusFE.xml");
            try
            {
                PbMarquee.Load(@"wheel\" + profile.GetValue(selectedGame, "Short Name").ToString() + ".png");
            }
            catch (Exception)
            {

            }
        }
        private void MlbGame_DoubleClick(object sender, EventArgs e)
        {
            Xml profile = new Xml("HypseusFE.xml");
            string fileName = profile.GetValue("HypseusFE Options", "Hypseus Location").ToString();
            string arguments = @" " + profile.GetValue(selectedGame, "Short Name").ToString() + " vldp -fullscreen -framefile \"" + profile.GetValue(selectedGame, "Frame File Location").ToString() + "\"";
            string workingdir = fileName.Substring(0, fileName.LastIndexOf(@"\") + 1);

            FileStream file = File.OpenWrite("commandline.txt");
            Byte[] info = new UTF8Encoding(true).GetBytes(fileName + arguments);
            file.Write(info, 0, info.Length);
            file.Close();

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
