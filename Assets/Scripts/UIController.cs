using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text highScore;
    public Text currentScore;

    private void Update()
    {
        highScore.text = ScoreMan.Instance.HighScore.ToString();
        currentScore.text = ScoreMan.Instance.CurrentScore.ToString();
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
