using UnityEngine;
using UnityEngine.Events;

public class PowerUpSpawn : MonoBehaviour
{
    public Transform powerUpSpawner;
    public GameObject powerUp;

    public void Start()
    {
        //Instantiate(powerUp, powerUpSpawner.transform.position, powerUp.transform.rotation);
    }
}
