using Microsoft.VisualBasic;

namespace kigyo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int fej_x = 100;
        int fej_y = 100;
        int irány_x = 1;
        int irány_y = 0;
        int lépészám = 0;
        int hossz = 5;
        int alma = 100;
        List<KígyóElem> Kígyó = new List<KígyóElem> ();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lépészám++;
             
            fej_x += irány_x * KígyóElem.Méret;
            fej_y += irány_y * KígyóElem.Méret;
            KígyóElem eleje = new KígyóElem();
            eleje.Top = fej_y;
            eleje.Left = fej_x;
            foreach (object item in Controls)
            {
                if (item is KígyóElem)
                {
                    KígyóElem k = (KígyóElem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        MessageBox.Show("vége van");
                        return;
                    }
                }
            }
            if (lépészám % 2 == 0) { eleje.BackColor = Color.Red; }
            

            if (Kígyó.Count > hossz)
            {
                Kígyó.RemoveAt(0);
                Controls.RemoveAt(0);
            }
            Controls.Add(eleje);
            Kígyó.Add(eleje);



        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }
            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }
            if (e.KeyCode == Keys.Left)
            {
                irány_x = -1;
                irány_y = 0;
            }
            if (e.KeyCode == Keys.Right)
            {
                irány_x = 1;
                irány_y = 0;
            }
            if (e.KeyCode == Keys.Space) { timer1.Interval = 100; }
            if(e.KeyCode == Keys.Enter) {
                Random rnd = new Random();
                alma alma = new alma();
                alma.Top = rnd.Next(0, 300);
                alma.Left = rnd.Next(0, 300);
                Controls.Add(alma);
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) { timer1.Interval = 500; }
        }
    }
}
