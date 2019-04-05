/*
 * Created by SharpDevelop.
 * User: 765454
 * Date: 3/1/2019
 * Time: 2:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text;
using System.Diagnostics;

namespace extrasol
{
	/// <summary>
	/// Description of String_and_StringBuilder.
	/// </summary>
	public class String_and_StringBuilder
	{

		public static void Main()
		{
			//string str="hello";
			StringBuilder sb = new StringBuilder(50);
			sb.Append("hello");
			sb.Append('a',10);
			Console.WriteLine(sb);
			
			Stopwatch sw=new Stopwatch();
			sw.Start();
			
			sw.Stop();
			Console.WriteLine(sw.ElapsedMilliseconds);
			Console.ReadLine();
			
		}
	}
}
