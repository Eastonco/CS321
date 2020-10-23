// <copyright file="OperatorNodeFactory.cs" company="Connor Easton (11557902)">
// Copyright (c) Connor Easton (11557902). All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ExpressionTree
{
    /// <summary>
    /// Operator node factory.
    /// </summary>
    public class OperatorNodeFactory
    {
        /// <summary>
        /// Dictionary of available operators.
        /// </summary>
        private Dictionary<char, Type> operators = new Dictionary<char, Type>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OperatorNodeFactory"/> class.
        /// </summary>
        public OperatorNodeFactory()
        {
            this.TraverseAvailableOperators((op, type) => this.operators.Add(op, type));
        }

        /// <summary>
        /// Delegate for the operator.
        /// </summary>
        /// <param name="op">operator character.</param>
        /// <param name="type">type of operator.</param>
        private delegate void OnOperator(char op, Type type);

        /// <summary>
        /// Creates an operator note from a character.
        /// </summary>
        /// <param name="c">the operator character.</param>
        /// <returns>an operator node.</returns>
        public OperatorNode CreateOperatorNode(char c)
        {
            if (this.operators.ContainsKey(c))
            {
                object operatorNodeObject = System.Activator.CreateInstance(this.operators[c]);
                if (operatorNodeObject is OperatorNode)
                {
                    return (OperatorNode)operatorNodeObject;
                }
            }

            throw new Exception("Unhandeled operator");
        }

        /// <summary>
        /// Gets teh precedence of an operator.
        /// </summary>
        /// <param name="op">the Operator.</param>
        /// <returns>The precedence of the operator.</returns>
        public uint GetPrecedence(char op)
        {
            ushort precedenceValue = 0;
            if (this.operators.ContainsKey(op))
            {
                Type type = this.operators[op];
                PropertyInfo propertyInfo = type.GetProperty("Precedence");
                if (propertyInfo != null)
                {
                    object propertyValue = propertyInfo.GetValue(type);
                    if (propertyValue is ushort)
                    {
                        precedenceValue = (ushort)propertyValue;
                    }
                }
            }
            else if (op == '(' || op == ')')
            {
                precedenceValue = 5;
            }

            return precedenceValue;
        }

        /// <summary>
        /// Gets the Associativity of an operator.
        /// </summary>
        /// <param name="op">the operator.</param>
        /// <returns>The Associativity.</returns>
        public OperatorNode.Associative GetAssociativity(char op)
        {
            if (this.operators.ContainsKey(op))
            {
                Type type = this.operators[op];
                PropertyInfo propertyInfo = type.GetProperty("Associative");
                if (propertyInfo != null)
                {
                    object propertyValue = propertyInfo.GetValue(type);
                    if (propertyValue is OperatorNode.Associative)
                    {
                        return (OperatorNode.Associative)propertyValue;
                    }
                }
            }

            return OperatorNode.Associative.Left;
        }

        /// <summary>
        /// Checks if the character is an operator.
        /// </summary>
        /// <param name="c">the operator character.</param>
        /// <returns>true if the character is an operator.</returns>
        public bool IsOperator(char c)
        {
            return this.operators.ContainsKey(c);
        }

        /// <summary>
        /// Populates the dictionary with all available operators.
        /// </summary>
        /// <param name="onOperator">the delegate.</param>
        private void TraverseAvailableOperators(OnOperator onOperator)
        {
            Type operatorNodeType = typeof(OperatorNode);

            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                IEnumerable<Type> operatorTypes = assembly.GetTypes().Where(type => type.IsSubclassOf(operatorNodeType));

                foreach (var type in operatorTypes)
                {
                    PropertyInfo operatorField = type.GetProperty("Operator");
                    if (operatorField != null)
                    {
                        object value = operatorField.GetValue(type);

                        if (value is char)
                        {
                            char operatorSymbol = (char)value;
                            onOperator(operatorSymbol, type);
                        }
                    }
                }
            }
        }
    }
}
