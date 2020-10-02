// <copyright file="FibonacciTextReader.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HW3
{
    using System.IO;
    using System.Numerics;

    /// <summary>
    /// Class for generating fib numbers.
    /// </summary>
    public class FibonacciTextReader : System.IO.TextReader
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FibonacciTextReader"/> class.
        /// default constructor.
        /// </summary>
        /// <param name="entryCount">max number of fibs to print.</param>
        public FibonacciTextReader(int entryCount)
        {
            this.EntryCount = entryCount;
            this.Current = 1;
        }

        /// <summary>
        /// Gets or sets keeps track of how many lines to print.
        /// </summary>
        private int EntryCount { get; set; }

        /// <summary>
        /// Gets or sets keeps track of how many fibs have been printed.
        /// </summary>
        private int Current { get; set; }

        /// <summary>
        /// Used for tests.
        /// </summary>
        /// <returns>the private entry count variable.</returns>
        public int GetEntryCount()
        {
            return this.EntryCount;
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
                sr.WriteLine(this.GetFibAt(this.Current - 1));
                this.Current += 1;

                return sr.ToString();
            }

            return null;
        }

        /// <summary>
        /// Overridden read to end function.
        /// </summary>
        /// <returns>the string of all lines until the end.</returns>
        public override string ReadToEnd()
        {
            StringWriter sr = new StringWriter();
            while (this.Current <= this.EntryCount)
            {
                sr.Write(this.ReadLine());
            }

            return sr.ToString();
        }

        /// <summary>
        /// gets the fib number at location.
        /// </summary>
        /// <param name="val">location of fib number.</param>
        /// <returns>the fib number at locaiton.</returns>
        private BigInteger GetFibAt(int val)
        {
            BigInteger[] fibs = new BigInteger[val + 2];
            int i;

            fibs[0] = 0;
            fibs[1] = 1;

            for (i = 2; i <= val; i++)
            {
                fibs[i] = fibs[i - 1] + fibs[i - 2];
            }

            return fibs[val];
        }
    }
}
