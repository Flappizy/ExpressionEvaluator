using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressionEvaluator
{
    class Validate
    {
        public static bool ValidateExpression(List<string> expression)
        {
            int countOfDigits = 0;
            int countOfOperators = 0;
            int countOfOpeningBracket = 0;
            int countOfClosingBracket = 0;

            if ((double.TryParse(expression[0], out _) == false))
            {
                switch (expression[0])
                {
                    case "(":
                        break;
                    default:
                        return false;
                }
            }

            for (int i = 0; i < expression.Count; i++)
            {
                if (double.TryParse(expression[i], out _))
                {
                    countOfDigits++;
                }
                else if ((expression[i] == "-") || (expression[i] == "*") || (expression[i] == "+") || (expression[i] == "/"))
                {
                    countOfOperators++;
                }
                else if (expression[i] == "(")
                {
                    countOfOpeningBracket++;
                }
                else if (expression[i] == ")")
                {
                    countOfClosingBracket++;
                }
                else
                {
                    return false;
                }
            }

            if ((countOfDigits > countOfOperators) && (countOfOpeningBracket == countOfClosingBracket))
            {
                return true;
            }
            return false;
        }

    }
}