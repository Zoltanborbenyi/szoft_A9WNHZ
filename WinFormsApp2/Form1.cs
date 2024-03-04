namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    Gombok gomb = new Gombok();
                    Controls.Add(gomb);
                    gomb.Top = i * 30;
                    gomb.Left = oszlop * 30;
                   
                    if (i < oszlop) { continue; }
                    else
                    {
                        Controls.Add(gomb);
                    }
                }
            }
        }
    }
}
