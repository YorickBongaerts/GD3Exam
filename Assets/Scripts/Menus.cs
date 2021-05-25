﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menus : MonoBehaviour
{
    [SerializeField] private GameObject _startMenu;
    [SerializeField] private GameObject _startOptionsMenu;
    [SerializeField] private GameObject _resumeButton, _startButton;
    [SerializeField] private SoundManager SoundManager;
    public GameObject scoreText;
    private bool _isGameActive = false;
    public void OnStartClick()
    {
        SoundManager.PlayButtonTap();
        SceneManager.LoadScene("bulletheaven_GameScene");
    }
    public void OnResumeClick()
    {
        SoundManager.PlayButtonTap();
        EventSystem.current.SetSelectedGameObject(_startButton);
        Time.timeScale = 1;
            _startOptionsMenu.SetActive(false);
            _startMenu.SetActive(true);
    }
    public void OnQuitClick()
    {
        SoundManager.PlayButtonTap();
        Application.Quit();
    }
    public void OnStartOptionsClick()
    {
        SoundManager.PlayButtonTap();
        EventSystem.current.SetSelectedGameObject(_resumeButton);
        Time.timeScale = 0;
        _startMenu.SetActive(false);
        _startOptionsMenu.SetActive(true);
    }
    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "bulletheaven_Heaven")
        {
            SoundManager.PlayHeavenBgm();
        }
        else if (SceneManager.GetActiveScene().name == "bulletheaven_Hell")
        {
            SoundManager.PlayHellBgm();
        }
        else if (SceneManager.GetActiveScene().name == "bulletheaven_Purgatory")
        {
            SoundManager.PlayPurgatoryBgm();
        }
        else if (SceneManager.GetActiveScene().name == "bulletheaven_info")
        {
            SoundManager.PlayTitlescreenBgm();
        }
        scoreText.GetComponent<Text>().text = ScoreSystem.score.ToString();
    }
}
