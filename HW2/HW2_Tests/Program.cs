// <copyright file="Program.cs" company="Connor Easton (11557902)">
// Copyright (c) Connor Easton (11557902). All rights reserved.
// </copyright>

using System;
using NUnit.Framework;


namespace HW2
{
    /// <summary>
    /// Main Test program.
    /// </summary>
    [TestFixture]
    public class HW2Tests
    {
        [Test]
        public void CreateList()
        {
            SortIntegers myInts = new SortIntegers();
            Assert.AreEqual(10000, myInts.myList.Count);
        }

    }
}
