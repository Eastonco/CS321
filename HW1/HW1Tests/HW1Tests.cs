// <copyright file="HW1Tests.cs" company="Connor Easton (11557902)">
// Copyright (c) Connor Easton (11557902). All rights reserved.
// </copyright>

using NUnit.Framework;

namespace HW1.Test
{
    /// <summary>
    /// HW1 test class.
    /// </summary>
    public class HW1Tests
    {
        /// <summary>
        /// funciton to test inputs.
        /// </summary>
        public void InputTests()
        {
            Input io = new Input();
            int[] inputList = { 1, 2, 3 };

            Assert.AreEqual(inputList, io.GetInput());
        }
    }
}
