using System;
using System.Windows.Forms;


namespace HypseusFE
{
    public partial class FrConfigure : XCoolForm.XCoolForm
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

            this.TitleBar.TitleBarCaption = "HypseusFE Configure - " + selectedGame;
                       
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