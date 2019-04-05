/*
 * Created by SharpDevelop.
 * User: 765454
 * Date: 2/27/2019
 * Time: 3:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace extrasol
{
	/// <summary>
	/// Description of Class2.
	/// </summary>
	class parent
	{
		public virtual void Test()
		{
			Console.WriteLine("inside Parent test");
		}
		
		 public void Test2()
		{
			Console.WriteLine("inside Parent test2");
		}
	
	}
	
	class child:parent
	{
		
		 public override void  Test()
		{
			Console.WriteLine("inside Child test");
		}
		
		 public new void  Test2()
		{
			Console.WriteLine("inside Child test2");
		}
		void parentTest()
		{
			base.Test();
		}
		public static void Main()
		{
			child c=new child();
			parent p;
			p=c;
			p.Test();
			p.Test2();
			//c.parentTest();
			Console.ReadLine();
		}
	}
	
}
