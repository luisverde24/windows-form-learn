using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_app_1
{
    public partial class Nota : Form
    {
        public Nota()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter text = new StreamWriter(Application.StartupPath + "\\text\\" + richTextBox1.Text + ".txt");
            text.WriteLine(lbltext.Text + " " + richTextBox1);


        }

        private void label2_Click(object sender, EventArgs e, string value)
        {
            lbltext.Text = value;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbltext.Text = Value;
        }

        public string Value { get; set; }
    }
}
