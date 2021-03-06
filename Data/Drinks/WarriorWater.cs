﻿/*
 * Author: Jack Seiler
 * Class name: WarriorWater.cs
 * Purpose: gives details of this particular drink
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

/// <summary>
/// Adding to the namespace of Drinks
/// </summary>
namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Creating an addition to the drink menu under the drink namespace
    /// </summary>
    public class WarriorWater : Drink, IOrderItem, INotifyPropertyChanged
    {
        public override string Description
        {
            get
            {
                return "It’s water. Just water.";
            }
        }

        /// <summary>
        /// Property to keep track of the price
        /// </summary>
        double price;

        /// <summary>
        /// Getter for the price after customer chooses a size, default free for water
        /// </summary>
        public override double Price
        {
            get
            {
                return price = 0;
            }
        }

        /// <summary>
        /// variable to keep track of the items calories
        /// </summary>
        uint calories;

        /// <summary>
        /// getter for the calories after customer chooses a size
        /// </summary>
        public override uint Calories
        {
            get
            {
               return calories = 0;
            }
        }

        /// <summary>
        /// property for choice of ice default to true
        /// </summary>
        private bool ice = true;
        public override bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                NotifyOfPropertyChange();
            }
        }

        /// <summary>
        /// propety for the choice of lemon, default to false
        /// </summary>
        private bool lemon = false;
        public bool Lemon
        {
            get { return lemon; }
            set
            {
                lemon = value;
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
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
                return instructions;
            }
        }

        /// <summary>
        /// to string override giving the size, and the item.
        /// </summary>
        /// <returns>a string detailing the items specifications</returns>
        public override string ToString()
        {
            return $"{Size} Warrior Water";
        }
    }
}