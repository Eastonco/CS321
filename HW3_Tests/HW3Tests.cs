// <copyright file="HW3Tests.cs" company="Connor Easton (11557902)">
// Copyright (c) Connor Easton (11557902). All rights reserved.
// </copyright>

using System;
using HW3;
using NUnit.Framework;

namespace HW3_Tests
{
    /// <summary>
    /// Tests for HW3.
    /// </summary>
    [TestFixture]
    public class HW3Tests
    {
        /// <summary>
        /// A sample test.
        /// </summary>
        [Test]
        public void FibonacciConstructor()
        {
            FibonacciTextReader reader = new FibonacciTextReader(50);
            Assert.AreEqual(50, reader.EntryCount);
        }

        [Test]
        public void getFibAt()
        {
            FibonacciTextReader reader = new FibonacciTextReader(50);
            Assert.AreEqual("1: 0", reader.ReadLine());
        }

        [Test]
        public void readToEnd()
        {
            FibonacciTextReader reader = new FibonacciTextReader(1);
            Assert.AreEqual("1: 0", reader.ReadToEnd());
        }
    }
}
