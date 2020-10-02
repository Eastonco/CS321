// <copyright file="FibonacciTextReader.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HW3
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Numerics;
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
            this.EntryCount = EntryCount;
            this.Current = 1;
        }

        /// <summary>
        /// keeps track of how many lines to print.
        /// </summary>
        public int EntryCount;
        public int Current;


        private BigInteger GetFibAt(BigInteger val)
        {
            if ( val <= 1)
            {
                return val;
            }
            else
            {
                return this.GetFibAt(val - 1) + this.GetFibAt(val - 2);
            }
        }

        /// <summary>
        /// Overridden readline function.
        /// </summary>
        /// <returns>the output string.</returns>
        public override string ReadLine()
        {
            if (this.Current <= this.EntryCount)
            {
                StringWriter sr = new StringWriter();
                sr.Write(this.Current);
                sr.Write(": ");
                sr.Write(this.GetFibAt(this.Current - 1));
                this.Current++;

                return sr.ToString();
            }

            return null;
        }
    }
}
