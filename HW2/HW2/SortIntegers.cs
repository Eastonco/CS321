// <copyright file="SortIntegers.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HW2
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class for main list calculations.
    /// </summary>
    public class SortIntegers
    {
        private readonly List<int> myList;

        /// <summary>
        /// Initializes a new instance of the <see cref="SortIntegers"/> class.
        /// </summary>
        public SortIntegers()
        {
            this.myList = new List<int>();
            var rand = new Random();
            for (int i = 0; i < 10000; i++)
            {
                this.myList.Add(rand.Next(20000));
            }
        }

        public List<int> HashDistinct()
        {
            return new List<int>();
        }
        /// <summary>
        /// Funciton to return the list.
        /// </summary>
        /// <returns>List of ints.</returns>
        public List<int> GetList()
        {
            return this.myList;
        }


    }
}
