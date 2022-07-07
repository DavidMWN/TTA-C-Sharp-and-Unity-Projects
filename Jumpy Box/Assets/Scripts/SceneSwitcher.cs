using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public static void SwitchScene(bool win)
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        if (win)
        {
            SceneManager.LoadScene(currentScene + 1);
        }
        else
        {
            SceneManager.LoadScene(currentScene + 2);
        }
    }

    public static void SwitchScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        if ((currentScene + 1) <= (SceneManager.sceneCountInBuildSettings - 1))
        {
            SceneManager.LoadScene(currentScene + 1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }

    public static void SwitchSceneTitle()
    {
        SceneManager.LoadScene(0);
    }
}
