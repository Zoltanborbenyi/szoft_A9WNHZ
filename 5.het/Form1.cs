namespace _5.het
{
    public partial class Form1 : Form
    {
        List<Kérdés> Összeskerdes;
        List<Kérdés> Aktualiskerdesek = new List<Kérdés>();
        int megjelenitettkerdesszama = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Összeskerdes = Kerdesekbeolvasasa();
            for (int i = 0; i < 7; i++)
            {
                Aktualiskerdesek.Add(Összeskerdes[0]);
                Összeskerdes.RemoveAt(0);

            }
            dataGridView1.DataSource = Aktualiskerdesek;
            Kérdésmegjelenítése(Aktualiskerdesek[megjelenitettkerdesszama]);
        }
        void Kérdésmegjelenítése(Kérdés kérdés)
        {
            label1.Text = kérdés.KérdésSzöveg;
            textBox1.Text = kérdés.Válasz1;
            textBox2.Text = kérdés.Válasz2;
            textBox3.Text = kérdés.Válasz3;
            if (string.IsNullOrEmpty(kérdés.URL))
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kérdés.URL);
            }
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
        }

        List<Kérdés> Kerdesekbeolvasasa()
        {
            List<Kérdés> kérdések = new();
            StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);

            while (!sr.EndOfStream)
            {


                string sor = sr.ReadLine();
                string[] tömb = sor.Split("\t");
                Kérdés k = new();
                if (tömb.Length != 7) continue;
                k.KérdésSzöveg = tömb[1].ToLower();
                k.Válasz1 = tömb[2].Trim('"');
                k.Válasz2 = tömb[3];
                k.Válasz3 = tömb[4];
                k.URL = tömb[5];

                int x = 0;
                int.TryParse(tömb[6], out x);
                k.HelyesVálasz = x;

                kérdések.Add(k);
            }
            sr.Close();
            return kérdések;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            megjelenitettkerdesszama++;
            if (megjelenitettkerdesszama == 7)
            {
                megjelenitettkerdesszama = 0;
            }
            Kérdésmegjelenítése(Aktualiskerdesek[megjelenitettkerdesszama]);

        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Red;

            textBox3.BackColor = Color.Red;
            if (Aktualiskerdesek[megjelenitettkerdesszama].HelyesVálasz == 3)
            {
                textBox3.BackColor = Color.Green;
                Aktualiskerdesek[megjelenitettkerdesszama].HelyesVálaszokSzáma++;
            }
            else { Aktualiskerdesek[megjelenitettkerdesszama].HelyesVálaszokSzáma = 0; }

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Red;

            textBox2.BackColor = Color.Red;
            if (Aktualiskerdesek[megjelenitettkerdesszama].HelyesVálasz == 2)
            {
                textBox2.BackColor = Color.Green;
                Aktualiskerdesek[megjelenitettkerdesszama].HelyesVálaszokSzáma++;
            }
            else { Aktualiskerdesek[megjelenitettkerdesszama].HelyesVálaszokSzáma = 0; }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
            if (Aktualiskerdesek[megjelenitettkerdesszama].HelyesVálasz==1)
            {
                textBox1.BackColor = Color.Green;
                Aktualiskerdesek[megjelenitettkerdesszama].HelyesVálaszokSzáma++;
            }
            else { Aktualiskerdesek[megjelenitettkerdesszama].HelyesVálaszokSzáma = 0; }
        }
    }
}