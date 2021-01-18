using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressionEvaluator
{
    class UserInput
    {
        public static List<string> ReadUserInput()
        {
            string expressionToken = string.Empty;
            List<string> expression = new List<string>();
            while (true)
            {
                var key = Console.ReadKey(false);
                if (key.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else if (key.Key == ConsoleKey.C)
                {
                    expression = new List<string>();
                    Console.Clear();
                    Console.WriteLine("Input expression you want to evaluate below and incase you make a mistake in your input " +
               "press the letter C on your keyboard to clear your input :)");

                }
                else if (char.IsNumber(key.KeyChar))
                {
                    expressionToken += key.KeyChar;
                }
                else
                {

                    if ((expression.Count <= 0) && (expressionToken == string.Empty))
                    {
                        expressionToken = key.KeyChar.ToString();
                        expression.Add(expressionToken);
                        expressionToken = string.Empty;
                    }

                    else if ((expression.Count > 0) && (expressionToken == string.Empty))
                    {
                        expressionToken = key.KeyChar.ToString();
                        expression.Add(expressionToken);
                        expressionToken = string.Empty;
                    }

                    else
                    {
                        expression.Add(expressionToken);
                        expressionToken = string.Empty;
                        expressionToken = key.KeyChar.ToString();
                        expression.Add(expressionToken);
                        expressionToken = string.Empty;
                    }
                }
            }
            if (expressionToken != string.Empty)
            {
                expression.Add(expressionToken);
            }
            return expression;
        }
    }
}
