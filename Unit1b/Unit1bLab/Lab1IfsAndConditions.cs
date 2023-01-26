using System;
					
public class Program
{
	public Comparisons operation;
	
	public void Main()
	{
		operation = new Comparisons();
		
		Console.WriteLine("Start Mathing!");
		operation.MakeBigger(20, 2);
		operation.MakeBigger(13, 7);
		operation.MakeBigger(100, 25);
		Console.WriteLine(" ");
		operation.BiggerOrSmaller(28,7);
		operation.BiggerOrSmaller(22,24);
		operation.BiggerOrSmaller(72,48);
		Console.WriteLine(" ");
		operation.Password("Password");
		operation.Password("password");
		operation.Password("LetMeIn");
		operation.Password("password ");
		operation.Password("Password ");
	}
}

public class Comparisons 
{
	public void MakeBigger (int value1, int value2) 
	{
		var number = value1 + value2;
		Console.WriteLine(number);
	}
	
	public void BiggerOrSmaller (int value1, int value2) 
	{
		if (value1 > value2) 
		{
			Console.WriteLine("It's bigger!");
		} 
		else 
		{
			Console.WriteLine("It's smaller!");
		}
	}
	
	public void Password (string password) 
	{
		if (password == "Password") 
		{
			Console.WriteLine("Access Granted");
		} 
		else if (password == "password")
		{
			Console.WriteLine("Access Granted");	
		}
		else if (password == "password ")
		{
			Console.WriteLine("Access Granted");	
		}
		else if (password == "Password ") 
		{
			Console.WriteLine("Access Granted");
		} 
		else 
		{
			Console.WriteLine("Access Denied");
		}
	}
}