using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUpSpawn : MonoBehaviour
{

    public Transform powerUpSpawner;
    public GameObject[] powerUps;
    private float spawnRangeX = 20.0f;
    private float spawnPosZ = 17.0f;
    private float spawnPosY = 5.0f;

    private float startDelay = 4.0f;
    private float spawnInterval = 3.0f;

    void Start()
    {
        InvokeRepeating("spawnRandomPowerUp", startDelay, spawnInterval);
    }

    void spawnRandomPowerUp()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY, spawnPosZ);
        int powerUpsIndex = Random.Range(0, powerUps.Length);
        Instantiate(powerUps[powerUpsIndex], spawnPos, powerUpSpawner.transform.rotation);
    }
}
