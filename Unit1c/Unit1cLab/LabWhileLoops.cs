using System;
					
public class Program
{
	public static void Main()
	{
		int num = 17;
		while (num < 20) 
		{
  			Console.WriteLine(num);
  			num++;
		}
		Console.WriteLine(" ");
		int num2 = 15;
		while (num2 > 12)
		{
			Console.WriteLine(num2);
			num2--;
		}
		Console.WriteLine(" ");
		int num3 = 10;
		while (num3 <= 12)
		{
			Console.WriteLine(num3);
			num3++;
		}
		Console.WriteLine(" ");
		
		int num4 = 8;
		do 
		{
  			Console.WriteLine(num4);
  			num4--;
		}
		while (num4 > 5);
		Console.WriteLine(" ");
		int num5 = 28;
		do 
		{
  			Console.WriteLine(num5);
  			num5--;
		}
		while (num5 < 16);
		Console.WriteLine(" ");
	}
}