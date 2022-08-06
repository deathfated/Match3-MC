using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMan : MonoBehaviour
{
    private static int highScore;

    #region Singleton

    private static ScoreMan _instance = null;

    public static ScoreMan Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<ScoreMan>();

                if (_instance == null)
                {
                    Debug.LogError("Fatal Error: ScoreManager not Found");
                }
            }

            return _instance;
        }
    }

    #endregion

    public int tileRatio;
    public int comboRatio;

    public int HighScore { get { return highScore; } }
    public int CurrentScore { get { return currentScore; } }

    private int currentScore;

    private void Start()
    {
        ResetCurrentScore();
    }

    public void ResetCurrentScore()
    {
        currentScore = 0;
    }

    public void SetHighScore()
    {
        highScore = currentScore;
    }

    public void IncrementCurrentScore(int tileCount, int comboCount)
    {
        currentScore += (tileCount * tileRatio) * (comboCount * comboRatio);

        SoundMan.Instance.PlayScore(comboCount > 1);
    }
}
