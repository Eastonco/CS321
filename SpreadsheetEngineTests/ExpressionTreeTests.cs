// <copyright file="ExpressionTreeTests.cs" company="Connor Easton (11557902)">
// Copyright (c) Connor Easton (11557902). All rights reserved.
// </copyright>

using NUnit.Framework;

namespace Cpts321.Tests
{
    /// <summary>
    /// Tests for the expresstion tree class.
    /// </summary>
    [TestFixture]
    public class ExpressionTreeTests
    {
        /// <summary>
        /// Testing Addition.
        /// </summary>
        [Test]
        public void AdditionEvaluation()
        {
            ExpressionTree tree = new ExpressionTree("1+2+3");
            Assert.AreEqual(6, tree.Evaluate());
        }

        /// <summary>
        /// Testing Subtraction.
        /// </summary>
        [Test]
        public void SubtractionEvaluation()
        {
            ExpressionTree tree = new ExpressionTree("1-2-3");
            Assert.AreEqual(-4, tree.Evaluate());
        }

        /// <summary>
        /// Testing multiplication.
        /// </summary>
        [Test]
        public void MultiplicationEvaluation()
        {
            ExpressionTree tree = new ExpressionTree("9*3");
            Assert.AreEqual(27, tree.Evaluate());
        }

        /// <summary>
        /// Testing division.
        /// </summary>
        [Test]
        public void DivisionEvaluation()
        {
            ExpressionTree tree = new ExpressionTree("30/5");
            Assert.AreEqual(6, tree.Evaluate());
        }

        /// <summary>
        /// Exponent Evaluation.
        /// </summary>
        [Test]
        public void ExponentEvaluation()
        {
            ExpressionTree tree = new ExpressionTree("2^8");
            Assert.AreEqual(256, tree.Evaluate());
        }

        /// <summary>
        /// Complex Evaluation.
        /// </summary>
        [Test]
        public void ComplexEvaluation()
        {
            ExpressionTree tree = new ExpressionTree("1+3*3+2^2");
            Assert.AreEqual(14, tree.Evaluate());
        }

        /// <summary>
        /// Divide by 0.
        /// </summary>
        [Test]
        public void DivideByZeroEvaluation()
        {
            ExpressionTree tree = new ExpressionTree("10/0");
            Assert.AreEqual(double.PositiveInfinity, tree.Evaluate());
        }

        /// <summary>
        /// Variables Evaluation.
        /// </summary>
        [Test]
        public void VariableEvaluation()
        {
            ExpressionTree tree = new ExpressionTree("Him-Her+They");
            tree.SetVariable("Him", 5);
            tree.SetVariable("Her", 20);
            tree.SetVariable("They", 5);
            Assert.AreEqual(-10, tree.Evaluate());
        }
    }
}
