using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.zh_2
{
    internal class vill : Button
    {
        public vill()
        {
            Height = 20;
            Width = 20;
            MouseClick += Vill_MouseClick;
        }

        private void Vill_MouseClick(object? sender, MouseEventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
