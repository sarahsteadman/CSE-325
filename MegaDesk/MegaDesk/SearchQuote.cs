using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class SearchQuote : Form
    {
        public SearchQuote()
        {
            InitializeComponent();
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            Form1 viewForm1 = (Form1)Tag;
            viewForm1.Show();
            Close();
        }
    }
}
