using CsvHelper;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms.Design;

namespace asdasdasd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BindingList<Class1> lista = new();
        private void Form1_Load(object sender, EventArgs e)
        {
            class1BindingSource.DataSource = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("hajo.txt");
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
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
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
            if (class1BindingSource.Current == null)
            {
                return;
            }
            if (MessageBox.Show("törlöd?", "a kiválasztottat törlöd", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                class1BindingSource.RemoveCurrent();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (class1BindingSource.Current == null) return;
            FormAddNew formEdit = new FormAddNew();

            formEdit.newClass1 = (Class1)class1BindingSource.Current;
            formEdit.Show();
        }
    }
}
