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
        int ir�ny_x = 1;
        int ir�ny_y = 0;
        int l�p�sz�m = 0;
        int hossz = 5;
        int alma = 100;
        List<K�gy�Elem> K�gy� = new List<K�gy�Elem> ();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            l�p�sz�m++;
             
            fej_x += ir�ny_x * K�gy�Elem.M�ret;
            fej_y += ir�ny_y * K�gy�Elem.M�ret;
            K�gy�Elem eleje = new K�gy�Elem();
            eleje.Top = fej_y;
            eleje.Left = fej_x;
            foreach (object item in Controls)
            {
                if (item is K�gy�Elem)
                {
                    K�gy�Elem k = (K�gy�Elem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        MessageBox.Show("v�ge van");
                        return;
                    }
                }
            }
            if (l�p�sz�m % 2 == 0) { eleje.BackColor = Color.Red; }
            

            if (K�gy�.Count > hossz)
            {
                K�gy�.RemoveAt(0);
                Controls.RemoveAt(0);
            }
            Controls.Add(eleje);
            K�gy�.Add(eleje);



        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                ir�ny_y = 1;
                ir�ny_x = 0;
            }
            if (e.KeyCode == Keys.Up)
            {
                ir�ny_y = -1;
                ir�ny_x = 0;
            }
            if (e.KeyCode == Keys.Left)
            {
                ir�ny_x = -1;
                ir�ny_y = 0;
            }
            if (e.KeyCode == Keys.Right)
            {
                ir�ny_x = 1;
                ir�ny_y = 0;
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
