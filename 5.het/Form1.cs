namespace _5.het
{
    public partial class Form1 : Form
    {
        List<K�rd�s> �sszeskerdes;
        List<K�rd�s> Aktualiskerdesek = new List<K�rd�s>();
        int megjelenitettkerdesszama = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            �sszeskerdes = Kerdesekbeolvasasa();
            for (int i = 0; i < 7; i++)
            {
                Aktualiskerdesek.Add(�sszeskerdes[0]);
                �sszeskerdes.RemoveAt(0);

            }
            dataGridView1.DataSource = Aktualiskerdesek;
            K�rd�smegjelen�t�se(Aktualiskerdesek[megjelenitettkerdesszama]);
        }
        void K�rd�smegjelen�t�se(K�rd�s k�rd�s)
        {
            label1.Text = k�rd�s.K�rd�sSz�veg;
            textBox1.Text = k�rd�s.V�lasz1;
            textBox2.Text = k�rd�s.V�lasz2;
            textBox3.Text = k�rd�s.V�lasz3;
            if (string.IsNullOrEmpty(k�rd�s.URL))
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + k�rd�s.URL);
            }
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
        }

        List<K�rd�s> Kerdesekbeolvasasa()
        {
            List<K�rd�s> k�rd�sek = new();
            StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);

            while (!sr.EndOfStream)
            {


                string sor = sr.ReadLine();
                string[] t�mb = sor.Split("\t");
                K�rd�s k = new();
                if (t�mb.Length != 7) continue;
                k.K�rd�sSz�veg = t�mb[1].ToLower();
                k.V�lasz1 = t�mb[2].Trim('"');
                k.V�lasz2 = t�mb[3];
                k.V�lasz3 = t�mb[4];
                k.URL = t�mb[5];

                int x = 0;
                int.TryParse(t�mb[6], out x);
                k.HelyesV�lasz = x;

                k�rd�sek.Add(k);
            }
            sr.Close();
            return k�rd�sek;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            megjelenitettkerdesszama++;
            if (megjelenitettkerdesszama == 7)
            {
                megjelenitettkerdesszama = 0;
            }
            K�rd�smegjelen�t�se(Aktualiskerdesek[megjelenitettkerdesszama]);

        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Red;

            textBox3.BackColor = Color.Red;
            if (Aktualiskerdesek[megjelenitettkerdesszama].HelyesV�lasz == 3)
            {
                textBox3.BackColor = Color.Green;
                Aktualiskerdesek[megjelenitettkerdesszama].HelyesV�laszokSz�ma++;
            }
            else { Aktualiskerdesek[megjelenitettkerdesszama].HelyesV�laszokSz�ma = 0; }

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Red;

            textBox2.BackColor = Color.Red;
            if (Aktualiskerdesek[megjelenitettkerdesszama].HelyesV�lasz == 2)
            {
                textBox2.BackColor = Color.Green;
                Aktualiskerdesek[megjelenitettkerdesszama].HelyesV�laszokSz�ma++;
            }
            else { Aktualiskerdesek[megjelenitettkerdesszama].HelyesV�laszokSz�ma = 0; }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
            if (Aktualiskerdesek[megjelenitettkerdesszama].HelyesV�lasz==1)
            {
                textBox1.BackColor = Color.Green;
                Aktualiskerdesek[megjelenitettkerdesszama].HelyesV�laszokSz�ma++;
            }
            else { Aktualiskerdesek[megjelenitettkerdesszama].HelyesV�laszokSz�ma = 0; }
        }
    }
}