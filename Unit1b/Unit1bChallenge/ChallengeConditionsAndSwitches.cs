using System;
					
public class Program
{
	public Combat diceRoll;
	public AfterCombat rollDice;
	public WhichEnemy thisEnemy;
	
	public void Main()
	{
		diceRoll = new Combat();
		rollDice = new AfterCombat();
		thisEnemy = new WhichEnemy();
		
		Console.WriteLine("Start Attacking!");
		Console.WriteLine(" ");
		diceRoll.Attack(20,14);
		diceRoll.Attack(12,23);
		diceRoll.Attack(30,31);
		Console.WriteLine(" ");
		rollDice.Damage(32,14);
		rollDice.Damage(45,28);
		rollDice.Damage(4,4);
		Console.WriteLine(" ");
		thisEnemy.currentOpponent = WhichEnemy.Enemies.Goblin;
		thisEnemy.GetLoot();
		thisEnemy.currentOpponent = WhichEnemy.Enemies.Orc;
		thisEnemy.GetLoot();
		thisEnemy.currentOpponent = WhichEnemy.Enemies.Ogre;
		thisEnemy.GetLoot();
		thisEnemy.currentOpponent = WhichEnemy.Enemies.Troll;
		thisEnemy.GetLoot();
		thisEnemy.currentOpponent = WhichEnemy.Enemies.Dragon;
		thisEnemy.GetLoot();
	}
}

public class Combat
{
	public void Attack (int armorClass, int attackScore)
	{
		if (armorClass <= attackScore) 
		{
			Console.WriteLine("AC:" + armorClass + " vs. " + "Attack:" + attackScore);
			Console.WriteLine("It's a hit!");
		} 
		else 
		{
			Console.WriteLine("AC:" + armorClass + " vs. " + "Attack:" + attackScore);
			Console.WriteLine("Attack blocked.");
		}
	}
}

public class AfterCombat 
{
	public void Damage (int healthPoints, int damagePoints)
	{
		var currentHP = healthPoints - damagePoints;
		if (currentHP > 0) 
		{
			Console.WriteLine("Took " + damagePoints + " damage. " + currentHP + " remaing.");
		} 
		else 
		{
			Console.WriteLine("Took " + damagePoints + " damage. You are dead!");
		}
	}
}

public class WhichEnemy
{
	public enum Enemies
	{
		Goblin,
		Orc,
		Ogre,
		Troll,
		Dragon,
	}
	
	public Enemies currentOpponent = Enemies.Troll;
	
	public void GetLoot ()
	{
		switch (currentOpponent) 
		{
			case Enemies.Goblin:
				Console.WriteLine("Goblin killed! Loot:5 gold");
				break;
			case Enemies.Orc:
				Console.WriteLine("Orc defeated! Loot:25 gold");
				break;
			case Enemies.Ogre:
				Console.WriteLine("Ogre beaten! Loot:100 gold");
				break;
			case Enemies.Troll:
				Console.WriteLine("Troll evicerated! Loot:500 gold");
				break;
			case Enemies.Dragon:
				Console.WriteLine("Dragon slain! Loot:10,000 gold");
				break;
			default:
				Console.WriteLine("No combatants.");
				break;
		}
	}
}