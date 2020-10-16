using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressionTree
{
    /// <summary>
    /// Node for constant values.
    /// </summary>
    public class ConstantNode : ExpressionTreeNode
    {
        /// <summary>
        /// internal constant value.
        /// </summary>
        private readonly double value;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstantNode"/> class.
        /// </summary>
        /// <param name="value">constant value.</param>
        public ConstantNode(double value)
        {
            this.value = value;
        }

        /// <summary>
        /// Evaluate the node.
        /// </summary>
        /// <returns>value of the node.</returns>
        public override double Evaluate()
        {
            return this.value;
        }
    }
}
