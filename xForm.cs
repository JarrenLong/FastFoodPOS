/*
 * SkillsUSA National Championships 2012
 * Contestant #510
 * Program #1 - Fast Food Ordering System
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FastFoodPOS
{
    // This is a static class for cross-form data transfer (thus the name xForm)
    static class xForm
    {
        public static bool Complete = false; // Is the application done running?
        public static bool Delivery = false; // Is this a delivery order?
        public static int RestaurantID = -1; // 0 = Ronny's, 1 = Burger Jack, 2 = Wendy Time
        public static string CustomerName = "";
        public static string CustomerAddress = "";
        public static string CustomerPhone = "";
        public static string PriceSmallDrink = "";
        public static string PriceMediumDrink = "";
        public static string PriceLargeDrink = "";
        public static int NumberOfOrders = 1;
        public static List<OrderItem> Order = new List<OrderItem>();

        // Helper method for updating ListViews
        public static void updateOrderListView(ListView control)
        {
            // Clear the listview first
            control.Items.Clear();

            // And add all of the items from the Order list in this class to it
            ListViewItem item = null;
            foreach (OrderItem it in xForm.Order)
            {
                item = new ListViewItem(it.Name);
                item.Tag = it.Price.ToString();
                control.Items.Add(item);
            }
        }
    }

    // A simple key:value pair class for generic order entries
    class OrderItem
    {
        // Every order entry has a name and a price, KISS method
        public string Name = "";
        public decimal Price = 0;
    }
}
