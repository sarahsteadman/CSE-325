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
    public partial class AddQuote : Form
    {
        Desk desk = new Desk();
        public AddQuote()
        {
            InitializeComponent();

            foreach (DesktopMaterial material in Enum.GetValues(typeof(DesktopMaterial)))
            {
                materials.Items.Add(material);
            }
            foreach (Time time in Enum.GetValues(typeof(Time)))
            {
                turnAroundTime.Items.Add(time);
            }

        }
        public void mainMenu_Click(object sender, EventArgs e)
        {
            Form1 viewForm1 = (Form1)Tag;
            viewForm1.Show();
            Close();
        }

        public void Validate_Width(object sender, KeyEventArgs e)
        {
            string entry = widthEntry.Text;
            widthEntry.Text = entry;

            try
            {
                int entryInt = int.Parse(entry);


                if (entryInt > desk.MAX_WIDTH|| entryInt < desk.MIN_WIDTH)
                {
                    widthLabel.ForeColor = Color.Red;

                }
                else
                {
                 widthLabel.ForeColor = Color.Black;
                }

            }
            catch (FormatException)
            {
                widthLabel.ForeColor = Color.Red;

            }
        }

        public void Validate_Depth(object sender, KeyEventArgs e)
        {
            string entry = depthEntry.Text;
            depthEntry.Text = entry;

            try
            {
                int entryInt = int.Parse(entry);

                if (entryInt > desk.MAX_DEPTH || entryInt < desk.MIN_DEPTH)
                {
                    depthLabel.ForeColor = Color.Red;

                }
                else
                {
                    depthLabel.ForeColor = Color.Black;
                }
            }
            catch (FormatException)
            {
                depthLabel.ForeColor = Color.Red;

            }
        }

        public void Validate_Drawers(object sender, KeyEventArgs e)
        {
            string entry = drawerEntry.Text;

            try
            {
                int entryInt = int.Parse(entry);

                if (entryInt > desk.MAX_DRAWERS || entryInt < desk.MIN_DRAWERS)
                {
                    drawerLabel.ForeColor = Color.Red;
                }
                else
                {
                    drawerLabel.ForeColor = Color.Black;
                }
            }
            catch (FormatException)
            {
                drawerLabel.ForeColor = Color.Red;

            }
        }

        public void Validate_Key_Type(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void Make_Order(object sender, EventArgs e)
        {
            desk.width = double.Parse(widthEntry.Text);
            desk.depth = double.Parse(depthEntry.Text);
            desk.drawers = int.Parse(drawerEntry.Text);

            if (materials.SelectedItem != null )
            {
            desk.surfaceMaterial = (DesktopMaterial)materials.SelectedItem;
            }
            else
            {
                MessageBox.Show("Please choose a surface mateial");
                return;
            }

            DeskQuote deskQuote = new DeskQuote();
            deskQuote.deskOrder = desk;
            deskQuote.customerName = nameEntry.Text;
            deskQuote.date = DateTime.Now;

            if (turnAroundTime.SelectedItem != null)
            {
                deskQuote.productionTime = (Time)turnAroundTime.SelectedItem;
            }
            else
            {
                MessageBox.Show("Please choose a turn around time.");
                return;
            }

            if (widthLabel.ForeColor == Color.Red || depthLabel.ForeColor == Color.Red || drawerLabel.ForeColor == Color.Red) 
            {
                MessageBox.Show("Please enter a valid input for the measurments and drawer number.");
                return;
            }
            deskQuote.Calculate();


            DisplayQuote viewDisplayQuote = new DisplayQuote(deskQuote);
            viewDisplayQuote.Show();
            Close();
        }


    }
}
