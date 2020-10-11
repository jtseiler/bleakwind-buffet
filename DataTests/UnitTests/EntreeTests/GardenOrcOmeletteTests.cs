/*
 * Author: Jack Seiler
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldBeAINotifyPropertyChanged()
        {
            var goc = new GardenOrcOmelette();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(goc);
        }

        [Fact]
        public void ChangingBroccoliNotifiesBroccoliProperty()
        {
            var go = new GardenOrcOmelette();

            Assert.PropertyChanged(go, "Broccoli", () =>
            {
                go.Broccoli = true;
            });

            Assert.PropertyChanged(go, "Broccoli", () =>
            {
                go.Broccoli = false;
            });
        }

        [Fact]
        public void ChangingMushroomsNotifiesMushroomsProperty()
        {
            var go = new GardenOrcOmelette();

            Assert.PropertyChanged(go, "Mushrooms", () =>
            {
                go.Mushrooms = true;
            });

            Assert.PropertyChanged(go, "Mushrooms", () =>
            {
                go.Mushrooms = false;
            });
        }

        [Fact]
        public void ChangingCheddarNotifiesCheddarProperty()
        {
            var go = new GardenOrcOmelette();

            Assert.PropertyChanged(go, "Cheddar", () =>
            {
                go.Cheddar = true;
            });

            Assert.PropertyChanged(go, "Cheddar", () =>
            {
                go.Cheddar = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var go = new GardenOrcOmelette();

            Assert.PropertyChanged(go, "Tomato", () =>
            {
                go.Tomato = true;
            });

            Assert.PropertyChanged(go, "Tomato", () =>
            {
                go.Tomato = false;
            });
        }

        [Fact]
        public void ShouldBeAIOrderItem()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(oo);
        }

        [Fact]
        public void ShouldBeAEntree()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(oo);
        }

        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.True(oo.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.True(oo.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.True(oo.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.True(oo.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            oo.Broccoli = true;
            Assert.True(oo.Broccoli);
            oo.Broccoli = false;
            Assert.False(oo.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            oo.Mushrooms = true;
            Assert.True(oo.Mushrooms);
            oo.Mushrooms = false;
            Assert.False(oo.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            oo.Tomato = true;
            Assert.True(oo.Tomato);
            oo.Tomato = false;
            Assert.False(oo.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            oo.Cheddar = true;
            Assert.True(oo.Cheddar);
            oo.Cheddar = false;
            Assert.False(oo.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.Equal(4.57, oo.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.Equal((uint)404, oo.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            oo.Broccoli = includeBroccoli;
            if (!includeBroccoli) Assert.Contains("Hold broccoli", oo.SpecialInstructions);
            oo.Mushrooms = includeMushrooms;
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", oo.SpecialInstructions);
            oo.Tomato = includeTomato;
            if (!includeTomato) Assert.Contains("Hold tomato", oo.SpecialInstructions);
            oo.Cheddar = includeCheddar;
            if (!includeCheddar) Assert.Contains("Hold cheddar", oo.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette oo = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", oo.ToString());
        }
    }
}