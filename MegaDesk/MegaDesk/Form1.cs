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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newQuote_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuote = new AddQuote();
            viewAddQuote.Tag = this;
            viewAddQuote.Show(this);
            Hide();
        }
        private void viewQuote_Click(object sender, EventArgs e)
        {
            DisplayQuote viewDisplayQuote = new DisplayQuote();
            viewDisplayQuote.Tag = this;
            viewDisplayQuote.Show(this);
            Hide();
        }
        private void searchQuote_Click(object sender, EventArgs e)
        {
            SearchQuote viewSearchQuote = new SearchQuote();
            viewSearchQuote.Tag = this;
            viewSearchQuote.Show(this);
            Hide();
        }
    }
}
