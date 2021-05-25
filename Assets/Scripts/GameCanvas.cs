using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GameCanvas : MonoBehaviour
{
    [SerializeField] private GameObject Overlay, Pause, Options;

    [SerializeField] private GameObject ResumeButton, BackButton;

    [SerializeField] private EventSystem eventSystem;

    [SerializeField] private SoundManager SoundManager;

    public List<GameObject> PowerUpUICollection = new List<GameObject>();
    private void Start()
    {
        SoundManager.PlayGameBgm();
    }
    public void OnResume()
    {
        Overlay.SetActive(true);
        Pause.SetActive(false);
            Time.timeScale = 1;
            eventSystem.SetSelectedGameObject(null);
    }
    public void OnPause(InputAction.CallbackContext context)
    {
        Overlay.SetActive(false);
        Pause.SetActive(true);
            Time.timeScale = 0;
            eventSystem.SetSelectedGameObject(ResumeButton);
    }
    public void OnOptionsClick()
    {
        Options.SetActive(true);
        Pause.SetActive(false);
        eventSystem.SetSelectedGameObject(BackButton);
    }
    public void OnBackClick()
    {
        Options.SetActive(false);
        Pause.SetActive(true);
            eventSystem.SetSelectedGameObject(ResumeButton);

    }
    public void OnQuit()
    {
        Application.Quit();
    }
}
