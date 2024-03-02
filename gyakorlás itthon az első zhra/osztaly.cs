using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlás_itthon_az_első_zhra
{
    internal class osztaly : Button
    {
        public osztaly()
        {
            MouseEnter += Osztaly_MouseEnter;
            MouseLeave += Osztaly_MouseLeave;
        }

        private void Osztaly_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void Osztaly_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Red;
        }
    }
}
