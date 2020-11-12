/*
 * Author: Jack Seiler
 * Class name: GardenOrcOmelete.cs
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
    public class GardenOrcOmelette : Entree, IOrderItem, INotifyPropertyChanged
    {
        public override string Description
        {
            get
            {
                return "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";
            }
        }

        /// <summary>
        /// Property to keep track of the price
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.57;
            }
        }

        /// <summary>
        /// variable to keep track of the items calories
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 404;
            }
        }

        /// <summary>
        /// property for the choice of broccoli, default to true
        /// </summary>
        private bool broccoli = true;
        public bool Broccoli
        {
            get { return broccoli; }
            set
            {
                broccoli = value;
                NotifyOfPropertyChange();
            }
        }

        /// <summary>
        /// property for the choice of mushroom, default to true
        /// </summary>
        private bool mushrooms = true;
        public bool Mushrooms
        {
            get { return mushrooms; }
            set
            {
                mushrooms = value;
                NotifyOfPropertyChange();
            }
        }

        /// <summary>
        /// property for the choice of tomatoes, default to true
        /// </summary>
        private bool tomato = true;
        public bool Tomato
        {
            get { return tomato; }
            set
            {
                tomato = value;
                NotifyOfPropertyChange();
            }
        }

        /// <summary>
        /// property for the choice of cheddar, default to true
        /// </summary>
        private bool cheddar = true;
        public bool Cheddar
        {
            get { return cheddar; }
            set
            {
                cheddar = value;
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
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
        }

        /// <summary>
        /// to string override giving the item.
        /// </summary>
        /// <returns>a string detailing the items specifications</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
