using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lfpersonal
{
    public partial class Form1 : Form
    {
        public static string un;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=null && radioButton1.Checked)
            {
                un = textBox1.Text;
                Form2 ob = new Form2();
                ob.Show();
                this.Hide();
            }
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.rem = textBox1.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text= Properties.Settings.Default.rem;
        }
    }
}
