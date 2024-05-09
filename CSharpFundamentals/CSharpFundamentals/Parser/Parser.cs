using System.Collections.Generic;

namespace Parser
{
    public class Parser
    {
        private static List<string> _mathcharacter = new List<string> { "+", "*", "/", "%", "^" };
        public static MathExpression ParseOperand(string input)
        {

            var expr = new MathExpression();
            bool leftsideinitialized = false;
            string tokens = "";
            for (int i = 0; i < input.Length; i++)
            {
                var currentchar = input[i];
                if (char.IsLetter(input[0]))
                    leftsideinitialized = true;
                if (char.IsDigit(currentchar))
                {
                    tokens += currentchar;
                    if (i == input.Length - 1 && leftsideinitialized)
                    {
                        expr.RightSideOperand = double.Parse(tokens);
                        break;
                    }
                }
                else if (_mathcharacter.Contains(currentchar.ToString()))
                {
                    if (!leftsideinitialized)
                    {
                        expr.LeftSideOperand = double.Parse(tokens);
                        tokens = "";
                        leftsideinitialized = true;
                    }
                    // To avoid 5-+6
                    if (expr.Operation == MathOperation.None)
                        expr.Operation = ParseOperation(currentchar.ToString());

                }
                else if (char.IsLetter(currentchar))
                {
                    tokens += currentchar;
                }
                else if (currentchar == ' ')
                {
                    if (!leftsideinitialized)
                    {
                        expr.LeftSideOperand = double.Parse(tokens);
                        leftsideinitialized = true;
                        tokens = "";
                    }
                    else if (expr.Operation == MathOperation.None)
                    {
                        expr.Operation = ParseOperation(tokens);
                        tokens = "";
                    }
                }
                else if (currentchar == '-')
                {
                    if (!leftsideinitialized || (leftsideinitialized && expr.Operation != MathOperation.None))
                    {
                        if (tokens.Length == 0)
                            tokens += currentchar;
                        else
                        {
                            expr.LeftSideOperand = double.Parse(tokens);
                            expr.Operation = MathOperation.Subtracion;
                            tokens = "";
                            leftsideinitialized = true;
                        }
                    }
                    else if (expr.Operation == MathOperation.None)
                    {
                        expr.Operation = MathOperation.Subtracion;

                    }
                }
                //if (leftsideinitialized && expr.Operation != MathOperation.None && tokens.Length != 0 && tokens != "-")
                //{
                //    expr.RightSideOperand = double.Parse(tokens);

                //}
            }
            return expr;
        }
        private static MathOperation ParseOperation(string operand)
        {
            switch (operand.ToLower())
            {
                case "+":
                    return MathOperation.Addition;
                case "*":
                    return MathOperation.Multiplication;
                case "/":
                    return MathOperation.Division;
                case "%":
                case "mod":
                    return MathOperation.Modulus;
                case "^":
                case "pow":
                    return MathOperation.Power;
                case "sin":
                    return MathOperation.Sin;
                case "cos":
                    return MathOperation.Cos;
                case "tan":
                    return MathOperation.Tan;
                default:
                    return MathOperation.None;

            }

        }
    }
}
