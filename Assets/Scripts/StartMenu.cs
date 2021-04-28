using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private GameObject _startMenu;
    [SerializeField] private GameObject _startOptionsMenu;
    [SerializeField] private GameObject _inGameOptionsMenu;
    [SerializeField] private GameObject _inGameOverlay;
    private bool _isGameActive = false;
    public void OnStartClick()
    {
        SceneManager.LoadScene(1);
        _inGameOverlay.SetActive(true);
    }
    public void OnResumeClick()
    {
        Time.timeScale = 1;
        if (_isGameActive)
        {
            _inGameOverlay.SetActive(true);
            _inGameOptionsMenu.SetActive(false);
        }
        else
        {
            _startOptionsMenu.SetActive(false);
            _startMenu.SetActive(true);
        }
    }
    public void OnQuitClick()
    {
        Application.Quit();
    }
    public void OnStartOptionsClick()
    {
        Time.timeScale = 0;
        _startMenu.SetActive(false);
        _inGameOverlay.SetActive(false);
        _startOptionsMenu.SetActive(true);
    }
    public void OnInGameOptionsClick()
    {
        Time.timeScale = 0;
        _inGameOverlay.SetActive(false);
        _inGameOptionsMenu.SetActive(true);
    }
}
