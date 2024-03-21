using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kigyo
{
    internal class alma : PictureBox
    {
        public static int Méret = 20;
        public alma()
        {
            Width = alma.Méret;
            Height = alma.Méret;
            BackColor = Color.Orange;
        }

    }
}
