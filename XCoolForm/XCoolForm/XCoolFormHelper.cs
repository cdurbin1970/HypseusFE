using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;


namespace XCoolForm
{
    internal class XCoolFormHelper
    {

        public static GraphicsPath RoundRect(RectangleF r, float r1, float r2, float r3, float r4)
        {
            float x = r.X, y = r.Y, w = r.Width, h = r.Height;
            GraphicsPath rr = new GraphicsPath();
            rr.AddBezier(x, y + r1, x, y, x + r1, y, x + r1, y);
            rr.AddLine(x + r1, y, x + w - r2, y);
            rr.AddBezier(x + w - r2, y, x + w, y, x + w, y + r2, x + w, y + r2);
            rr.AddLine(x + w, y + r2, x + w, y + h - r3);
            rr.AddBezier(x + w, y + h - r3, x + w, y + h, x + w - r3, y + h, x + w - r3, y + h);
            rr.AddLine(x + w - r3, y + h, x + r4, y + h);
            rr.AddBezier(x + r4, y + h, x, y + h, x, y + h - r4, x, y + h - r4);
            rr.AddLine(x, y + h - r4, x, y + r1);
            return rr;
        }
        public static ColorBlend ColorMix(List<Color> clrMix, bool bTitleBar)
        {
            if (clrMix.Count != 5) throw new ArgumentException("The number of colors must be equal to 5.");

            ColorBlend blend = new ColorBlend();
            int lIdx = 0;

            blend.Colors = new Color[clrMix.Count];
            if (bTitleBar)
                blend.Positions = new float[] { 0.0f, 0.03f, 0.4f, 0.6f, 1.0f };
            else
                blend.Positions = new float[] { 0.0f, 0.2f, 0.8f, 0.9f, 1.0f };

            foreach (Color clr in clrMix){
                blend.Colors[lIdx] = clr;
                lIdx++;
            }
            
            return blend;
        }
    
    }
}
