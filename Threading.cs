/*
 * Created by SharpDevelop.
 * User: 765454
 * Date: 3/4/2019
 * Time: 10:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;

namespace extrasol
{
	/// <summary>
	/// Description of Threading.
	/// </summary>
	public class Threading
	{	
		public static void test1()
		{
			for(int i=0;i<50;i++)
				Console.WriteLine("test1=-"+i);
		}
		
		public static void test2()
		{
			for(int i=0;i<50;i++)
				Console.WriteLine("test2=-"+i);
		}
		public static void Main()
		{
			//ThreadStart obj=new ThreadStart(test1);
			//ThreadStart obj=test1;
			//ThreadStart obj=delegate(){test1();};
			//ThreadStart obj=()=>test1();
			Thread t= new Thread(test1);
			t.Start();
			Console.ReadLine();
		}
	}
}
