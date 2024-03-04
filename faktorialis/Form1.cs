namespace faktorialis
{
    public partial class Form1 : Form
    {
        public object DataGridView1 { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Sorok> lista = new List<Sorok>();
            for (int sor = 0; sor < 30; sor++)
            {
                Sorok újsor = new Sorok();
                újsor.sorok = sor;
                újsor.ertek = Fibanachi(sor);
                lista.Add(újsor);

            }

            dataGridView1.DataSource = lista;

        }

        int Fibanachi(int n)
        {
            if (n == 0) { return 0; }
            if (n == 1) { return 1; }
            else
            {
                return (Fibanachi(n - 1) + Fibanachi(n - 2));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal szam = decimal.Parse(textBox1.Text);
           textBox2.Text = (szam*2).ToString();
        }
    }
}
