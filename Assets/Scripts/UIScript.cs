﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    public void OnRetry()
    {
        SceneManager.LoadScene(1);
    }
    public void OnQuit()
    {
        SceneManager.LoadScene(0);
    }
}
