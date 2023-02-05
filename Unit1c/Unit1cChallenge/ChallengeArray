using System;
					
public class Program
{
	public void Main()
	{
		Adventurers[] characters = {new Adventurers(), new Adventurers(), new Adventurers(), new Adventurers()};
		
		string[] tags = {"Name: ", "Class: ", "Armor Class: ", "Attack: ", "Hit Points: "};
		string[] names = {"", "Tabby", "Granite", "Jackmoore"};
		string[] classes = {"", "Fighter", "Cleric", "Wizard"};
		int[] aC = {0, 16, 18, 12};
		int[] toHit = {0, 10, 6, 14};
		int[] hP = {0, 24, 32, 16};
		
		int t = 0;
		for (int n = 1; n < 4; n++)
		{
			Console.WriteLine("Player " + n);
			characters[n].name = names[n];
			Console.WriteLine(tags[t] + characters[n].name);
			t++;
			characters[n].job = classes[n];
			Console.WriteLine(tags[t] + characters[n].job);
			t++;
			characters[n].armor = aC[n];
			Console.WriteLine(tags[t] + characters[n].armor); 
			t++;
			characters[n].attack = toHit[n];
			Console.WriteLine(tags[t] + characters[n].attack);
			t++;
			characters[n].health = hP[n];
			Console.WriteLine(tags[t] + characters[n].health);
			t = 0;
			Console.WriteLine(" ");
		}
	}
}

public class Adventurers
{
	public string name;
	public string job;
	public int armor;
	public int attack;
	public int health;
}