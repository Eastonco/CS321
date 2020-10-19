using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ExpressionTree
{
    public class OperatorNodeFactory
    {
        private Dictionary<char, Type> operators = new Dictionary<char, Type>();

        public OperatorNodeFactory()
        {
            TraverseAvailableOperators((op, type) => this.operators.Add(op, type));
        }

        private delegate void OnOperator(char op, Type type);

        private void TraverseAvailableOperators(OnOperator onOperator)
        {
            Type operatorNodeType = typeof(OperatorNode);

            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                IEnumerable<Type> operatorTypes = assembly.GetTypes().Where(type => type.IsSubclassOf(operatorNodeType));

                foreach (var type in operatorTypes)
                {
                    PropertyInfo operatorField = type.GetProperty("Operator");
                    if(operatorField != null)
                    {
                        object value = operatorField.GetValue(type);

                        if(value is char)
                        {
                            char operatorSymbol = (char)value;
                            onOperator(operatorSymbol, type);
                        }
                    }
                }
            }
        }

        public OperatorNode CreateOperatorNode(char c)
        {
            switch (c)
            {
                case '+':
                    return new PlusOperatorNode();
                case '-':
                    return new MinusOperatorNode();
                case '*':
                    return new MultiplyOperatorNode();
                case '/':
                    return new DivideOperatorNode();
                case '^':
                    return new ExponentOperatorNode();
                default:
                    return null;
            }
        }

        public uint GetPrecedence(char value)
        {
            switch (value)
            {
                case '+':
                    return 7;
                case '-':
                    return 7;
                case '*':
                    return 6;
                case '/':
                    return 6;
                case '^':
                    return 5;
                default:
                    return 10;
            }
        }

        public int GetAssociativity(char value)
        {
            switch (value)
            {
                case '^':
                    return 1;
                    break;
                default:
                    return -1;
                    break;
            }
        }

        public bool IsOperator(char c)
        {
            if (this.operators.ContainsKey(c))
            {
                return true;
            }
            return false;
        }


    }
}
