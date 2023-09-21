using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_app_1.Models;
using TODO;

namespace test_app_1
{
    public partial class Nota : Form
    {

        private List<Todo> AllTodos = new();

        private bool IsEditing { get; set; } = false;

        private int rowId { get; set; } = 0;

        public Nota()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                Todo todo = AllTodos[rowId];

                todo.Titulo = saveDataTextBox.Text;
                todo.Descripcion = richTextBox1.Text;
                todo.Estatus = radioButton1.Checked ? "Por Hacer" : "Completado";

                AllTodos[rowId] = todo;

                saveDataTextBox.Text = "";
                richTextBox1.Text = "";
                radioButton1.Checked = true;

                IsEditing = false;
                rowId = 0;
            }
            else
            {
                Todo todo = new Todo
                {

                    Titulo = saveDataTextBox.Text,
                    Descripcion = richTextBox1.Text,
                    Estatus = radioButton1.Checked ? "Por Hacer" : "Completado",

                };

                AllTodos.Add(todo);

                saveDataTextBox.Text = "";
                richTextBox1.Text = "";
                radioButton1.Checked = true;

            }


            LoadData();


            /*StreamWriter text = new StreamWriter(Application.StartupPath + "\\text\\" + saveDataTextBox.Text + " " + ".txt");
            text.WriteLine("Titulo:" + " " + saveDataTextBox.Text);
            text.WriteLine(richTextBox1.Text);
            text.WriteLine("Estatus:" + " " + "Por Hacer");

            text.Close();*/
        }


        private void Nota_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            ListToDatatableConvert convert = new ListToDatatableConvert();
            DataTable dataTable = convert.ToDataTable(AllTodos);
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveDataTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Todo todo = AllTodos[e.RowIndex];

            saveDataTextBox.Text = todo.Titulo;
            richTextBox1.Text = todo.Descripcion;

            rowId = e.RowIndex;
            IsEditing = true;
        }
    }

}
