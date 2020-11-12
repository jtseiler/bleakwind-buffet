/*
 * Author: Jack Seiler
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ShouldReturnCorrectDescription()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal("Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.", ss.Description);
        }

        [Fact]
        public void ShouldBeAINotifyPropertyChanged()
        {
            var ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ss);
        }

        [Fact]
        public void ChangingSausageLinkNotifiesSausageLinkProperty()
        {
            var ss = new SmokehouseSkeleton();

            Assert.PropertyChanged(ss, "SausageLink", () =>
            {
                ss.SausageLink = true;
            });

            Assert.PropertyChanged(ss, "SausageLink", () =>
            {
                ss.SausageLink = false;
            });
        }

        [Fact]
        public void ChangingHashBrownsNotifiesHashbrownsProperty()
        {
            var ss = new SmokehouseSkeleton();

            Assert.PropertyChanged(ss, "HashBrowns", () =>
            {
                ss.HashBrowns = true;
            });

            Assert.PropertyChanged(ss, "HashBrowns", () =>
            {
                ss.HashBrowns = false;
            });
        }

        [Fact]
        public void ChangingPancakeNotifiesPancakeProperty()
        {
            var ss = new SmokehouseSkeleton();

            Assert.PropertyChanged(ss, "Pancake", () =>
            {
                ss.Pancake = true;
            });

            Assert.PropertyChanged(ss, "Pancake", () =>
            {
                ss.Pancake = false;
            });
        }

        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            var ss = new SmokehouseSkeleton();

            Assert.PropertyChanged(ss, "Egg", () =>
            {
                ss.Egg = true;
            });

            Assert.PropertyChanged(ss, "Egg", () =>
            {
                ss.Egg = false;
            });
        }

        [Fact]
        public void ShouldBeAIOrderItem()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(ss);
        }

        [Fact]
        public void ShouldBeAEntree()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(ss);
        }

        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = true;
            Assert.True(ss.SausageLink);
            ss.SausageLink = false;
            Assert.False(ss.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Egg = true;
            Assert.True(ss.Egg);
            ss.Egg = false;
            Assert.False(ss.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.HashBrowns = true;
            Assert.True(ss.HashBrowns);
            ss.HashBrowns = false;
            Assert.False(ss.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Pancake = true;
            Assert.True(ss.Pancake);
            ss.Pancake = false;
            Assert.False(ss.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal(5.62, ss.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal((uint)602, ss.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = includeSausage;
            if (!includeSausage) Assert.Contains("Hold sausage", ss.SpecialInstructions);
            ss.Egg = includeEgg;
            if (!includeEgg) Assert.Contains("Hold eggs", ss.SpecialInstructions);
            ss.HashBrowns = includeHashbrowns;
            if (!includeHashbrowns) Assert.Contains("Hold hash browns", ss.SpecialInstructions);
            ss.Pancake = includePancake;
            if (!includePancake) Assert.Contains("Hold pancakes", ss.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", ss.ToString());
        }
    }
}