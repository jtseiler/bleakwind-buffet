﻿/*
 * Author: Jack Seiler
 * Class name: DragonbornWaffleFries.cs
 * Purpose: gives details of this particular side
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

/// <summary>
/// Adding to the namespace of Sides
/// </summary>
namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Creating an addition to the side menu under the sides namespace
    /// </summary>
    public class DragonbornWaffleFries
    {
        /// <summary>
        /// Property to keep track of the price
        /// </summary>
        double price;

        /// <summary>
        /// Getter for the price after customer chooses a size, default free for water
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return price = .76;
                }
                if (Size == Size.Large)
                {
                    return price = .96;
                }
                else return price = .42;
            }
        }

        /// <summary>
        /// getter and setter for the Size property set to default small
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// variable to keep track of the items calories
        /// </summary>
        uint calories;

        /// <summary>
        /// getter for the calories after customer chooses a size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return calories = 89;
                }
                if (Size == Size.Large)
                {
                    return calories = 100;
                }
                else return calories = 77;
            }
        }

        /// <summary>
        /// special instructions should customer want any unusal additions or subractions from their item
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// to string override giving the size, and the item.
        /// </summary>
        /// <returns>a string detailing the items specifications</returns>
        public override string ToString()
        {
            return @"""[Size] Dragonborn Waffle Fries"" where [Size] is ""Large"", ""Medium"", or ""Small""";
        }
    }
}