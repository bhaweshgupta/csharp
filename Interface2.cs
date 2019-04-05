/*
 * Created by SharpDevelop.
 * User: 765454
 * Date: 2/28/2019
 * Time: 11:21 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace extrasol
{
	/// <summary>
	/// Description of Interface2.
	/// </summary>
	public interface Interface2
	{
		void Test();
		
	}
	public interface Interface3
	{
		void Test();
	}
	
	class TestInterface:Interface2,Interface3
	{
		  void Interface2.Test()
		{
			Console.WriteLine("Test implemented 2\n");
		}
		  void Interface3.Test()
		{
			Console.WriteLine("Test implemented 3\n");
		}
		  
		  
		public static void Main()
		{
			
			TestInterface obj=new TestInterface();
			Interface2 i2=obj;
			i2.Test();
			Console.ReadLine();
			
		}
	}
}
