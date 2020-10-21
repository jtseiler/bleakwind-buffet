/*
 * Author: Jack Seiler
 * Class name: CashRegister.xaml.cs
 * Purpose: gives details of this particular cash register on the screen
 */
using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashRegister.xaml
    /// </summary>
    public partial class CashRegister : UserControl
    {
        MainWindow ancestor;
        
        RegistrarFunction Cash;

        /// <summary>
        /// insitantiates the cash register for the current order
        /// </summary>
        /// <param name="ancestor"></param>
        /// <param name="order"></param>
        public CashRegister(MainWindow ancestor, Order newOrder)
        {
            InitializeComponent();
            this.ancestor = ancestor;
            ancestor.newOrder = newOrder;
            Cash = new RegistrarFunction(newOrder);
            DataContext = Cash;
        }

        /// <summary>
        /// click event that calcualtes the correlating change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cash.ChangeDue(ancestor.newOrder.Total);
        }
    }
}
