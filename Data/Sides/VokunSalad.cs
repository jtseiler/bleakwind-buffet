/*
 * Author: Jack Seiler
 * Class name: VokunSalad.cs
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
    public class VokunSalad
    {
        /// <summary>
        /// Creating an addition to the side menu under the sides namespace
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
                    return price = 1.28;
                }
                if (Size == Size.Large)
                {
                    return price = 1.82;
                }
                else return price = .93;
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
                    return calories = 52;
                }
                if (Size == Size.Large)
                {
                    return calories = 73;
                }
                else return calories = 41;
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
            return $"{Size} Vokun Salad";
        }
    }
}

