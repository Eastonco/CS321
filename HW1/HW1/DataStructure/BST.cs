// <copyright file="BST.cs" company="Connor Easton (11557902)">
// Copyright (c) Connor Easton (11557902). All rights reserved.
// </copyright>

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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BST"/> class.
        /// </summary>
        /// <param name="newroot">The Node of the root.</param>
        public BST(Node newroot)
        {
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
            return 0;
        }

        /// <summary>
        /// Function to get the string of printed values of the tree.
        /// </summary>
        /// <returns>a string of the tree contents.</returns>
        public string TraverseInOrder()
        {
            return null;
        }

        /// <summary>
        /// Function to get level count.
        /// </summary>
        /// <returns>The number of levels in the tree.</returns>
        public int GetLevelCount()
        {
            return 0;
        }

        /// <summary>
        /// Function to get the minimum count of levels the tree could have.
        /// </summary>
        /// <returns>the minimum number of levels the BST could have.</returns>
        public int GetMinLevelCount()
        {
            return 0;
        }

        /// <summary>
        /// Insert a node into the tree.
        /// </summary>
        /// <param name="newnode">The node to be inserted.</param>
        public void Insert(Node newnode)
        {
        }

        /// <summary>
        /// recursive function to help build the in order traversal string.
        /// </summary>
        /// <param name="output">a string to be built on.</param>
        /// <returns>the built string.</returns>
        private string TraversalHelper(StringBuilder output)
        {
            return null;
        }
    }
}
