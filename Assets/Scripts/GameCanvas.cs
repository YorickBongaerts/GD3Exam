using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class GameCanvas : MonoBehaviour
{
    [SerializeField] private GameObject Overlay, Pause, Options;

    [SerializeField] private GameObject ResumeButton;
    public void OnResume(InputAction.CallbackContext context)
    {
        Overlay.SetActive(true);
        Pause.SetActive(false);
        if (Overlay.activeSelf)
        {
            Time.timeScale = 1;
            EventSystem.current.SetSelectedGameObject(null);
        }
    }
    public void OnPause(InputAction.CallbackContext context)
    {
        Overlay.SetActive(false);
        Pause.SetActive(true);
        if (Overlay.activeSelf)
        {
            Time.timeScale = 0;
            EventSystem.current.SetSelectedGameObject(ResumeButton);
        }
    }
}
