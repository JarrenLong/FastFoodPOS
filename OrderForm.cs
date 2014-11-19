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
using System.Xml;

namespace FastFoodPOS
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            try
            {
                loadMenu("Menu.xml"); // Load in the menu from the XML file (Menu.xml)
            }
            catch
            {
                MessageBox.Show("Sorry! We can't find the menu for this " +
                    "restaurant! Please contact the front desk for assistance.");
                //Close up this form (don't quit yet)
                this.Close();
            }

            // Make sure we fall out if the next form launched is closed
            if (xForm.Complete)
            {
                this.Close();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            // Make sure we know how many orders we have
            xForm.NumberOfOrders = (int)numericUpDownOrders.Value;

            // And call up the checkout/confirm form
            CheckoutForm checkout = new CheckoutForm();
            checkout.ShowDialog();

            if (xForm.Complete)
            {
                this.Close();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ListViewItem it = null;
            OrderItem oi = new OrderItem();
            if (listViewEntreeMenu.Visible) // User selected an entree
            {
                // Add the name and price to the order list
                it = listViewEntreeMenu.SelectedItems[0];
                if (it != null)
                {
                    oi.Name = it.Text;
                    oi.Price = Convert.ToDecimal(it.Tag);
                }
            }
            else if (listViewSideMenu.Visible) // User selected a side order
            {
                // Add the name and price to the order list
                it = listViewSideMenu.SelectedItems[0];
                if (it != null)
                {
                    oi.Name = it.Text;
                    oi.Price = Convert.ToDecimal(it.Tag);
                }
            }
            else
            { // must be a drink then
                it = listViewDrinkMenu.SelectedItems[0];
                if (it != null)
                {
                    oi.Name = it.Text;
                    // Is it a small, medium, or large? (Large = default)
                    if (radioButtonSmall.Checked)
                    {
                        oi.Price = Convert.ToDecimal(xForm.PriceSmallDrink);
                    }
                    else if (radioButtonMedium.Checked)
                    {
                        oi.Price = Convert.ToDecimal(xForm.PriceMediumDrink);
                    }
                    else
                    {
                        oi.Price = Convert.ToDecimal(xForm.PriceLargeDrink);
                    }
                }
            }

            // Add the item to our order list
            xForm.Order.Add(oi);

            // And update the listview to display it
            xForm.updateOrderListView(listViewOrder);
        }

        private void loadMenu(string filename)
        {
            /* We're going to let all exceptions fall through this method and
             * catch them where the method is called. If anything goes wrong
             * here, we'll assume the menu is botched and throw an error.
             */
            XmlDocument xd = new XmlDocument();
            xd.Load(filename);

            // Grab all of the <restaurant> nodes (and sub nodes)
            XmlNodeList xn = xd.GetElementsByTagName("restaurant");
            if (xForm.RestaurantID == -1)
            {
                throw new Exception("Unknown restaurant!");
            }

            //Get the entree, side, and drink nodes
            XmlNodeList node = xn[xForm.RestaurantID].ChildNodes;

            //Update the restaurant contact info labels
            labelName.Text = xn[xForm.RestaurantID].Attributes["name"].Value;
            labelAddress1.Text = xn[xForm.RestaurantID].Attributes["address_a"].Value;
            labelAddress2.Text = xn[xForm.RestaurantID].Attributes["address_b"].Value;
            labelPhone.Text = xn[xForm.RestaurantID].Attributes["phone"].Value;

            //And iterate through each sub node to populate the menu listview
            ListViewItem tmp = null;
            foreach (XmlNode n in node[0]) //entree node
            {
                tmp = new ListViewItem(n.Attributes["name"].Value);
                tmp.Tag = n.Attributes["price"].Value;

                listViewEntreeMenu.Items.Add(tmp);
            }

            foreach (XmlNode n in node[1]) //side node
            {
                tmp = new ListViewItem(n.Attributes["name"].Value);
                tmp.Tag = n.Attributes["price"].Value;

                listViewSideMenu.Items.Add(tmp);
            }

            xForm.PriceSmallDrink = node[2].Attributes["sm_price"].Value;
            xForm.PriceMediumDrink = node[2].Attributes["med_price"].Value;
            xForm.PriceLargeDrink = node[2].Attributes["lg_price"].Value;
            foreach (XmlNode n in node[2]) //drink node
            {
                listViewDrinkMenu.Items.Add(new ListViewItem(n.Attributes["name"].Value));
            }
        }
    }
}
