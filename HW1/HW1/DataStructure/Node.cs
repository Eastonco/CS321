﻿// <copyright file="Node.cs" company="Connor Easton (11557902)">
// Copyright (c) Connor Easton (11557902). All rights reserved.
// </copyright>

namespace BinarySearchTree
{
    /// <summary>
    /// Node Class.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// Default Constructor.
        /// </summary>
        public Node()
        {
            this.NodeCount = 0;
            this.RightNode = null;
            this.LeftNode = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// Constructor with integer input.
        /// </summary>
        /// <param name="data">integer input.</param>
        public Node(int data)
        {
            this.NodeCount = 0;
            this.Data = data;
            this.RightNode = null;
            this.LeftNode = null;
        }

        /// <summary>
        /// gets or sets the nodeCount.
        /// </summary>
        public int NodeCount { get; set; }

        /// <summary>
        /// gets or sets the Left pointer.
        /// </summary>
        public Node LeftNode { get; set; }

        /// <summary>
        /// gets or sets the right pointer.
        /// </summary>
        public Node RightNode { get; set; }

        /// <summary>
        /// gets or sets the integer value.
        /// </summary>
        public int Data { get; set; }
    }
}