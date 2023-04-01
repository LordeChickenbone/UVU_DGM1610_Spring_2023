using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public PlayerController playerController;
    public float speedIncrease = 2.0f;

    public GameManager gameManager;

    private void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        playerController.UpdateSpeed(speedIncrease);
        Destroy(gameObject);
        Debug.Log("Ship speed +2!");
        gameManager.PowerUp();
    }
}
