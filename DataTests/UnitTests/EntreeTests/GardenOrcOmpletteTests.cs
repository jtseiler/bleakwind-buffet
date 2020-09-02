/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelete oo = new GardenOrcOmelete();
            Assert.True(oo.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelete oo = new GardenOrcOmelete();
            Assert.True(oo.Mushroom);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelete oo = new GardenOrcOmelete();
            Assert.True(oo.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelete oo = new GardenOrcOmelete();
            Assert.True(oo.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelete oo = new GardenOrcOmelete();
            oo.Broccoli = true;
            Assert.True(oo.Broccoli);
            oo.Broccoli = false;
            Assert.False(oo.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelete oo = new GardenOrcOmelete();
            oo.Mushroom = true;
            Assert.True(oo.Mushroom);
            oo.Mushroom = false;
            Assert.False(oo.Mushroom);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelete oo = new GardenOrcOmelete();
            oo.Tomato = true;
            Assert.True(oo.Tomato);
            oo.Tomato = false;
            Assert.False(oo.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelete oo = new GardenOrcOmelete();
            oo.Cheddar = true;
            Assert.True(oo.Cheddar);
            oo.Cheddar = false;
            Assert.False(oo.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelete oo = new GardenOrcOmelete();
            Assert.Equal(4.57, oo.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelete oo = new GardenOrcOmelete();
            Assert.Equal((uint)404, oo.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelete oo = new GardenOrcOmelete();
            oo.Broccoli = includeBroccoli;
            if (!includeBroccoli) Assert.Contains("Hold broccoli", oo.SpecialInstructions);
            oo.Mushroom = includeMushrooms;
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", oo.SpecialInstructions);
            oo.Tomato = includeTomato;
            if (!includeTomato) Assert.Contains("Hold tomato", oo.SpecialInstructions);
            oo.Cheddar = includeCheddar;
            if (!includeCheddar) Assert.Contains("Hold cheddar", oo.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelete oo = new GardenOrcOmelete();
            Assert.Equal("Garden Orc Omelette", oo.ToString());
        }
    }
}