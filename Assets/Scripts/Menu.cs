using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void LoadFirstScene()
    {
        Time.timeScale = 1;/////////////////////////////////
        SceneManager.LoadScene(1);
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1;/////////////////////////////////
        SceneManager.LoadScene(0);
    }
}
