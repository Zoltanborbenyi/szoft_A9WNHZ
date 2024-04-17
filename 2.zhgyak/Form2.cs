using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.zhgyak
{
    public partial class Form2 : Form
    {
        public Class1 újhajo = new Class1();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            class1BindingSource.DataSource = újhajo;

        }
    }
}
