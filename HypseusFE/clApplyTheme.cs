using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XCoolForm;

namespace HypseusFE
{
    internal class clApplyTheme
    {
        public static void ApplyTheme(XCoolForm.XCoolForm form)
        {
            Label mylabel;
            Button mybutton;
            CheckBox mycheckBox; 
            GroupBox mygroup;
            
            foreach (Control con in form.Controls)
            {
                if (con.GetType() == typeof(Label)) 
                {
                    mylabel = (Label)con;
                    mylabel.BackColor = form.XFormBackColor;
                    mylabel.ForeColor = form.m_xTitleBar.TitleBarCaptionColor;
                }
                if(con.GetType() == typeof(Button))
                {
                    mybutton = (Button)con;
                    mybutton.BackColor = form.XFormBackColor;
                    mybutton.ForeColor = form.m_xTitleBar.TitleBarCaptionColor;
                }
                if (con.GetType() == typeof(CheckBox))
                {
                    mycheckBox = (CheckBox)con;
                    mycheckBox.BackColor = form.XFormBackColor;
                    mycheckBox.ForeColor = form.m_xTitleBar.TitleBarCaptionColor;
                }
                if (con.GetType() == typeof(GroupBox))
                {
                    mygroup = (GroupBox)con;
                    mygroup.BackColor = form.XFormBackColor;
                    mygroup.ForeColor = form.m_xTitleBar.TitleBarCaptionColor;

                }

            }
        }
    }
}
