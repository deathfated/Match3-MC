using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeMan : MonoBehaviour
{
    #region Singleton

    private static TimeMan _instance = null;

    public static TimeMan Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<TimeMan>();

                if (_instance == null)
                {
                    Debug.LogError("Fatal Error: TimeManager not Found");
                }
            }

            return _instance;
        }
    }

    #endregion

    public int duration;

    private float time;

    private void Start()
    {
        time = 0;
    }

    private void Update()
    {
        if (GameFlowMan.Instance.IsGameOver)
        {
            return;
        }

        if (time > duration)
        {
            GameFlowMan.Instance.GameOver();
            return;
        }

        time += Time.deltaTime;
    }

    public float GetRemainingTime()
    {
        return duration - time;
    }
}
