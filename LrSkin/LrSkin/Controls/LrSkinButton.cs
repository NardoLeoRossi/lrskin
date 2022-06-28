using LrSkin.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LrSkin.Controls
{
    public class LrSkinButton: Button
    {
        #region Properties
        private float _edgeRadius;
        [DefaultValue(4), Category("LR Skin"), Description("Representa o raio da borda do controle")]
        public float EdgeRadius 
        { 
            get => _edgeRadius;
            set
            {
                _edgeRadius = value;
                Invalidate();
            }
        }

        #endregion



        #region Events
        protected override void OnPaint(PaintEventArgs pevent)
        {
            var g = pevent.Graphics;

            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Parent.BackColor);

            //Retangulo base
            RectangleF buttonRectF = new RectangleF(ClientRectangle.Location, ClientRectangle.Size);
            buttonRectF.X -= 0.5f;
            buttonRectF.Y -= 0.5f;
            GraphicsPath buttonPath = DrawHelper.GetRoundRect(buttonRectF, 4);

    


            base.OnPaint(pevent);
        }

        #endregion




    }
}
