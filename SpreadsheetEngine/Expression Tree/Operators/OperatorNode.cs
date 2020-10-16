using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressionTree
{
    /// <summary>
    /// Abstract OperatorNode class.
    /// </summary>
    public abstract class OperatorNode : ExpressionTreeNode
    {
        /// <summary>
        /// Associativity of the node.
        /// </summary>
        public enum Associative
        {
            /// <summary>
            /// Left value.
            /// </summary>
            Left,

            /// <summary>
            /// Right value.
            /// </summary>
            Right,
        }

        /// <summary>
        /// Gets or sets the left node.
        /// </summary>
        public ExpressionTreeNode Left { get; set; }

        /// <summary>
        /// Gets or sets the right node.
        /// </summary>
        public ExpressionTreeNode Right { get; set; }
    }
}
