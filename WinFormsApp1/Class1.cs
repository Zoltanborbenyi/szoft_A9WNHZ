using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Villogszamol : Button
    {   

        int szam;
        Random rng = new Random();
        public Villogszamol()
        {
            MouseLeave += Villogszamol_MouseLeave;
            MouseEnter += Villogszamol_MouseEnter;
            MouseClick += Villogszamol_MouseClick;
            Width = 30;
            Height = 30;
        }

        private void Villogszamol_MouseClick(object? sender, MouseEventArgs e)
        {
            if (szam==5)
            {
                szam = 0;
                Text = szam.ToString();
            }
            else
            {
                szam++;
                Text = szam.ToString();
            }
        }

        private void Villogszamol_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.FromArgb(rng.Next(0, 244), rng.Next(0, 255), rng.Next(0, 255));
        }

        private void Villogszamol_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = Color.FromArgb(rng.Next(0, 244), rng.Next(0, 255), rng.Next(0, 255));
        }
    }
}
