using System;
					
public class Program
{
	public Combat diceRoll;
	public AfterCombat rollDice;
	
	public void Main()
	{
		diceRoll = new Combat();
		rollDice = new AfterCombat();
		
		Console.WriteLine("Start Attacking!");
		Console.WriteLine(" ");
		diceRoll.Attack(20,14);
		diceRoll.Attack(12,23);
		diceRoll.Attack(30,31);
		Console.WriteLine(" ");
		if (hit = true)
		{
			rollDice.Damage(32,14);
			rollDice.Damage(45,28);
			rollDice.Damage(4,4);
		}
		else
		{
			Console.WriteLine("No Damage");
		}
	}
}

public class Combat
{
	public void Attack (int armorClass, int attackScore)
	{
		public bool hit = true;
		if (armorClass <= attackScore)
		{
			hit = true;
		}
		else
		{
			hit = false;
		} 

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