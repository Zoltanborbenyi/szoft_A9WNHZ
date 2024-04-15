using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace gyakzh2
{
    public partial class Form1 : Form
    {
        BindingList<Class1> list = new();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("hajozasi_szabalyzat_coma.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var asd = csv.GetRecord<Class1>();

                foreach (var item in asd)
                {
                    list.Add(item);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
