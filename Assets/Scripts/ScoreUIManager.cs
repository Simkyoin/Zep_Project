using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUIManager : MonoBehaviour
{
    public Text currentScoreText;
    public Text highScoreText;

    void Start()
    {
        currentScoreText.text = "Score: " + MiniGameManager.latestScore;
        highScoreText.text = "High Score: " + MiniGameManager.highScore;
    }
}