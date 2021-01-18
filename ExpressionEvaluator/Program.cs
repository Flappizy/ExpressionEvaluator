using System;
using System.Collections.Generic;

namespace ExpressionEvaluator
{
    class TestProgrsm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an expression you want to evaluate below and incase you make a mistake in your input " +
                "press the letter C on your keyboard to clear your input :)");
            List<string> expression = UserInput.ReadUserInput();
            bool validExpression = Validate.ValidateExpression(expression);
            Console.Clear(); 
            while (validExpression == false)
            {
                Console.WriteLine("Enter a valid expression");
                expression = UserInput.ReadUserInput();
                validExpression = Validate.ValidateExpression(expression);
                Console.Clear();
            }
            List<string> postfixExpression = InfixToPostFix.ConvertInfixToPostFix(expression);
            string resultOfEvaluatedExpression = Calculator.EvaluateExpression(postfixExpression);
            Console.WriteLine(resultOfEvaluatedExpression);
        }
    }
}
