using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressionEvaluator
{
    class Calculator
    {
        public static string EvaluateExpression(List<string> expression)
        {
            Stack<string> operand = new Stack<string>();
            double result;
            double firstDigit;
            double secondDigit;
            string expressionAnswer;

            for (int i = 0; i < expression.Count; i++)
            {
                string character = expression[i];
                if (character == "*")
                {
                    string secondChar = operand.Pop().ToString();
                    string firstChar = operand.Pop().ToString();
                    secondDigit = double.Parse(secondChar);
                    firstDigit = double.Parse(firstChar);
                    result = (firstDigit * secondDigit);
                    operand.Push(result.ToString());
                }
                else if (character == "/")
                {
                    string secondChar = operand.Pop().ToString();
                    string firstChar = operand.Pop().ToString();
                    secondDigit = double.Parse(secondChar);
                    firstDigit = double.Parse(firstChar);
                    result = firstDigit / secondDigit;
                    operand.Push(result.ToString());
                }
                else if (character == "+")
                {
                    string secondChar = operand.Pop().ToString();
                    string firstChar = operand.Pop().ToString();
                    secondDigit = double.Parse(secondChar);
                    firstDigit = double.Parse(firstChar);
                    result = firstDigit + secondDigit;
                    operand.Push(result.ToString());
                }
                else if (character == "-")
                {
                    string secondChar = operand.Pop().ToString();
                    string firstChar = operand.Pop().ToString();
                    secondDigit = double.Parse(secondChar);
                    firstDigit = double.Parse(firstChar);
                    result = firstDigit - secondDigit;
                    operand.Push(result.ToString());
                }
                else
                {
                    operand.Push(character);
                }
            }
            expressionAnswer = operand.Pop();
            return expressionAnswer;
        }
    }
}
