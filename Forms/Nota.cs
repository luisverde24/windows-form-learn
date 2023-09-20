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
using TODO;

namespace test_app_1
{
    public partial class Nota : Form
    {

        private List<Todo> TodoList = new List<Todo>();

        public Nota()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {



            if (radioButton1.Checked == true)
            {
                StreamWriter text = new StreamWriter(Application.StartupPath + "\\text\\" + saveDataTextBox.Text + " " + ".txt");
                text.WriteLine("Titulo:" + " " + saveDataTextBox.Text);
                text.WriteLine(richTextBox1.Text);
                text.WriteLine("Estatus:" + " " + "Por Hacer");

                text.Close();

                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = saveDataTextBox.Text;
                dataGridView1.Rows[n].Cells[1].Value = richTextBox1.Text;
                dataGridView1.Rows[n].Cells[2].Value = "Por Hacer";
                // StreamReader textrender = new StreamReader(Application.StartupPath + "\\text\\" + saveDataTextBox.Text + " " + ".txt");

                //lbltext.Text = textrender.ReadToEnd();
                //textrender.Close();

            }

            else if (radioButton2.Checked == true)
            {
                StreamWriter text = new StreamWriter(Application.StartupPath + "\\text\\" + saveDataTextBox.Text + " " + ".txt");
                text.WriteLine("Titulo:" + " " + saveDataTextBox.Text);
                text.WriteLine(richTextBox1.Text);
                text.WriteLine("Estatus:" + " " + "Completado");

                text.Close();

                //StreamReader textrender = new StreamReader(Application.StartupPath + "\\text\\" + saveDataTextBox.Text + " " + ".txt");

                //textrender.Close();

                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = saveDataTextBox.Text;
                dataGridView1.Rows[n].Cells[1].Value = richTextBox1.Text;
                dataGridView1.Rows[n].Cells[2].Value = "Por Completar";

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

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void Nota_Load(object sender, EventArgs e)
        {
            List<Todo> list = new List<Todo>();

            Todo todo1 = new Todo
            {
                Titulo = "",
                Descripcion = "",
                Estatus = "",
            };

            Todo todo2 = new Todo
            {
                Titulo = "",
                Descripcion = "",
                Estatus = "",
            };

            Todo todo3 = new Todo
            {
                Titulo = "",
                Descripcion = "",
                Estatus = "",
            };

            list.Add(todo1);
            list.Add(todo2);
            list.Add(todo3);

            TodoList.AddRange(list);
        }

        public string Value { get; set; }
    }
}
