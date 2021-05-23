using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    [SerializeField] private GameObject _startMenu;
    [SerializeField] private GameObject _startOptionsMenu;
    private bool _isGameActive = false;
    public void OnStartClick()
    {
        SceneManager.LoadScene(1);
    }
    public void OnResumeClick()
    {
        Time.timeScale = 1;
            _startOptionsMenu.SetActive(false);
            _startMenu.SetActive(true);
    }
    public void OnQuitClick()
    {
        Application.Quit();
    }
    public void OnStartOptionsClick()
    {
        Time.timeScale = 0;
        _startMenu.SetActive(false);
        _startOptionsMenu.SetActive(true);
    }
}
