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
            Assert.AreEqual(3, newNode.Data);

            newNode.Data = 1;
            Assert.AreEqual(1, newNode.Data);
        }

        /// <summary>
        /// Empty tree creation.
        /// </summary>
        [Test]
        public void EmptyBSTCreation()
        {
            BST tree = new BST();
            Assert.AreEqual(string.Empty, tree.TraverseInOrder());
        }

        /// <summary>
        /// tree creation with a root node.
        /// </summary>
        [Test]
        public void BSTCreationWithNode()
        {
            BST tree = new BST(new Node(5));
            Assert.AreEqual("5 ", tree.TraverseInOrder());
        }

        /// <summary>
        /// Inserts a node to the BST.
        /// </summary>
        [Test]
        public void InsertToBST()
        {
            BST tree = new BST();
            tree.Insert(10);
            Assert.AreEqual("10 ", tree.TraverseInOrder());
        }

        /// <summary>
        /// Inserts multiple elements out of order and tests the sorting.
        /// </summary>
        [Test]
        public void SortBST()
        {
            BST tree = new BST();
            tree.Insert(10);
            tree.Insert(8);
            tree.Insert(6);
            tree.Insert(4);
            tree.Insert(2);
            tree.Insert(0);

            Assert.AreEqual("0 2 4 6 8 10 ", tree.TraverseInOrder());
        }

        /// <summary>
        /// Inserts multiple elements out of order and tests node count.
        /// </summary>
        [Test]
        public void BSTNodeCount()
        {
            BST tree = new BST();
            tree.Insert(10);
            tree.Insert(8);
            tree.Insert(6);
            tree.Insert(4);
            tree.Insert(2);
            tree.Insert(0);

            Assert.AreEqual(5, tree.GetNodeCount());
        }

        /// <summary>
        /// Inserts multiple elements out of order and tests node count.
        /// </summary>
        [Test]
        public void BSTMinLevelCount()
        {
            BST tree = new BST();
            tree.Insert(10);
            tree.Insert(8);
            tree.Insert(6);
            tree.Insert(4);
            tree.Insert(2);
            tree.Insert(0);

            Assert.AreEqual(3, tree.GetMinLevelCount());
        }

        /// <summary>
        /// Inserts multiple elements out of order and tests level count.
        /// </summary>
        [Test]
        public void BSTLevelCount()
        {
            BST tree = new BST();
            tree.Insert(5);
            tree.Insert(6);
            tree.Insert(4);
            tree.Insert(2);
            tree.Insert(1);

            Assert.AreEqual(4, tree.GetLevelCount());
        }
    }
}
