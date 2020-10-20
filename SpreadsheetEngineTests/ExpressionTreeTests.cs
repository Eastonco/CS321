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
        /// <param name="expression">Expression.</param>
        /// <returns>Value of the evaluation.</returns>
        [Test]
        [TestCase("1+2+3", ExpectedResult = 6)]
        [TestCase("1-2-3", ExpectedResult = -4)]
        [TestCase("9*3", ExpectedResult = 27)]
        [TestCase("30/5", ExpectedResult = 6)]
        [TestCase("2^8", ExpectedResult = 256)]
        [TestCase("1+3*3+2^2", ExpectedResult = 14)]
        [TestCase("10/0", ExpectedResult = double.PositiveInfinity)]
        [TestCase("((((2+5)*(7-2))))", ExpectedResult = 35)]
        public double TestConstantEvaluation(string expression)
        {
            ExpressionTree tree = new ExpressionTree(expression);
            return tree.Evaluate();
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
