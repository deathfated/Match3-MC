using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlowMan : MonoBehaviour
{
    #region Singleton

    private static GameFlowMan _instance = null;

    public static GameFlowMan Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameFlowMan>();

                if (_instance == null)
                {
                    Debug.LogError("Fatal Error: GameFlowManager not Found");
                }
            }

            return _instance;
        }
    }

    #endregion

    public bool IsGameOver { get { return isGameOver; } }

    private bool isGameOver = false;

    private void Start()
    {
        isGameOver = false;
    }

    [Header("UI")]
    public UIGameOver GameOverUI;

    public void GameOver()
    {
        isGameOver = true;
        ScoreMan.Instance.SetHighScore();
        GameOverUI.Show();
    }
}
