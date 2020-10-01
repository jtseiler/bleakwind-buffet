/*
 * Author: Jack Seiler
 * Class name: OrderControl.xaml.cs
 * Purpose: gives details of this particular order
 */
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
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using PointOfSale.CustomizeEntrees;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// The ancestor of this control
        /// </summary>
        public MainWindow Ancestor { get; set; }

        public OrderControl()
        {
            InitializeComponent();
        }

        void onSwitchScreen(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.custBriarheartBurger);
        }

    }
}
