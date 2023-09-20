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

            if (radioButton1.Checked == true )
            {
                StreamWriter text = new StreamWriter(Application.StartupPath + "\\text\\" + saveDataTextBox.Text + " " + ".txt");
                text.WriteLine("Titulo:" + " " + saveDataTextBox.Text);
                text.WriteLine(richTextBox1.Text);
                text.WriteLine( "Estatus:" + " " + "Por Hacer");

                text.Close();

                StreamReader textrender = new StreamReader(Application.StartupPath + "\\text\\" + saveDataTextBox.Text + " " + ".txt");

                lbltext.Text = textrender.ReadToEnd();
                textrender.Close();

            }

            else if (radioButton2.Checked == true)
            {
                StreamWriter text = new StreamWriter(Application.StartupPath + "\\text\\" + saveDataTextBox.Text + " " + ".txt");
                text.WriteLine( "Titulo:" + " " + saveDataTextBox.Text);
                text.WriteLine(richTextBox1.Text);
                text.WriteLine( "Estatus:" + " " + "Completado");

                text.Close();

                StreamReader textrender = new StreamReader(Application.StartupPath + "\\text\\" + saveDataTextBox.Text + " " + ".txt");

                lbltext.Text = textrender.ReadToEnd();
                textrender.Close();

            }


        }

        private void label2_Click(object sender, EventArgs e, string value)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbltext_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public string Value { get; set; }
    }
}
