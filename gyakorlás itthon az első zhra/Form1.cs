namespace gyakorlás_itthon_az_első_zhra
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
                    vill gomg = new vill();
                    Controls.Add(gomg);
                    gomg.Width = 40;
                    gomg.Height = 40;
                    gomg.Left = i * 40;
                    gomg.Top = o * 40;
                    gomg.Text = ((o+1) * (i+1)).ToString();
                }

            }
        }
    }
}
