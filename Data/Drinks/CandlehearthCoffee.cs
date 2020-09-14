/*
 * Author: Jack Seiler
 * Class name: WarriorWater.cs
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
    public class CandlehearthCoffee : Drink, IOrderItem
    {
        /// <summary>
        /// Property to keep track of the price
        /// </summary>
        double price;

        /// <summary>
        /// Getter for the price after customer chooses a size
        /// </summary>
        public  override double Price
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return price = 1.25;
                }
                if (Size == Size.Large)
                {
                    return price = 1.75;
                }
                else return price = .75;
            }
        }

        /// <summary>
        /// variable to keep track of the items calories
        /// </summary>
        uint calories;

        /// <summary>
        /// getter for the calories after customer chooses a size
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return calories = 10;
                }
                if (Size == Size.Large)
                {
                    return calories = 20;
                }
                else return calories = 7;
            }
        }

        /// <summary>
        /// property for choice of ice default to false
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// Property giving choice of added cream, default to false
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Property giving choice of decaf, default to fault
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// special instructions should customer want any unusal additions or subractions from their item
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (RoomForCream) instructions.Add("Add cream");
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
            if (Decaf)
            {
                return Size + " Decaf Candlehearth Coffee";
            }
            else return Size + " Candlehearth Coffee";
        }
    }
}
