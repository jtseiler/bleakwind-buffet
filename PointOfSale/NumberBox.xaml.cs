/*
 * Author: Jack Seiler
 * Class name: NumberBox.xaml.cs
 * Purpose: gives the particular unit of currency on the screen
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for NumberBox.xaml
    /// </summary>
    public partial class NumberBox : UserControl
    {
        public static DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(int), typeof(NumberBox));

        /// <summary>
        /// value property for the given order
        /// </summary>
        public int Value
        {
            get { return (int)GetValue(NumberBox.ValueProperty); }
            set { SetValue(NumberBox.ValueProperty, value); }
        }

        /// <summary>
        /// contructor for the given number boxes
        /// </summary>
        public NumberBox()
        {
            InitializeComponent();
            CheckIfZero();
        }

        /// <summary>
        /// click event that increments the given numberbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void IncrementButtonClick(object sender, RoutedEventArgs e)
        {
            Value++;
            e.Handled = true;
            CheckIfZero();
        }

        /// <summary>
        /// method to check and see if the given number box is already at 0
        /// </summary>
        void CheckIfZero()
        {
            if (Value == 0) Decrement.IsEnabled = false;
            else Decrement.IsEnabled = true;
        }

        /// <summary>
        /// click event that decrements the given number box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DecrementButtonClick(object sender, RoutedEventArgs e)
        {
            Value--;
            e.Handled = true;
            CheckIfZero();
        }
    }
}
