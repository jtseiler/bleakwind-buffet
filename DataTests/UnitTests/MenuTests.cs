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
        [Fact]
        public void EntreesContainAllEntreeItems()
        {
            var entrees = Menu.Entrees();
            foreach (IOrderItem i in entrees)
            {
                Assert.Contains(i, entrees);
            }
        }

        [Fact]
        public void SidesContainAllSideItems()
        {
            var sides = Menu.Sides();
            foreach (IOrderItem i in sides)
            {
                Assert.Contains(i, sides);
            }
        }

        [Fact]
        public void DrinksContainAllDrinkItems()
        {
            var drinks = Menu.Drinks();
            foreach (IOrderItem i in drinks)
            {
                Assert.Contains(i, drinks);
            }
        }

        [Fact]
        public void AllContainAllIOrderItems()
        {
            var all = Menu.FullMenu();
            foreach (IOrderItem i in all)
            {
                Assert.Contains(i, all);
            }
        }
    }
}