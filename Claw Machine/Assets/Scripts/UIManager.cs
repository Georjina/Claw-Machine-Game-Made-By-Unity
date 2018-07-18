﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;
    public Text ScoreText, MulText;
    public GameObject DeadEffect, RankPanel, InsertScorePanel;
    public Slider GameTimer;
    public Image MuteButton;
    public Sprite SoundOn, SoundOff;

    public static UIManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new UIManager();
            }
            return instance;
        }
    }


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        ScoreText.text = "SCORE : 0";
    }
    public void Update()
    {
        ScoreText.text = "Score : " + GameManager.Instance.Score.ToString();
    }

    public void _UISound(bool ismMute)
    {
        if (ismMute)
            MuteButton.sprite = SoundOff;
        else
            MuteButton.sprite = SoundOn;
    }
}
