namespace test_app_1
{
    partial class Form1
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
            button1 = new Button();
            textName = new TextBox();
            label1 = new Label();
            labelMessage = new Label();
            // 
            // button1
            // 
            button1.Location = new Point(25, 169);
            button1.Name = "button1";
            button1.Size = new Size(162, 23);
            button1.TabIndex = 0;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textName
            // 
            textName.Location = new Point(25, 107);
            textName.Name = "textName";
            textName.Size = new Size(162, 23);
            textName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 18);
            label1.Name = "label1";
            label1.Size = new Size(162, 30);
            label1.TabIndex = 2;
            label1.Text = "Programa si la letra comienza\r\n          por la letra P o no";
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(25, 72);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(0, 15);
            labelMessage.TabIndex = 3;
            // 
            // Form1
            // 
        }

        #endregion

        private Button button1;
        private TextBox textName;
        private Label label1;
        private Label labelMessage;
    }
}