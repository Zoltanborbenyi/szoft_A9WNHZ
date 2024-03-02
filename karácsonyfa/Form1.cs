namespace karácsonyfa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int sor = 0; sor < 10; sor++)
            {
                
                for (int oszlop = 0; oszlop < 10; oszlop++)

                { Button gomb = new Button();
                    gomb.Top = oszlop * 20;
                    gomb.Left = sor * 20;
                    gomb.Width = 20;
                    gomb.Height = 20;
                    if (oszlop < sor)
                    {
                        continue;
                    }
                    else { Controls.Add(gomb);
                    } 
                }
            }
        }
    }
}
