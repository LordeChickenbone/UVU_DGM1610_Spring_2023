using System;
					
public class Program
{
	public static void Main()
	{
		for (int num = 6; num < 10; num++) 
		{
  			Console.WriteLine(num);
		}
		Console.WriteLine(" ");
		for (int num2 = 40; num2 >= 10; num2 = num2 - 10) 
		{
  			Console.WriteLine(num2);
		}
		Console.WriteLine(" ");
		
		int[] manynums = {5, 15, 25, 35};
		foreach (int num3 in manynums) 
		{
  			Console.WriteLine(num3);
		}
		Console.WriteLine(" ");
		int[] manynums2 = {0, 1, 2};
		foreach (int num4 in manynums2) 
		{
  			Console.WriteLine("Ha!");
		}
	}
}