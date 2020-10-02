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
        /// tests the constructor.
        /// </summary>
        [Test]
        public void FibonacciConstructor()
        {
            FibonacciTextReader reader = new FibonacciTextReader(50);
            Assert.AreEqual(50, reader.GetEntryCount());
        }

        /// <summary>
        /// tests the readLine funciton.
        /// </summary>
        [Test]
        public void GetFibAt()
        {
            FibonacciTextReader reader = new FibonacciTextReader(50);
            Assert.AreEqual("1: 0", reader.ReadLine());
        }

        /// <summary>
        /// test the ReadToEnd() funciton.
        /// </summary>
        [Test]
        public void ReadToEnd()
        {
            FibonacciTextReader reader = new FibonacciTextReader(1);
            Assert.AreEqual("1: 0", reader.ReadToEnd());
        }
    }
}
