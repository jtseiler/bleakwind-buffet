/*
 * Author: Jack Seiler
 * Class name: PhillyPoacher.cs
 * Purpose: gives details of this particular entree
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

/// <summary>
/// Adding to the namespace of entrees
/// </summary>
namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Creating an addition to the drink menu under the entree namespace
    /// </summary>
    public class PhillyPoacher : Entree, IOrderItem, INotifyPropertyChanged
    {
        public override string Description
        {
            get
            {
                return "Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.";
            }
        }

        // <summary>
        /// Property to keep track of the price
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.23;
            }
        }

        /// <summary>
        /// variable to keep track of the items calories
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 784;
            }
        }

        /// <summary>
        /// property for the choice of Sirloin, default to true
        /// </summary>
        private bool sirloin = true;
        public bool Sirloin
        {
            get { return sirloin; }
            set
            {
                sirloin = value;
                NotifyOfPropertyChange();
            }
        }

        /// <summary>
        /// property for the choice of onions, default to true
        /// </summary>
        private bool onion = true;
        public bool Onion
        {
            get { return onion; }
            set
            {
                onion = value;
                NotifyOfPropertyChange();
            }
        }

        /// <summary>
        /// property for the choice of a roll, default to true
        /// </summary>
        private bool roll = true;
        public bool Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                NotifyOfPropertyChange();
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
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");
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
