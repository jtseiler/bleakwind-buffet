/*
 * Author: Zachery Brunner
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {   
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDragur dd = new DoubleDragur();
            Assert.True(dd.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDragur dd = new DoubleDragur();
            Assert.True(dd.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDragur dd = new DoubleDragur();
            Assert.True(dd.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDragur dd = new DoubleDragur();
            Assert.True(dd.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDragur dd = new DoubleDragur();
            Assert.True(dd.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDragur dd = new DoubleDragur();
            Assert.True(dd.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDragur dd = new DoubleDragur();
            Assert.True(dd.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDragur dd = new DoubleDragur();
            Assert.True(dd.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDragur dd = new DoubleDragur();
            dd.Bun = true;
            Assert.True(dd.Bun);
            dd.Bun = false;
            Assert.False(dd.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDragur dd = new DoubleDragur();
            dd.Ketchup = true;
            Assert.True(dd.Ketchup);
            dd.Ketchup = false;
            Assert.False(dd.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDragur dd = new DoubleDragur();
            dd.Mustard = true;
            Assert.True(dd.Mustard);
            dd.Mustard = false;
            Assert.False(dd.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDragur dd = new DoubleDragur();
            dd.Pickle = true;
            Assert.True(dd.Pickle);
            dd.Pickle = false;
            Assert.False(dd.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDragur dd = new DoubleDragur();
            dd.Cheese = true;
            Assert.True(dd.Cheese);
            dd.Cheese = false;
            Assert.False(dd.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDragur dd = new DoubleDragur();
            dd.Tomato = true;
            Assert.True(dd.Tomato);
            dd.Tomato = false;
            Assert.False(dd.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDragur dd = new DoubleDragur();
            dd.Lettuce = true;
            Assert.True(dd.Lettuce);
            dd.Lettuce = false;
            Assert.False(dd.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDragur dd = new DoubleDragur();
            dd.Mayo = true;
            Assert.True(dd.Mayo);
            dd.Mayo = false;
            Assert.False(dd.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDragur dd = new DoubleDragur();
            Assert.Equal(7.32, dd.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDragur dd = new DoubleDragur();
            Assert.Equal((uint)843, dd.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDragur dd = new DoubleDragur();
            dd.Bun = includeBun;
            if (!includeBun) Assert.Contains("Hold bun", dd.SpecialInstructions);
            dd.Ketchup = includeKetchup;
            if (!includeKetchup) Assert.Contains("Hold ketchup", dd.SpecialInstructions);
            dd.Mustard = includeMustard;
            if (!includeMustard) Assert.Contains("Hold mustard", dd.SpecialInstructions);
            dd.Pickle = includePickle;
            if (!includePickle) Assert.Contains("Hold pickle", dd.SpecialInstructions);
            dd.Cheese = includeCheese;
            if (!includeCheese) Assert.Contains("Hold cheese", dd.SpecialInstructions);
            dd.Tomato = includeTomato;
            if (!includeTomato) Assert.Contains("Hold tomato", dd.SpecialInstructions);
            dd.Lettuce = includeLettuce;
            if (!includeLettuce) Assert.Contains("Hold lettuce", dd.SpecialInstructions);
            dd.Mayo = includeMayo;
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDragur dd = new DoubleDragur();
            Assert.Equal("Double Draugr", dd.ToString());
        }
    }
}