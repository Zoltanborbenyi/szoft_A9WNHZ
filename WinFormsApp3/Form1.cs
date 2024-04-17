using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        BindingList<Class1> bindingLis = new();
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
                    bindingLis.Add(item);
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
            class1BindingSource.DataSource = bindingLis;
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

                    csv.WriteRecords(bindingLis);
                    sw.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
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
            Form2 form2 = new Form2();
            //form2.EgySor = class1BindingSource.Current as Class1;
            //form2.Show();

            if (form2.ShowDialog() == DialogResult.OK)
            {
                class1BindingSource.Add(form2.EgySor);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.szerk = class1BindingSource.Current as Class1;
            form3.Show();
        }
    }
}
