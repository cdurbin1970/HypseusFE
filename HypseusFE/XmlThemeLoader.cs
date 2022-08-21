using System;
using System.Xml;
using System.Windows.Forms;
using System.Drawing;


namespace ThemeLoader
{
    public class XmlThemeLoader
    {

        /// <summary>
        /// Form to apply theme.
        /// </summary>
        private XCoolForm.XCoolForm m_xcf = new XCoolForm.XCoolForm();
        /// <summary>
        /// Xml theme configuration file.
        /// </summary>
        private XmlDocument m_xmlTheme = new XmlDocument();

        /// <summary>
        /// Gets/ sets target form.
        /// </summary>
        public XCoolForm.XCoolForm ThemeForm
        {
            get
            {
                return this.m_xcf;
            }
            set
            {
                this.m_xcf = value;
            }
        }

        public XmlThemeLoader()
        {
        }
        public void ApplyTheme(string sTheme)
        {
            try
            {
              m_xmlTheme.Load(sTheme);
              LoadTitleBarXmlPresets();
              LoadTitlebarButtonsXmlPresets();
              LoadBorderXmlPresets();
              LoadIconHolderXmlPresets();
              LoadFormBackColor();
              LoadMenuIconXmlPresets();
              LoadStatusBarXmlPresets();

              m_xcf.Invalidate();
            }catch (XmlException e)
            {
                MessageBox.Show("Error while loading theme file." + e.InnerException.Message, "Theme error");
            }
        }

        private void LoadTitleBarXmlPresets(){
            String sXPath = "XCoolForm/XCoolFormElements/TitleBar";
            
            m_xcf.TitleBar.InnerTitleBarColor = ReadXmlColor(sXPath, "InnerBorderColor");
            m_xcf.TitleBar.OuterTitleBarColor = ReadXmlColor(sXPath, "OuterBorderColor");
            m_xcf.TitleBar.TitleBarCaptionColor = ReadXmlColor(sXPath, "TitleBarCaptionColor");

            m_xcf.TitleBar.TitleBarMixColors[0] = ReadXmlColor(sXPath + "/TitleBarMixColors", "MixColor1");
            m_xcf.TitleBar.TitleBarMixColors[1] = ReadXmlColor(sXPath + "/TitleBarMixColors", "MixColor2");
            m_xcf.TitleBar.TitleBarMixColors[2] = ReadXmlColor(sXPath + "/TitleBarMixColors", "MixColor3");
            m_xcf.TitleBar.TitleBarMixColors[3] = ReadXmlColor(sXPath + "/TitleBarMixColors", "MixColor4");
            m_xcf.TitleBar.TitleBarMixColors[4] = ReadXmlColor(sXPath + "/TitleBarMixColors", "MixColor5");
            m_xcf.TitleBar.LinearGradientStart = ReadXmlColor(sXPath, "GradientStartColor");
            m_xcf.TitleBar.LinearGradientEnd = ReadXmlColor(sXPath, "GradientEndColor");
            m_xcf.TitleBar.GlowFillStart = ReadXmlColor(sXPath, "GlowFillStart");
            m_xcf.TitleBar.GlowFillEnd = ReadXmlColor(sXPath, "GlowFillEnd");

            m_xcf.TitleBar.ButtonBoxMixColors[0] = ReadXmlColor(sXPath + "/ButtonBox", "MixColor1");
            m_xcf.TitleBar.ButtonBoxMixColors[1] = ReadXmlColor(sXPath + "/ButtonBox", "MixColor2");
            m_xcf.TitleBar.ButtonBoxMixColors[2] = ReadXmlColor(sXPath + "/ButtonBox", "MixColor3");
            m_xcf.TitleBar.ButtonBoxMixColors[3] = ReadXmlColor(sXPath + "/ButtonBox", "MixColor4");
            m_xcf.TitleBar.ButtonBoxMixColors[4] = ReadXmlColor(sXPath + "/ButtonBox", "MixColor5");
            m_xcf.TitleBar.ButtonBoxInnerBorder = ReadXmlColor(sXPath + "/ButtonBox", "ButtonBoxInnerColor");
            m_xcf.TitleBar.ButtonBoxOuterBorder = ReadXmlColor(sXPath + "/ButtonBox", "ButtonBoxOuterColor");
        }
        private void LoadTitlebarButtonsXmlPresets(){
            String sXPath = "XCoolForm/XCoolFormElements/TitleBarButton";

            m_xcf.TitleBar.TitleBarButtons[0].ButtonSymbolColor = ReadXmlColor(sXPath + "/CloseButton", "SymbolColor");
            m_xcf.TitleBar.TitleBarButtons[1].ButtonSymbolColor = ReadXmlColor(sXPath + "/MaxButton", "SymbolColor");
            m_xcf.TitleBar.TitleBarButtons[2].ButtonSymbolColor = ReadXmlColor(sXPath + "/MinButton", "SymbolColor");

            m_xcf.TitleBar.TitleBarButtons[0].FillColorOne = ReadXmlColor(sXPath + "/CloseButton", "FillColorOne");
            m_xcf.TitleBar.TitleBarButtons[0].FillColorTwo = ReadXmlColor(sXPath + "/CloseButton", "FillColorTwo");

            m_xcf.TitleBar.TitleBarButtons[1].FillColorOne = ReadXmlColor(sXPath + "/MaxButton", "FillColorOne");
            m_xcf.TitleBar.TitleBarButtons[1].FillColorTwo = ReadXmlColor(sXPath + "/MaxButton", "FillColorTwo");

            m_xcf.TitleBar.TitleBarButtons[2].FillColorOne = ReadXmlColor(sXPath + "/MinButton", "FillColorOne");
            m_xcf.TitleBar.TitleBarButtons[2].FillColorTwo = ReadXmlColor(sXPath + "/MinButton", "FillColorTwo");

        }
        private void LoadBorderXmlPresets(){
            String sXPath = "XCoolForm/XCoolFormElements/Border";

            m_xcf.Border.OuterBorderColors[0] = ReadXmlColor(sXPath + "/BorderOuterColors", "Color1");
            m_xcf.Border.OuterBorderColors[1] = ReadXmlColor(sXPath + "/BorderOuterColors", "Color2");

            m_xcf.Border.InnerBorderColors[0] = ReadXmlColor(sXPath + "/BorderInnerColors", "Color1");
            m_xcf.Border.InnerBorderColors[1] = ReadXmlColor(sXPath + "/BorderInnerColors", "Color2");
            m_xcf.Border.InnerBorderColors[2] = ReadXmlColor(sXPath + "/BorderInnerColors", "Color3");
            m_xcf.Border.InnerBorderColors[3] = ReadXmlColor(sXPath + "/BorderInnerColors", "Color4");
            
        }
        private void LoadIconHolderXmlPresets(){
            String sXPath = "XCoolForm/XCoolFormElements/IconHolder";

            if (m_xcf.IconHolder.HolderButtons.Count == 0) return;
            foreach(XCoolForm.XTitleBarIconHolder.XHolderButton btn in m_xcf.IconHolder.HolderButtons){
                btn.FrameStartColor = ReadXmlColor(sXPath, "FrameStartColor");
                btn.FrameEndColor = ReadXmlColor(sXPath, "FrameEndColor");
                btn.XHolderButtonCaptionColor = ReadXmlColor(sXPath, "CaptionColor");
            }
        }
        private void LoadFormBackColor(){
            m_xcf.XFormBackColor = ReadXmlColor("XCoolForm/XCoolFormElements", "FormBackColor");
        }
        private void LoadMenuIconXmlPresets(){
            String sXPath = "XCoolForm/XCoolFormElements/MenuIcon";

            m_xcf.MenuIconMix[0] = ReadXmlColor(sXPath, "MixColor1");
            m_xcf.MenuIconMix[1] = ReadXmlColor(sXPath, "MixColor2");
            m_xcf.MenuIconMix[2] = ReadXmlColor(sXPath, "MixColor3");
            m_xcf.MenuIconMix[3] = ReadXmlColor(sXPath, "MixColor4");
            m_xcf.MenuIconMix[4] = ReadXmlColor(sXPath, "MixColor5");
            m_xcf.MenuIconOuterBorder = ReadXmlColor(sXPath, "MenuIconOuterBorder");
            m_xcf.MenuIconInnerBorder = ReadXmlColor(sXPath, "MenuIconInnerBorder");

        }
        private void LoadStatusBarXmlPresets(){
            String sXPath = "XCoolForm/XCoolFormElements/StatusBar";

            foreach (XCoolForm.XStatusBar.XBarItem item in m_xcf.StatusBar.BarItems){
                item.SepInnerColor = ReadXmlColor(sXPath + "/StatusBarItems", "SeparatorInnerColor");
                item.SepOuterColor = ReadXmlColor(sXPath + "/StatusBarItems","SeparatorOuterColor");
                item.ItemFontColor = ReadXmlColor(sXPath + "/StatusBarItems", "FontColor");

            }
            m_xcf.StatusBar.StatusStartColor = ReadXmlColor(sXPath, "StatusStartColor");
            m_xcf.StatusBar.StatusEndColor = ReadXmlColor(sXPath, "StatusEndColor");
            m_xcf.StatusBar.BarBorder = ReadXmlColor(sXPath, "BorderColor");
            m_xcf.StatusBar.SizeGripElem.ForeRectStart = ReadXmlColor(sXPath + "/SizeGrip", "ForeRectStart");
            m_xcf.StatusBar.SizeGripElem.ForeRectEnd = ReadXmlColor(sXPath + "/SizeGrip", "ForeRectEnd");
            m_xcf.StatusBar.SizeGripElem.BackRect = ReadXmlColor(sXPath + "/SizeGrip", "BackRect");
        }
        private Color ReadXmlColor(string sXPath, string sNodeName){
            byte r = 0;
            byte g = 0;
            byte b = 0;

            XmlNode node = m_xmlTheme.SelectSingleNode(
                   sXPath
                   );
            r = Convert.ToByte(node[sNodeName].GetAttribute("r"));
            g = Convert.ToByte(node[sNodeName].GetAttribute("g"));
            b = Convert.ToByte(node[sNodeName].GetAttribute("b"));

            Color clr = Color.FromArgb(r, g, b);
            return clr;
        
        }
       


    
    }
}
