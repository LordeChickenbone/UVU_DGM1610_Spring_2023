using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class CreatureHealthTextBehavior : MonoBehaviour
{
    public Text health;
    public Creature healthValue;

    private void Start()
    {
        health = GetComponent<Text>();
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        health.text = healthValue.creatureHealth.ToString(CultureInfo.InvariantCulture);
    }
}