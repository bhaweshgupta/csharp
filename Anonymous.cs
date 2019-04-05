/*
 * Created by SharpDevelop.
 * User: 765454
 * Date: 3/1/2019
 * Time: 10:40 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace extrasol
{
	/// <summary>
	/// Description of Anonymous.
	/// </summary>
	public delegate string GreetingDelegate(string s);
	public delegate int CubeDelegate(int x);
	public class Anonymous
	{
		
		public static int a2b2(int x,int y)
		{
			return x*x-y*y;
		}
	
	static void Main()
	{
		GreetingDelegate obj = name =>
		{
			return "hello "+name+" have a good day";
		};
		CubeDelegate obj2=delegate(int n)
		{
			return n*n*n;
		};

		Func<int,int,int> obj3=a2b2;
		
		
		Func<int,int> obj4=(xxx)=>
		{
			return -xxx;
		};
		
		Func<int,int,int> perimeter=delegate(int x,int y)
		{
			
				return 2*x+2*y;
			
		};
		
		Console.WriteLine(obj("ram"));
		Console.WriteLine(obj2(4));
		Console.WriteLine(obj3(4,2));
		Console.WriteLine(obj4(5));
		Console.WriteLine(perimeter(5,4));
		Console.ReadLine();
	}
	}}
