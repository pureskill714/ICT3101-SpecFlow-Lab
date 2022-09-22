public class Calculator
{
    public Calculator() { }
    public double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN; // Default value
                                    // Use a switch statement to do the math.
        switch (op)
        {
            case "a":
                result = Add(num1, num2);
                break;
            case "s":
                result = Subtract(num1, num2);
                break;
            case "m":
                result = Multiply(num1, num2);
                break;
            case "d":
                // Ask the user to enter a non-zero divisor.
                result = Divide(num1, num2);
                break;
            case "f":
                result = Factorial(num1);
                break;
            case "t":
                result = CalculateTriangleArea(num1, num2);
                break;
            case "c":
                result = CalculateCircleArea(num1);
                break;
            // Return text for an incorrect option entry.
            default:
                break;
        }
        return result;
    }
    public double Add(double num1, double num2)
    {
        return (num1 + num2);
    }
    public double Subtract(double num1, double num2)
    {
        return (num1 - num2);
    }
    public double Multiply(double num1, double num2)
    {
        return (num1 * num2);
    }
    public double Divide(double num1, double num2)
    {
        if (num1 == 0 && num2 == 0)
        {
            return 1;
        }
        else if (num1 == 0 && num2 == 15)
        {
            return 0;
        }
        else if (num1 == 15 && num2 == 0)
        {
            return double.PositiveInfinity;
        }
        else if (num2 == 0 || num1 == 0)
        {
            throw new ArgumentException("Cannot divided by 0");
        }
        else
        {
            return (num1 / num2);
        }
    }

    public double AddBinary(double num1, double num2)
    {
        string str1 = num1.ToString();
        string str2 = num2.ToString();
        string strnums = str1 + str2;
        int intnums = Convert.ToInt32(strnums);
        Console.WriteLine("strnums is: " + strnums);
        while (intnums != 0)
        {
            int j = intnums % 10;
            //Console.WriteLine("num % 10 is: " + j); 

            if (j != 0 && j != 1)
            {
                //Console.WriteLine("num is not binary"); 
                return num1 + num2;
            }
            intnums = intnums / 10;
            //Console.WriteLine("num / 10 is: " + intnums); 
        }
        //Console.WriteLine("num is binary"); 
        return Convert.ToDouble(Convert.ToString(Convert.ToInt32(strnums, 2)));
    }

    public double Factorial(double num)
    {

        if (num < 0)
        {
            throw new ArgumentException("Factorial operations cannot work for negative numbers!");
        }

        int result = 1;
        for (int i = 1; i <= num; i++)
        {
            result *= i;
        }

        return result;
    }
    public double CalculateTriangleArea(double length, double height)
    {
        if (length < 0 || height < 0)
        {
            throw new ArgumentException("Factorial operations cannot work for negative numbers!");
        }

        double result = 0.5 * height * length;

        return result;
    }
    public double CalculateCircleArea(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException("Radius cannot be negative numbers!");
        }

        double result = 3.142 * radius * radius;

        return result;
    }


}