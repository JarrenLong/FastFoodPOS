/*
 * SkillsUSA National Championships 2012
 * Contestant #510
 * Program #1 - Fast Food Ordering System
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FastFoodPOS
{
    public partial class CheckoutForm : Form
    {
        public CheckoutForm()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            decimal total = 0;

            // Grab each order entry from the list, and sum up the total
            foreach (ListViewItem it in listViewOrder.Items)
            {
                try
                {
                    total += Convert.ToDecimal(it.Tag);
                }
                catch { }
            }

            //Delivery orders are $5.00 more
            if (xForm.Delivery)
                total += 5;

            // Factor in the order multiplier
            total *= xForm.NumberOfOrders;

            // Display the final total if there is one
            MessageBox.Show(
                total > 0 ?
                "Your total is " + total :
                "Nothing selected!");

            // and close the app if there was an order placed
            xForm.Complete = (total > 0);
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Clear out the order
            xForm.Order.Clear();
            xForm.updateOrderListView(listViewOrder);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Just close the form and quit
            xForm.Complete = true;
            this.Close();
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            // Build the order list on load
            xForm.updateOrderListView(listViewOrder);
        }
    }
}
