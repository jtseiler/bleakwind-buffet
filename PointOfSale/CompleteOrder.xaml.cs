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

        public CompleteOrder(MainWindow ancestor)
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

        
    }
}
