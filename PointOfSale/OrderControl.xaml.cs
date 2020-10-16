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
            if (DataContext is Order newOrder)
            {
                var buttons = (Button)sender;
                switch (buttons.ToString())
                {
                    case "System.Windows.Controls.Button: Briarheart Burger":
                        DisplayCurrentOrder();
                        BriarheartBurger newbb = new BriarheartBurger();
                        newOrder.Add(newbb);
                        Ancestor.SwitchScreen(Screen.custBriarheartBurger, newbb);
                        break;

                    case "System.Windows.Controls.Button: Double Draugr":
                        DisplayCurrentOrder();
                        DoubleDraugr newdd = new DoubleDraugr();
                        newOrder.Add(newdd);
                        Ancestor.SwitchScreen(Screen.custDoubleDraugr, newdd);
                        break;

                    case "System.Windows.Controls.Button: Garden Orc Omelette":
                        DisplayCurrentOrder();
                        GardenOrcOmelette newgoc = new GardenOrcOmelette();
                        newOrder.Add(newgoc);
                        Ancestor.SwitchScreen(Screen.custGardenOrcOmelette, newgoc);
                        break;

                    case "System.Windows.Controls.Button: Philly Poacher":
                        DisplayCurrentOrder();
                        PhillyPoacher newpp = new PhillyPoacher();
                        newOrder.Add(newpp);
                        Ancestor.SwitchScreen(Screen.custPhillyPoacher, newpp);
                        break;

                    case "System.Windows.Controls.Button: Smokehouse Skeleton":
                        DisplayCurrentOrder();
                        SmokehouseSkeleton newss = new SmokehouseSkeleton();
                        newOrder.Add(newss);
                        Ancestor.SwitchScreen(Screen.custSmokehouseSkeleton, newss);
                        break;

                    case "System.Windows.Controls.Button: Thalmor Triple":
                        DisplayCurrentOrder();
                        ThalmorTriple newtt = new ThalmorTriple();
                        newOrder.Add(newtt);
                        Ancestor.SwitchScreen(Screen.custThalmorTriple, newtt);
                        break;

                    case "System.Windows.Controls.Button: Dragonborn Waffle Fries":
                        DisplayCurrentOrder();
                        DragonbornWaffleFries newdwf = new DragonbornWaffleFries();
                        newOrder.Add(newdwf);
                        Ancestor.SwitchScreen(Screen.custDragonbornWaffleFries, newdwf);
                        break;

                    case "System.Windows.Controls.Button: Fried Miraak":
                        DisplayCurrentOrder();
                        FriedMiraak newfm = new FriedMiraak();
                        newOrder.Add(newfm);
                        Ancestor.SwitchScreen(Screen.custFriedMiraak, newfm);
                        break;

                    case "System.Windows.Controls.Button: Mad Otar Grits":
                        DisplayCurrentOrder();
                        MadOtarGrits newmog = new MadOtarGrits();
                        newOrder.Add(newmog);
                        Ancestor.SwitchScreen(Screen.custMadOtarGrits, newmog);
                        break;

                    case "System.Windows.Controls.Button: Vokun Salad":
                        DisplayCurrentOrder();
                        VokunSalad newvs = new VokunSalad();
                        newOrder.Add(newvs);
                        Ancestor.SwitchScreen(Screen.custVokunSalad, newvs);
                        break;

                    case "System.Windows.Controls.Button: Aretino Apple Juice":
                        DisplayCurrentOrder();
                        AretinoAppleJuice newaa = new AretinoAppleJuice();
                        newOrder.Add(newaa);
                        Ancestor.SwitchScreen(Screen.custAretinoAppleJuice, newaa);
                        break;

                    case "System.Windows.Controls.Button: Candlehearth Coffee":
                        DisplayCurrentOrder();
                        CandlehearthCoffee newcc = new CandlehearthCoffee();
                        newOrder.Add(newcc);
                        Ancestor.SwitchScreen(Screen.custCandlehearthCoffee, newcc);
                        break;

                    case "System.Windows.Controls.Button: Markarth Milk":
                        DisplayCurrentOrder();
                        MarkarthMilk newmm = new MarkarthMilk();
                        newOrder.Add(newmm);
                        Ancestor.SwitchScreen(Screen.custMarkarthMilk, newmm);
                        break;

                    case "System.Windows.Controls.Button: Sailor Soda":
                        DisplayCurrentOrder();
                        SailorSoda newsoda = new SailorSoda();
                        newOrder.Add(newsoda);
                        Ancestor.SwitchScreen(Screen.custSailorSoda, newsoda);
                        break;

                    case "System.Windows.Controls.Button: Warrior Water":
                        DisplayCurrentOrder();
                        WarriorWater newww = new WarriorWater();
                        newOrder.Add(newww);
                        Ancestor.SwitchScreen(Screen.custWarriorWater, newww);
                        break;

                    case "System.Windows.Controls.Button: Complete Order":
                        Ancestor.SwitchScreen(Screen.completeOrder);
                        break;
                }
            }
        }

        
        public void DisplayCurrentOrder()
        {
            OrderListView.Items.Clear();
            OrderListView.Items.Add("       Order #" + Ancestor.newOrder.OrderNumber);
            foreach(IOrderItem item in Ancestor.newOrder.Items)
            {
                OrderListView.FontSize = 17;
                OrderListView.FontWeight = FontWeight.FromOpenTypeWeight(5);
                OrderListView.Items.Add(item.ToString() + " $" + item.Price);
                foreach(string specialInstructions in item.SpecialInstructions)
                {
                    OrderListView.Items.Add("-" + specialInstructions);
                }

                Button editButton = new Button();
                editButton.Margin = new Thickness(1);
                editButton.VerticalAlignment = VerticalAlignment.Center;
                editButton.Width = 250;
                editButton.Height = 20;
                editButton.FontSize = 15;
                editButton.Content = "Edit Item";
                OrderListView.Items.Add(editButton);

                Button removeButton = new Button();
                removeButton.Margin = new Thickness(1);
                removeButton.Width = 250;
                removeButton.Height = 20;
                removeButton.FontSize = 15;
                removeButton.Content = "Remove Item";
                OrderListView.Items.Add(removeButton);
            }
            OrderListView.Items.Add("Subtotal:      $" + Ancestor.newOrder.Subtotal);
            OrderListView.Items.Add("Tax:      $" + Ancestor.newOrder.SalesTax);
            OrderListView.Items.Add("Total:      $" + Ancestor.newOrder.Total);
        }

        /// <summary>
        /// Click event for the CANCEL ORDER BUTTON
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Clear();
            Order order = new Order();
            DataContext = order;
        }

    }
}
