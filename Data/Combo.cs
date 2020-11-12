/*
 * Author: Jack Seiler
 * Class name: Combo.cs
 * Purpose: gives details of this particular combo
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using System.Runtime.CompilerServices;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data
{
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// contructor that creates a combo
        /// </summary>
        /// <param name="e">entree</param>
        /// <param name="s">side</param>
        /// <param name="d">drink</param>
        public Combo(Entree e, Side s, Drink d)
        {
            Entree = e;
            Side = s;
            Drink = d;
            Entree.PropertyChanged += NotifyComboChanged;
            Side.PropertyChanged += NotifyComboChanged;
            Drink.PropertyChanged += NotifyComboChanged;
        }

        /// <summary>
        /// method to help change item properties when size is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void NotifyComboChanged(object sender, PropertyChangedEventArgs e)
        {
            NotifyPropertyChanged();
            NotifyPropertyChanged("Price");
            NotifyPropertyChanged("SpecialInstructions");
            NotifyPropertyChanged("Calories");
            this.PropertyChanged -= NotifyComboChanged;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if(PropertyChanged != null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public virtual Size size { get; set; }

        /// <summary>
        /// property to hold the sum of all the calories for the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        private string description;
        public string Description
        {
            get
            {
                return description;
            }
        }

        /// <summary>
        /// property to get the special instructions for the given combo
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                specialInstructions.Add(Entree.ToString());
                specialInstructions.AddRange(Entree.SpecialInstructions);
                specialInstructions.Add(Side.ToString());
                specialInstructions.AddRange(Side.SpecialInstructions);
                specialInstructions.Add(Drink.ToString());
                specialInstructions.AddRange(Drink.SpecialInstructions);
                return specialInstructions;
            }
        }

        /// <summary>
        /// gets the combo price after subtracting a dollar
        /// </summary>
        private double price;
        public double Price
        {
            get
            {
                price = (Entree.Price + Side.Price + Drink.Price) - 1.00;
                price = Math.Round(price, 2);
                return price;
            }
        }

        /// <summary>
        /// gets the specified entree for the combo and notifies the correct properties
        /// </summary>
        private Entree entree;
        public Entree Entree
        {
            get
            {
                return this.entree;
            }
            set
            {
                if (value != this.entree)
                {
                    this.entree = value;
                    NotifyPropertyChanged();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// gets the specified side for the combo and notifies the correct properties
        /// </summary>
        private Side side;
        public Side Side
        {
            get
            {
                return this.side;
            }
            set
            {
                if (value != this.side)
                {
                    this.side = value;
                    NotifyPropertyChanged();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// gets the specified drink for the combo and notifes the correct properties
        /// </summary>
        private Drink drink;
        public Drink Drink
        {
            get
            {
                return this.drink;
            }
            set
            {
                if (value != this.drink)
                {
                    this.drink = value;
                    NotifyPropertyChanged();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }
    }
}
