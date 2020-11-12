/*
 * Author: Jack Seiler
 * Class name: SmokehouseSkeleton.cs
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
    public class SmokehouseSkeleton : Entree, IOrderItem, INotifyPropertyChanged
    {
        public override string Description
        {
            get
            {
                return "Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.";
            }
        }

        /// <summary>
        /// Property to keep track of the price
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.62;
            }
        }

        /// <summary>
        /// variable to keep track of the items calories
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 602;
            }
        }

        /// <summary>
        /// property for the choice of sausage, default set to true
        /// </summary>
        private bool sausageLink = true;
        public bool SausageLink
        {
            get { return sausageLink; }
            set
            {
                sausageLink = value;
                NotifyOfPropertyChange();
            }
        }

        /// <summary>
        /// property for the choice of eggs, default set to true
        /// </summary>
        private bool egg = true;
        public bool Egg
        {
            get { return egg; }
            set
            {
                egg = value;
                NotifyOfPropertyChange();
            }
        }

        /// <summary>
        /// property for the choice of hashbrowns, default set to true
        /// </summary>
        private bool hashbrowns = true;
        public bool HashBrowns
        {
            get { return hashbrowns; }
            set
            {
                hashbrowns = value;
                NotifyOfPropertyChange();
            }
        }

        /// <summary>
        /// property for the choice of pancakes, default set to true
        /// </summary>
        private bool pancake = true;
        public bool Pancake
        {
            get { return pancake; }
            set
            {
                pancake = value;
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
