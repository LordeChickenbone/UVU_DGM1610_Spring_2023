using System;
					
public class Program
{
	public Class fighter;
	public Class cleric;
	public Class rogue;
	public Class wizard;
	
	public Enemy goblin;
	public Enemy orc;
	
	public void Main()
	{
		fighter = new Class();
		cleric = new Class();
		rogue = new Class();
		wizard = new Class();
		
		goblin = new Enemy();
		orc = new Enemy();
		
		fighter.hitPoints = 13;
		fighter.level = 2;
		fighter.armour = "Chainmail";
		fighter.gear = "Sword and Shield";
		fighter.characterName = "Greg";
		
		cleric.hitPoints = 10;
		cleric.level = 2;
		cleric.armour = "Splint";
		cleric.gear = "Hammer and Holy Symbol";
		cleric.characterName = "Andorax, Light of the West";
		
		rogue.hitPoints = 8;
		rogue.level = 2;
		rogue.armour = "Leather";
		rogue.gear = "Dagger and Poison";
		rogue.characterName = "Corvis Gray";
		
		wizard.hitPoints = 4;
		wizard.level = 2;
		wizard.armour = "Robes of the Scholar";
		wizard.gear = "Wand and Spellbook";
		wizard.characterName = "Wonald Reasley";
		
		goblin.hitPoints = 7;
		goblin.challengeRating = 0.25;
		goblin.armour = "Leather Scraps";
		goblin.gear = "Dagger and Rock";
		
		orc.hitPoints = 24;
		orc.challengeRating = 1;
		orc.armour = "Animal Hide";
		orc.gear = "Scimitar and Crossbow";
		
		Console.WriteLine("Characters-");
		Console.WriteLine(" ");
		Console.WriteLine(fighter.characterName);
		Console.WriteLine("Class: Fighter");
		Console.WriteLine("Hit Points: " + fighter.hitPoints);
		Console.WriteLine("Level: " + fighter.level);
		Console.WriteLine("Armour: " + fighter.armour);
		Console.WriteLine("Equipment: " + fighter.gear);
		Console.WriteLine(" ");
		
		Console.WriteLine(cleric.characterName);
		Console.WriteLine("Class: Cleric");
		Console.WriteLine("Hit Points: " + cleric.hitPoints);
		Console.WriteLine("Level: " + cleric.level);
		Console.WriteLine("Armour: " + cleric.armour);
		Console.WriteLine("Equipment: " + cleric.gear);
		Console.WriteLine(" ");
		
		Console.WriteLine(rogue.characterName);
		Console.WriteLine("Class: Rogue");
		Console.WriteLine("Hit Points: " + rogue.hitPoints);
		Console.WriteLine("Level: " + rogue.level);
		Console.WriteLine("Armour: " + rogue.armour);
		Console.WriteLine("Equipment: " + rogue.gear);
		Console.WriteLine(" ");
		
		Console.WriteLine(wizard.characterName);
		Console.WriteLine("Class: Wizard");
		Console.WriteLine("Hit Points: " + wizard.hitPoints);
		Console.WriteLine("Level: " + wizard.level);
		Console.WriteLine("Armour: " + wizard.armour);
		Console.WriteLine("Equipment: " + wizard.gear);
		Console.WriteLine(" ");
		
		Console.WriteLine("Enemies-");
		Console.WriteLine(" ");
		
		Console.WriteLine("Goblin");
		Console.WriteLine("Hit Points: " + goblin.hitPoints);
		Console.WriteLine("Challenge Rating: " + goblin.challengeRating);
		Console.WriteLine("Armour: " + goblin.armour);
		Console.WriteLine("Equipment: " + goblin.gear);
		Console.WriteLine(" ");
		
		Console.WriteLine("Orc");
		Console.WriteLine("Hit Points: " + orc.hitPoints);
		Console.WriteLine("Challenge Rating: " + orc.challengeRating);
		Console.WriteLine("Armour: " + orc.armour);
		Console.WriteLine("Equipment: " + orc.gear);
	}
}

public class Class {
	public int hitPoints;
	public int level;
	public string armour;
	public string gear;
	public string characterName;
}

public class Enemy {
	public int hitPoints;
	public double challengeRating;
	public string armour;
	public string gear;
}