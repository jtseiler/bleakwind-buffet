/*
 * Author: Jack Seiler
 * Class name: Order.cs
 * Purpose: gives details of this particular order
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.Specialized;

namespace BleakwindBuffet.Data
{
    public class Order : INotifyPropertyChanged, INotifyCollectionChanged//, ICollection<IOrderItem>
    {
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// Constrcutor
        /// </summary>
        public Order()
        {
            orderNumber += 1;
        }

        private static uint orderNumber = 0;
        /// <summary>
        /// Order number
        /// </summary>
        public uint OrderNumber
        { get { return orderNumber; } private set { orderNumber = value; } }

        /// <summary>
        /// list of items for the order
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// list of items for the order
        /// </summary>
        public IEnumerable<IOrderItem> Items { get { return items.ToArray(); } }


        private double subtotal = 0;
        /// <summary>
        /// Cost of the order
        /// </summary>
        public double Subtotal
        {
            get
            {
                double total = 0;
                foreach (var item in items)
                {
                    total += item.Price;
                }
                return total;
            }
        }


        public double SalesTax
        {
            get
            {
                return Math.Round(Subtotal * 0.12, 2);
            }
        }


        /// <summary>
        /// Cost of the order including the sales tax
        /// </summary>
        public double Total
        {
            get
            {
                return Subtotal * 1.12;
            }
        }

        /// <summary>
        /// Adds an item to the order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
        }

        /// <summary>
        /// Removes an item from the order
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            if(items.Contains(item))
            {
                var itemIndex = items.IndexOf(item);
                items.Remove(item);
                CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            }
        }

        /// <summary>
        /// Updates the items and subtotal
        /// </summary>
        public void OnItemPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}
