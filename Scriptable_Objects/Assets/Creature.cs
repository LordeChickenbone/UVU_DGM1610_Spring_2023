using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class Creature : ScriptableObject
{
    public string creatureType;

    public int creatureHealth;
    public int creatureArmor;
    public int creatureAttack;

    public void Attack(int damage)
    {
        if(creatureArmor > 0)
        {
            UpdateArmor(damage);
        }
        else
        {
            UpdateHealth(damage);
        }
  

    }
    public void UpdateArmor(int damage)
    {
        creatureArmor -= damage;
    }

    public void UpdateHealth(int damage)
    {
        creatureHealth -= damage;
    }
}
