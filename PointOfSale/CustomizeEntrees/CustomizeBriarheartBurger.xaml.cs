/*
 * Author: Jack Seiler
 * Class name: CustomizeBriarheartBurger.xaml.cs
 * Purpose: gives details of the briarheartburger
 */
using BleakwindBuffet.Data.Entrees;
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

namespace PointOfSale.CustomizeEntrees
{
    /// <summary>
    /// Interaction logic for CustomizeBriarheartBurger.xaml
    /// </summary>
    public partial class CustomizeBriarheartBurger : UserControl
    {
        /// <summary>
        /// creates mainwindow ancestor property
        /// </summary>
        MainWindow ancestor;

       // MainWindow window = (MainWindow)Application.Current.MainWindow();

        /// <summary>
        /// constructs an object stating this item as the ancestor
        /// </summary>
        /// <param name="ancestor"></param>
        public CustomizeBriarheartBurger(MainWindow ancestor, BriarheartBurger bb)
        {
            InitializeComponent();
            this.ancestor = ancestor;
            DataContext = bb;
            ancestor.newOrder.Add(bb);
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
