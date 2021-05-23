﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class ScoreSystem
{
    public static int score = 0;
    public static IEnumerator OnGameOver()
    {
        if (score > 0)
        {
            yield return new WaitForEndOfFrame();
            SceneManager.LoadScene(3);
        }
        else if (score < 0)
        {
            yield return new WaitForEndOfFrame();
            SceneManager.LoadScene(2);
        }
        else
        {
            SceneManager.LoadScene(4);
            yield return null;
        }
    }
    public static void AddPoints(Material material)
    {
        if (material.color == new Color(0,0,1,1) || material.color == new Color(1, 1, 1, 1)) //angel colors
        {
            score -= 100;
        }
        else
        {
            score += 100;
        }
    }
}
