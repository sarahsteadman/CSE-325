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
    public partial class DisplayQuote : Form
    {
        public DeskQuote deskQuote;
        public DisplayQuote(DeskQuote deskQuote)
        {
            InitializeComponent();
            this.deskQuote = deskQuote;

            Desk desk = deskQuote.deskOrder;
            width.Text = $"Width: {desk.width}";
            depth.Text = $"Depth: {desk.depth}";
            drawers.Text = $"Drawers: {desk.drawers}";
            material.Text = desk.surfaceMaterial.ToString();
            name.Text = deskQuote.customerName;
            time.Text = $"Turn Around Time: {deskQuote.productionTime}";
            date.Text = deskQuote.date.ToString();
            quote.Text = $"Quote: {deskQuote.quote}";

        }

        public void mainMenu_Click(object sender, EventArgs e)
        {
            Form1 viewForm1 = new Form1();
            viewForm1.Show();
            Close();
        }

    }
}
