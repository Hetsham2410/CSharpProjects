using System;
namespace Parser
{
    internal class CalculateResult
    {
        public static double GetResult(MathExpression expression)
        {
            switch (expression.Operation)
            {
                case MathOperation.Addition:
                    return expression.LeftSideOperand + expression.RightSideOperand;
                case MathOperation.Subtracion:
                    return expression.LeftSideOperand - expression.RightSideOperand;
                case MathOperation.Multiplication:
                    return expression.LeftSideOperand * expression.RightSideOperand;
                case MathOperation.Division:
                    return expression.LeftSideOperand / expression.RightSideOperand;
                case MathOperation.Modulus:
                    return expression.LeftSideOperand % expression.RightSideOperand;
                case MathOperation.Power:
                    return Math.Pow(expression.LeftSideOperand, expression.RightSideOperand);
                case MathOperation.Sin:
                    return Math.Sin(expression.RightSideOperand);
                case MathOperation.Cos:
                    return Math.Cos(expression.RightSideOperand);
                case MathOperation.Tan:
                    return Math.Tan(expression.RightSideOperand);
                default:
                    return 0;
            }
        }
    }
}