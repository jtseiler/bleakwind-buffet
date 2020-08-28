/*
 * Author: Jack Seiler
 * Class name: SmokehouseSkeleton.cs
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
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// Property to keep track of the price
        /// </summary>
        public double Price => 5.62;

        /// <summary>
        /// variable to keep track of the items calories
        /// </summary>
        public uint Calories => 602;

        /// <summary>
        /// property for the choice of sausage, default set to true
        /// </summary>
        public bool SausageLink { get; set; } = true;

        /// <summary>
        /// property for the choice of eggs, default set to true
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// property for the choice of hashbrowns, default set to true
        /// </summary>
        public bool Hashbrowns { get; set; } = true;

        /// <summary>
        /// property for the choice of pancakes, default set to true
        /// </summary>
        public bool Pancake { get; set; } = true;

        /// <summary>
        /// special instructions should customer want any unusal additions or subractions from their item
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sauasage;");
                if (!Egg) instructions.Add("Hold egg;");
                if (!Hashbrowns) instructions.Add("Hold hashbrown;");
                if (!Pancake) instructions.Add("Hold pancakes;");
                return instructions;
            }
        }

        /// <summary>
        /// to string override giving the item.
        /// </summary>
        /// <returns>a string detailing the items specifications</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
