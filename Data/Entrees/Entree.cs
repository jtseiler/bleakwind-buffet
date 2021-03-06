﻿ /*
 * Author: Jack Seiler
 * Class name: Entree.cs
 * Purpose: gives details of this particular entree
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A base class representing the common propeerties of entrees
    /// </summary>
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// the description of each item
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// The price of the entree
        /// </summary>
        /// <value> In US dollars </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories in the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// The special instructions for the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Helper method to notify of boolean customization property changes
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChange([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
