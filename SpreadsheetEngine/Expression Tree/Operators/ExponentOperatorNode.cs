// <copyright file="ExponentOperatorNode.cs" company="Connor Easton (11557902)">
// Copyright (c) Connor Easton (11557902). All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressionTree
{
    /// <summary>
    /// Exponent Operator Node.
    /// </summary>
    public class ExponentOperatorNode : OperatorNode
    {
        /// <summary>
        /// Gets operator type.
        /// </summary>
        public static char Operator => '^';

        /// <summary>
        /// Gets the precedence of the operator.
        /// </summary>
        public static ushort Precedence => 5;

        /// <summary>
        /// Gets the Associativity of the node.
        /// </summary>
        public static Associative Associativity => Associative.Right;

        /// <summary>
        /// Overridden Evaluate function.
        /// </summary>
        /// <returns>left to the power of right.</returns>
        public override double Evaluate()
        {
            return Math.Pow(this.Left.Evaluate(), this.Right.Evaluate());
        }
    }
}
