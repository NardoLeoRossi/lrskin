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
        private int _edgeRadius;

        /// <summary>
        /// Representa o raio da borda do controle.
        /// </summary>
        [DefaultValue(true)]
        [Category("LR Skin")]
        public int EdgeRadius { get; set; }




    }
}
