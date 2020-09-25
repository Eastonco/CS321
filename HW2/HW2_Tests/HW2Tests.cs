// <copyright file="HW2Tests.cs" company="Connor Easton (11557902)">
// Copyright (c) Connor Easton (11557902). All rights reserved.
// </copyright>

using NUnit.Framework;
using System.Collections.Immutable;
using System.Collections.Generic;
using System.Linq;

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
        /// Tests the first sort method
        /// </summary>
        [Test]
        public void HashDistinct()
        {
            SortIntegers Sorter = new SortIntegers();
            var list = Sorter.GetList();
            List<int> distinct = list.Distinct().ToList();
            distinct.Sort();
            Assert.AreEqual(distinct, Sorter.HashDistinct());
        }
    }
}
