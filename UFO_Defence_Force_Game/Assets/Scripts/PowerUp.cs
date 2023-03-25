using UnityEngine;
using UnityEngine.Events;

public class PowerUp : MonoBehaviour
{
    public UnityEvent collectPowerUpEvent;

    private void OnTriggerEnter(Collider other)
    {
        collectPowerUpEvent.Invoke();
        Destroy(gameObject);
        Debug.Log("Ship speed +2!");
    }
}
