using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    float topBounds = 25.0f;
    float lowerBounds = -17.0f;
    void Awake()
    {
        Time.timeScale = 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject); //destroy other game object
        Destroy(gameObject); //destroy itself
    }

    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBounds)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }
}
