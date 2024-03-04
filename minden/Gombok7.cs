using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minden
{
    internal class Gombok : Button
    { Random rnd = new Random();
        public Gombok()
        {
            Height = 30;
            Width = 30;
            MouseLeave += Gombok_MouseLeave;
            MouseEnter += Gombok_MouseEnter;
        }

        private void Gombok_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Black;
        }

        private void Gombok_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }
    }
}
