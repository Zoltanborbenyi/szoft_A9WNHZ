using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BindingList<Class1> lista = new BindingList<Class1>();
        private void Form1_Load(object sender, EventArgs e)
        {
            class1BindingSource.DataSource = lista;
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

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(lista);
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
            form2.ShowDialog();
            form2.egysor = class1BindingSource.Current as Class1;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            if (form3.ShowDialog() == DialogResult.OK)
            {
                class1BindingSource.Add(form3.egysor);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(class1BindingSource.Current == null) { return; } 
            double minimum = double.PositiveInfinity;
            foreach (var item in lista)
            {
                if (item.EredmenyPerc < minimum & item.Nemzetiseg == "UK")
                {
                    minimum = item.EredmenyPerc;
                }

            }
            MessageBox.Show(minimum.ToString());
        }
    }
}
