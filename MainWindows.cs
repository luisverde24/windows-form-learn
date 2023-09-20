using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_app_1
{
    public partial class MainWindows : Form
    {
        public MainWindows()
        {
            InitializeComponent();
        }

        private void notaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nota note = new Nota();
            note.ShowDialog();
        }
    }
}
