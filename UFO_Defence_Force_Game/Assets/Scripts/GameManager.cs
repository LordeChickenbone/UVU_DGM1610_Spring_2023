using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;

    private GameObject gameOverText;

    public ParticleSystem deathParticle;
    private AudioSource ufoDeathAudio;
    private AudioSource powerUpAudio;
    public AudioClip explosion;
    public AudioClip powerUpGet;

    private void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
        ufoDeathAudio = GetComponent<AudioSource>();
        powerUpAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver)
        {
            EndGame();//start endgame method
        }
        else
        {
            gameOverText.gameObject.SetActive(false);//keep game over text hidden
        }
        
    }

    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0; //freezes time
    }

    public void UFODead()
    {
        ufoDeathAudio.PlayOneShot(explosion, .75f);
    }

    public void PowerUp()
    {
        powerUpAudio.PlayOneShot(powerUpGet, .75f);
    }
}
