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
using BleakwindBuffet.Data;

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

       public Order newOrder = new Order();
        /// <summary>
        /// contructor that adds all screens to the dictionary
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            descendant.Ancestor = this;
            screens.Add(Screen.Home, descendant);
            screens.Add(Screen.completeOrder, new CompleteOrder(this));
            screens.Add(Screen.custBriarheartBurger, new CustomizeBriarheartBurger(this, new BriarheartBurger()));
            screens.Add(Screen.custDoubleDraugr, new CustomzieDoubleDraugr(this, new DoubleDraugr())); ;
            screens.Add(Screen.custGardenOrcOmelette, new CustomizeGardenOrcOmelette(this, new GardenOrcOmelette()));
            screens.Add(Screen.custPhillyPoacher, new CustomizePhillyPoacher(this, new PhillyPoacher()));
            screens.Add(Screen.custSmokehouseSkeleton, new CustomizeSmokehouseSkeleton(this, new SmokehouseSkeleton()));
            screens.Add(Screen.custThalmorTriple, new CustomizeThalmorTriple(this, new ThalmorTriple()));
            screens.Add(Screen.custAretinoAppleJuice, new CustomizeAretinoAppleJuice(this, new AretinoAppleJuice()));
            screens.Add(Screen.custCandlehearthCoffee, new CustomizeCandlehearthCoffee(this, new CandlehearthCoffee()));
            screens.Add(Screen.custMarkarthMilk, new CustomizeMarkarthMilk(this, new MarkarthMilk()));
            screens.Add(Screen.custSailorSoda, new CustomizeSailorSoda(this, new SailorSoda()));
            screens.Add(Screen.custWarriorWater, new CustomizeWarriorWater(this, new WarriorWater()));
            screens.Add(Screen.custDragonbornWaffleFries, new CustomizeDragonbornWaffleFries(this, new DragonbornWaffleFries()));
            screens.Add(Screen.custFriedMiraak, new CustomizeFriedMiraak(this, new FriedMiraak()));
            screens.Add(Screen.custMadOtarGrits, new CustomizeMadOtarGrits(this, new MadOtarGrits()));
            screens.Add(Screen.custVokunSalad, new CustomizeVokunSalad(this, new VokunSalad()));
        }

        /// <summary>
        /// method that switches to the correct screen.
        /// </summary>
        /// <param name="screen"></param>
        public void SwitchScreen(Screen screen)
        {
            switchableContent.Child = screens[screen];
        }

    }
}
