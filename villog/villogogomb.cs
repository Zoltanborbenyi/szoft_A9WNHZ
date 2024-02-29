using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace villog
{
    internal class Villogogomb : Button
    {
        public int szamolo = 0;
        public Villogogomb()
        {
            MouseEnter += Villogogomb_MouseEnter;
            MouseLeave += Villogogomb_MouseLeave;
            MouseClick += Villogogomb_MouseClick;
        }

        private void Villogogomb_MouseClick(object? sender, MouseEventArgs e)
        {

            
            if (szamolo == 5) { szamolo = 1; Text = szamolo.ToString(); }
            else { szamolo++; Text = szamolo.ToString(); }
        }

        private void Villogogomb_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void Villogogomb_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
