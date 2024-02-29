namespace villog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int s = 0; s < 20; s++)
            {
                for (int o = 0; o < 20; o++)
                {
                    Villogogomb gomb = new Villogogomb();
                    Controls.Add(gomb);
                    gomb.BackColor = Color.White;
                    gomb.Height = 20;
                    gomb.Width = 20;
                    gomb.Left = o * 20;
                    gomb.Top = s * 20;
                }

            }


        }
    }
}