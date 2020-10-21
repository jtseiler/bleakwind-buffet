/*
 * Author: Jack Seiler
 * Class name: CompleteOrder.xaml.cs
 * Purpose: completes the given order on the screen
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
using BleakwindBuffet.Data;
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CompleteOrder.xaml
    /// </summary>
    public partial class CompleteOrder : UserControl
    {
        /// <summary>
        /// creates mainwindow ancestor property
        /// </summary>
        MainWindow ancestor;

        /// <summary>
        /// sets the data context and allows for screens switching
        /// </summary>
        /// <param name="ancestor"></param>
        /// <param name="newOrder"></param>
        public CompleteOrder(MainWindow ancestor, Order newOrder)
        {
            InitializeComponent();
            this.ancestor = ancestor;
            ancestor.newOrder = newOrder;
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

        /// <summary>
        /// Click event for CREDIT/DEBIT button for payment type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PayByCard_Click(object sender, RoutedEventArgs e)
        {
            switch(CardReader.RunCard(ancestor.newOrder.Total))
            {
                case CardTransactionResult.Approved:
                    //print receipt
                    //OrderListView.Items.Clear();
                    ancestor.newOrder = new Order();
                    DataContext = ancestor.newOrder;
                    break;
                case CardTransactionResult.Declined:
                    PayByCard.IsEnabled = false;
                    MessageBox.Show("Error: Card Declined, please select another payment method.");
                    break;
                case CardTransactionResult.ReadError:
                    MessageBox.Show("Error: Card Read Error! \n\t Please try swiping card again!");
                    break;
                case CardTransactionResult.InsufficientFunds:
                    PayByCard.IsEnabled = false;
                    MessageBox.Show("Error: Insufficient funds on card. \n\t Please select another payment method.");
                    break;
                case CardTransactionResult.IncorrectPin:
                    MessageBox.Show("Error: Incorrect Pin. \n\t Please try entering again.");
                    break;
                default:
                    throw new NotImplementedException("Should never be reached");
            }
        }

        /// <summary>
        /// method that prints the recipt for the current order
        /// </summary>
        /// <param name="typeofPayment"></param>
        /// <param name="totalChange"></param>
        public void PrintReciept(string typeofPayment, double totalChange)
        {
            RecieptPrinter.PrintLine("Order # " + ancestor.newOrder.OrderNumber.ToString());
            RecieptPrinter.PrintLine(DateTime.Now.ToString());

            foreach (IOrderItem item in ancestor.newOrder.Items)
            {
                RecieptPrinter.PrintLine(item.ToString() + " $" + item.Price);
                foreach (string specialstruc in item.SpecialInstructions)
                {
                    RecieptPrinter.PrintLine("-" + specialstruc);
                }
            }
            RecieptPrinter.PrintLine("SubTotal: $" + ancestor.newOrder.Subtotal.ToString());
            RecieptPrinter.PrintLine("Tax: $" + ancestor.newOrder.SalesTax.ToString());
            RecieptPrinter.PrintLine("Total: $" + ancestor.newOrder.Total.ToString());
            RecieptPrinter.PrintLine("Payment Type:  " + typeofPayment);
            RecieptPrinter.PrintLine("Change:   $" + totalChange.ToString());
            RecieptPrinter.CutTape();

        }

        /// <summary>
        /// click event for moving to the cash register
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ancestor.SwitchScreen(Screen.cashRegister);
        }
    }
}
