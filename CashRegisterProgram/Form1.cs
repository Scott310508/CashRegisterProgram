using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CashRegisterProgram
{
    public partial class Form1 : Form
    {
        double brakeNumber;
        double turboNumber;
        double radiatorNumber;
        double subtotal;
        double tax;
        double total;
        double tender;
        double change;
        public Form1()
        {
            InitializeComponent();
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            try
            {
                brakeNumber = Convert.ToDouble(box1.Text);
                turboNumber = Convert.ToDouble(box2.Text);
                radiatorNumber = Convert.ToDouble(box3.Text);

                subtotal = brakeNumber * 40 + turboNumber * 1790 + radiatorNumber * 250;
                tax = 0.13 * subtotal;
                total = subtotal + tax;

                subtotalOutput.Text = $"{subtotal.ToString("$##.00")}";
                taxOutput.Text = $"{tax.ToString("C")}";
                totalOutput.Text = $"{total.ToString("C")}";
            }
            catch
            {
                subtotalOutput.Text = "";
                taxOutput.Text = "";
                totalOutput.Text = "ERROR";
            }
        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            tender = Convert.ToDouble(box4.Text);
            change = tender - total;

            if (change < 0) 
                changeOutput1.Text = $"{change.ToString("ERROR")}";
            else if (change == 0)
                changeOutput1.Text = $"{change.ToString("$0.00")}";
            else changeOutput1.Text = $"{change.ToString("$##.##")}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void rjButton7_Click(object sender, EventArgs e)
        {
            
            receiptbox.Text = "          J. Scott Auto Parts Inc.\n\n";
            receiptbox.Refresh();

            
            Thread.Sleep(500);
            receiptbox.Text += "Order number 1820" + "\nMarch 4, 2025\n\n";
            receiptbox.Refresh();


            if (brakeNumber > 0)
            {
                Thread.Sleep(500);
                receiptbox.Text += $"Brakes        40.00      x{brakeNumber}\n";
                receiptbox.Refresh();
            }
            else
            {
                Thread.Sleep(500);
                receiptbox.Text += "Brakes        40.00      x0\n";
                receiptbox.Refresh();
            }

            if (radiatorNumber > 0)
            {
                Thread.Sleep(500);
                receiptbox.Text += $"Radiators     250.00     x{radiatorNumber}\n";
                receiptbox.Refresh();
            }
            else
            {
                Thread.Sleep(500);
                receiptbox.Text += $"Radiators     250.00     x{radiatorNumber}\n";
                receiptbox.Refresh();
            }

            if (turboNumber > 0)
            {
                Thread.Sleep(500);
                receiptbox.Text += $"Turbos        1790.00    x{turboNumber}\n\n";
                receiptbox.Refresh();
            }
            else
            {
                Thread.Sleep(500);
                receiptbox.Text += "Turbos        1790.00      x0\n\n";
                receiptbox.Refresh();
            }


            if (subtotal > 0)
            {
                Thread.Sleep(500);
                receiptbox.Text += $"Subtotal     ${subtotal.ToString("##.##")}\n";
                receiptbox.Refresh();
            }
            else
            {
                Thread.Sleep(500);
                receiptbox.Text += $"Subtotal     ${subtotal.ToString("0.00")}\n";
                receiptbox.Refresh();
            }

            if (tax > 0)
            {
                Thread.Sleep(500);
                receiptbox.Text += $"Tax          ${tax.ToString("##.##")}\n";
                receiptbox.Refresh();
            }
            else
            {
                Thread.Sleep(500);
                receiptbox.Text += $"Tax          ${tax.ToString("0.00")}\n";
                receiptbox.Refresh();
            }

            if (total > 0)
            {
                Thread.Sleep(500);
                receiptbox.Text += $"Total        ${total.ToString("##.##")}\n\n";
                receiptbox.Refresh();
            }
            else
            {
                Thread.Sleep(500);
                receiptbox.Text += $"Total        ${total.ToString("0.00")}\n\n";
                receiptbox.Refresh();
            }


            if (tender > 0)
            {
                Thread.Sleep(500);
                receiptbox.Text += $"Tendered     ${tender.ToString("##.##")}\n";
                receiptbox.Refresh();
            }
            else
            {
                Thread.Sleep(500);
                receiptbox.Text += $"Tendered     ${tender.ToString("0.00")}\n";
                receiptbox.Refresh();
            }

            if (change > 0)
            {
                Thread.Sleep(500);
                receiptbox.Text += $"Change       ${change.ToString("##.##")}\n\n";
                receiptbox.Refresh();
            }
            else if (tender < total)
            {
                Thread.Sleep(500);
                receiptbox.Text += $"Change       {change.ToString("Not enough cash")}\n\n";
                receiptbox.Refresh();
            }
            else
            {
                Thread.Sleep(500);
                receiptbox.Text += $"Change       ${change.ToString("0.00")}\n\n";
                receiptbox.Refresh();
            }


            Thread.Sleep(500);
            receiptbox.Text += "Email contact: scottjautoparts@yahoo.com\n";
            receiptbox.Refresh();

            Thread.Sleep(500);
            receiptbox.Text += "Mobile contact: 226-122-8952\n\n";
            receiptbox.Refresh();


            Thread.Sleep(500);
            receiptbox.Text += "            HAVE A GREAT DAY !";
            receiptbox.Refresh();
        }

        public void reset()
        {
            box1.Text = null;
            box2.Text = null;
            box3.Text = null;
            box4.Text = null;
            subtotalOutput.Text = null;
            taxOutput.Text = null;
            totalOutput.Text = null;
            changeOutput1.Text = null;
            receiptbox.Text = null;
;       }
        private void rjButton8_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
