namespace test_app_1
{
    partial class MainWindows
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
            menuStrip1 = new MenuStrip();
            letraPToolStripMenuItem = new ToolStripMenuItem();
            calculadoraToolStripMenuItem = new ToolStripMenuItem();
            notaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { letraPToolStripMenuItem, calculadoraToolStripMenuItem, notaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(306, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // letraPToolStripMenuItem
            // 
            letraPToolStripMenuItem.Name = "letraPToolStripMenuItem";
            letraPToolStripMenuItem.Size = new Size(55, 20);
            letraPToolStripMenuItem.Text = "Letra P";
            // 
            // calculadoraToolStripMenuItem
            // 
            calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            calculadoraToolStripMenuItem.Size = new Size(82, 20);
            calculadoraToolStripMenuItem.Text = "Calculadora";
            // 
            // notaToolStripMenuItem
            // 
            notaToolStripMenuItem.Name = "notaToolStripMenuItem";
            notaToolStripMenuItem.Size = new Size(45, 20);
            notaToolStripMenuItem.Text = "Nota";
            notaToolStripMenuItem.Click += notaToolStripMenuItem_Click;
            // 
            // MainWindows
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 212);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainWindows";
            Text = "MainWindows";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem letraPToolStripMenuItem;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
        private ToolStripMenuItem notaToolStripMenuItem;
    }
}