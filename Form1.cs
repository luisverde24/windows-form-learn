using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_app_1.utils;

namespace test_app_1.apps
{
    public partial class calculator : Form
    {

        private float Value { get; set; } = 0;
        private CalculatorTypes Type { get; set; } = CalculatorTypes.NONE;


        double valor1 = 0;
        double valor2 = 0;


        public calculator()
        {
            InitializeComponent();
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            switch (e.KeyChar)
            {
                case '-':
                    HandleMinus();
                    break;
                case '+':
                    HandlePlus();
                    break;
                case '*':
                    HandleMulti();
                    break;
                case '/':
                    HandleDivision();
                    break;
                case 'C':
                    HandleDelete();
                    break;

                default:
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    break;

            }
        }

        /// <summary>
        /// Maneja el boton de suma
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_plus_Click(object sender, EventArgs e)
        {
            HandlePlus();
        }

        private void btn_minium_Click(object sender, EventArgs e)
        {
            HandleMinus();
        }

        private void HandleMinus()
        {
            var values = textBox1.Text.Split('-').ToList();

            if (float.TryParse(values[values.Count - 1], out float amount))
            {
                Value -= amount;
            }

            lblAmount.Text = Value.ToString();

            textBox1.Text += "";
            textBox1.Text = "";
        }

        private void HandlePlus()
        {
            var values = textBox1.Text.Split('+').ToList();

            if (float.TryParse(values[values.Count - 1], out float amount))
            {
                Value += amount;
            }

            lblAmount.Text = Value.ToString();

            textBox1.Text += "+";
            textBox1.Text = "";
        }

        private void btn_Multi_Click(object sender, EventArgs e)
        {
            HandleMulti();
        }

        private void HandleMulti()
        {
            var values = textBox1.Text.Split('x').ToList();

            if (float.TryParse(values[values.Count - 1], out float amount))
            {
                Value *= amount;
            }

            lblAmount.Text = Value.ToString();

            textBox1.Text += "x";
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HandleDivision();
        }

        private void HandleDivision()
        {
            var values = textBox1.Text.Split('/').ToList();

            if (float.TryParse(values[values.Count - 1], out float amount) && amount != 0)
            {
                Value = Value / amount;

            }

            textBox1.Text = "";
            lblAmount.Text = Value.ToString();
        }

        /// <summary>
        /// Muestra el resultado de las operaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_result_Click(object sender, EventArgs e)
        {

            if (valor2 == 0)
            {
                textBox1.Text = textBox1 + "=";
                valor1 = 0;
                valor2 = 0;
                double resultado = valor1 + valor2;
                textBox1.Text = Convert.ToString(resultado);
                textBox1.Text = "";

            }

        }



        private void HandleDelete()
        {
            textBox1.Text = string.Empty;
            lblAmount.Text = string.Empty;
            Value = 0;
        }

        private void btn_supr(object sender, KeyEventArgs e)
        {
            HandleDelete();
        }

        private void btn_plusKeyDown(object sender, KeyEventArgs e)
        {
            HandlePlus();

        }
        private void btn_Multi_KeyDown(object sender, KeyEventArgs e)
        {
            HandleMulti();
        }

    }
}
