using System;
using System.Drawing;
using System.Windows.Forms;
using ThemeLoader;
using XCoolForm;

namespace HypseusFE
{
    public partial class frSplash : XCoolForm.XCoolForm
    {
        public frSplash()
        {
            InitializeComponent();
        }

        private void frSplash_Load(object sender, EventArgs e)
        {
            XmlThemeLoader xtl = new XmlThemeLoader();
            xtl.ThemeForm = this;
            try
            {
                xtl.ApplyTheme(@"resources\themes\" + clProfile.GetProfileValue("HypseusFE Options", "Theme").ToString());
                clApplyTheme.ApplyTheme(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            this.TitleBar.TitleBarCaption = "HypseusFE";
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
