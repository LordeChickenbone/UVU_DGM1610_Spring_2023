using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class DetectCollision : MonoBehaviour
{
    public ScoreManagerBehavior scoreManager;
    public GameManager gameManager;

    float topBounds = 25.0f;
    float lowerBounds = -17.0f;

    public int scoreToGive = 10;

    private void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManagerBehavior>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Awake()
    {
        Time.timeScale = 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        scoreManager.IncreaseScore(scoreToGive);
        Destroy(other.gameObject); //destroy other game object
        Destroy(gameObject); //destroy itself
        gameManager.UFODead();
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
            gameManager.isGameOver = true;
        }
    }
}
