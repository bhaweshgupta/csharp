/*
 * Created by SharpDevelop.
 * User: 765454
 * Date: 2/27/2019
 * Time: 6:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace extrasol
{
	/// <summary>
	/// Description of Class3.
	/// </summary>
	/// 
	class Matrix:Object
	{
		
		int a,b,c,d;
		public Matrix(int a,int b,int c,int d)
		{
			this.a=a;
			this.b=b;
			this.c=c;
			this.d=d;
		}
		public static Matrix operator  +(Matrix obj1,Matrix obj2)
		{
			Matrix temp=new Matrix(obj1.a+obj2.a,obj1.b+obj2.b,obj1.c+obj2.c,obj1.d+obj2.d);
			return temp;
		}
//		public override string ToString()
//		{
//			//return a +" "+ b +"\n"+ c +" "+ d;	
//		}
	}
	
		
	public class Class3:Object
	{
		
		
		
		public static void Main()
			
		{
			Matrix m1=new Matrix(10,0,5,6);
			Matrix m2=new Matrix(5,11,5,4);
			Matrix m3=m1+m2;
			Class3 obj2=new Class3();
			Console.WriteLine(m3);
			Console.ReadLine();
		}
	}
}
