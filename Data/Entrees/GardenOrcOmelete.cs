/*
 * Author: Jack Seiler
 * Class name: GardenOrcOmelete.cs
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
    public class GardenOrcOmelete
    {
        /// <summary>
        /// Property to keep track of the price
        /// </summary>
        public double Price => 4.57;

        /// <summary>
        /// variable to keep track of the items calories
        /// </summary>
        public uint Calories => 404;

        /// <summary>
        /// property for the choice of broccoli, default to true
        /// </summary>
        public bool Broccoli { get; set; } = true;

        /// <summary>
        /// property for the choice of mushroom, default to true
        /// </summary>
        public bool Mushroom { get; set; } = true;

        /// <summary>
        /// property for the choice of tomatoes, default to true
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// property for the choice of cheddar, default to true
        /// </summary>
        public bool Cheddar { get; set; } = true;

        /// <summary>
        /// special instructions should customer want any unusal additions or subractions from their item
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli;");
                if (!Mushroom) instructions.Add("Hold mushroom;");
                if (!Tomato) instructions.Add("Hold tomato;");
                if (!Cheddar) instructions.Add("Hold cheddar;");
                return instructions;
            }
        }

        /// <summary>
        /// to string override giving the item.
        /// </summary>
        /// <returns>a string detailing the items specifications</returns>
        public override string ToString()
        {
            return "Garden Orc Omelete";
        }
    }
}
