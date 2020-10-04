using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing the common propeerties of drinks
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        public virtual event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The price of the drink
        /// </summary>
        /// <value> In US dollars </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories in the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// The special instructions for the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        private Size size;
        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// Gets if the drink should have ice
        /// </summary>
        public virtual bool Ice { get; set; }

        /// <summary>
        /// Helper method to notify of boolean customization property changes
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}
