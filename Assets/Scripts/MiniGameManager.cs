using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameManager : MonoBehaviour
{
    public static int latestScore = 0;
    public static int highScore = 0;

    public void StartMiniGame()
    {
        SceneManager.LoadScene("MiniGameScene");
    }

    public static void EndMiniGame(int score)
    {
        latestScore = score;
        if (score > highScore)
            highScore = score;

        SceneManager.LoadScene("MainMap");
    }
}
