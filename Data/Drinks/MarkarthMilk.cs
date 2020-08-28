﻿/*
 * Author: Jack Seiler
 * class name: MarkarthMilk.cs
 * Purpose: gives details of this particular drink
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

/// <summary>
/// Adding to the namespace of Drinks
/// </summary>
namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Creating an addition to the drink menu under the drink namespace
    /// </summary>
    public class MarkarthMilk
    {
        /// <summary>
        /// Property to keep track of the price
        /// </summary>
        double price;

        /// <summary>
        /// Getter for the price after customer chooses a size
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return price = 1.11;
                }
                if (Size == Size.Large)
                {
                    return price = 1.22;
                }
                else return price = 1.05;
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
                    return calories = 72;
                }
                if (Size == Size.Large)
                {
                    return calories = 93;
                }
                else return calories = 56;
            }
        }

        /// <summary>
        /// property for choice of ice default to false
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// special instructions should customer want any unusal additions or subractions from their item
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// to string override giving the size, and the item.
        /// </summary>
        /// <returns>a string detailing the items specifications</returns>
        public override string ToString()
        {
            return @"""[Size] Markarth Milk"" where [Size] is ""Large"", ""Medium"", or ""Small""";
        }
    }
}
