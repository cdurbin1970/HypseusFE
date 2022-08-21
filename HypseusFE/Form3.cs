using System;
using System.Windows.Forms;


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
            this.TitleBar.TitleBarCaption = "HypseusFE Options";
            MtbHypseusLocation.Text = clProfile.GetProfileValue("HypseusFE Options", "Hypseus Location").ToString();
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
        }
    }
}
