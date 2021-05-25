using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    public void OnRetry()
    {
        SceneManager.LoadScene("bulletheaven_GameScene");
    }
    public void OnQuit()
    {
        SceneManager.LoadScene("bulletheaven_info");
    }
}
