/*
 * Author: Jack Seiler
 * Class name: DoubleDraugr.cs
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
    public class DoubleDragur
    {
        /// <summary>
        /// Property to keep track of the price
        /// </summary>
        public double Price => 7.32;

        /// <summary>
        /// variable to keep track of the items calories
        /// </summary>
        public uint Calories => 843;

        /// <summary>
        /// property for the choice of ketchup, default to true
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// property for the choice of a bun, default to true
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// property for the choice of a bun, default to true
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// property for the choice of pickles, default to true
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// property for the choice of cheese, default to true
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// property for the choice of tomatoes, default to true
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// property for the choice of lettuce, default to true
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// property for the choice of mayo, default to true
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// special instructions should customer want any unusal additions or subractions from their item
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun;");
                if (!Ketchup) instructions.Add("Hold ketchup;");
                if (!Mustard) instructions.Add("Hold mustard;");
                if (!Cheese) instructions.Add("Hold cheese;");
                if (!Pickle) instructions.Add("Hold pickle;");
                if (!Tomato) instructions.Add("Hold tomato;");
                if (!Lettuce) instructions.Add("Hold lettuce;");
                if (!Mayo) instructions.Add("Hold mayo;");
                return instructions;
            }
        }

        /// <summary>
        /// to string override giving the item.
        /// </summary>
        /// <returns>a string detailing the items specifications</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
