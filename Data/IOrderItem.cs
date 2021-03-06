﻿/*
 * Author: Jack Seiler
 * Class name: IOrderItem.cs
 * Purpose: gives the interface for the menu
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// An interface representing a single item in an order
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price of this order item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The price of this order item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// The special instructions for this order item
        /// </summary>
        List<string> SpecialInstructions { get; }

        /// <summary>
        /// The description of the menu item
        /// </summary>
        string Description { get; }
    }
}
