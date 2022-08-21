using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace XCoolForm
{
    public class XStatusBar
    {
        
        private Color m_clrStart = Color.FromArgb(40, 40, 40);
        private Color m_clrEnd = Color.FromArgb(35, 35, 35);
        private Color m_clrBarSepLineUp = Color.FromArgb(27, 27, 27);
        private int m_lBarHeight = 22;
        public Rectangle rcSizeGrip = new Rectangle();
        private bool m_bEllipticalGlow = true;

        private Color m_clrGlow = Color.FromArgb(80, 80, 80);
        
        public enum XStatusBarBackImageAlign
        {
            /// <summary>
            /// Left aligned image.
            /// </summary>
            Left,
            /// <summary>
            /// Middle aligned image.
            /// </summary>
            Center,
            /// <summary>
            /// Rigth aligned image.
            /// </summary>
            Right
        }
        private XStatusBarBackImageAlign m_eStatusBarImageAlign = XStatusBarBackImageAlign.Left;

        private Image m_BarBackground;
        private Color m_clrBarBorder = Color.FromArgb(27, 27, 27);
        private List<XBarItem> m_xbItems = new List<XBarItem>();
        private SizeGripElement sgr = new SizeGripElement();

        public List<XBarItem> BarItems
        {
            get
            {
                return this.m_xbItems;
            }
        }
        public SizeGripElement SizeGripElem
        {
            get
            {
                return this.sgr;
            }
        }

        internal Rectangle XGripRect
        {
            get
            {
                return this.rcSizeGrip;
            }
        }
        public int BarHeight
        {
            get
            {
                return this.m_lBarHeight;
            }
            set
            {
                this.m_lBarHeight = value;
            }
        }
        public Color StatusStartColor
        {
            get
            {
                return this.m_clrStart;
            }
            set
            {
                this.m_clrStart = value;
            }
        }
        public Color StatusEndColor
        {
            get
            {
                return this.m_clrEnd;
            }
            set
            {
                this.m_clrEnd = value;
            }
        }
        public Color UpperSeparatorColor
        {
            get
            {
                return this.m_clrBarSepLineUp;
            }
            set
            {
                this.m_clrBarSepLineUp = value;
            }
        }
        public bool EllipticalGlow
        {
            get 
            {
                return this.m_bEllipticalGlow;
            }
            set
            {
                this.m_bEllipticalGlow = value;
            }
        }
        public Color GlowColor
        {
            get
            {
                return this.m_clrGlow;
            }
            set
            {
                this.m_clrGlow = value;
            }
        }
        public Color BarBorder
        {
            get
            {
                return this.m_clrBarBorder;
            }
            set
            {
                this.m_clrBarBorder = value;
            }
             
        }
        public Image BarBackImage
        {
            get
            {
                return this.m_BarBackground;
            }
            set
            {
                this.m_BarBackground = value;
            }
        }
        public XStatusBarBackImageAlign BarImageAlign
        {
            get
            {
                return this.m_eStatusBarImageAlign;
            }
            set
            {
                this.m_eStatusBarImageAlign = value;
            }
        }
        public class XBarItem
        {
            private Color m_clrSeparatorOuter = Color.FromArgb(27, 27, 27);
            private Color m_clrSeparatorInner = Color.FromArgb(36, 36, 36);
            private Font m_fntItemFont = new Font("Visitor TT2 BRK", 9);
            private Color m_clrItemFontColor = Color.FromArgb(255, 255, 255);
            private StringAlignment m_saItem = StringAlignment.Near;

            private int m_lWidth = 90;
            private int m_lHeight = 22;
            private string m_sItemText = "";

            public String BarItemText
            {
                get
                {
                    return this.m_sItemText;
                }
                set
                {
                    this.m_sItemText = value;
                }

            }
            public Font BarItemFont
            {
                get
                {
                    return this.m_fntItemFont;
                }
                set
                {
                    this.m_fntItemFont = value;
                }
            }
            public StringAlignment ItemTextAlign
            {
                get
                {
                    return this.m_saItem;
                }
                set
                {
                    this.m_saItem = value;
                }
            }
            public Color SepInnerColor
            {
                get
                {
                    return this.m_clrSeparatorInner;
                }
                set
                {
                    this.m_clrSeparatorInner = value;
                }
            }
            public Color SepOuterColor
            {
                get
                {
                    return this.m_clrSeparatorOuter;
                }
                set
                {
                    this.m_clrSeparatorOuter = value;
                }
            }
            public Color ItemFontColor
            {
                get
                {
                    return this.m_clrItemFontColor;
                }
                set
                {
                    this.m_clrItemFontColor = value;
                }
            }
            public int ItemWidth
            {
                get
                {
                    return this.m_lWidth;
                }
                set
                {
                    this.m_lWidth = value;
                }
                
            }
            public XBarItem()
            {
            }

            public XBarItem(
                   int lWidth
                )
            {
                m_lWidth = lWidth;
            }
            
            public XBarItem(
                   int lWidth,
                   string sText
                )
            {
                m_lWidth = lWidth;
                m_sItemText = sText;
            }

            public void RenderXBarItem(
                Graphics g,
                int lLeft,
                int lTop
                )
            {
            
                Pen pSeparator = new Pen(m_clrSeparatorOuter);
                Rectangle rcItem = new Rectangle(
                      lLeft,
                      lTop,
                      m_lWidth,
                      m_lHeight 
                      );
                Rectangle rcText = rcItem;
                
                rcText.X += 2;
                rcText.Width -= 4;
               
                // draw separators:
                g.DrawLine(
                  pSeparator,
                  rcItem.Left + rcItem.Width,
                  rcItem.Top + 1,
                  rcItem.Left + rcItem.Width,
                  rcItem.Top + m_lHeight - 1
                );
                pSeparator = new Pen(m_clrSeparatorInner);
                g.DrawLine(
                  pSeparator,
                  rcItem.Left + rcItem.Width + 1,
                  rcItem.Top + 1,
                  rcItem.Left + rcItem.Width + 1,
                  rcItem.Top + m_lHeight - 1
                );

                // draw item text:
                StringFormat sf = new StringFormat();
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = m_saItem;
                sf.Trimming = StringTrimming.EllipsisCharacter;
                SolidBrush sb = new SolidBrush(m_clrItemFontColor);

                g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                g.DrawString(
                  m_sItemText,
                  m_fntItemFont,
                  sb,
                  rcText,
                  sf        );
                
                pSeparator.Dispose();
                sf.Dispose();
                sb.Dispose();
            }
                
        
        }

        public XStatusBar()
        {
        }

        public void RenderStatusBar(
            Graphics g,
            int x,
            int y,
            int lWidth,
            int lHeight
           )
        {
            #region Fill status bar
            Rectangle rcStatus = new Rectangle(
                x,
                y,
                lWidth,
                lHeight
                );
            using (LinearGradientBrush lgb = new
                            LinearGradientBrush(
                            rcStatus,
                            m_clrStart,
                            m_clrEnd,
                            LinearGradientMode.Vertical
                            ))
            {
                g.FillRectangle(
                    lgb,
                    rcStatus
                );

            }
            
            #endregion

            #region Draw separator line
            Pen pUp = new Pen(m_clrBarSepLineUp);
            g.DrawLine(
                pUp,
                x,
                rcStatus.Bottom,
                rcStatus.Right,
                rcStatus.Bottom
            );
            #endregion


            DrawStatusBarBackImage(g, rcStatus);
            #region Render items

            int lLeft = rcStatus.Left;
            foreach (XBarItem xbi in m_xbItems)
            {

                xbi.RenderXBarItem(
                    g,
                    lLeft,
                    rcStatus.Top
                   
                );
                lLeft += xbi.ItemWidth;
            }
           
            #endregion

            DrawStatusGlow(rcStatus, g, m_clrGlow);
           

            #region Render size grip
            rcSizeGrip = new Rectangle(
                rcStatus.Right - 22,
                rcStatus.Bottom  - 10,
                10,
                11
            );
            
            int lX = rcSizeGrip.Left;
            int lY = rcSizeGrip.Top + 2;
            for (int i = 0; i < 4; i++)
            {
                if (i == 3)
                {
                    lX -= 4;
                    for (int j = 0; j < 2; j++){
                        lY -= 4;
                        sgr.DrawSizeGripElement(
                            g,
                            lX,
                            lY
                        );
                        if (j == 1) {
                            lY += 4;
                            lX -= 4;
                            sgr.DrawSizeGripElement(
                                g,
                                lX,
                                lY
                            );
                         }

                    }
                }
                else
                {
                    sgr.DrawSizeGripElement(
                        g,
                        lX,
                        lY
                    );

                    lX += 4;
                }

            }
            #endregion

            #region Draw border
            using (Pen pBorder = new Pen(m_clrBarBorder))
            {
                g.DrawRectangle(
                  pBorder,
                  rcStatus
                );
            }
            #endregion

            #region Clean-Up
            pUp.Dispose();
            #endregion
        }

        private void DrawStatusGlow(
            Rectangle rect,
            Graphics g,
            Color clrGlowColor
           )
        {
            Rectangle rcGlow = rect;
            using (LinearGradientBrush lgbGlow = new LinearGradientBrush(
                       rcGlow,
                       Color.FromArgb(30, clrGlowColor),
                       Color.FromArgb(150, clrGlowColor),
                       LinearGradientMode.Vertical))
            {
                if (m_bEllipticalGlow)
                {
                    g.SetClip(rect);
                    using (XAntiAlias xaa = new XAntiAlias(g))
                    {
                        using (GraphicsPath XEllipseGlow = new GraphicsPath())
                        {
                            XEllipseGlow.AddEllipse(
                            rect.Left - 5,
                            rect.Top - rect.Height / 2,
                            rect.Width + 10,
                            rect.Height);

                            g.FillPath(
                              lgbGlow,
                              XEllipseGlow
                            );
                        }
                    }
                    g.ResetClip();

                }
                else
                {
                    rcGlow.Height = 5;
                    g.FillRectangle(
                      lgbGlow,
                      rcGlow
                    );

                }
            }
        
        }
        private void DrawStatusBarBackImage(
            Graphics g,
            Rectangle rcStatusbar
           )
        {
            if (m_BarBackground != null)
            {
                int lH = m_BarBackground.Height;
                int lW = m_BarBackground.Width;

                Rectangle rcIcon = new Rectangle(
                0,
                0,
                lW,
                lH
                );
                switch (m_eStatusBarImageAlign)
                {
                    case XStatusBarBackImageAlign.Right:
                        rcIcon.X = rcStatusbar.Right - lW;
                        rcIcon.Y = rcStatusbar.Bottom - lH / 2;
                        break;
                    case XStatusBarBackImageAlign.Center:
                        rcIcon.X = rcStatusbar.Right / 2 - lW / 2 + rcStatusbar.Height / 2;
                        rcIcon.Y = rcStatusbar.Bottom   - lH / 2;
                        break;
                    case XStatusBarBackImageAlign.Left:
                        rcIcon.X = rcStatusbar.Left + 5;
                        rcIcon.Y = rcStatusbar.Bottom - lH / 2;
                        break;

                }
                

                // draw image:
                g.SetClip(rcStatusbar);
                g.DrawImage(
                   m_BarBackground,
                   rcIcon
                );
                g.ResetClip();
               
            }
        }


        #region SizeGripElement
        public class SizeGripElement
        {
            private Color m_clrForeRectStart = Color.FromArgb(27, 27, 27);
            private Color m_clrForeRectEnd = Color.FromArgb(27, 27, 27);
            private Color m_clrBackRect = Color.FromArgb(48, 48, 48);

            public Color ForeRectStart
            {
                get
                {
                    return this.m_clrForeRectStart;
                }
                set
                {
                    this.m_clrForeRectStart = value;
                }
            }
            public Color ForeRectEnd
            {
                get
                {
                    return this.m_clrForeRectEnd;
                }
                set
                {
                    this.m_clrForeRectEnd = value;
                }
            }
            public Color BackRect
            {
                get
                {
                    return this.m_clrBackRect;
                }
                set
                {
                    this.m_clrBackRect = value;
                }
            }



            public void DrawSizeGripElement(
                Graphics g,
                int lX,
                int lY)
            {
                Rectangle rcForeRect = new Rectangle(
                    lX,
                    lY,
                    2,
                    2);
                Rectangle rcBackRect = new Rectangle(
                    lX + 1,
                    lY + 1,
                    2,
                    2);

                SolidBrush sbForeStart = new SolidBrush(m_clrForeRectStart);
                SolidBrush sbBack = new SolidBrush(m_clrBackRect);

                g.FillRectangle(
                  sbBack,
                  rcBackRect
                );
                
                g.FillRectangle(
                  sbForeStart,
                  rcForeRect
                );
                
                rcForeRect.Y += 1;
                rcForeRect.Height -= 1;
                sbForeStart = new SolidBrush(m_clrForeRectEnd);
                g.FillRectangle(
                  sbForeStart,
                  rcForeRect
                );

                sbForeStart.Dispose();
                sbBack.Dispose();
            }

        }
        #endregion


    }
}
