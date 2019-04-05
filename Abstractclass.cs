/*
 * Created by SharpDevelop.
 * User: 765454
 * Date: 2/28/2019
 * Time: 12:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace extrasol
{
	/// <summary>
	/// Description of Abstractclass.
	/// </summary>
	public abstract class Abstractclass
	{
		 public int width;
		 public int height;
		 public int radius;
		public const double pi=3.14;
		public  abstract double GetArea();
		
	}
	class Circle:Abstractclass
	{
		public Circle(int radius)
		{
			this.radius=radius;
		}
		public override double GetArea()
		{
			return radius*radius*pi;
		}
	
	}
	
	class Rect:Abstractclass
	{
		public Rect(int height,int width)
		{
			this.width=width;
			this.height=height;
		}
		public override double GetArea()
		{
			return width*height;
		}
	}
	class AbstractImplement
	{
		public static void Main()
		{
			Circle c=new Circle(10);
			Rect r=new Rect(20,30);
			Console.WriteLine(c.GetArea());
			Console.WriteLine(r.GetArea());
			Console.ReadLine();
		}
	}
}
