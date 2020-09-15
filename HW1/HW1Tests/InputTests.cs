// <copyright file="InputTests.cs" company="Connor Easton (11557902)">
// Copyright (c) Connor Easton (11557902). All rights reserved.
// </copyright>

using System.IO;
using BinarySearchTree;
using NUnit.Framework;

namespace HW1.Test
{
    /// <summary>
    /// HW1 test class.
    /// </summary>
    [TestFixture]
    public class InputTests
    {
        /// <summary>
        /// funciton to test inputs.
        /// </summary>
        [Test]
        public void SimulatedInput()
        {
            Input io = new Input();
            int[] inputList = { 1, 2, 3 };

            const string inputString = "1 2 3";
            var stringReader = new StringReader(inputString);

            // normal use would use Console.in, for tests we make a string reader
            Assert.AreEqual(inputList, io.GetInput(stringReader));
        }
    }
}
