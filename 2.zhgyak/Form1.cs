using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace _2.zhgyak
{
    public partial class Form1 : Form
    {
        BindingList<Class1> Lista = new BindingList<Class1>();
        public Form1()
        {
            InitializeComponent();
        }
        int legnagyobb = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            class1BindingSource.DataSource = Lista;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("hajo.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tömb = csv.GetRecords<Class1>();
                foreach (var item in tömb)
                { Lista.Add(item); }
                sr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecord(Lista);
                    sw.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {if (class1BindingSource.Current == null)
            {
                MessageBox.Show("szar");
                return;
            }
            if (MessageBox.Show("asd", "Asd", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                class1BindingSource.RemoveCurrent();
            }

            
        }
    }
}
