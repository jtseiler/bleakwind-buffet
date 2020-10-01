/*
 * Author: Jack Seiler
 * Class name: MainWindow.xaml.cs
 * Purpose: gives details of this particular order on the screen
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PointOfSale.CustomizeEntrees;
using PointOfSale.CustomizeSides;
using PointOfSale.CustomizeDrinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// creates dictionary to hold all of our screens
        /// </summary>
        Dictionary<Screen, UserControl> screens = new Dictionary<Screen, UserControl>();

        /// <summary>
        /// contructor that adds all screens to the dictionary
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            descendant.Ancestor = this;
            screens.Add(Screen.Home, descendant);
            screens.Add(Screen.custBriarheartBurger, new CustomizeBriarheartBurger(this));
            screens.Add(Screen.custDoubleDraugr, new CustomzieDoubleDraugr(this));
            screens.Add(Screen.custGardenOrcOmelette, new CustomizeGardenOrcOmelette(this));
            screens.Add(Screen.custPhillyPoacher, new CustomizePhillyPoacher(this));
            screens.Add(Screen.custSmokehouseSkeleton, new CustomizeSmokehouseSkeleton(this));
            screens.Add(Screen.custThalmorTriple, new CustomizeThalmorTriple(this));
            screens.Add(Screen.custAretinoAppleJuice, new CustomizeAretinoAppleJuice(this));
            screens.Add(Screen.custCandlehearthCoffee, new CustomizeCandlehearthCoffee(this));
            screens.Add(Screen.custMarkarthMilk, new CustomizeMarkarthMilk(this));
            screens.Add(Screen.custSailorSoda, new CustomizeSailorSoda(this));
            screens.Add(Screen.custWarriorWater, new CustomizeWarriorWater(this));
            screens.Add(Screen.custDragonbornWaffleFries, new CustomizeDragonvornWaffleFries(this));
            screens.Add(Screen.custFriedMiraak, new CustomizeFriedMiraak(this));
            screens.Add(Screen.custMadOtarGrits, new CustomizeMadOtarGrits(this));
            screens.Add(Screen.custVokunSalad, new CustomizeVokunSalad(this));
        }

        /// <summary>
        /// method that switches to the correct screen.
        /// </summary>
        /// <param name="screen"></param>
        public void SwitchScreen(Screen screen)
        {
            switchableContent.Child = screens[screen];
        }


/*
        // <summary>
        /// Adds Vokun Salad to the Order list
        /// </summary>
        /// <param name="sender">oject created by click event</param>
        /// <param name="e">routed event</param>
        private void AddBriarheartBurger_Click_1(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new CustomizeBriarheartBurger());
        }

        // <summary>
        /// opens double draugr customization
        /// </summary>
        /// <param name="sender">oject created by click event</param>
        /// <param name="e">routed event</param>
        private void AddDoubleDraugr_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new CustomzieDoubleDraugr());
        }

        // <summary>
        /// opens garden orc omelette customization
        /// </summary>
        /// <param name="sender">oject created by click event</param>
        /// <param name="e">routed event</param>
        private void AddGardenOrcOmelette_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new CustomizeGardenOrcOmelette());
        }

        // <summary>
        /// opens philly poacher customization
        /// <param name="sender">oject created by click event</param>
        /// <param name="e">routed event</param>
        private void AddPhillyPoacher_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new CustomizePhillyPoacher());
        }

        // <summary>
        /// opens smokehouse skeleton customization
        /// </summary>
        /// <param name="sender">oject created by click event</param>
        /// <param name="e">routed event</param>
        private void AddSmokehouseSkeleton_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new CustomizeSmokehouseSkeleton());
        }

        // <summary>
        /// opens thalmor triple customization
        /// </summary>
        /// <param name="sender">oject created by click event</param>
        /// <param name="e">routed event</param>
        private void AddThalmorTriple_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new CustomizeThalmorTriple());
        }

        // <summary>
        /// Opens dragonborn waffle fries customization
        /// </summary>
        /// <param name="sender">oject created by click event</param>
        /// <param name="e">routed event</param>
        private void AddDragonbornWaffleFries_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new CustomizeDragonvornWaffleFries());
        }

        // <summary>
        /// opens fried miraak customization
        /// </summary>
        /// <param name="sender">oject created by click event</param>
        /// <param name="e">routed event</param>
        private void AddFriedMiraak_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new CustomizeFriedMiraak());
        }

        // <summary>
        /// opens mad otar grits customization
        /// </summary>
        /// <param name="sender">oject created by click event</param>
        /// <param name="e">routed event</param>
        private void AddMadOtarGrits_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new CustomizeMadOtarGrits());
        }

        // <summary>
        /// opens vokun salad customization
        /// </summary>
        /// <param name="sender">oject created by click event</param>
        /// <param name="e">routed event</param>
        private void AddVokunSalad_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new CustomizeVokunSalad());
        }

        // <summary>
        /// opens apple juice customization
        /// </summary>
        /// <param name="sender">oject created by click event</param>
        /// <param name="e">routed event</param>
        private void AddAretinoAppleJuice_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new CustomizeAretinoAppleJuice());
        }

        // <summary>
        /// opens coffee customization
        /// </summary>
        /// <param name="sender">oject created by click event</param>
        /// <param name="e">routed event</param>
        private void AddCandlehearthCoffee_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new CustomizeCandlehearthCoffee());
        }

        // <summary>
        /// opens milk customization
        /// </summary>
        /// <param name="sender">oject created by click event</param>
        /// <param name="e">routed event</param>
        private void AddMarkarthMilk_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new CustomizeMarkarthMilk());
        }

        // <summary>
        /// opens sailor soda customization
        /// </summary>
        /// <param name="sender">oject created by click event</param>
        /// <param name="e">routed event</param>
        private void AddSailorSoda_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new CustomizeSailorSoda());
        }

        // <summary>
        /// Opens Water customization
        /// </summary>
        /// <param name="sender">oject created by click event</param>
        /// <param name="e">routed event</param>
        private void AddWarriorWater_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new CustomizeWarriorWater());
        }

*/
    }
}
