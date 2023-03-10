using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class CreatureStatTextBehavior : MonoBehaviour
{
    public Text stat;
    public Creature healthValue;
    public Creature armorValue;
    public Creature attackValue;

    private void Start()
    {
        stat = GetComponent<Text>();
        UpdateStat();
    }

    public void UpdateStat()
    {
        if(healthValue)
        {
            stat.text = "Health: " + healthValue.creatureHealth.ToString(CultureInfo.InvariantCulture);
        }
        else if(armorValue)
        {
            stat.text = "Armor: " + armorValue.creatureArmor.ToString(CultureInfo.InvariantCulture);
        }
        else if(attackValue)
        {
            stat.text = "Attack: " + attackValue.creatureAttack.ToString(CultureInfo.InvariantCulture);
        }
        else
        {
            stat.text = "No stat";
        }
    }
}