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
        /// 
        /// </summary>
        private Dictionary<string, double> variables = new Dictionary<string, double>();

        public ExpressionTree(string expression)
        {
            this.root = this.BuildTree(expression);
        }

        public void SetVariable(string variableName, double variableValue)
        {
            this.variables.Add(variableName, variableValue);
        }

        public double Evaluate()
        {
            return this.root.Evaluate();
        }

        public List<string> ShuntingYardAlogritthm(string expression)
        {
            List<string> postfixExpression = new List<string>();
            Stack<char> operators = new Stack<char>();
            int operandStart = -1;
            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];
                if (IsOperatorOrParenthesis(c))
                {
                    if(operandStart != -1)
                    {
                        string operand = expression.Substring(operandStart, i - operandStart);
                        postfixExpression.Add(operand);
                        operandStart = -1;
                    }

                    if (IsLeftParenthesis(c))
                    {
                        operators.Push(c);
                    }

                    else if (IsRightParenthesis(c))
                    {
                        char op = operators.Pop();
                        while (!IsLeftParenthesis(op))
                        {
                            postfixExpression.Add(op.ToString());
                            op = operators.Pop();
                        }
                    }

                    else if (this.operatorNodeFactory.IsOperator(c))
                    {
                        if (operators.Count == 0 || IsLeftParenthesis(c))
                        {
                            operators.Push(c);
                        }

                        else if (IsHigherPrecedence(c, operators.Peek()) || (IsSamePrecedence(c, operators.Peek()) && IsRightAssociative(c)))
                        {
                            operators.Push(c);
                        }

                        else if (IsLowerPrecedence(c, operators.Peek()) || (IsSamePrecedence(c, operators.Peek()) && IsLeftAssociative(c)))
                        {
                            do
                            {
                                char op = operators.Pop();
                                postfixExpression.Add(op.ToString());
                            } while (operators.Count > 0 && (IsLowerPrecedence(c, operators.Peek()) || (IsSamePrecedence(c, operators.Peek()) && IsLeftAssociative(c))));

                            operators.Push(c);
                        }
                    }

                }

                else if (operandStart == -1)
                {
                    operandStart = i;
                }
            }
            if(operandStart != -1)
            {
                postfixExpression.Add(expression.Substring(operandStart, expression.Length - operandStart));
                operandStart = -1;
            }

            while(operators.Count > 0)
            {
                postfixExpression.Add(operators.Pop().ToString());
            }
            return postfixExpression;
        }

        private ExpressionTreeNode BuildTree(string expression)
        {
            Stack<ExpressionTreeNode> nodes = new Stack<ExpressionTreeNode>();
            var postfixExpression = ShuntingYardAlogritthm(expression);
            foreach(var item in postfixExpression)
            {
                if (item.Length == 1 && IsOperatorOrParenthesis(item[0]))
                {
                    OperatorNode node = operatorNodeFactory.CreateOperatorNode(item[0]);
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


        private bool IsRightAssociative(char c)
        {
            int Associativity = operatorNodeFactory.GetAssociativity(c);
            if(Associativity == 1)
            {
                return true;
            }
            return false;
        }

        private bool IsLeftAssociative(char c)
        {
            int Associativity = operatorNodeFactory.GetAssociativity(c);
            if (Associativity == -1)
            {
                return true;
            }
            return false;
        }

        private bool IsHigherPrecedence(char c1, char c2)
        {
            uint p1 = operatorNodeFactory.GetPrecedence(c1);
            uint p2 = operatorNodeFactory.GetPrecedence(c2);

            if (p1 < p2)
            {
                return true;
            }

            return false;
        }

        private bool IsSamePrecedence(char c1, char c2)
        {
            uint p1 = operatorNodeFactory.GetPrecedence(c1);
            uint p2 = operatorNodeFactory.GetPrecedence(c2);

            if(p1 == p2)
            {
                return true;
            }

            return false;
        }

        private bool IsLowerPrecedence(char c1, char c2)
        {
            uint p1 = operatorNodeFactory.GetPrecedence(c1);
            uint p2 = operatorNodeFactory.GetPrecedence(c2);

            if(p1 > p2)
            {
                return true;
            }

            return false;
        }

        private bool IsOperatorOrParenthesis(char c)
        {
            if(c == '+' || c == '-' || c == '/' || c == '*' || c == '^' || c == '(' || c == ')')
            {
                return true;
            }

            return false;
        }

        private bool IsRightParenthesis(char c)
        {
            if(c == ')')
            {
                return true;
            }

            return false;
        }

        private bool IsLeftParenthesis(char c)
        {
            if(c == '(')
            {
                return true;
            }

            return false;
        }


    }
}
