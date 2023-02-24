using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class Creature : ScriptableObject
{
    public string creatureType;

    public int creatureHealth;
    public int creatureArmor;
    public int creatureAttack;

    public void Attack(int enemyAttack)
    {
        if(creatureArmor > 0)
        {
            UpdateArmor(enemyAttack);
        }
        else
        {
            UpdateHealth(enemyAttack);
        }
  

    }
    public void UpdateArmor(int enemyAttack)
    {
        creatureArmor -= enemyAttack;
    }

    public void UpdateHealth(int enemyAttack)
    {
        creatureHealth -= enemyAttack;
    }
}
