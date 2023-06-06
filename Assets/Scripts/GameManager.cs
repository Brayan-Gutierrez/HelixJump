using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public int bestScore;
    public int currentScore;
    public int currentLevel = 0;

    public static GameManager singleton;

    void Awake()
    {
        if (singleton == null)
        {
            singleton = this;
        }

        else if (singleton != this)
        {
            Destroy(gameObject);
        }

        bestScore = PlayerPrefs.GetInt("HighScore");
          
    }

    public void NextLevel()
    {
        Debug.Log("NextLevel");
    }

    public void Restartlevel()
    {

    }

    public void AddScore(int scoreToAdd)
    {
        currentScore += scoreToAdd;

        if (currentScore > bestScore)
        {
            bestScore = currentScore;

            //PlayerPrefs serves to store an integer, you need a key and a value
            PlayerPrefs.SetInt("HighScore", currentScore);
        }
    }
}
