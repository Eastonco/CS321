// <copyright file="Program.cs" company="Connor Easton (11557902)">
// Copyright (c) Connor Easton (11557902). All rights reserved.
// </copyright>

using System;
using BinarySearchTree;

namespace HW1
{
    /// <summary>
    /// Class for the main program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Function call for the main program.
        /// </summary>
        /// <param name="args">Standard main input.</param>
        public static void Main(string[] args)
        {
            Input io = new Input();
            BST tree = new BST();

            Console.WriteLine("Enter a collection of numbers in the range [0, 100], separated by spaces:");
            int[] input = io.RemoveDuplicates(io.GetInput(Console.In));

            foreach (int i in input)
            {
                tree.Insert(i);
            }

            Console.WriteLine("Tree Contents {0}", tree.TraverseInOrder());
            Console.WriteLine("Tree Statistics:");
            Console.WriteLine("\tNumber of Nodes: {0}", tree.GetNodeCount());
            Console.WriteLine("\tNumber of levels: {0}", tree.GetLevelCount());
            Console.WriteLine("\tMinimum number of levels that a tree with {0} nodes could have = {1}", tree.GetNodeCount(), tree.GetMinLevelCount());
            Console.WriteLine("Done.");

            return;
        }
    }
}
