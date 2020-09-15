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
        /// Tests node creation.
        /// </summary>
        [Test]
        public void NodeCreation()
        {
            Node newNode = new Node(3);
            Assert.AreEqual(newNode.Data, 3);

            newNode.Data = 1;
            Assert.AreEqual(newNode.Data, 1);
        }

        /// <summary>
        /// Empty tree creation.
        /// </summary>
        [Test]
        public void EmptyBSTCreation()
        {
            BST tree = new BST();
            Assert.AreEqual(tree.TraverseInOrder(), string.Empty);
        }

        /// <summary>
        /// tree creation with a root node.
        /// </summary>
        [Test]
        public void BSTCreationWithNode()
        {
            BST tree = new BST(new Node(5));
            Assert.AreEqual(tree.TraverseInOrder(), "5");
        }

        /// <summary>
        /// Inserts a node to the BST.
        /// </summary>
        [Test]
        public void InsertToBST()
        {
            BST tree = new BST();
            tree.Insert(new Node(10));
            Assert.AreEqual(tree.TraverseInOrder(), "10");
        }

        /// <summary>
        /// Inserts multiple elements out of order and tests the sorting.
        /// </summary>
        [Test]
        public void SortBST()
        {
            BST tree = new BST();
            tree.Insert(new Node(10));
            tree.Insert(new Node(8));
            tree.Insert(new Node(6));
            tree.Insert(new Node(4));
            tree.Insert(new Node(2));
            tree.Insert(new Node(0));

            Assert.AreEqual(tree.TraverseInOrder(), "0 2 4 6 8 10");
        }

        /// <summary>
        /// Inserts multiple elements out of order and tests node count.
        /// </summary>
        [Test]
        public void BSTNodeCount()
        {
            BST tree = new BST();
            tree.Insert(new Node(10));
            tree.Insert(new Node(8));
            tree.Insert(new Node(6));
            tree.Insert(new Node(4));
            tree.Insert(new Node(2));
            tree.Insert(new Node(0));

            Assert.AreEqual(tree.GetNodeCount(), 5);
        }

        /// <summary>
        /// Inserts multiple elements out of order and tests node count.
        /// </summary>
        [Test]
        public void BSTMinLevelCount()
        {
            BST tree = new BST();
            tree.Insert(new Node(10));
            tree.Insert(new Node(8));
            tree.Insert(new Node(6));
            tree.Insert(new Node(4));
            tree.Insert(new Node(2));
            tree.Insert(new Node(0));

            Assert.AreEqual(tree.GetMinLevelCount(), 3);
        }

        /// <summary>
        /// Inserts multiple elements out of order and tests level count.
        /// </summary>
        [Test]
        public void BSTLevelCount()
        {
            BST tree = new BST();
            tree.Insert(new Node(5));
            tree.Insert(new Node(6));
            tree.Insert(new Node(4));
            tree.Insert(new Node(2));
            tree.Insert(new Node(1));

            Assert.AreEqual(tree.GetLevelCount(), 4);
        }
    }
}
