namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

<<<<<<< HEAD

        private void Form1_Load(object sender, EventArgs e)
        {

=======
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    Villogszamol gomb = new Villogszamol();
                    gomb.Left = sor * 30;
                    gomb.Top = oszlop * 30;
                    if (oszlop < sor)
                    {
                        continue;
                    }
                    else
                    {
                        Controls.Add(gomb);
                    }
                }
            }
>>>>>>> 53c39ce7b7d31be7f2ebf138aac61ccd951eeb30
        }
    }
}
