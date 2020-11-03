using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTests
    {
        [Fact]
        public void AddingComboShouldForcePriceChange()
        {
            var bb = new BriarheartBurger();
            var vs = new VokunSalad();
            var mm = new MarkarthMilk();

            Combo combo = new Combo(bb, vs, mm);

            Assert.PropertyChanged(combo, "Price", () => combo.Entree = new DoubleDraugr());
            Assert.PropertyChanged(combo, "Price", () => combo.Side = new FriedMiraak());
            Assert.PropertyChanged(combo, "Price", () => combo.Drink = new AretinoAppleJuice());
        }

        [Fact]
        public void AddingComboShouldForceCalorieChange()
        {
            var bb = new BriarheartBurger();
            var vs = new VokunSalad();
            var mm = new MarkarthMilk();

            Combo combo = new Combo(bb, vs, mm);

            Assert.PropertyChanged(combo, "Calories", () => combo.Entree = new DoubleDraugr());
            Assert.PropertyChanged(combo, "Calories", () => combo.Side = new FriedMiraak());
            Assert.PropertyChanged(combo, "Calories", () => combo.Drink = new AretinoAppleJuice());
        }

        /*
        [Fact]
        public void AddingComboShouldForceSizeChange()
        {
            var bb = new BriarheartBurger();
            var vs = new VokunSalad();
            var mm = new MarkarthMilk();

            Combo combo = new Combo(bb, vs, mm);

            mm.Size = Data.Enums.Size.Small;
            vs.Size = Data.Enums.Size.Large;

            Assert.PropertyChanged(combo, "Size", () => combo.Drink.Size = Size.Large);
            Assert.PropertyChanged(combo, "Size", () => combo.Side.Size = Size.Medium);
        }
        */
    }
}
