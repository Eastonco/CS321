// <copyright file="HW2Tests.cs" company="Connor Easton (11557902)">
// Copyright (c) Connor Easton (11557902). All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace HW2
{
    /// <summary>
    /// Main Test program.
    /// </summary>
    [TestFixture]
    public class HW2Tests
    {
        /// <summary>
        /// Test list creation.
        /// </summary>
        [Test]
        public void CreateList()
        {
            SortIntegers myInts = new SortIntegers();
            Assert.AreEqual(10000, myInts.GetList().Count);
        }

        /// <summary>
        /// Tests the first sort method.
        /// </summary>
        [Test]
        public void HashDistinct()
        {
            SortIntegers sorter = new SortIntegers();
            var list = sorter.GetList();
            List<int> distinct = list.Distinct().ToList();
            Assert.AreEqual(distinct.Count(), sorter.HashDistinct());
        }

        /// <summary>
        /// Distinct funciton with O(1) space complexity.
        /// </summary>
        [Test]
        public void SpaceDistinct()
        {
            SortIntegers sorter = new SortIntegers();
            var list = sorter.GetList();
            List<int> distinct = list.Distinct().ToList();
            Assert.AreEqual(distinct.Count(), sorter.SpaceDistinct());
        }

        /// <summary>
        /// Test case for the distinct by sort functon.
        /// </summary>
        [Test]
        public void SortDistinct()
        {
            SortIntegers sorter = new SortIntegers();
            var list = sorter.GetList();
            List<int> distinct = list.Distinct().ToList();
            Assert.AreEqual(distinct.Count(), sorter.SortDistinct());
        }
    }
}
