// I wrote this code before doing the Correct Errors lab, and I couldn't beleive we chose the same names for a bunch of objects. 
using System;
					
public class Program
{
	public Weekdays whichDay;
	
	public void Main()
	{
		whichDay = new Weekdays();
		whichDay.presentDay = Weekdays.Days.Wed;
		whichDay.GetDay();
	}
}

public class Weekdays 
{
	
	public enum Days 
	{
		Mon,
		Tue,
		Wed,
		Thu,
		Fri,
		Sat,
		Sun
	}
	
	public Days presentDay = Days.Wed;
	
	public void GetDay () 
	{
		switch (presentDay) 
		{
			case Days.Mon:
				Console.WriteLine("It's Monday");
				break;
			case Days.Tue:
				Console.WriteLine("It's Tuesday");
				break;
			case Days.Wed:
				Console.WriteLine("It is Wednesday");
				break;
			case Days.Thu:
				Console.WriteLine("It's Thursday");
				break;
			case Days.Fri:
				Console.WriteLine("It's Friday");
				break;
			case Days.Sat:
				Console.WriteLine("It's Saturday");
				break;
			case Days.Sun:
				Console.WriteLine("It's Sunday");
				break;
			default:
				Console.WriteLine("It's Someday!");
				break;
		}
	}
}