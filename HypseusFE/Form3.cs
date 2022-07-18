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
    public partial class FrOptions : MaterialForm
    {
        public FrOptions()
        {
            InitializeComponent();
        }

        private void FrOptions_Load(object sender, EventArgs e)
        {
            Xml profile = new Xml("HypseusFE.xml");
            MtbHypseusLocation.Text = profile.GetValue("HypseusFE Options", "Hypseus Location").ToString();
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
                Xml profile = new Xml("HypseusFE.xml");
                profile.SetValue("HypseusFE Options", "Hypseus Location", MtbHypseusLocation.Text);
            }
        }
    }
}
