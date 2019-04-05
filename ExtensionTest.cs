/*
 * Created by SharpDevelop.
 * User: 765454
 * Date: 3/1/2019
 * Time: 1:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace extrasol
{
	/// <summary>
	/// Description of ExtensionTest.
	/// </summary>
	/// 
	static  class statclass
	{
		
		public static void Method3(this ExtensionClass E,int t)
		{
			Console.WriteLine("method 3  "+t);
		}
		public static void Method2(this ExtensionClass E)
		{
			Console.WriteLine("method 2 of statcalss");
		}
		public static long Factorial(this Int32 E)
		{
			if(E==1)
				return 1;
			if(E==2)
				return 2;
			return E*Factorial(E-1);
		}
		public static string ToProperFirst(this String str)
		{
			
			if(str.Trim().Length>0)
			{
				str=str.ToLower();
				string Onec=str.Substring(0,1);
				Onec=Onec.ToUpper();
				str=str.Remove(0,1);
				str=Onec+str;
				return str;
			}
			return str;
		}
		public static string ToProper(this String str)
		{
			
			if(str.Trim().Length>0)
			{
				String NewStr=null;
				str=str.ToLower();
				string [] sarr= str.Split(' ');
				foreach(string s in sarr)
				{
					char[] charr=s.ToCharArray();
					charr[0]=Char.ToUpper(charr[0]);
					if(NewStr==null)
					NewStr= new String(charr);
					else
					NewStr+=" "+new String(charr);
				}
				return NewStr;
			}
			return str;
		}
	}
	public class ExtensionTest
	{
		public static void Main()
		{
			ExtensionClass obj=new ExtensionClass();
			obj.Method3(10);
			obj.Method2();
			Char c='f';
			Char.ToUpper(c);
			int i=5;
			string str="nOt iN Proper Format";
			long ll=i.Factorial();
			Console.WriteLine(str.ToProperFirst());
			Console.WriteLine(str.ToProper());			
			Console.WriteLine(ll.ToString()+c.ToString());
			Console.ReadLine();
		}
	}
}
