﻿namespace test_app_1
{
    partial class Nota
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Guardar = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            saveDataTextBox = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 278);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 58;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(390, 199);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Guardar
            // 
            Guardar.Location = new Point(325, 245);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(77, 23);
            Guardar.TabIndex = 1;
            Guardar.Text = "Guardar";
            Guardar.UseVisualStyleBackColor = true;
            Guardar.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(21, 110);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(381, 96);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 29);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 6;
            label1.Text = "Welcome to Jumaji";
            // 
            // saveDataTextBox
            // 
            saveDataTextBox.Location = new Point(21, 81);
            saveDataTextBox.Name = "saveDataTextBox";
            saveDataTextBox.Size = new Size(381, 23);
            saveDataTextBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 63);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 9;
            label2.Text = "Titulo:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(21, 212);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 56);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estatus";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(114, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(91, 19);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Completado";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(14, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(77, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Por Hacer";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(242, 245);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Borrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Nota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 491);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(saveDataTextBox);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(Guardar);
            Controls.Add(dataGridView1);
            Name = "Nota";
            Text = "Nota";
            Load += Nota_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Guardar;
        private RichTextBox richTextBox1;
        private Label label1;
        private TextBox saveDataTextBox;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
    }
}