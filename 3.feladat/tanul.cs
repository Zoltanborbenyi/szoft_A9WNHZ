using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.feladat
{
    internal class Szamol : Button
    {
        int szam;
        public Szamol()
        {
            Width = 20;
            Height = 20;
            szam = 0;
            MouseClick += Szamol_MouseClick;
        

        }


        private void Szamol_MouseClick(object? sender, MouseEventArgs e)
        {
      
            if (szam == 5)
            { szam++;
                szam = 1;
            }
            else { szam++; }
            Text = szam.ToString();
        }
    }
}
