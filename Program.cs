/*
 * Created by SharpDevelop.
 * User: 765454
 * Date: 2/27/2019
 * Time: 10:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace extrasol
{
	public enum days
	{
		Monday=11,
		Tuesday=13,
		Wednesday=15,
		Thrusday=16,
		Friday=17
	}
	class Program
	{
		public static void Main(string[] args)
		{
			
			foreach(var i  in Enum.GetValues(typeof(days)))
			        Console.WriteLine(i);
			        Console.ReadLine();
		}
	}
}