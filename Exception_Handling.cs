/*
 * Created by SharpDevelop.
 * User: 765454
 * Date: 3/1/2019
 * Time: 3:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace extrasol
{
	/// <summary>
	/// Description of Exception_Handling.
	/// </summary>
	public class Exception_Handling
	{
    static double SafeDivision(double x, double y)
    {
        if (y == 0)
        	throw new System.DivideByZeroException();
        return x / y;
    }
    static void Main()
    {
       
        double a = 98, b = 0;
        double result = 0;

        try
        {
            result = SafeDivision(a, b);
            Console.WriteLine("{0} divided by {1} = {2}", a, b, result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Attempted divide by zero.");
        }
        Console.ReadLine();
    }
}
	}

