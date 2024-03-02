namespace _3.feladat
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
                for (int o = 0; o < 10; o++)
                {
                    Szamol gomg = new Szamol();
                    Controls.Add(gomg);
                    gomg.Left = i * 40;
                    gomg.Top = o * 40;
                }

            }
        }
    }
}
