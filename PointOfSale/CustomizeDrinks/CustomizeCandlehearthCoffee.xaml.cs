﻿/*
 * Author: Jack Seiler
 * Class name: CustomizeCandlehearthCoffee.xaml.cs
 * Purpose: gives details of the candlehearth coffee
 */
using BleakwindBuffet.Data.Drinks;
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

namespace PointOfSale.CustomizeDrinks
{
    /// <summary>
    /// Interaction logic for CustomizeCandlehearthCoffee.xaml
    /// </summary>
    public partial class CustomizeCandlehearthCoffee : UserControl
    {
        /// <summary>
        /// creates mainwindow ancestor property
        /// </summary>
        MainWindow ancestor;

        /// <summary>
        /// constructs an object stating this item as the ancestor
        /// </summary>
        /// <param name="ancestor"></param>
        public CustomizeCandlehearthCoffee(MainWindow ancestor)
        {
            InitializeComponent();
            this.ancestor = ancestor;
        }

        /// <summary>
        /// click event handler for switching screens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnSwitchScreen(object sender, RoutedEventArgs e)
        {
            ancestor.SwitchScreen(Screen.Home);
        }
    }
}
