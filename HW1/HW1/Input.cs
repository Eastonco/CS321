// <copyright file="Input.cs" company="Connor Easton (11557902)">
// Copyright (c) Connor Easton (11557902). All rights reserved.
// </copyright>

using System;
using System.IO;

namespace HW1
{
    /// <summary>
    /// Class for taking input in the project.
    /// </summary>
    public class Input
    {
        /// <summary>
        /// Takes input from a TextReader.
        /// </summary>
        /// <param name="reader">TextReader variable.</param>
        /// <returns>an array of parsed integers.</returns>
        public int[] GetInput(TextReader reader)
        {
            int[] parsed = Array.ConvertAll(reader.ReadLine().Split(" "), int.Parse);
            return parsed;
        }
    }
}
