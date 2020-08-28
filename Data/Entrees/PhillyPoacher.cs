/*
 * Author: Jack Seiler
 * Class name: PhillyPoacher.cs
 * Purpose: gives details of this particular entree
 */
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Adding to the namespace of entrees
/// </summary>
namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Creating an addition to the drink menu under the entree namespace
    /// </summary>
    public class PhillyPoacher
    {
        // <summary>
        /// Property to keep track of the price
        /// </summary>
        public double Price => 7.23;

        /// <summary>
        /// variable to keep track of the items calories
        /// </summary>
        public uint Calories => 404;

        /// <summary>
        /// property for the choice of Sirloin, default to true
        /// </summary>
        public bool Sirloin { get; set; } = true;

        /// <summary>
        /// property for the choice of onions, default to true
        /// </summary>
        public bool Onion { get; set; } = true;

        /// <summary>
        /// property for the choice of a roll, default to true
        /// </summary>
        public bool Roll { get; set; } = true;

        /// <summary>
        /// special instructions should customer want any unusal additions or subractions from their item
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin;");
                if (!Onion) instructions.Add("Hold onion;");
                if (!Roll) instructions.Add("Hold roll;");
                return instructions;
            }
        }

        /// <summary>
        /// to string override giving the item.
        /// </summary>
        /// <returns>a string detailing the items specifications</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
