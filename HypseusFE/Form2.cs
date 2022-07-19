using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMS.Profile;
using MaterialSkin.Controls;

namespace HypseusFE
{
    public partial class FrConfigure : MaterialForm
    {
        private string selectedGame;

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
            this.Text = "HypseusFE Configure - " + selectedGame;
            
            try
            {
                MtbFrameFileLocation.Text = clProfile.GetProfileValue(selectedGame, "Frame File Location");
                MtbROMFileLocation.Text = clProfile.GetProfileValue(selectedGame, "ROM File Location");
            }
            catch (Exception)
            {

            }

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
    }
}