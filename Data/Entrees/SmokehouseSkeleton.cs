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
    public class SmokehouseSkeleton : Entree, IOrderItem
    {
        /// <summary>
        /// Property to keep track of the price
        /// </summary>
        public override double Price => 5.62;

        /// <summary>
        /// variable to keep track of the items calories
        /// </summary>
        public override uint Calories => 602;

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
        public bool HashBrowns { get; set; } = true;

        /// <summary>
        /// property for the choice of pancakes, default set to true
        /// </summary>
        public bool Pancake { get; set; } = true;

        /// <summary>
        /// special instructions should customer want any unusal additions or subractions from their item
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
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
