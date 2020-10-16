// <copyright file="VariableNode.cs" company="Connor Easton (11557902)">
// Copyright (c) Connor Easton (11557902). All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressionTree
{
    /// <summary>
    /// Variable Node.
    /// </summary>
    public class VariableNode : ExpressionTreeNode
    {
        /// <summary>
        /// Variable name.
        /// </summary>
        private readonly string name;

        /// <summary>
        /// refrence to dictionary table.
        /// </summary>
        private readonly Dictionary<string, double> variables;

        /// <summary>
        /// Initializes a new instance of the <see cref="VariableNode"/> class.
        /// </summary>
        /// <param name="name">Name of the variable.</param>
        /// <param name="variables">ref to dict list.</param>
        public VariableNode(string name, ref Dictionary<string, double> variables)
        {
            this.name = name;
            this.variables = variables;
        }

        /// <summary>
        /// Lookup value from dict table.
        /// </summary>
        /// <returns>the value of the node.</returns>
        public override double Evaluate()
        {
            double value = 0.0;
            if (this.variables.ContainsKey(this.name))
            {
                value = this.variables[this.name];
            }

            return value;
        }
    }
}