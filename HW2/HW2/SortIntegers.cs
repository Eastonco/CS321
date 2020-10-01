// <copyright file="SortIntegers.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HW2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

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

        /// <summary>
        /// Distinct by hashtable.
        /// </summary>
        /// <returns>List of distinct elements.</returns>
        public int HashDistinct()
        {
            bool[] hashtable = new bool[20001];
            int distinct = 0;
            foreach (int element in this.myList)
            {
                hashtable[element] = true;
            }

            for (int i = 0; i < hashtable.Count(); i++)
            {
                if (hashtable[i])
                {
                    distinct++;
                }
            }

            return distinct;
        }

        /// <summary>
        /// Function for calculating the distinct count with constant space complexity.
        /// </summary>
        /// <returns>the list of distinct.</returns>
        public int SpaceDistinct()
        {
            int count = 0;
            bool lastOccurance = true;
            for (int i = 0; i < this.myList.Count() - 1; i++)
            {
                lastOccurance = true;

                for (int j = i + 1; j < this.myList.Count(); j++)
                {
                    if (this.myList[i] == this.myList[j])
                    {
                        lastOccurance = false;
                    }
                }

                if (lastOccurance)
                {
                    count++;
                }
            }

            count++;

            return count;
        }

        /// <summary>
        /// Sorts the list first and runs in O(n) with O(1) space.
        /// </summary>
        /// <returns>count of distinct values.</returns>
        public int SortDistinct()
        {
            int count = 0;
            this.myList.Sort();
            for (int i = 0; i < this.myList.Count() - 1; i++)
            {
                if (this.myList[i] != this.myList[i + 1])
                {
                    count++;
                }
            }

            return ++count;
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