using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[CreateAssetMenu]
public class Creature : ScriptableObject
{
    public UnityEvent onZeroEvent;
   
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

    public void SetHealth(int healthNum)
    {
        creatureHealth = healthNum;
    }

    public void SetArmor(int armorNum)
    {
        creatureArmor = armorNum;
    }
    public void SetAttack(int attackNum)
    {
        creatureAttack = attackNum;
    }
}
