using System;

namespace Cpts321.Tests
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string expression = "";
            string input = "";
            ExpressionTree tree = new ExpressionTree("A1-12-B2");
            while (true)
            {

                printMenu(expression);
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Enter new Expression: ");
                        expression = Console.ReadLine();
                        tree = new ExpressionTree(expression);
                        break;
                    case "2":
                        Console.Write("Enter variable name: ");
                        string variable = Console.ReadLine();
                        Console.Write("Enter variable value: ");
                        double value = Convert.ToDouble(Console.ReadLine());
                        tree.SetVariable(variable, value);
                        break;
                    case "3":
                        Console.WriteLine(tree.Evaluate());
                        break;
                    case "4":
                        Console.WriteLine("Done");
                        return;
                    default:
                        break;
                }
            }

        }

        public static void printMenu(string expression)
        {
            Console.WriteLine("Menu (Current expression=\"" + expression + "\")");
            Console.WriteLine("\t1 = Enter a new expression");
            Console.WriteLine("\t2 = Set a variable value");
            Console.WriteLine("\t3 = Evaluate tree");
            Console.WriteLine("\t4 = Quit");
        }
    }
}
