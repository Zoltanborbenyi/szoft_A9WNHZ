using System.Dynamic;

namespace random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random veletlen = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 99; i++)
            {
                Button gomb = new Button();
                Controls.Add(gomb);
                int Height = veletlen.Next(10,50);
                int Width = veletlen.Next(10, 50);
                gomb.Height = Height;
                gomb.Width = Width;
                gomb.Left = veletlen.Next(0, ClientSize.Width- gomb.Width);
                gomb.Top = veletlen.Next(0, ClientSize.Height-gomb.Height);
                gomb.BackColor = Color.FromArgb(veletlen.Next(0, 255), veletlen.Next(0, 255), veletlen.Next(0, 255));
                
            }
        }
    }
}
