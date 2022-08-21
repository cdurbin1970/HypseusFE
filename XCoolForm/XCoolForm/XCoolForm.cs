using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

// ====================================================================================
// XCoolForm library -
// Copyright by: Nedim Sabic
// x86nedo@yahoo.es
// ====================================================================================

namespace XCoolForm
{
    public class XCoolForm : System.Windows.Forms.Form
    {

        #region PInvoke
        private const int NCLBUTTONDOWN = 0x00A1;
        private const int WM_SYSCOMMAND = 0x112;
        private const int HTCAPTION = 2;
        private const int SC_SIZE = 0xF000;
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(
            IntPtr hWnd,
            int wMsg,
            IntPtr wParam,
            IntPtr lParam
            );
        #endregion

        #region Private members
        private Rectangle m_rcTitleBar = new Rectangle();
        private Image m_MenuIcon;
        private Image m_bmpBackImage;
        private ContentAlignment m_ImageAlign = ContentAlignment.TopLeft;
      
        private Rectangle m_rcXTitleBarIconHolder = new Rectangle();
        private Rectangle m_rcSizeGrip = new Rectangle();
        private Rectangle m_rcXMenuIcon = new Rectangle();
        private Rectangle m_rcBox = new Rectangle();
        
        private Color m_clrBackground = Color.FromArgb(34, 34, 34);

        private Rectangle m_rcRestoreBounds = new Rectangle();
        private Rectangle m_rcIconHolder = new Rectangle();
        
        private int m_lTitleBarHeight = 35;
     
        private Rectangle m_rcTitleBarIcon = new Rectangle();
        private Rectangle m_rcXStatusBar = new Rectangle();

        private bool m_bMouseDown = false;
        private bool m_bMaximized = false;

        private XTitleBarIconHolder m_xtbHolder = new XTitleBarIconHolder();
        public XTitleBar m_xTitleBar = new XTitleBar();
        private XStatusBar m_xsbStatusBar = new XStatusBar();
        private X3DBorderPrimitive m_x3dx = new X3DBorderPrimitive();

        private GraphicsPath m_TitleBarButtonsBox = new GraphicsPath();

        private List<Color> m_MenuIconMix = new List<Color>();
        private Color m_clrMenuIconBorderInner = Color.FromArgb(52, 52, 52);
        private Color m_clrMenuIconBorderOuter = Color.FromArgb(0,0,0);
       
        #endregion

        #region XCoolFormHolderButtonClickArgs
        public class XCoolFormHolderButtonClickArgs : EventArgs
        {
            /// <summary>
            /// Button index.
            /// </summary>
            private int m_lIndex;

            public int ButtonIndex
            {
                get
                {
                    return m_lIndex;
                }
            }

            public XCoolFormHolderButtonClickArgs(
                int lIndex
                )
                : base()
            {
                m_lIndex = lIndex;
            }
        }
        #endregion      
        
        #region Events / Delegates
        public delegate void XCoolFormHolderButtonClickHandler(XCoolFormHolderButtonClickArgs e);
        public event XCoolFormHolderButtonClickHandler XCoolFormHolderButtonClick;
        #endregion
        
        #region Properties
        public XTitleBarIconHolder IconHolder
        {
            get
            {
                return this.m_xtbHolder;
            }
        }
        public XTitleBar TitleBar
        {
            get
            {
                return this.m_xTitleBar;
            }
        }
        public XStatusBar StatusBar
        {
            get
            {
                return this.m_xsbStatusBar;
            }
        }
        public X3DBorderPrimitive Border
        {
            get
            {
                return this.m_x3dx;
            }
        }

        public Color XFormBackColor
        {
            get
            {
                return this.m_clrBackground;
            }
            set
            {
                this.m_clrBackground = value;
            }
        }
        public Color MenuIconInnerBorder
        {
            get
            {
                return this.m_clrMenuIconBorderInner;
            }
            set
            {
                this.m_clrMenuIconBorderInner = value;
            }
        }
        public Color MenuIconOuterBorder
        {
            get
            {
                return this.m_clrMenuIconBorderOuter;
            }
            set
            {
                this.m_clrMenuIconBorderOuter = value;
            }
        }
        public Image MenuIcon
        {
            get
            {
                return this.m_MenuIcon;
            }
            set
            {
                this.m_MenuIcon = value;
            }
        }
        public Image BackImage
        {
            get
            {
                return this.m_bmpBackImage;
            }
            set
            {
                this.m_bmpBackImage = value;
            }
        }
        public List<Color> MenuIconMix
        {
            get
            {
                return this.m_MenuIconMix;
            }
            set
            {
                this.m_MenuIconMix = value;
            }
        }
        #endregion

        public XCoolForm()
            
        {
               
            // set control styles:
            this.SetStyle(
                 ControlStyles.AllPaintingInWmPaint |
                 ControlStyles.DoubleBuffer |
                 ControlStyles.UserPaint |
                 ControlStyles.ResizeRedraw |
                 ControlStyles.SupportsTransparentBackColor,
                 true
            );
            this.FormBorderStyle = FormBorderStyle.None;
            this.MinimumSize = new Size(400, 400);
            this.Padding = new Padding( 8 );
           
            // initialize titlebar buttons:
            m_xTitleBar.TitleBarButtons.Add(new XTitleBarButton(XTitleBarButton.XTitleBarButtonType.Close));
            m_xTitleBar.TitleBarButtons.Add(new XTitleBarButton(XTitleBarButton.XTitleBarButtonType.Maximize, Color.FromArgb(3, 63, 126),Color.FromArgb(119,217, 246)));
            m_xTitleBar.TitleBarButtons.Add(new XTitleBarButton(XTitleBarButton.XTitleBarButtonType.Minimize, Color.FromArgb(124, 13, 2),Color.FromArgb(251, 164, 48)));

            // initialize mix:
            m_MenuIconMix.Add(Color.FromArgb(112, 106, 108));
            m_MenuIconMix.Add(Color.FromArgb(56, 52, 53));
            m_MenuIconMix.Add(Color.FromArgb(53, 49, 50));
            m_MenuIconMix.Add(Color.FromArgb(71, 71, 71));
            m_MenuIconMix.Add(Color.FromArgb(112, 106, 108));

            m_xtbHolder = new XTitleBarIconHolder(this);
           
            
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
           
            bool bShouldReset = false;
            if (m_x3dx.BorderType != X3DBorderPrimitive.XBorderType.Rectangular){
                e.Graphics.Clip = new Region(m_x3dx.FindX3DBorderPrimitive(this.ClientRectangle));
                bShouldReset = true;
                this.BackColor = Color.Fuchsia;
                this.TransparencyKey = Color.Fuchsia;
            }
            using (SolidBrush sb = new SolidBrush(m_clrBackground))
            {

                
                e.Graphics.FillRectangle(
                    sb,
                    this.ClientRectangle
                );
                if (bShouldReset)
                    e.Graphics.ResetClip();
            }
           
        }

        protected override void OnMouseDown(
            System.Windows.Forms.MouseEventArgs e
            )
        {


            if (e.Button == MouseButtons.Left)
            m_bMouseDown = true;
           
        #region Titlebar buttons

        if (m_xTitleBar.ShouldDrawButtonBox)
        {
            foreach (XTitleBarButton xbtn in m_xTitleBar.TitleBarButtons)
            {

                if (m_TitleBarButtonsBox.IsVisible(e.Location))
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
                        if (xbtn.XButtonType == XTitleBarButton.XTitleBarButtonType.Minimize)
                            this.WindowState = FormWindowState.Minimized;
                        else if (xbtn.XButtonType == XTitleBarButton.XTitleBarButtonType.Maximize)
                        {
                            if (m_bMaximized)
                            {
                                m_bMaximized = false;
                                this.Size = new Size(m_rcRestoreBounds.Width, m_rcRestoreBounds.Height);
                                this.Location = new Point(m_rcRestoreBounds.Left, m_rcRestoreBounds.Top);
                            }
                            else
                            {
                                m_rcRestoreBounds = new Rectangle(this.Location, this.Size);
                                Rectangle wa = Screen.GetWorkingArea(this);
                                this.Size = new Size(wa.Width, wa.Height);
                                this.Location = new Point(wa.Left, wa.Top);
                                m_bMaximized = true;
                            }
                        }
                        else if (xbtn.XButtonType == XTitleBarButton.XTitleBarButtonType.Close)
                        {
                            Application.Exit();
                        }
                    }
                }

            }
        }
        else
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
                    if (xbtn.XButtonType == XTitleBarButton.XTitleBarButtonType.Minimize)
                        this.WindowState = FormWindowState.Minimized;
                    else if (xbtn.XButtonType == XTitleBarButton.XTitleBarButtonType.Maximize)
                    {
                        if (m_bMaximized)
                        {
                            m_bMaximized = false;
                            this.Size = new Size(m_rcRestoreBounds.Width, m_rcRestoreBounds.Height);
                            this.Location = new Point(m_rcRestoreBounds.Left, m_rcRestoreBounds.Top);
                        }
                        else
                        {
                            m_rcRestoreBounds = new Rectangle(this.Location, this.Size);
                            Rectangle wa = Screen.GetWorkingArea(this);
                            this.Size = new Size(wa.Width, wa.Height);
                            this.Location = new Point(wa.Left, wa.Top);
                            m_bMaximized = true;
                        }
                    }
                    else if (xbtn.XButtonType == XTitleBarButton.XTitleBarButtonType.Close)
                    {
                        Application.Exit();
                    }
                }


            }
        }
        #endregion

        #region Titlebar icon holder
            // mouse over TitleBarIconHolder :
            if (PointInRect(e.Location, m_rcXTitleBarIconHolder))
            {
                if (e.Button == MouseButtons.Left)
                {
                    // find hovering button:
                    int lIdx = m_xtbHolder.HitTestHolderButton(
                         e.X,
                         e.Y,
                         m_rcXTitleBarIconHolder
                    );

                    for (int i = 0; i < m_xtbHolder.HolderButtons.Count; i++)
                    {
                        if (i == lIdx)
                        {
                            XCoolFormHolderButtonClickArgs XCoolHolderButton =
                                new XCoolFormHolderButtonClickArgs(i);
                            if (XCoolFormHolderButtonClick != null)
                                XCoolFormHolderButtonClick(XCoolHolderButton);
                        }
                    }
                }
            }
            #endregion
          

        }
        protected override void OnMouseUp(
            System.Windows.Forms.MouseEventArgs e
            )
        {

            if (e.Button == MouseButtons.Left)
                m_bMouseDown = false;

        }
        protected override void OnResizeBegin(EventArgs e)
        {
            
            this.Invalidate();
            base.OnResizeBegin(e);
        }
        protected override void OnMouseMove(
            System.Windows.Forms.MouseEventArgs e
            )
        {
           
           
            #region TitleBarIconHolder
            // mouse over TitleBarIconHolder ?:
            if (PointInRect(e.Location, m_rcXTitleBarIconHolder))
            {
                // find hovering button:
                int lIdx = m_xtbHolder.HitTestHolderButton(
                     e.X,
                     e.Y,
                     m_rcXTitleBarIconHolder
                );

                for (int i = 0; i < m_xtbHolder.HolderButtons.Count; i++)
                {
                    if (i == lIdx)
                    {
                        if (!m_xtbHolder.HolderButtons[i].Hot)
                        {
                            m_xtbHolder.HolderButtons[i].Hot = true;
                            Invalidate(m_rcXTitleBarIconHolder);
                        }

                    }
                    else
                    {
                        if (m_xtbHolder.HolderButtons[i].Hot)
                        {
                            m_xtbHolder.HolderButtons[i].Hot = false;
                            Invalidate(m_rcXTitleBarIconHolder);
                        }
                    }
                }

            }
            else
            {
                for (int i = 0; i < m_xtbHolder.HolderButtons.Count; i++)
                {
                    if (m_xtbHolder.HolderButtons[i].Hot)
                    {
                        m_xtbHolder.HolderButtons[i].Hot = false;
                        Invalidate(m_rcXTitleBarIconHolder);
                    }
                }
            }
            #endregion
            
            #region TitleBar buttons
            HitTestTitleBarButtons(e.Location);
            #endregion

            #region Form moving
            HitTestMoveTitleBar(e);
            #endregion

            #region Sizing
            ResizeWindow(e);
            #endregion

            base.OnMouseMove(e);
        }

        private void ResizeWindow(MouseEventArgs e)
        {
            bool bResizing = true;
           
            if (PointInRect(
                 e.Location,
                 m_rcSizeGrip))
            {
                Cursor = Cursors.SizeNWSE;
                if (m_bMouseDown && bResizing)
                {
                    
                    if (e.Button == MouseButtons.Left)
                    {
                        if (this.Width < this.MinimumSize.Width)
                            bResizing = false;
                        if (this.Height < this.MinimumSize.Height)
                            bResizing = false;

                        ReleaseCapture();
                        SendMessage(
                         this.Handle,
                         WM_SYSCOMMAND,
                         (IntPtr)(SC_SIZE + 8),
                         IntPtr.Zero
                         );
                        
                    }
                }
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }

        private void HitTestMoveTitleBar(MouseEventArgs e)
        {
            if (m_bMouseDown)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (PointInRect(
                        e.Location,
                        m_rcTitleBar))
                    {
                        ReleaseCapture();
                        SendMessage(
                            this.Handle,
                            NCLBUTTONDOWN,
                            (IntPtr)HTCAPTION,
                            IntPtr.Zero
                        );
                    }
                }
            }
        }
        private void HitTestTitleBarButtons(Point pos)
        {
            bool bChanged = false;
           
            if (m_xTitleBar.ShouldDrawButtonBox)
            {
                if (m_TitleBarButtonsBox.IsVisible(pos))
                {
                    foreach (XTitleBarButton xbtn in m_xTitleBar.TitleBarButtons)
                    {
                        if (PointInRect(
                             pos,
                             new Rectangle(
                             xbtn.XButtonLeft,
                             xbtn.XButtonTop,
                             xbtn.XButtonWidth,
                             xbtn.XButtonHeight
                             )))
                        {
                            if (!xbtn.Hovering)
                            {
                                xbtn.Hovering = true;
                                bChanged = true;

                            }
                        }
                        else
                        {
                            if (xbtn.Hovering)
                            {
                                xbtn.Hovering = false;
                                bChanged = true;

                            }
                        }
                    }

                }
                else
                {
                    foreach (XTitleBarButton xbtn in m_xTitleBar.TitleBarButtons)
                    {
                        if (xbtn.Hovering)
                        {
                            xbtn.Hovering = false;
                            bChanged = true;
                        }
                    }
                }
            }
            else
            {
                
                foreach (XTitleBarButton xbtn in m_xTitleBar.TitleBarButtons)
                {
                        if (PointInRect(
                             pos,
                             new Rectangle(
                             xbtn.XButtonLeft,
                             xbtn.XButtonTop,
                             xbtn.XButtonWidth,
                             xbtn.XButtonHeight
                             )))
                        {
                            if (!xbtn.Hovering)
                            {
                                xbtn.Hovering = true;
                                Invalidate(new Rectangle(xbtn.XButtonLeft, xbtn.XButtonTop, xbtn.XButtonWidth, xbtn.XButtonHeight));
                               

                            }
                        }
                        else
                        {
                            if (xbtn.Hovering)
                            {
                                xbtn.Hovering = false;
                                Invalidate(new Rectangle(xbtn.XButtonLeft, xbtn.XButtonTop, xbtn.XButtonWidth, xbtn.XButtonHeight));

                            }
                        }
                }
            }
            if (bChanged)
            {
                Invalidate(m_rcBox);
            }
            
        }
        
        protected override void OnPaint(
            System.Windows.Forms.PaintEventArgs e
            )
        {
            
            m_rcTitleBarIcon = new Rectangle(7, 5, 40, 40);
            Rectangle rcBorder = new Rectangle(0, 0, this.ClientRectangle.Width - 1, this.ClientRectangle.Height - 1);
            
            DrawStatusBar(e.Graphics);
            
            // render border:
            m_x3dx.Render(rcBorder, e.Graphics);
            
            DrawSysIcon(e.Graphics);
            DrawButtonsBox(e.Graphics);
            DrawTitleBar(e.Graphics);
            
            // build titlebar buttons box:
            m_TitleBarButtonsBox = m_xTitleBar.BuildTitleBarButtonsBox(m_rcBox);
           
            // render holder buttons:
            m_xtbHolder.RenderHolderButtons(
                m_rcIconHolder.X,
                m_rcIconHolder.Y,
                e.Graphics
             );
             
        }
        private void DrawButtonsBox(Graphics g)
        {
          int lBoxTop = 0;
          int lBtnWidth = 0;
          int lBtnHeight = 0;
          int lBorder = 6;
          int lBoxWidth = 0;
          int lBoxHeight = 0;
          int x = this.ClientRectangle.Right - lBorder - 14;
          int y = 9;
          if (m_xTitleBar.TitleBarType == XTitleBar.XTitleBarType.Angular || m_xTitleBar.TitleBarType == XTitleBar.XTitleBarType.Rectangular)
             lBoxTop += 4;
          
          foreach (XTitleBarButton btn in m_xTitleBar.TitleBarButtons)
          {
                  lBtnWidth = btn.XButtonWidth;
                  lBtnHeight = btn.XButtonHeight;
          }
          if (m_xTitleBar.ShouldDrawButtonBox)
              lBoxWidth = lBtnWidth * 3 - 1;
          else
              lBoxWidth = 60;
          lBoxHeight = lBtnHeight;
              
          m_rcBox = new Rectangle(
              ClientRectangle.Right - lBorder - lBoxWidth,
              lBoxTop,
              lBoxWidth,
              lBoxHeight
              );
          
          m_xTitleBar.RenderTitleBarButtonsBox(m_rcBox, g, x, y);
          
        }
        private void DrawSysIcon(Graphics g)
        {
           
            int lLeft = 6; int lTop = 3;
            int lWidth = 47;
            int lHeight = m_lTitleBarHeight - 6;
            m_rcXMenuIcon = new Rectangle(lLeft, lTop, lWidth, lHeight);
            RenderSysMenuIcon(m_rcXMenuIcon, g);
           
        }
        private void DrawStatusBar(Graphics g)
        {
            int lBorderExcess = 7;
            if (m_x3dx.BorderStyle == X3DBorderPrimitive.XBorderStyle.Flat)
                lBorderExcess = 2;
            
            m_rcXStatusBar = new Rectangle(1, ClientRectangle.Bottom - lBorderExcess - m_xsbStatusBar.BarHeight, ClientRectangle.Right - ClientRectangle.Left, m_xsbStatusBar.BarHeight);
            m_xsbStatusBar.RenderStatusBar(g, m_rcXStatusBar.Left, m_rcXStatusBar.Top, m_rcXStatusBar.Width, m_rcXStatusBar.Height);
            m_rcSizeGrip = m_xsbStatusBar.XGripRect;
        }
        private void DrawTitleBar(Graphics g)
        {
            int lTitleBarWidth = m_rcBox.Left - m_rcXMenuIcon.Width - 12;
            int lTopOffset = 5;
            int lRectOffset = m_rcXMenuIcon.Right - 2;

            if (m_xTitleBar.TitleBarType == XTitleBar.XTitleBarType.Angular)
            {
                lTitleBarWidth += 25;
                
            }
            if (m_xTitleBar.TitleBarType == XTitleBar.XTitleBarType.Rounded)
            {
                lTitleBarWidth -= 10;
            }
            if (m_xTitleBar.TitleBarType == XTitleBar.XTitleBarType.Rectangular)
            {
                lRectOffset += 5;
            }

            m_rcTitleBar = new Rectangle(lRectOffset, lTopOffset, lTitleBarWidth, 25);
            int lIconHolderOffset = m_rcTitleBar.Left + 4;
            if (m_xTitleBar.TitleBarType == XTitleBar.XTitleBarType.Angular)
            {
                lIconHolderOffset += 15;
            }
            if (m_xTitleBar.TitleBarType == XTitleBar.XTitleBarType.Rounded)
            {
                lIconHolderOffset += 4;
            }

            m_rcXTitleBarIconHolder = new Rectangle(
              55,
              m_rcTitleBar.Top + 3,
              255,
              m_lTitleBarHeight + 60
              );
            m_rcIconHolder = new Rectangle(
              lIconHolderOffset,
              7,
              200,
              400);

            m_xTitleBar.RenderTitleBar(g, m_rcTitleBar);
        }

        private void RenderSysMenuIcon(
            Rectangle rcMenuIcon,
            Graphics g)
        {
            using (GraphicsPath XMenuIconPath = BuildMenuIconShape(ref rcMenuIcon))
            {


                FillMenuIconGradient(XMenuIconPath, g, m_MenuIconMix);

                using (XAntiAlias xaa = new XAntiAlias(g))
                {
                    DrawInnerMenuIconBorder(rcMenuIcon, g, m_clrMenuIconBorderInner);
                    g.DrawPath(
                     new Pen(m_clrMenuIconBorderOuter),
                      XMenuIconPath
                     );
                    
                }

            }

            #region Draw icon
            if (m_MenuIcon != null) {
                int lH = m_MenuIcon.Height;
                int lW = m_MenuIcon.Width;

                Rectangle rcImage = new Rectangle((rcMenuIcon.Right - rcMenuIcon.Width / 2) - lW / 2 - 2, (rcMenuIcon.Bottom - rcMenuIcon.Height / 2) - lH / 2, lW, lH);
                g.DrawImage(
                  m_MenuIcon,
                  rcImage
                );
            }
            #endregion
        }
        private void FillMenuIconGradient(
            GraphicsPath XFillPath,
            Graphics g,
            List<Color> mix
            )
        {


            using (XAntiAlias xaa = new XAntiAlias(g))
            {
                using (LinearGradientBrush lgb = new LinearGradientBrush
                    (XFillPath.GetBounds(),
                     mix[0],
                     mix[4],
                     LinearGradientMode.Vertical))
                {
                   
                    lgb.InterpolationColors = XCoolFormHelper.ColorMix(mix, false);
                    
                    g.FillPath(
                      lgb,
                      XFillPath
                    );

                }
            }
            
            
        
        }
       
        
        private GraphicsPath BuildMenuIconShape( ref Rectangle rcMenuIcon)
        {
            GraphicsPath XMenuIconPath = new GraphicsPath();
            switch (m_xTitleBar.TitleBarType)
            {
                case XTitleBar.XTitleBarType.Rounded:
                    XMenuIconPath.AddArc(
                    rcMenuIcon.Left,
                    rcMenuIcon.Top,
                    rcMenuIcon.Height,
                    rcMenuIcon.Height,
                    90,
                    180);
                    XMenuIconPath.AddLine(
                    rcMenuIcon.Left + rcMenuIcon.Height / 2,
                    rcMenuIcon.Top,
                    rcMenuIcon.Right,
                    rcMenuIcon.Top
                    );
                    XMenuIconPath.AddBezier(
                    new Point(rcMenuIcon.Right, rcMenuIcon.Top),
                    new Point(rcMenuIcon.Right - 10, rcMenuIcon.Bottom / 2 - 5),
                    new Point(rcMenuIcon.Right - 12, rcMenuIcon.Bottom / 2 + 5),
                    new Point(rcMenuIcon.Right, rcMenuIcon.Bottom)
                    );
                    XMenuIconPath.AddLine(
                    rcMenuIcon.Right,
                    rcMenuIcon.Bottom,
                    rcMenuIcon.Left + rcMenuIcon.Height / 2,
                    rcMenuIcon.Bottom
                    );
                    break;
                case XTitleBar.XTitleBarType.Angular:
                    XMenuIconPath.AddArc(
                    rcMenuIcon.Left,
                    rcMenuIcon.Top,
                    rcMenuIcon.Height,
                    rcMenuIcon.Height,
                    90,
                    180);
                    XMenuIconPath.AddLine(
                    rcMenuIcon.Left + rcMenuIcon.Height / 2,
                    rcMenuIcon.Top,
                    rcMenuIcon.Right + 18,
                    rcMenuIcon.Top
                    );
                    XMenuIconPath.AddLine(
                    rcMenuIcon.Right + 18,
                    rcMenuIcon.Top,
                    rcMenuIcon.Right - 5,
                    rcMenuIcon.Bottom
                    );
                    XMenuIconPath.AddLine(
                    rcMenuIcon.Right - 5,
                    rcMenuIcon.Bottom,
                    rcMenuIcon.Left + rcMenuIcon.Height / 2,
                    rcMenuIcon.Bottom
                    );
                    break;
                case XTitleBar.XTitleBarType.Rectangular:
                    XMenuIconPath.AddArc(
                    rcMenuIcon.Left,
                    rcMenuIcon.Top,
                    rcMenuIcon.Height,
                    rcMenuIcon.Height,
                    90,
                    180);
                    XMenuIconPath.AddLine(
                    rcMenuIcon.Left + rcMenuIcon.Height / 2,
                    rcMenuIcon.Top,
                    rcMenuIcon.Right,
                    rcMenuIcon.Top
                    );
                    XMenuIconPath.AddLine(
                    rcMenuIcon.Right,
                    rcMenuIcon.Top,
                    rcMenuIcon.Right,
                    rcMenuIcon.Bottom
                    );
                    XMenuIconPath.AddLine(
                    rcMenuIcon.Right,
                    rcMenuIcon.Bottom,
                    rcMenuIcon.Left + rcMenuIcon.Height / 2,
                    rcMenuIcon.Bottom
                    );
                    break;
                    

            }
            return XMenuIconPath;
        }
        private void DrawInnerMenuIconBorder(
            Rectangle rcMenuIcon,
            Graphics g,
            Color clr)
        {

            
            rcMenuIcon.Inflate(-1, -1);
            using (GraphicsPath XMenuIconPath = BuildMenuIconShape(ref rcMenuIcon))
            {
                using (Pen pInner = new Pen(clr))
                {
                    g.DrawPath(
                      pInner,
                      XMenuIconPath
                    );
                }
            }
            
        
        }
        /// <summary>
        /// Checks if point is inside specific rectangle.
        /// </summary>
        /// <param name="p"> Point to check.</param>
        /// <param name="rc">Rectangle area.</param>
        /// <returns></returns>
        protected bool PointInRect(Point p, Rectangle rc)
        { 
            if ((p.X > rc.Left && p.X < rc.Right &&
                p.Y > rc.Top && p.Y < rc.Bottom))
               return true;
            else
               return false;
        }
        private void DrawBackImage(
            Graphics gfx,
            Rectangle rc
            )
        {
            if (m_bmpBackImage != null)
            {
                int lW = m_bmpBackImage.Width;
                int lH = m_bmpBackImage.Height;
                Rectangle rcImage = new Rectangle(
                    0,
                    0,
                    lW,
                    lH
                    );

                switch (m_ImageAlign)
                {
                    case ContentAlignment.BottomCenter:
                        rcImage.X = rc.Width / 2 - lW / 2;
                        rcImage.Y = rc.Height - lH - 2;
                        break;
                    case ContentAlignment.BottomLeft:
                        rcImage.X = rc.Left + 2;
                        rcImage.Y = rc.Height - lH - 2;
                        break;
                    case ContentAlignment.BottomRight:
                        rcImage.X = rc.Right - lW - 2;
                        rcImage.Y = rc.Height - lH - 2;
                        break;
                    case ContentAlignment.MiddleCenter:
                        rcImage.X = rc.Width / 2 - lW / 2;
                        rcImage.Y = rc.Height / 2 - lH / 2;
                        break;
                    case ContentAlignment.MiddleLeft:
                        rcImage.X = rc.Left + 2;
                        rcImage.Y = rc.Height / 2 - lH / 2;
                        break;
                    case ContentAlignment.MiddleRight:
                        rcImage.X = rc.Right - lW - 2;
                        rcImage.Y = rc.Height / 2 - lH / 2;
                        break;
                    case ContentAlignment.TopCenter:
                        rcImage.X = rc.Width / 2 - lW / 2;
                        rcImage.Y = rc.Top + 2;
                        break;
                    case ContentAlignment.TopLeft:
                        rcImage.X = rc.Left + 2;
                        rcImage.Y = rc.Top + 2;
                        break;
                    case ContentAlignment.TopRight:
                        rcImage.X = rc.Right - lW - 2;
                        rcImage.Y = rc.Top + 2;
                        break;

                }

                gfx.DrawImage(
                    m_bmpBackImage,
                    rcImage
                );

            }

        }

    
    
    
    }
}
