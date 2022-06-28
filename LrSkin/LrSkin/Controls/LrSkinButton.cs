using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LrSkin.Controls
{
    public class LrSkinButton: Button
    {
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




    }
}
