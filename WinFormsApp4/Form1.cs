using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        BindingList<Class1> lista = new BindingList<Class1>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("futok.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tömb = csv.GetRecords<Class1>();
                foreach (var item in tömb)
                {
                    lista.Add(item);
                }

                sr.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            class1BindingSource.DataSource = lista;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);


                    sw.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (class1BindingSource.Current == null) return;
            if (MessageBox.Show("asd", "asd", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                class1BindingSource.RemoveCurrent();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
