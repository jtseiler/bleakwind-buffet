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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
            AddBriarheartBurger.Click += OnAddBriarheartBurgerButtonClicked;
            AddDoubleDraugr.Click += OnAddDoubleDraugrButtonClicked;
            AddGardenOrcOmelette.Click += OnAddGardenOrcOmeletteButtonClicked;
            AddPhillyPoacher.Click += OnAddPhillyPoacherButtonClicked;
            AddSmokehouseSkeleton.Click += OnAddSmokehouseSkeletonButtonClicked;
            AddThalmorTriple.Click += OnAddThalmorTripleButtonClicked;
            AddThugsTBone.Click += OnAddThugsTBoneButtonClicked;
        }

        /// <summary>
        /// Adds Briarheart burger to the Order list
        /// </summary>
        /// <param name="sender">oject created by click event</param>
        /// <param name="e">routed event</param>
        void OnAddBriarheartBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new BriarheartBurger());
        }

        /// <summary>
        /// Adds Double Draugr to the Order list
        /// </summary>
        /// <param name="sender">oject created by click event</param>
        /// <param name="e">routed event</param>
        void OnAddDoubleDraugrButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new DoubleDraugr());
        }

        /// <summary>
        /// Adds Garden Orc Omelette to the Order list
        /// </summary>
        /// <param name="sender">oject created by click event</param>
        /// <param name="e">routed event</param>
        void OnAddGardenOrcOmeletteButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new GardenOrcOmelette());
        }

        /// <summary>
        /// Adds Philly Poacher to the Order list
        /// </summary>
        /// <param name="sender">oject created by click event</param>
        /// <param name="e">routed event</param>
        void OnAddPhillyPoacherButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PhillyPoacher());
        }

        /// <summary>
        /// Adds Thalmor Triple to the Order list
        /// </summary>
        /// <param name="sender">oject created by click event</param>
        /// <param name="e">routed event</param>
        void OnAddThalmorTripleButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new ThalmorTriple());
        }

        /// <summary>
        /// Adds Smokehouse Skeleton to the Order list
        /// </summary>
        /// <param name="sender">oject created by click event</param>
        /// <param name="e">routed event</param>
        void OnAddSmokehouseSkeletonButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new SmokehouseSkeleton());
        }

        /// <summary>
        /// Adds Thugs T Bone to the Order list
        /// </summary>
        /// <param name="sender">oject created by click event</param>
        /// <param name="e">routed event</param>
        void OnAddThugsTBoneButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new ThugsTBone());
        }
    }
}
