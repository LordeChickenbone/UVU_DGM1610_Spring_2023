using UnityEngine;
using UnityEngine.Events;

public class DeathTriggerBehavior : MonoBehaviour
{
    public UnityEvent deathTriggerEvent;
    public Creature creature;

    public void OnTriggerEnter(Collider other)
    {
        if(creature.creatureHealth <= 0)
        {
            deathTriggerEvent?.Invoke();
        }
    }
}
