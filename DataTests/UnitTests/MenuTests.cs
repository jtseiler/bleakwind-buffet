/*
 * Author: Jack Seiler
 * Class: MenuTests.cs
 * Purpose: Test the MenuTests.cs class in the Data library
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using BleakwindBuffet.Data;
using System.Linq;

namespace BleakwindBuffet.DataTests
{
    public class MenuTests
    {
        [Theory]
        [InlineData("Briarheart Burger")]
        [InlineData("Double Draugr")]
        [InlineData("Garden Orc Omelette")]
        [InlineData("Philly Poacher")]
        [InlineData("Smokehouse Skeleton")]
        [InlineData("Thalmor Triple")]
        [InlineData("Thugs T-Bone")]
        public void EntreesContainAllEntreeItems(string s)
        {
            List<IOrderItem> allEntrees = new List<IOrderItem>();
            allEntrees = (List<IOrderItem>)Menu.Entrees();
            Assert.Contains<IOrderItem>(allEntrees, (item) => item.ToString().Equals(s));
        }

        [Theory]
        [InlineData("Small Dragonborn Waffle Fries")]
        [InlineData("Medium Dragonborn Waffle Fries")]
        [InlineData("Large Dragonborn Waffle Fries")]
        [InlineData("Small Fried Miraak")]
        [InlineData("Medium Fried Miraak")]
        [InlineData("Large Fried Miraak")]
        [InlineData("Small Mad Otar Grits")]
        [InlineData("Medium Mad Otar Grits")]
        [InlineData("Large Mad Otar Grits")]
        [InlineData("Small Vokun Salad")]
        [InlineData("Medium Vokun Salad")]
        [InlineData("Large Vokun Salad")]
        public void SidesContainAllSideItems(string s)
        {
            List<IOrderItem> allSides = new List<IOrderItem>();
            allSides = (List<IOrderItem>)Menu.Sides();
            Assert.Contains<IOrderItem>(allSides, (item) => item.ToString().Equals(s));
        }

        [Theory]
        [InlineData("Small Aretino Apple Juice")]
        [InlineData("Medium Aretino Apple Juice")]
        [InlineData("Large Aretino Apple Juice")]
        [InlineData("Small Candlehearth Coffee")]
        [InlineData("Medium Candlehearth Coffee")]
        [InlineData("Large Candlehearth Coffee")]
        [InlineData("Small Markarth Milk")]
        [InlineData("Medium Markarth Milk")]
        [InlineData("Large Markarth Milk")]
        [InlineData("Small Cherry Sailor Soda")]
        [InlineData("Medium Cherry Sailor Soda")]
        [InlineData("Large Cherry Sailor Soda")]
        [InlineData("Small Blackberry Sailor Soda")]
        [InlineData("Medium Blackberry Sailor Soda")]
        [InlineData("Large Blackberry Sailor Soda")]
        [InlineData("Small Grapefruit Sailor Soda")]
        [InlineData("Medium Grapefruit Sailor Soda")]
        [InlineData("Large Grapefruit Sailor Soda")]
        [InlineData("Small Lemon Sailor Soda")]
        [InlineData("Medium Lemon Sailor Soda")]
        [InlineData("Large Lemon Sailor Soda")]
        [InlineData("Small Peach Sailor Soda")]
        [InlineData("Medium Peach Sailor Soda")]
        [InlineData("Large Peach Sailor Soda")]
        [InlineData("Small Watermelon Sailor Soda")]
        [InlineData("Medium Watermelon Sailor Soda")]
        [InlineData("Large Watermelon Sailor Soda")]
        [InlineData("Small Warrior Water")]
        [InlineData("Medium Warrior Water")]
        [InlineData("Large Warrior Water")]
        public void DrinksContainAllDrinkItems(string s)
        {
            List<IOrderItem> allDrinks = new List<IOrderItem>();
            allDrinks = (List<IOrderItem>)Menu.Drinks();
            Assert.Contains<IOrderItem>(allDrinks, (item) => item.ToString().Equals(s));
        }

        [Theory]
        [InlineData("Small Aretino Apple Juice")]
        [InlineData("Medium Aretino Apple Juice")]
        [InlineData("Large Aretino Apple Juice")]
        [InlineData("Small Candlehearth Coffee")]
        [InlineData("Medium Candlehearth Coffee")]
        [InlineData("Large Candlehearth Coffee")]
        [InlineData("Small Markarth Milk")]
        [InlineData("Medium Markarth Milk")]
        [InlineData("Large Markarth Milk")]
        [InlineData("Small Cherry Sailor Soda")]
        [InlineData("Medium Cherry Sailor Soda")]
        [InlineData("Large Cherry Sailor Soda")]
        [InlineData("Small Blackberry Sailor Soda")]
        [InlineData("Medium Blackberry Sailor Soda")]
        [InlineData("Large Blackberry Sailor Soda")]
        [InlineData("Small Grapefruit Sailor Soda")]
        [InlineData("Medium Grapefruit Sailor Soda")]
        [InlineData("Large Grapefruit Sailor Soda")]
        [InlineData("Small Lemon Sailor Soda")]
        [InlineData("Medium Lemon Sailor Soda")]
        [InlineData("Large Lemon Sailor Soda")]
        [InlineData("Small Peach Sailor Soda")]
        [InlineData("Medium Peach Sailor Soda")]
        [InlineData("Large Peach Sailor Soda")]
        [InlineData("Small Watermelon Sailor Soda")]
        [InlineData("Medium Watermelon Sailor Soda")]
        [InlineData("Large Watermelon Sailor Soda")]
        [InlineData("Small Warrior Water")]
        [InlineData("Medium Warrior Water")]
        [InlineData("Large Warrior Water")]
        [InlineData("Briarheart Burger")]
        [InlineData("Double Draugr")]
        [InlineData("Garden Orc Omelette")]
        [InlineData("Philly Poacher")]
        [InlineData("Smokehouse Skeleton")]
        [InlineData("Thalmor Triple")]
        [InlineData("Thugs T-Bone")]
        [InlineData("Small Dragonborn Waffle Fries")]
        [InlineData("Medium Dragonborn Waffle Fries")]
        [InlineData("Large Dragonborn Waffle Fries")]
        [InlineData("Small Fried Miraak")]
        [InlineData("Medium Fried Miraak")]
        [InlineData("Large Fried Miraak")]
        [InlineData("Small Mad Otar Grits")]
        [InlineData("Medium Mad Otar Grits")]
        [InlineData("Large Mad Otar Grits")]
        [InlineData("Small Vokun Salad")]
        [InlineData("Medium Vokun Salad")]
        [InlineData("Large Vokun Salad")]
        public void AllContainAllIOrderItems(string s)
        {
            List<IOrderItem> fullMenu = new List<IOrderItem>();
            fullMenu = (List<IOrderItem>)Menu.FullMenu();
            Assert.Contains<IOrderItem>(fullMenu, (item) => item.ToString().Equals(s));
        }

        [Fact]
        public void SearchFilterTest()
        {
            IEnumerable<IOrderItem> test = Menu.Search(Menu.FullMenu(), "Briarheart");
            IEnumerable<IOrderItem> all = Menu.FullMenu();
            bool contains = false;
            foreach (IOrderItem i in test)
            {
                if (i.ToString().Contains("Briarheart", StringComparison.InvariantCultureIgnoreCase))
                {
                    contains = true;
                }
            }
            Assert.True(contains);
        }

        [Fact]
        public void SearchFilterTestNull()
        {
            IEnumerable<IOrderItem> test = Menu.Search(Menu.FullMenu(), "");
            IEnumerable<IOrderItem> all = Menu.FullMenu();
            Assert.Equal<int>(all.Count(), test.Count());
        }

        [Fact]
        public void CategoryFilterTestNull()
        {
            IEnumerable<IOrderItem> test = Menu.FilterByCategory(Menu.FullMenu(), null);
            IEnumerable<IOrderItem> all = Menu.FullMenu();
            Assert.Equal<int>(all.Count(), test.Count());
        }

        [Fact]
        public void PriceFilterTestNull()
        {
            IEnumerable<IOrderItem> test = Menu.FilterByPrice(Menu.FullMenu(), null, null);
            IEnumerable<IOrderItem> all = Menu.FullMenu();
            Assert.Equal<int>(all.Count(), test.Count());
        }

        [Fact]
        public void CalorieFilterTestNull()
        {
            IEnumerable<IOrderItem> test = Menu.FilterByCalories(Menu.FullMenu(), null, null);
            IEnumerable<IOrderItem> all = Menu.FullMenu();
            Assert.Equal<int>(all.Count(), test.Count());
        }

        [Fact]
        public void CategoryFilterTest()
        {
            string[] category = new string[] { "Entrees" };
            IEnumerable<IOrderItem> test = Menu.FilterByCategory(Menu.FullMenu(), category);
            Assert.Equal<int>(7, test.Count());
        }

        [Fact]
        public void PriceMinFilterTest()
        {
            IEnumerable<IOrderItem> test = Menu.FilterByPrice(Menu.FullMenu(), 0, null);
            IEnumerable<IOrderItem> all = Menu.FullMenu();
            Assert.Equal<int>(all.Count(), test.Count());
        }

        [Fact]
        public void PriceMaxFilterTest()
        {
            IEnumerable<IOrderItem> test = Menu.FilterByPrice(Menu.FullMenu(), null, 0);
            Assert.Equal<int>(3, test.Count());
        }

        [Fact]
        public void CalorieMinFilterTest()
        {
            IEnumerable<IOrderItem> test = Menu.FilterByCalories(Menu.FullMenu(), 0, null);
            IEnumerable<IOrderItem> all = Menu.FullMenu();
            Assert.Equal<int>(all.Count(), test.Count());
        }

        [Fact]
        public void CalorieMaxFilterTest()
        {
            IEnumerable<IOrderItem> test = Menu.FilterByCalories(Menu.FullMenu(), null, 0);
            IEnumerable<IOrderItem> all = Menu.FullMenu();
            bool contains = false;
            foreach (IOrderItem i in test)
            {
                if (i.ToString().Contains("water", StringComparison.InvariantCultureIgnoreCase))
                {
                    contains = true;
                }
            }
            Assert.True(contains);
        }
    }
}