// <copyright file="ExpressionTreeNode.cs" company="Connor Easton (11557902)">
// Copyright (c) Connor Easton (11557902). All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressionTree
{
    /// <summary>
    /// Abstract ExpressionTreeNode.
    /// </summary>
    public abstract class ExpressionTreeNode
    {
        /// <summary>
        /// abstract evaluate function.
        /// </summary>
        /// <returns>the evalusted value.</returns>
        public abstract double Evaluate();
    }
}
