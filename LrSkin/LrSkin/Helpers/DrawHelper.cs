using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LrSkin.Helpers
{
    internal static class DrawHelper
    {
        public static GraphicsPath GetRoundRect(Rectangle rec, float edgeRadius)
        {
            return GetRoundRect(rec.X, rec.Y, rec.Width, rec.Height, edgeRadius);
        }

        public static GraphicsPath GetRoundRect(RectangleF rec, float edgeRadius)
        {
            return GetRoundRect(rec.X, rec.Y, rec.Width, rec.Height, edgeRadius);
        }

        public static GraphicsPath GetRoundRect(float x, float y, float width, float height, float edgeRadius)
        {
            var gp = new GraphicsPath();
            gp.AddArc(x + width - (edgeRadius * 2), y, edgeRadius * 2, edgeRadius * 2, 270, 90);
            gp.AddArc(x + width - (edgeRadius * 2), y + height - (edgeRadius * 2), edgeRadius * 2, edgeRadius * 2, 0, 90);
            gp.AddArc(x, y + height - (edgeRadius * 2), edgeRadius * 2, edgeRadius * 2, 90, 90);
            gp.AddArc(x, y, edgeRadius * 2, edgeRadius * 2, 180, 90);
            gp.CloseFigure();
            return gp;
        }




    }
}
