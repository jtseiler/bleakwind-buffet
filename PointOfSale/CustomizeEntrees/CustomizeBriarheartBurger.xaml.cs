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
        MainWindow ancestor;

        public CustomizeBriarheartBurger()
        {
            InitializeComponent();
            //this.ancestor = ancestor;
        }

        void OnSwitchScreen(object sender, RoutedEventArgs e)
        {
            ancestor.SwitchScreen();
        }
    }
}
