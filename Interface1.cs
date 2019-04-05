/*
 * Created by SharpDevelop.
 * User: 765454
 * Date: 2/28/2019
 * Time: 10:28 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace extrasol
{
	/// <summary>
	/// Description of Interface1.
	/// </summary>
	public interface Interface1
	{
	 void Ad(int x,int y);
	}
	public interface Interface:Interface1
	{
		void sub(int x,int y);
		
	}
	class Prog:Interface
	{
		 public void Ad(int x,int y)
		{
			Console.WriteLine(x+y);
		}
		 public void sub(int x,int y)
		{
			Console.WriteLine(x-y);
		}
		public static void Main()
		{
			Prog obj=new Prog();
			obj.Ad(4,4);
			obj.sub(4,2);
			Console.ReadLine();
		}
	}
}
