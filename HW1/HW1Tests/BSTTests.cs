// <copyright file="BSTTests.cs" company="Connor Easton (11557902)">
// Copyright (c) Connor Easton (11557902). All rights reserved.
// </copyright>

using NUnit.Framework;

namespace BinarySearchTree
{
    /// <summary>
    /// Class for BST tests.
    /// </summary>
    [TestFixture]
    public class BSTTests
    {
        /// <summary>
        /// Tests for the Binary Search Tree.
        /// </summary>
        [Test]
        public void NodeCreation()
        {
            Node newNode = new Node(3);
            Assert.AreEqual(newNode.Data, 3);

            newNode.Data = 1;
            Assert.AreEqual(newNode.Data, 1);
        }
    }
}
