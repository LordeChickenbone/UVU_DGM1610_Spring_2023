using System;
					
public class Program
{
	public static void Main()
	{
		int[] nums = {3, 6, 9, 12};
		nums[0] = 27;
		Console.WriteLine(nums[0]);
		Console.WriteLine("has " + nums.Length + " nums.");
		Console.WriteLine(" ");
		string[] gear = {"Sword", "Shield", "Bow", "Axe"};
		Console.WriteLine("I want a " + gear[1] + " please.");
		gear[1] = "Broken " + gear[1];
		Console.WriteLine("I've got a " + gear[1] + " now.");
		Console.WriteLine(" ");
		
		string[] baddies = {"Skelly", "Zombo", "Ghoul Fool", "Lich Bi..."};
		for (int num = 0; num < baddies.Length; num++) 
		{
  			Console.WriteLine(baddies[num]);
		}
	}
}