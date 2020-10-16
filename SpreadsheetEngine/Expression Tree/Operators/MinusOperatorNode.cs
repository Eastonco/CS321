// <copyright file="MultiplyOperatorNode.cs" company="Connor Easton (11557902)">
// Copyright (c) Connor Easton (11557902). All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;
using ExpressionTree;

namespace ExpressionTree
{
    /// <summary>
    /// Multiplication Node.
    /// </summary>
    public class MinusOperatorNode : OperatorNode
    {
        /// <summary>
        /// Gets operator type.
        /// </summary>
        public static char Operator => '-';

        /// <summary>
        /// Gets the Importance of the operator.
        /// </summary>
        public static ushort Precedence => 7;

        /// <summary>
        /// Gets the Associativity of the node.
        /// </summary>
        public static Associative Associativity => Associative.Left;

        /// <summary>
        /// Overridden Evaluate function.
        /// </summary>
        /// <returns>Evaluated value of left * right nodes.</returns>
        public override double Evaluate()
        {
            return this.Left.Evaluate() * this.Right.Evaluate();
        }
    }
}