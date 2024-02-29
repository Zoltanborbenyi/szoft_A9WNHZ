namespace veletlen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        { 
            
     
            for (int s = 0; s < 100; s++)
            {
                Button gomb = new Button();
                Controls.Add(gomb);
                gomb.Width = rnd.Next(0, 50);
                gomb.Height = rnd.Next(0, 50);
                gomb.Left = rnd.Next(0, ClientRectangle.Width-gomb.Width);
                gomb.Top = rnd.Next(0, ClientRectangle.Height - gomb.Height);

                gomb.BackColor = Color.FromArgb(rnd.Next(0,225), rnd.Next(0,225), rnd.Next(0,225));
            }
        }
    }
}