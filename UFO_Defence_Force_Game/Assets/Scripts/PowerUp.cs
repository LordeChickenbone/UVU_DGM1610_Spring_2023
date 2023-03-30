using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public PlayerController playerController;
    public float speedIncrease = 2.0f;

    private void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        playerController.UpdateSpeed(speedIncrease);
        Destroy(gameObject);
        Debug.Log("Ship speed +2!");
    }
}
