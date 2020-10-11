/*
 * Author: Jack Seiler
 * Class name: BriarheartBurger.cs
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
    public class BriarheartBurger : Entree, IOrderItem
    {

        /// <summary>
        /// Property to keep track of the price
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.32;
            }
        }

        /// <summary>
        /// variable to keep track of the items calories
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 743;
            }
        }

        /// <summary>
        /// property for the choice of ketchup, default to true
        /// </summary>
        private bool ketchup = true;
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                ketchup = value;
                NotifyOfPropertyChange("Ketchup");
            }
        }

        /// <summary>
        /// property for the choice of a bun, default to true
        /// </summary>
        private bool bun = true;
        public bool Bun
        {
            get { return bun; }
            set
            {
                bun = value;
                NotifyOfPropertyChange("Bun");
            }
        }

        /// <summary>
        /// property for the choice of a bun, default to true
        /// </summary>
        private bool mustard = true;
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                mustard = value;
                NotifyOfPropertyChange("Mustard");
            }
        }

        /// <summary>
        /// property for the choice of pickles, default to true
        /// </summary>
        private bool pickle = true;
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                NotifyOfPropertyChange("Pickle");
            }
        }

        /// <summary>
        /// property for the choice of cheese, default to true
        /// </summary>
        private bool cheese = true;
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                cheese = value;
                NotifyOfPropertyChange("Cheese");
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
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Pickle) instructions.Add("Hold pickle");
                return instructions;
            }
        }

        /// <summary>
        /// to string override giving the item.
        /// </summary>
        /// <returns>a string detailing the items specifications</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
