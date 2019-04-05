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
	public class Class1
	{
		static int s=10;
		const int cx=20;
		public readonly int x2;
		
		Class1()
		{
			x2=40;
		}
		
	
		public static void Main(string[] args)
		{
			Console.WriteLine(s);
			Console.WriteLine(cx);
			Class1 obj=new Class1();
			Console.WriteLine(obj.x2);
			//obj.change();
			//Console.WriteLine(obj.x2);
			
			
			Console.ReadKey(true);
		}
	}
}
