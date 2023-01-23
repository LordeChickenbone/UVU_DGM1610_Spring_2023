using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	public Hero heroThree;
	public Hero heroFour;
		
	public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();
		heroThree = new Hero();
		heroFour = new Hero();
		
		heroOne.health = 2;
		heroOne.powerLevel = 5;
		heroOne.suitColor = "Blue";
		heroOne.weapon = "Staff";
		
		heroTwo.health = 3;
		heroTwo.powerLevel = 1;
		heroTwo.suitColor = "Red";
		heroTwo.weapon = "Sword";
		
		heroThree.health = 6;
		heroThree.powerLevel = 2;
		heroThree.suitColor = "Green";
		heroThree.weapon = "Fist";
		
		heroFour.health = 3;
		heroFour.powerLevel = 4;
		heroFour.suitColor = "Purple";
		heroFour.weapon = "Bow";
		
		Console.WriteLine("Hero One");
		Console.WriteLine("Health: " + heroOne.health);
		Console.WriteLine("Power: " + heroOne.powerLevel);
		Console.WriteLine("Color: " + heroOne.suitColor);
		Console.WriteLine("Weapon: " + heroOne.weapon);
		Console.WriteLine(" ");
		
		Console.WriteLine("Hero Two");
		Console.WriteLine("Health: " + heroTwo.health);
		Console.WriteLine("Power: " + heroTwo.powerLevel);
		Console.WriteLine("Color: " + heroTwo.suitColor);
		Console.WriteLine("Weapon: " + heroTwo.weapon);
		Console.WriteLine(" ");
		
		Console.WriteLine("Hero Three");
		Console.WriteLine("Health: " + heroThree.health);
		Console.WriteLine("Power: " + heroThree.powerLevel);
		Console.WriteLine("Color: " + heroThree.suitColor);
		Console.WriteLine("Weapon: " + heroThree.weapon);
		Console.WriteLine(" ");
		
		Console.WriteLine("Hero Four");
		Console.WriteLine("Health: " + heroFour.health);
		Console.WriteLine("Power: " + heroFour.powerLevel);
		Console.WriteLine("Color: " + heroFour.suitColor);
		Console.WriteLine("Weapon: " + heroFour.weapon);
	}
}

public class Hero {
	public int health;
	public int powerLevel;
	public string suitColor;
	public string weapon;
}