/*
 * Author: Jack Seiler
 * Class name: VokunSalad.cs
 * Purpose: gives details of this particular side
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public class VokunSalad : Side, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Creating an addition to the side menu under the sides namespace
        /// </summary>
        double price;

        /// <summary>
        /// Getter for the price after customer chooses a size, default free for water
        /// </summary>
        public  override double Price
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
        public override List<string> SpecialInstructions
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

