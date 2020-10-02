// <copyright file="FibonacciTextReader.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HW3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class for generating fib numbers.
    /// </summary>
    public class FibonacciTextReader : System.IO.TextReader
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FibonacciTextReader"/> class.
        /// default constructor.
        /// </summary>
        /// <param name="EntryCount"></param>
        public FibonacciTextReader(int EntryCount)
        {

        }

        /// <summary>
        /// keeps track of how many lines to print.
        /// </summary>
        public int EntryCount { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ReadLine()
        {
            return base.ReadLine();
        }
    }
}
