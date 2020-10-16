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
