using System;

namespace SimpleCalculator
{
    public static class CalculatorEngine
    {
        public static string Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            //You can use switch case also here for multiple operations or use if-else-if ladder
            double result = 0;
            string text = "";

            if (argOperation == "+" || argOperation.ToLower() == "add")
            {
                result = argFirstNumber + argSecondNumber;
                text = "plus";
            }
            else if (argOperation == "-" || argOperation.ToLower() == "substract")
            {
                result = argFirstNumber - argSecondNumber;
                text = "minus";
            }
            else if (argOperation == "*" || argOperation.ToLower() == "multiply")
            {
                result = argFirstNumber * argSecondNumber;
                text = "multiplied by";
            }
            else if (argOperation == "/" || argOperation.ToLower() == "divide")
            {
                result = argFirstNumber / argSecondNumber;
                text = "divided by";
                }
            else 
            {
            console.WriteLine("You have entered an invalid operation. Valid operation are:");
            console.WriteLine("Enter  + or add");
            console.WriteLine("Enter  - or subtract");
            console.WriteLine("Enter  * or multiply");
            console.WriteLine("Enter  / or divide");
                return "";
            }
            
           StringBuilder sb = new StringBuilder();
            sb.Append("The value ");
            sb.Append(argFirstNumber.ToString("F2"));
            sb.Append(" ");
            sb.Append(text);
            sb.Append(" the value ");
            sb.Append(argSecondNumber.ToString("F2"));
            sb.Append(" is equal to ");
            sb.Append(result.ToString("F2"));
            sb.Append(".");
            return sb.ToString();
        }
    }
}
