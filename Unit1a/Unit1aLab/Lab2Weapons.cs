using System;
					
public class Program
{
	public Weapon squidLauncher;
	public PowerUp weaponPowerUp;
    
	public void Main()
	{
		squidLauncher = new Weapon();
		weaponPowerUp = new PowerUp();
		squidLauncher.ammoCount -= 4;
		squidLauncher.ammoCount += 2;
		squidLauncher.firePower += weaponPowerUp.powerLevel;
		Console.WriteLine(squidLauncher.weaponName + " Ammo count is " + squidLauncher.ammoCount + ".");
		Console.WriteLine("Fire Power increased to " + squidLauncher.firePower + "! Oh Yeah!");
	}
}

public class Weapon{
	public int ammoCount = 8;
	public string weaponName = "Squid Launcher";
	public double firePower = 3.3;
}

public class PowerUp{
	public double powerLevel = 6.7;
}