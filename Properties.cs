/*
 * Created by SharpDevelop.
 * User: 765454
 * Date: 2/28/2019
 * Time: 2:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using extrasol;

namespace extrasol
{
	/// <summary>
	/// Description of Properties.
	/// </summary>
	public enum Cities
	{
		Delhi,Banglore,Chennai,Amritsar
	}
	public class UserData
	{
		string _Name;
		int _Age;
		Cities _City;
		
		
		public UserData(int _Age,string _Name,Cities _City,string Country)
		{
			this._Age=_Age;
			this._Name=_Name;
			this._City=_City;
			this.Country=Country;
		}
		public string Name
		{
			get
			{
				
				return _Name;
			}
			
		}
		public int Age
		{
			get
			{
				return _Age;
				
			}set
			{	if(_Age<value)
				_Age=value;
			}
			
		}
		public Cities City
		{
			get{
				return _City;
				
			}
			set
			{
				_City=value;
			}
		}
		public string Country
		{
			get;
			set;
		}
	}
	
	
	public class Properties
	{
		public static void Main()
		{
			UserData obj=new UserData(15,"ram",Cities.Banglore,"India");
			obj.Age=16;
			int Age=obj.Age;
			Console.WriteLine(Age);
			Console.WriteLine(obj.Name+" "+obj.City+" "+obj.Country);
				Console.ReadLine();
			
		}
	}
}
