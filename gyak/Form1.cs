namespace gyak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Class1> lista = new List<Class1>();
            for (int i = 0; i < 10; i++)
            {
                Class1 újsor = new Class1();
                újsor.vonal = i;
                újsor.oszlop = Fibanachi(i);
                lista.Add(újsor);
            }
            dataGridView1.DataSource = lista;
        }
        int Fibanachi(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibanachi(n - 1) + Fibanachi(n - 2);
        }
    }
}
