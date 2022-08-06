using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMan : MonoBehaviour
{
    #region Singleton

    private static SoundMan _instance = null;

    public static SoundMan Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<SoundMan>();

                if (_instance == null)
                {
                    Debug.LogError("Fatal Error: SoundManager not Found");
                }
            }

            return _instance;
        }
    }

    #endregion

    public AudioClip scoreNormal;
    public AudioClip scoreCombo;

    public AudioClip wrongMove;

    public AudioClip tap;

    private AudioSource player;

    private void Start()
    {
        player = GetComponent<AudioSource>();
    }

    public void PlayScore(bool isCombo)
    {
        if (isCombo)
        {
            player.PlayOneShot(scoreCombo);
        }
        else
        {
            player.PlayOneShot(scoreNormal);
        }
    }

    public void PlayWrong()
    {
        player.PlayOneShot(wrongMove);
    }

    public void PlayTap()
    {
        player.PlayOneShot(tap);
    }
}
