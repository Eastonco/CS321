// <copyright file="BST.cs" company="Connor Easton (11557902)">
// Copyright (c) Connor Easton (11557902). All rights reserved.
// </copyright>

using System;
using System.Text;

namespace BinarySearchTree
{
    /// <summary>
    /// Binary Search Tree class.
    /// </summary>
    public class BST
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BST"/> class.
        /// </summary>
        public BST()
        {
            this.Root = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BST"/> class.
        /// </summary>
        /// <param name="newroot">The Node of the root.</param>
        public BST(Node newroot)
        {
            this.Root = newroot;
        }

        /// <summary>
        /// Gets or sets root node of the BST.
        /// </summary>
        private Node Root { get; set; }

        /// <summary>
        /// Function to get the number of nodes in the BST.
        /// </summary>
        /// <returns>the number of nodes in the BST.</returns>
        public int GetNodeCount()
        {
            if (this.Root != null)
            {
                return this.Root.NodeCount + 1;
            }

            return 0;
        }

        /// <summary>
        /// Function to get the string of printed values of the tree.
        /// </summary>
        /// <returns>a string of the tree contents.</returns>
        public string TraverseInOrder()
        {
            return this.TraversalHelper(this.Root, new StringBuilder()).ToString();
        }

        /// <summary>
        /// Function to get level count.
        /// </summary>
        /// <returns>The number of levels in the tree.</returns>
        public int GetLevelCount()
        {
            return this.GetHeight(this.Root);
        }

        /// <summary>
        /// Function to get the minimum count of levels the tree could have.
        /// </summary>
        /// <returns>the minimum number of levels the BST could have.</returns>
        public int GetMinLevelCount()
        {
            if (this.Root != null)
            {
                int nodecount = this.Root.NodeCount + 1;
                return Convert.ToInt32(Math.Ceiling(Math.Log2(nodecount)));
            }

            return 0;
        }

        /// <summary>
        /// Insert a node into the tree.
        /// </summary>
        /// <param name="value">The value of the node to be inserted.</param>
        public void Insert(int value)
        {
            if (this.Root == null)
            {
                this.Root = new Node(value);
            }
            else
            {
                this.InsertHelper(this.Root, value);
            }
        }

        /// <summary>
        /// Recursive helper function to create return print string.
        /// </summary>
        /// <param name="pcur">current node.</param>
        /// <param name="output">string to be built on.</param>
        /// <returns>the built string of tree contents.</returns>
        private StringBuilder TraversalHelper(Node pcur, StringBuilder output)
        {
            if (pcur == null)
            {
                return output;
            }

            this.TraversalHelper(pcur.LeftNode, output);
            output.Append(pcur.Data + " ");
            this.TraversalHelper(pcur.RightNode, output);
            return output;
        }

        /// <summary>
        /// helper function for Insert().
        /// </summary>
        /// <param name="pcur">current node of the tree.</param>
        /// <param name="value">Node to be inserted.</param>
        private void InsertHelper(Node pcur, int value)
        {
            pcur.NodeCount++;
            if (pcur.Data > value)
            {
                if (pcur.LeftNode == null)
                {
                    pcur.LeftNode = new Node(value);
                }
                else
                {
                    this.InsertHelper(pcur.LeftNode, value);
                }
            }
            else
            {
                if (pcur.RightNode == null)
                {
                    pcur.RightNode = new Node(value);
                }
                else
                {
                    this.InsertHelper(pcur.RightNode, value);
                }
            }
        }

        /// <summary>
        /// A function to get the height of a node.
        /// </summary>
        /// <param name="root">a node to measure height from.</param>
        /// <returns>max height of given root.</returns>
        private int GetHeight(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            return Math.Max(this.GetHeight(root.LeftNode), this.GetHeight(root.RightNode)) + 1;
        }
    }
}
