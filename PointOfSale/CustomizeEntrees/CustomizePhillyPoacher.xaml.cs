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
    /// Interaction logic for CustomizePhillyPoacher.xaml
    /// </summary>
    public partial class CustomizePhillyPoacher : UserControl
    {
        MainWindow ancestor;

        public CustomizePhillyPoacher(MainWindow ancestor)
        {
            InitializeComponent();
            this.ancestor = ancestor;
        }

        void OnSwitchScreen(object sender, RoutedEventArgs e)
        {
            ancestor.SwitchScreen(Screen.Home);
        }
    }
}
