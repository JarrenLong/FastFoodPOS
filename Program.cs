/*
 * SkillsUSA National Championships 2012
 * Contestant #510
 * Program #1 - Fast Food Ordering System
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FastFoodPOS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application. This application allows a
        /// user to place an order with three restaurants. The ordering system is
        /// split up into three windows forms for gathering information quickly.
        /// The restaurant menus are extremely flexible, being stored in a simple
        /// XML file that can be easily extended for future use.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RestaurantSelectionForm());
        }
    }
}
