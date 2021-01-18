using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressionEvaluator
{
    class InfixToPostFix
    {
        private static int Precedence(string operater)
        {
            switch (operater)
            {
                case "-":
                case "+":
                    return 1;
                case "*":
                case "/":
                    return 2;
                case "^":
                    return 3;
            }
            return -1;
        }

        public static List<string> ConvertInfixToPostFix(List<string> expression)
        {
            Stack<string> operators = new Stack<string>();
            List<string> postFixExpression = new List<string>();

            for (int i = 0; i < expression.Count; i++)
            {
                string character = expression[i];
                if (double.TryParse(character, out _))
                {
                    postFixExpression.Add(character);
                }

                else if (character == "(")
                {
                    operators.Push(character);
                }

                else if (character == ")")
                {
                    while (operators.Peek() != "(")
                    {
                        postFixExpression.Add(operators.Pop());
                    }
                    operators.Pop();
                }
                else
                {
                    while (operators.Count > 0 && Precedence(character) <= Precedence(operators.Peek()))
                    {
                        postFixExpression.Add(operators.Pop());
                    }

                    operators.Push(character);
                }
            }

            while (operators.Count > 0)
            {
                postFixExpression.Add(operators.Pop());
            }

            return postFixExpression;
        }
    }
}
