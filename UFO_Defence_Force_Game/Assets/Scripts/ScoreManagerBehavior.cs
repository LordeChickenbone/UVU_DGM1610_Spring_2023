using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //Text mesh pro namespace added to access the Unity Libraries for UI

public class ScoreManagerBehavior : MonoBehaviour
{
    public int score;

    public TextMeshProUGUI scoreText; //visual text element

    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    public void DecreaseScore(int amount)
    {
        score -= amount;
        UpdateScoreText();
    }
    
    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
