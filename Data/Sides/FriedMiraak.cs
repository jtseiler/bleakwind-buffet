/*
 * Author: Jack Seiler
 * Class name: FfriedMiraak.cs
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
    public class FriedMiraak : Side, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Property to keep track of the price
        /// </summary>
        double price;

        /// <summary>
        /// Getter for the price after customer chooses a size, default free for water
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return price = 2.01;
                }
                if (Size == Size.Large)
                {
                    return price = 2.88;
                }
                else return price = 1.78;
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
                    return calories = 236;
                }
                if (Size == Size.Large)
                {
                    return calories = 306;
                }
                else return calories = 151;
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
            return $"{Size} Fried Miraak";
        }
    }
}
