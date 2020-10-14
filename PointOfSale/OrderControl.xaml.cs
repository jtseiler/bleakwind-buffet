﻿/*
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
using BleakwindBuffet.Data;

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
            DisplayCurrentOrder();
            var buttons = (Button)sender;
            switch (buttons.ToString())
            {
                case "System.Windows.Controls.Button: Briarheart Burger":
                    DisplayCurrentOrder();
                    Ancestor.SwitchScreen(Screen.custBriarheartBurger);
                    break;
                case "System.Windows.Controls.Button: Double Draugr":
                    Ancestor.SwitchScreen(Screen.custDoubleDraugr);
                    DisplayCurrentOrder();
                    break;
                case "System.Windows.Controls.Button: Garden Orc Omelette":
                    Ancestor.SwitchScreen(Screen.custGardenOrcOmelette); 
                    DisplayCurrentOrder();
                    break;
                case "System.Windows.Controls.Button: Philly Poacher":
                    Ancestor.SwitchScreen(Screen.custPhillyPoacher);
                    DisplayCurrentOrder();
                    break;
                case "System.Windows.Controls.Button: Smokehouse Skeleton":
                    Ancestor.SwitchScreen(Screen.custSmokehouseSkeleton);
                    DisplayCurrentOrder();
                    break;
                case "System.Windows.Controls.Button: Thalmor Triple":
                    Ancestor.SwitchScreen(Screen.custThalmorTriple);
                    DisplayCurrentOrder();
                    break;
                case "System.Windows.Controls.Button: Dragonborn Waffle Fries":
                    Ancestor.SwitchScreen(Screen.custDragonbornWaffleFries);
                    DisplayCurrentOrder();
                    break;
                case "System.Windows.Controls.Button: Fried Miraak":
                    Ancestor.SwitchScreen(Screen.custFriedMiraak);
                    DisplayCurrentOrder();
                    break;
                case "System.Windows.Controls.Button: Mad Otar Grits":
                    Ancestor.SwitchScreen(Screen.custMadOtarGrits);
                    DisplayCurrentOrder();
                    break;
                case "System.Windows.Controls.Button: Vokun Salad":
                    Ancestor.SwitchScreen(Screen.custVokunSalad);
                    DisplayCurrentOrder();
                    break;
                case "System.Windows.Controls.Button: Aretino Apple Juice":
                    Ancestor.SwitchScreen(Screen.custAretinoAppleJuice);
                    DisplayCurrentOrder();
                    break;
                case "System.Windows.Controls.Button: Candlehearth Coffee":
                    Ancestor.SwitchScreen(Screen.custCandlehearthCoffee);
                    DisplayCurrentOrder();
                    break;
                case "System.Windows.Controls.Button: Markarth Milk":
                    Ancestor.SwitchScreen(Screen.custMarkarthMilk);
                    DisplayCurrentOrder();
                    break;
                case "System.Windows.Controls.Button: Sailor Soda":
                    Ancestor.SwitchScreen(Screen.custSailorSoda);
                    DisplayCurrentOrder();
                    break;
                case "System.Windows.Controls.Button: Warrior Water":
                    Ancestor.SwitchScreen(Screen.custWarriorWater);
                    DisplayCurrentOrder();
                    break;
            }
        }

        
        public void DisplayCurrentOrder()
        {
            OrderListView.Items.Clear();
            OrderListView.Items.Add("       Order #" + Ancestor.newOrder.OrderNumber);
            foreach(IOrderItem item in Ancestor.newOrder.Items)
            {
                OrderListView.Items.Add(item.ToString() + " $" + item.Price);
                foreach(string specialInstructions in item.SpecialInstructions)
                {
                    OrderListView.Items.Add("-" + specialInstructions);
                }
                //Button removeEditButton = new Button();
                //removeEditButton.Margin = new Thickness(20, 0, 0, 0);
                //removeEditButton.Content = "Remove/Edit Order";
                //need help hooking up clcik event
                //removeEditButton.Click = (object sender, RoutedEventArgs e) => { ItemReSelectionClickEvent(sender, e, item) };
                //OrderListView.Items.Add(removeEditButton);
            }
            OrderListView.Items.Add("Subtotal:      $" + Ancestor.newOrder.Subtotal);
            OrderListView.Items.Add("Tax:      $" + Ancestor.newOrder.SalesTax);
            OrderListView.Items.Add("Total:      $" + Ancestor.newOrder.Total);
        }

        private void OrderListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
