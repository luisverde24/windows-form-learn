using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_app_1.Models;
using TODO;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json;
using System.Text.Json;

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            AllTodos.RemoveAt(rowId);

            saveDataTextBox.Text = "";
            richTextBox1.Text = "";
            radioButton1.Checked = true;


            rowId = 0;
            button1.Enabled = false;

            LoadData();

        }

        private void convertText()
        {
            // Mandar formato Txt
            if (radioButton1.Checked == true)
            {

                StreamWriter text = new StreamWriter(Application.StartupPath + "\\text\\" + saveDataTextBox.Text + " " + ".txt");
                text.WriteLine("Titulo:" + " " + saveDataTextBox.Text);
                text.WriteLine(richTextBox1.Text);
                text.WriteLine("Estatus:" + " " + "Por Hacer");

                text.Close();

            }
            else if (radioButton2.Checked == true)
            {
                StreamWriter text = new StreamWriter(Application.StartupPath + "\\text\\" + saveDataTextBox.Text + " " + ".txt");
                text.WriteLine("Titulo:" + " " + saveDataTextBox.Text);
                text.WriteLine(richTextBox1.Text);
                text.WriteLine("Estatus:" + " " + "Completado");

                text.Close();
            }
            // Fin
        }

        private void Json()

        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            //string JsonString = JsonConvert.SerializeObject(AllTodos);
            //Console.WriteLine(JsonString);
            //File.WriteAllText(rutaArchivo, JsonString);

            // var rutaArchivo = @"C:\Users\LuisGVerde\Desktop\AAA.json
            // 
            string test = File.ReadAllText(@"C:\\Users\\LuisGVerde\\Desktop\\AAA.json");
            var dat = Newtonsoft.Json.JsonConvert.DeserializeObject<List<dataJson>>(test);


            System.Console.WriteLine(dat);




        }

        private void IsNullEmptyInput()
        {
            //validacion
            if ((string.IsNullOrEmpty(saveDataTextBox.Text)))
            {
                MessageBox.Show("Pon Titulo");
                return;
            }
            if ((string.IsNullOrEmpty(richTextBox1.Text)))
            {
                MessageBox.Show("Llena la Descripcion");
                return;
            }
            //fin
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            convertText();


            IsNullEmptyInput();

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

                Json();

                AllTodos.Add(todo);

                saveDataTextBox.Text = "";
                richTextBox1.Text = "";
                radioButton1.Checked = true;

            }


            LoadData();

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

        /// <summary>
        /// Seleccionar una celda 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Todo tarea = AllTodos[e.RowIndex];

            saveDataTextBox.Text = tarea.Titulo;
            richTextBox1.Text = tarea.Descripcion;
            rowId = e.RowIndex;
            IsEditing = true;

            button1.Enabled = true;

        }
    }

    public class dataJson
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Estatus { get; set; }

    }

}
