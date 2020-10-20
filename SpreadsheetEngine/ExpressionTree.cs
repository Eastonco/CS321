// <copyright file="ExpressionTree.cs" company="Connor Easton (11557902)">
// Copyright (c) Connor Easton (11557902). All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using ExpressionTree;

namespace Cpts321
{
    /// <summary>
    /// Expression tree class.
    /// </summary>
    public class ExpressionTree
    {
        /// <summary>
        /// Root of the tree.
        /// </summary>
        private ExpressionTreeNode root;

        /// <summary>
        /// Operator Node creator.
        /// </summary>
        private OperatorNodeFactory operatorNodeFactory = new OperatorNodeFactory();

        /// <summary>
        /// Dictionary of variables.
        /// </summary>
        private Dictionary<string, double> variables = new Dictionary<string, double>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionTree"/> class.
        /// Default ExpretionTree.
        /// </summary>
        /// <param name="expression">the infixexpresstion to be evaluated.</param>
        public ExpressionTree(string expression)
        {
            this.root = this.BuildTree(expression);
        }

        /// <summary>
        /// Sets a variable in the dictioanry.
        /// </summary>
        /// <param name="variableName">Name.</param>
        /// <param name="variableValue">Value.</param>
        public void SetVariable(string variableName, double variableValue)
        {
            this.variables.Add(variableName, variableValue);
        }

        /// <summary>
        /// Evaluates the tree.
        /// </summary>
        /// <returns>the result of the equation.</returns>
        public double Evaluate()
        {
            return this.root.Evaluate();
        }

        /// <summary>
        /// Converts the infix expresstion to postfix.
        /// </summary>
        /// <param name="expression">the infix expression.</param>
        /// <returns>a parsed list of each operator in postfix notation.</returns>
        private List<string> ShuntingYardAlogritthm(string expression)
        {
            List<string> postfixExpression = new List<string>();
            Stack<char> operators = new Stack<char>();
            int operandStart = -1;
            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];
                if (this.IsOperatorOrParenthesis(c))
                {
                    if (operandStart != -1)
                    {
                        string operand = expression.Substring(operandStart, i - operandStart);
                        postfixExpression.Add(operand);
                        operandStart = -1;
                    }

                    if (this.IsLeftParenthesis(c))
                    {
                        operators.Push(c);
                    }
                    else if (this.IsRightParenthesis(c))
                    {
                        char op = operators.Pop();
                        while (!this.IsLeftParenthesis(op))
                        {
                            postfixExpression.Add(op.ToString());
                            op = operators.Pop();
                        }
                    }
                    else if (this.operatorNodeFactory.IsOperator(c))
                    {
                        if (operators.Count == 0 || this.IsLeftParenthesis(c))
                        {
                            operators.Push(c);
                        }
                        else if (this.IsHigherPrecedence(c, operators.Peek()) || (this.IsSamePrecedence(c, operators.Peek()) && this.IsRightAssociative(c)))
                        {
                            operators.Push(c);
                        }
                        else if (this.IsLowerPrecedence(c, operators.Peek()) || (this.IsSamePrecedence(c, operators.Peek()) && this.IsLeftAssociative(c)))
                        {
                            do
                            {
                                char op = operators.Pop();
                                postfixExpression.Add(op.ToString());
                            }
                            while (operators.Count > 0 && (this.IsLowerPrecedence(c, operators.Peek()) || (this.IsSamePrecedence(c, operators.Peek()) && this.IsLeftAssociative(c))));

                            operators.Push(c);
                        }
                    }
                }
                else if (operandStart == -1)
                {
                    operandStart = i;
                }
            }

            if (operandStart != -1)
            {
                postfixExpression.Add(expression.Substring(operandStart, expression.Length - operandStart));
                operandStart = -1;
            }

            while (operators.Count > 0)
            {
                postfixExpression.Add(operators.Pop().ToString());
            }

            return postfixExpression;
        }

        /// <summary>
        /// Builds the tree.
        /// </summary>
        /// <param name="expression">expression in infix notation.</param>
        /// <returns>the root node of the new tree.</returns>
        private ExpressionTreeNode BuildTree(string expression)
        {
            Stack<ExpressionTreeNode> nodes = new Stack<ExpressionTreeNode>();
            var postfixExpression = this.ShuntingYardAlogritthm(expression);
            foreach (var item in postfixExpression)
            {
                if (item.Length == 1 && this.IsOperatorOrParenthesis(item[0]))
                {
                    OperatorNode node = this.operatorNodeFactory.CreateOperatorNode(item[0]);
                    node.Right = nodes.Pop();
                    node.Left = nodes.Pop();
                    nodes.Push(node);
                }
                else
                {
                    double num = 0.0;
                    if (double.TryParse(item, out num))
                    {
                        nodes.Push(new ConstantNode(num));
                    }
                    else
                    {
                        nodes.Push(new VariableNode(item, ref this.variables));
                    }
                }
            }

            return nodes.Pop();
        }

        /// <summary>
        /// Checks if the operator is right assoctive.
        /// </summary>
        /// <param name="c">the operator.</param>
        /// <returns>true or false.</returns>
        private bool IsRightAssociative(char c)
        {
            return this.operatorNodeFactory.GetAssociativity(c) == OperatorNode.Associative.Right;
        }

        /// <summary>
        /// Checks if the operator is left associative.
        /// </summary>
        /// <param name="c">the operator.</param>
        /// <returns>true or false.</returns>
        private bool IsLeftAssociative(char c)
        {
            return this.operatorNodeFactory.GetAssociativity(c) == OperatorNode.Associative.Left;
        }

        /// <summary>
        /// Checks if c1 has a higer precednece that c2.
        /// </summary>
        /// <param name="c1">operator 1.</param>
        /// <param name="c2">operator 2.</param>
        /// <returns>true if c1 has higher precedence than c2, else false.</returns>
        private bool IsHigherPrecedence(char c1, char c2)
        {
            uint p1 = this.operatorNodeFactory.GetPrecedence(c1);
            uint p2 = this.operatorNodeFactory.GetPrecedence(c2);

            if (p1 < p2)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks if the two operators have the same precedence.
        /// </summary>
        /// <param name="c1">operator 1.</param>
        /// <param name="c2">operator 2.</param>
        /// <returns>true or false.</returns>
        private bool IsSamePrecedence(char c1, char c2)
        {
            uint p1 = this.operatorNodeFactory.GetPrecedence(c1);
            uint p2 = this.operatorNodeFactory.GetPrecedence(c2);

            if (p1 == p2)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks if c1 has a lower precedence than c2.
        /// </summary>
        /// <param name="c1">operator 1.</param>
        /// <param name="c2">operator 2.</param>
        /// <returns>true or false.</returns>
        private bool IsLowerPrecedence(char c1, char c2)
        {
            uint p1 = this.operatorNodeFactory.GetPrecedence(c1);
            uint p2 = this.operatorNodeFactory.GetPrecedence(c2);

            if (p1 > p2)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks if the character is an operator or parenthesis.
        /// </summary>
        /// <param name="c">the operator.</param>
        /// <returns>true or false.</returns>
        private bool IsOperatorOrParenthesis(char c)
        {
            if (c == '+' || c == '-' || c == '/' || c == '*' || c == '^' || c == '(' || c == ')')
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks if the operator is a right parenthesis.
        /// </summary>
        /// <param name="c">the operator.</param>
        /// <returns>true or false.</returns>
        private bool IsRightParenthesis(char c)
        {
            if (c == ')')
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks if the operator is a left parenthesis.
        /// </summary>
        /// <param name="c">the operator.</param>
        /// <returns>true or false.</returns>
        private bool IsLeftParenthesis(char c)
        {
            if (c == '(')
            {
                return true;
            }

            return false;
        }
    }
}
