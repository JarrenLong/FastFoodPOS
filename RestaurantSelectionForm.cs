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
    public partial class RestaurantSelectionForm : Form
    {
        public RestaurantSelectionForm()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            // Get the customer's info
            xForm.CustomerName = textBoxName.Text;
            xForm.CustomerAddress = textBoxAddress.Text;
            xForm.CustomerPhone = textBoxPhone.Text;

            //Is this a delivery or carry out order?
            xForm.Delivery = checkBoxDelivery.Checked;
            // Delivery requires a name, address, & phone #
            if (xForm.Delivery)
            {
                if (xForm.CustomerName == "" || xForm.CustomerAddress == "" || xForm.CustomerPhone == "")
                {
                    MessageBox.Show("Contact information required for delivery!");
                    return;
                }
            }

            // Determine the rastaurant ID based on which radio button is checked
            xForm.RestaurantID = radioButtonRonnyDs.Checked ? 0 :
                (radioButtonBurgerJack.Checked ? 1 :
                (radioButtonWendyTime.Checked ? 2 :
                -1));

            //If everything looks good, show the next screen
            OrderForm order = new OrderForm();
            order.ShowDialog();

            // and close this window when the others close and indicate that
            // they're complete
            if (xForm.Complete)
            {
                this.Close();
            }
        }
    }
}
