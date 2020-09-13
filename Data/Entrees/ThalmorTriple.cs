/*
 * Author: Jack Seiler
 * Class name: ThalmorTriple.cs
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
    public class ThalmorTriple : Entree
    {
        /// <summary>
        /// Property to keep track of the price
        /// </summary>
        public override double Price => 8.32;

        /// <summary>
        /// variable to keep track of the items calories
        /// </summary>
        public override uint Calories => 943;

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
        /// property for the choice of bacon, default to true
        /// </summary>
        public bool Bacon { get; set; } = true;
       
        /// <summary>
        /// property for the choice of eggs, default to true
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// special instructions should customer want any unusal additions or subractions from their item
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Mustard) instructions.Add("Hold tomato");
                if (!Cheese) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                if (!Bacon) instructions.Add("Hold bacon"); 
                if (!Egg) instructions.Add("Hold egg");
                return instructions;
            }
        }

        /// <summary>
        /// to string override giving the item.
        /// </summary>
        /// <returns>a string detailing the items specifications</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
