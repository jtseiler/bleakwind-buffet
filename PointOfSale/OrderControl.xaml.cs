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
            //AddBriarheartBurger.Click += onSwitchScreen;
        }

        /// <summary>
        /// event handler that switches screens between home screen and item customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void onSwitchScreen(object sender, RoutedEventArgs e)
        {
            //if (DataContext is Order newOrder)
            //{
                var buttons = (Button)sender;
                switch (buttons.ToString())
                {
                    case "System.Windows.Controls.Button: Briarheart Burger":
                        BriarheartBurger newbb = new BriarheartBurger();
                        Ancestor.newOrder.Add(newbb);
                        Ancestor.SwitchScreen(Screen.custBriarheartBurger, newbb);
                        DisplayCurrentOrder();
                        break;

                    case "System.Windows.Controls.Button: Double Draugr":
                        DoubleDraugr newdd = new DoubleDraugr();
                        Ancestor.newOrder.Add(newdd);
                        Ancestor.SwitchScreen(Screen.custDoubleDraugr, newdd);
                        DisplayCurrentOrder();
                        break;

                    case "System.Windows.Controls.Button: Garden Orc Omelette":
                        GardenOrcOmelette newgoc = new GardenOrcOmelette();
                        Ancestor.newOrder.Add(newgoc);
                        Ancestor.SwitchScreen(Screen.custGardenOrcOmelette, newgoc);
                        DisplayCurrentOrder();
                        break;

                    case "System.Windows.Controls.Button: Philly Poacher":
                        PhillyPoacher newpp = new PhillyPoacher();
                        Ancestor.newOrder.Add(newpp);
                        Ancestor.SwitchScreen(Screen.custPhillyPoacher, newpp);
                        DisplayCurrentOrder();
                        break;

                    case "System.Windows.Controls.Button: Smokehouse Skeleton":
                        SmokehouseSkeleton newss = new SmokehouseSkeleton();
                        Ancestor.newOrder.Add(newss);
                        Ancestor.SwitchScreen(Screen.custSmokehouseSkeleton, newss);
                        DisplayCurrentOrder();
                        break;

                    case "System.Windows.Controls.Button: Thalmor Triple":
                        ThalmorTriple newtt = new ThalmorTriple();
                        Ancestor.newOrder.Add(newtt);
                        Ancestor.SwitchScreen(Screen.custThalmorTriple, newtt);
                        DisplayCurrentOrder();
                        break;

                    case "System.Windows.Controls.Button: Dragonborn Waffle Fries":
                        DragonbornWaffleFries newdwf = new DragonbornWaffleFries();
                        Ancestor.newOrder.Add(newdwf);
                        Ancestor.SwitchScreen(Screen.custDragonbornWaffleFries, newdwf);
                        DisplayCurrentOrder();
                        break;

                    case "System.Windows.Controls.Button: Fried Miraak":
                        FriedMiraak newfm = new FriedMiraak();
                        Ancestor.newOrder.Add(newfm);
                        Ancestor.SwitchScreen(Screen.custFriedMiraak, newfm);
                        DisplayCurrentOrder();
                        break;

                    case "System.Windows.Controls.Button: Mad Otar Grits":
                        MadOtarGrits newmog = new MadOtarGrits();
                        Ancestor.newOrder.Add(newmog);
                        Ancestor.SwitchScreen(Screen.custMadOtarGrits, newmog);
                        DisplayCurrentOrder();
                        break;

                    case "System.Windows.Controls.Button: Vokun Salad":
                        VokunSalad newvs = new VokunSalad();
                        Ancestor.newOrder.Add(newvs);
                        Ancestor.SwitchScreen(Screen.custVokunSalad, newvs);
                        DisplayCurrentOrder();
                        break;

                    case "System.Windows.Controls.Button: Aretino Apple Juice":
                        AretinoAppleJuice newaa = new AretinoAppleJuice();
                        Ancestor.newOrder.Add(newaa);
                        Ancestor.SwitchScreen(Screen.custAretinoAppleJuice, newaa);
                        DisplayCurrentOrder();
                    break;

                    case "System.Windows.Controls.Button: Candlehearth Coffee":
                        CandlehearthCoffee newcc = new CandlehearthCoffee();
                        Ancestor.newOrder.Add(newcc);
                        Ancestor.SwitchScreen(Screen.custCandlehearthCoffee, newcc);
                        DisplayCurrentOrder();
                        break;

                    case "System.Windows.Controls.Button: Markarth Milk":
                        MarkarthMilk newmm = new MarkarthMilk();
                        Ancestor.newOrder.Add(newmm);
                        Ancestor.SwitchScreen(Screen.custMarkarthMilk, newmm);
                        DisplayCurrentOrder();
                    break;

                    case "System.Windows.Controls.Button: Sailor Soda":
                        SailorSoda newsoda = new SailorSoda();
                        Ancestor.newOrder.Add(newsoda);
                        Ancestor.SwitchScreen(Screen.custSailorSoda, newsoda);
                        DisplayCurrentOrder();
                        break;

                    case "System.Windows.Controls.Button: Warrior Water":
                        WarriorWater newww = new WarriorWater();
                        Ancestor.newOrder.Add(newww);
                        Ancestor.SwitchScreen(Screen.custWarriorWater, newww);
                        DisplayCurrentOrder();
                        break;

                    case "System.Windows.Controls.Button: Complete Order":
                        Ancestor.SwitchScreen(Screen.completeOrder);
                        break;
                }
            DisplayCurrentOrder();

            //}
        }

        public void CreateACombo_Click(object sender, RoutedEventArgs e)
        {
            //Combo combo = new Combo(/*entree, side, drink*/);
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
                removeButton.VerticalAlignment = VerticalAlignment.Center;
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
            Ancestor.newOrder = new Order();
            DataContext = Ancestor.newOrder;
        }

        private void RemoveItemFromOrder_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
