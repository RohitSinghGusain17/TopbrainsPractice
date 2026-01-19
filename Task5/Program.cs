using System.IO.Pipelines;
using System.Text;

public class Program
{
    /// <summary>
    /// Function to check the string format and evaluate the result
    /// </summary>
    /// <param name="s">string s</param>
    /// <returns>result</returns>
    public static string EvaluateString(string? s)
    {
        var split = s.Split(" ");//split of string
        int a,b;
        string result = ""; // result string
        if (s.Length != 5)
        {
            result+= "Error:InvalidExpression";
        }
        else if (!int.TryParse(split[0], out a) || !int.TryParse(split[2], out b))
        {
            result+= "a or b is not an int";
        }
        else if (b == 0)
        {
            result+= "Error:DivideByZero";
        }
        else if(split[1]!="+" && split[1]!="-" && split[1]!="*" && split[1]!="/")
        {
            result+= "Error:UnknownOperator";
        }
        else
        {
            switch (split[1])//Switch case to evalute string
            {
                case "+":
                    result+= (a+b).ToString();
                    break;
                case "-":
                    result+= (a-b).ToString();
                    break;
                case "*":
                    result+= (a*b).ToString();
                    break;
                case "/":
                    result+= (a/b).ToString();
                    break;
            }
        }
        return result;
    }

    /// <summary>
    /// Main Function
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        string? str = Console.ReadLine();
        var result = EvaluateString(str);//method calling
        Console.WriteLine(result);
    }
}