using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class Gombok : Button
    {
        int szam = 0;
        public Gombok()
        {
            Width = 30;
            Height = 30;
            MouseLeave += Gombok_MouseLeave;
            MouseEnter += Gombok_MouseEnter;
            MouseClick += Gombok_MouseClick;
        }

        private void Gombok_MouseClick(object? sender, MouseEventArgs e)
        {
            if (szam == 5) { szam = 0}
            else
            {
                szam++
            }  
        }
        Random rnd = new Random();
        private void Gombok_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.FromArgb(rnd.Next(0,255), rnd.Next(0, 255), rnd.Next(0, 255));
        }

        private void Gombok_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }
    }
}
