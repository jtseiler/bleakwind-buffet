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

        /// <summary>
        /// event handler that switches screens between home screen and item customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void onSwitchScreen(object sender, RoutedEventArgs e)
        {
            var buttons = (Button)sender;
            switch (buttons.ToString())
            {
                case "System.Windows.Controls.Button: Briarheart Burger":
                    Ancestor.SwitchScreen(Screen.custBriarheartBurger);
                    break;
                case "System.Windows.Controls.Button: Double Draugr":
                    Ancestor.SwitchScreen(Screen.custDoubleDraugr);
                    break;
                case "System.Windows.Controls.Button: Garden Orc Omelette":
                    Ancestor.SwitchScreen(Screen.custGardenOrcOmelette);
                    break;
                case "System.Windows.Controls.Button: Philly Poacher":
                    Ancestor.SwitchScreen(Screen.custPhillyPoacher);
                    break;
                case "System.Windows.Controls.Button: Smokehouse Skeleton":
                    Ancestor.SwitchScreen(Screen.custSmokehouseSkeleton);
                    break;
                case "System.Windows.Controls.Button: Thalmor Triple":
                    Ancestor.SwitchScreen(Screen.custThalmorTriple);
                    break;
            }
                
                

            //Ancestor.SwitchScreen(GetScreen());
            }

    }
}
