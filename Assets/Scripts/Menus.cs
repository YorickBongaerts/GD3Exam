using System.Collections;
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
    public GameObject scoreText;
    private bool _isGameActive = false;
    public void OnStartClick()
    {
        SceneManager.LoadScene(1);
    }
    public void OnResumeClick()
    {
        EventSystem.current.SetSelectedGameObject(_startButton);
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
        EventSystem.current.SetSelectedGameObject(_resumeButton);
        Time.timeScale = 0;
        _startMenu.SetActive(false);
        _startOptionsMenu.SetActive(true);
    }
    private void Start()
    {
        scoreText.GetComponent<Text>().text = ScoreSystem.score.ToString();
    }
}
